﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string str; /* Declares a string of size 100 */
            int l = 0;

            Console.Write("\n\nFind the length of a string :\n");
            Console.Write("---------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char ch in str)
            {
                l += 1;
            }

            Console.Write("Length of the string is : {0}\n\n", l);

            Console.ReadLine();
        }
    }
}
