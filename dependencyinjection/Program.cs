using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjection
{
    
     class Program
    {
        public static readonly calculator cc;
        public Program(calculator cc)
        {
            cc = cc;
        }
        static void Main(string[] args)
        {
            //calculator cc=new calculator();
            int result1 = cc.add(12, 34);
            Console.WriteLine("The sum is" + result1);

            int result2 = cc.substract(23, 12);
            Console.WriteLine("the diff is" + result2);

            Console.ReadLine();
        }
    }
}
