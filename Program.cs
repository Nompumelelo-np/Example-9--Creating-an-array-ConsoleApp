using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_9_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OneWayAttributes way of creating an array
            int[] luckyNumbers = { 4, 5, 8, 9, };
            Console.WriteLine("The luck number at index 0 is " + luckyNumbers[0]);
            //if you want to populate it later,the size is equal to 5
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "John";
            friends[2] = "Peter";

            Console.WriteLine("The name at index 0 is " + friends[0]);

            Console.Read();
        }
    }
}
