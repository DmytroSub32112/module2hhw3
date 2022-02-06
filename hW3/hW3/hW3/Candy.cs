using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2hw3
{
    public class Candy : IComparable
    {
        public int Weight { get; set; }
        public int Calories { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            var secondItem = obj as Candy;
            if (secondItem == null)
            {
                throw new ArgumentException();
            }

            if (Weight < secondItem.Weight)
            {
                return -1;
            }

            if (Weight > secondItem.Weight)
            {
                return +1;
            }

            return 0;
        }
    }
}
