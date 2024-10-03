using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp5
{
    internal class Program
    {
        internal int Add(int a, int b)
        {
            return a + b;
        }
        internal int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
               Program p = new Program();
            Console.WriteLine("sum of two interger valuers is" + p.Add(1, 2)); 
            Console.WriteLine("sum of three integer values is"  +p.Add(1,2,3));
            Console.ReadLine();
        }
    }
}
