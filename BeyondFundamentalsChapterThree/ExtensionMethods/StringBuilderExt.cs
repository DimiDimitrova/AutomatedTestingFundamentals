using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringBuilderExt
    {
        public static string MySubstring(this  int index, int length)
        {
            StringBuilder sb = new StringBuilder();
          

            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Start index is out of range");
            }

            if (index > length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Start index is larger than length");
            }

            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Negative length");
            }

            if (index > length - length)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Invalid index");
            }

            if (length == 0)
            {
                return string.Empty;

            }

            return sb.ToString(index, length);


        }
    }
}
