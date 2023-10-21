using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_StaticPractical
{
    internal class Customer
    {
        static int instances = 0;
        public Customer() 
        { 
            instances++;
        }

        public static void GetInstance()
        {
            Console.WriteLine(instances);
        }

    }
}
