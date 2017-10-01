using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kokoin_library_framework
{
    public class calcurator
    {
        public long add (long a,long b)
        {
            return a + b;
        }

        public long sub(long a, long b)
        {
            return a - b;
        }

        public long multi (long a, long b)
        {
            return a * b;
        }

        public long div(long a, long b)
        {
            if (a == 0 || b == 0) return 0;
            return a / b;
        }
    }
}
