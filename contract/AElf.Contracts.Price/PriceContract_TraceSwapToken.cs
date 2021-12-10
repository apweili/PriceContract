﻿using System.Globalization;
using System.Linq;

namespace AElf.Contracts.Price
{
    public partial class PriceContract
    {
        private void InitializeSwapUnderlyingToken()
        {
            State.SwapTokenTraceInfo[UnderlyingTokenSymbol] = new PriceTraceInfo
            {
                TracedPathWeight = 0
            };
        }

        private void AssertValidToken(string originalSymbol, string targetTokenSymbol)
        {
        }

        private void AddTokenPair(string originalSymbol, string targetTokenSymbol, string price)
        {
            AssertValidToken(originalSymbol, targetTokenSymbol);
            var originalTokenInfo = State.SwapTokenTraceInfo[originalSymbol] ?? new PriceTraceInfo
            {
                TracedPathWeight = InfinitePathWeight
            };
            Assert(originalTokenInfo.TokenList.All(t => t != targetTokenSymbol),
                $"Pair: {originalSymbol}-{targetTokenSymbol} has been added");
            var targetTokenInfo = State.SwapTokenTraceInfo[targetTokenSymbol] ?? new PriceTraceInfo
            {
                TracedPathWeight = InfinitePathWeight
            };
            originalTokenInfo.TokenList.Add(targetTokenSymbol);

            targetTokenInfo.TokenList.Add(originalSymbol);

            State.SwapTokenTraceInfo[targetTokenSymbol] = targetTokenInfo;
            State.SwapTokenTraceInfo[originalSymbol] = originalTokenInfo;
            UpdateTokenPriceTraceInfo(originalSymbol, targetTokenSymbol);
        }

        private void UpdateTokenPairPrice(string originalTokenSymbol, string targetTokenSymbol, string price)
        {
            var tokenKey = GetTokenKey(originalTokenSymbol, targetTokenSymbol, out var isReverse);
            State.SwapTokenPriceInfo[tokenKey] = isReverse? GetPriceReciprocalStr(price) : price;
        }
        

        private void UpdateTokenPriceTraceInfo(string originalTokenSymbol, string targetSymbol)
        {
            var originalTokenInfo = State.SwapTokenTraceInfo[originalTokenSymbol];
            var targetSymbolTokenInfo = State.SwapTokenTraceInfo[targetSymbol];
            var targetTokenTraceSymbol = targetSymbolTokenInfo.TracedToken;
            var targetTokenPathWeight = targetSymbolTokenInfo.TracedPathWeight;
            if (originalTokenInfo.TracedPathWeight == targetTokenPathWeight ||
                originalTokenInfo.TracedPathWeight == targetTokenPathWeight + 1)
            {
                return;
            }

            if (originalTokenInfo.TracedPathWeight < targetTokenPathWeight)
            {
                UpdateTokenPriceTraceInfo(targetSymbol, originalTokenSymbol);
                return;
            }

            originalTokenInfo.TracedToken = targetTokenTraceSymbol;
            originalTokenInfo.TracedPathWeight = targetTokenPathWeight + 1;
            State.SwapTokenTraceInfo[originalTokenSymbol] = originalTokenInfo;

            foreach (var neighbourToken in originalTokenInfo.TokenList)
            {
                if (neighbourToken == targetSymbol)
                {
                    continue;
                }

                UpdateTokenPriceTraceInfo(neighbourToken, originalTokenSymbol);
            }
        }

        private decimal TraceSwapTokenPrice(string originalTokenSymbol, string targetTokenSymbol)
        {
            var originalTokenTraceInfo = State.SwapTokenTraceInfo[originalTokenSymbol];
            Assert(originalTokenTraceInfo != null, $"Token:{originalTokenSymbol} does not exist");
            if (originalTokenSymbol == targetTokenSymbol)
            {
                return 1m;
            }

            if (targetTokenSymbol != UnderlyingTokenSymbol)
                return GetTracedTokenPrice(originalTokenSymbol, targetTokenSymbol);

            Assert(originalTokenTraceInfo.TracedPathWeight < InfinitePathWeight,
                $"Token {originalTokenSymbol}'s Usdt price can not be traced");
            var nextTokenSymbol = originalTokenTraceInfo.TracedToken;
            var price = GetTracedTokenPrice(originalTokenSymbol, nextTokenSymbol);
            return price * TraceSwapTokenPrice(nextTokenSymbol, targetTokenSymbol);
        }

        private decimal GetTracedTokenPrice(string originalTokenSymbol, string nextTokenSymbol)
        {
            var tokenKey = GetTokenKey(originalTokenSymbol, nextTokenSymbol, out var isReverse);
            var price = State.SwapTokenPriceInfo[tokenKey];
            return isReverse ? GetPriceReciprocal(price) : decimal.Parse(price);
        }

        private decimal GetPriceReciprocal(string price)
        {
            return decimal.Round(decimal.Parse(price), PriceDecimals);
        }
        
        private string GetPriceReciprocalStr(string price)
        {
            return GetPriceReciprocal(price).ToString();
        }
    }
}