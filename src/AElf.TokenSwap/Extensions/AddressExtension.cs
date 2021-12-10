using System;
using AElf.Types;

namespace AElf.TokenSwap
{
    public static class AddressExtension
    {
        public static Address Generate()
        {
            var rd = new Random(Guid.NewGuid().GetHashCode());
            var randomBytes = new byte[32];
            rd.NextBytes(randomBytes);

            return Address.FromBytes(randomBytes);
        }

        public static Address ConvertAddress(this string address)
        {
            return Address.FromBase58(address);
        }

        public static bool IsAddressInfo(string info, out Address address)
        {
            address = new Address();
            try
            {
                address = info.ConvertAddress();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public static class HashExtension
    {
        public static bool IsHashInfo(string info, out Hash hash)
        {
            hash = new Hash();
            try
            {
                hash = Hash.LoadFromHex(info);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}