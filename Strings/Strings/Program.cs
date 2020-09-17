using System;
using System.Diagnostics;
using System.Text;

namespace Strings
{    class Program
    {
        static void Main(string[] args)
        {




            string myString = "Hello Batman";
            string mickey = "Hello Mickey Mouse";

            // string result = myString + mickey;

            // for (int i = 0; i < 1000; i++)
            // {
            //     result += i;
            //     Console.WriteLine(result);

            //     //result = result + i;
            //}
            Stopwatch1 = Stopwatch();

            StringBuilder builder = new StringBuilder();
            


            if (myString == mickey)
            {
                Console.WriteLine("Mickey equals myString");
            }
            string longString = "a, b, c, ddd, s, s";
            Console.WriteLine(longString);
           
            
            string replacedString = longString.Replace(",", ";");
            Console.WriteLine(replacedString);

            Console.WriteLine(myString.Remove(6, 6));

            Console.WriteLine(myString.Length);
            Console.WriteLine(myString[0]);

            Console.WriteLine(myString.Contains("M"));

            Console.WriteLine("Hello World!");
        }
    }
}
