using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment.Assignment
{
    class StringCustomComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (y is null)
            {
                if (x is null)
                    return 0;

                return 1;
            }

            return x?.ToLower().CompareTo(y.ToLower()) ?? -1;
        }
    }
}
