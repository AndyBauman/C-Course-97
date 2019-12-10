using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_97
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate three strings.

            //Convert a string to uppercase.

            Console.WriteLine("What's your name?");
            string name = "<Type your name here>";
            name = Convert.ToString(Console.ReadLine());

            // Use the + and += operators for one-time concatenations.
            string str1 = "Hello " + name + ".";
            System.Console.WriteLine(str1);

            str1 = " It was great to meet you " + name;
            string str2 = str1.ToUpper();
            //Console.WriteLine(" \n have a pleasent day \n \t See you next time.");
            Console.WriteLine(str2 + " \n Have a pleasent day \n \t See you next time.");




            // StringBuilder.

            //StringBuilder sb = new StringBuilder("Welcome to The Tech Academy, ", 50);

            //sb.Append("Here's what you'll learn: ");
            //sb.AppendLine("Computer Programming");
            //sb.AppendLine("And many more things");

            //Console.WriteLine(sb);

            Console.ReadLine();

        }
    }
}

