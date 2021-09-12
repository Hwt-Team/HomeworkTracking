using System;

namespace Core.Utilities.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string str) => string.IsNullOrWhiteSpace(str);

        public static bool StartsWith(this string str, bool ignoreCase = false, params string[] arr)
        {
            foreach (var item in arr)
            {
                if (ignoreCase) if (str.StartsWith(item, StringComparison.OrdinalIgnoreCase)) return true;
                    else
                    {
                        if (str.StartsWith(item)) return true;
                    }
            }


            return false;
        }

        public static bool Contains(this string str, bool ignoreCase = false, params string[] arr)
        {
            foreach (var item in arr)
            {
                if(ignoreCase) if (str.Contains(item)) return true;
                    else
                    {
                        if (str.ToLower().Contains(item.ToLower())) return true;
                    }
            }
                
            return false;
        }

        public static bool ContainsAll(this string str, bool ignoreCase = false, params string[] arr)
        {
            foreach (var item in arr)
            {
                if(ignoreCase) if (!str.Contains(item)) return false;
                    else
                    {
                        if (!str.ToLower().Contains(item.ToLower())) return false;
                    }
            }

            return true;
        }
    }
}
