using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal class Extremy
    {
        public static T Nejvetsi<T>(T[] pole) where T : IComparable<T>
        {
            T max = pole[0];
            foreach (T item in pole)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Nejmensi<T>(T[] pole) where T : IComparable<T>
        {
            T min = pole[0];
            foreach (T item in pole)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
