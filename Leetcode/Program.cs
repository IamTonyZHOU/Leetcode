using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var res = s.ProductExceptSelf(new int[] { 1, 0 });
            Console.ReadKey();
        }
    }
}
