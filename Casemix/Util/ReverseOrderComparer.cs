using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casemix.Util
{
    public class ReverseOrderComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null && y == null)
                return 0;
            else if (y == null)
                return 1;
            else if (x == null)
                return -1;
            else
                return -x.ToString().CompareTo(y.ToString());
        }
    }
}
