using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersServiceTest
{
    class YieldExample
    {
        //public dynamic data = fibonacci(10);
        
        public static IEnumerable<int> fibonacci(int n)
        {
            var  vals = new List<int>();

            for (int i = 0, n1=0 , n2 = 1; i < n; i++)
            {
                int fib = n1 + n2;
                n1 = n2;
                vals.Add(fib);
                n2 = fib;
                yield return fib;
            }
            
        }
    }
}
