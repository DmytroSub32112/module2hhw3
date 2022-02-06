using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2hw3
{
    public class Consider1 : IConsider
    {
        public int ConsiderCalories(int weith, int calories)
        {
            return weith * calories / 100;
        }
    }
}
