using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingCoreFXClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var datTimeNow = DateTime.Now.TimeOfDay;
            //DateTime datTimeNow = DateTime.Now.TimeOfDay;
            Console.WriteLine(datTimeNow);
            Console.ReadLine();


            var a = 5;
            var b = 0;
            Debug.Assert(b != 0, "b cannot be equal to zero.");
            Console.WriteLine(a / b);
            Console.ReadLine();
        }

        /// <summary>
        /// Yippee this words!!
        /// </summary>
        public static void doSomething() {

        }
    }
}
