using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extentions
    {
        public static double Sum(this IEnumerable<double> IEnum)
        {
            if (IEnum == null)
            {
                throw new ArgumentNullException("This value is null");
            }
            double sum = 0;

            foreach (double item in IEnum)
            {
                sum += item;
            }
            return sum;

        }
        public static int Sum(this IEnumerable<int> IEnum)
        {
            if (IEnum == null)
            {
                throw new ArgumentNullException("This value is null");
            }
            int sum = 0;

            foreach (int item in IEnum)
            {
                sum += item;
            }
            return sum;

        }
        public static double Min(this IEnumerable<double> IEnum)
        {

            if (IEnum == null)
            {
                throw new ArgumentNullException("This value is null");
            }
            double min = 0;
            double temp = IEnum.ElementAt(0);
            for (int i = 1; i < IEnum.Count(); i++)
            {
                min = Math.Min(temp, IEnum.ElementAt(i));
                temp = min;
            }
            return min;
        }

        public static int Min(this IEnumerable<int> IEnum)
        {

            if (IEnum == null)
            {
                throw new ArgumentNullException("This value is null");
            }
            int min = 0;
            int temp = IEnum.ElementAt(0);
            for (int i = 1; i < IEnum.Count(); i++)
            {
                min = Math.Min(temp, IEnum.ElementAt(i));
                temp = min;
            }
            return min;
        }
        public static int Max(this IEnumerable<int> IEnum)
        {
            if (IEnum == null)
            {
                throw new ArgumentNullException("This value is null");
            }
            int max = 0;
            int temp = IEnum.ElementAt(0);
            for (int i = 1; i < IEnum.Count(); i++)
            {
                max = Math.Max(temp, IEnum.ElementAt(i));
                temp = max;
            }
            return max;
        }
        public static double Max(this IEnumerable<double> IEnum)
        {
            if (IEnum == null)
            {
                throw new ArgumentNullException("This value is null");
            }
            double max = 0;
            double temp = IEnum.ElementAt(0);
            for (int i = 1; i < IEnum.Count(); i++)
            {
                max = Math.Max(temp, IEnum.ElementAt(i));
                temp = max;
            }
            return max;
        }
        public static double Average(this IEnumerable<double> IEnum)
        {
            if (IEnum == null)
            {
                throw new ArgumentNullException("This value is null");
            }
            double result = IEnum.Sum() / IEnum.Count();
            return result;
        }
        public static StringBuilder MySubstring(this StringBuilder text, int index, int length)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Start index is out of range");
            }

            if (index >= text.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Start index is larger than length");
            }

            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Negative length");
            }

            if (index >= text.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Invalid index");
            }

            StringBuilder sb = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                sb.Append(text[i]);
            }

            return sb;


        }


    }
}
