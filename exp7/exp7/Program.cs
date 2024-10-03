using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp7
{
    class Base
    {
        public void show()
        {
            Console.WriteLine("Base class Method");
        }
    }
    class Derived:Base
    {
        public void show()
        {
            Console.WriteLine("Derived Class Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.show();
            Derived d = new Derived();
            d.show();
        }
    }
}
