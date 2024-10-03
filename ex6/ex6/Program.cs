using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    public class student
    {
        public int id;
        public string name;
        public student(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
        public student(string name,int id) {
            this.name = name;
            this.id = id; 
        }
       

        internal void show()
        {
            Console.WriteLine("name:{0}", name);
            Console.WriteLine("id:{0}", id);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(5, "Ravi");
            student s2 = new student("Ravi", 5);
            Console.WriteLine("frist constructor");
            s1.show();
            Console.WriteLine("second sconstrutor");
            s2.show();
            Console.ReadLine();
        }
    }
}
