using System;

namespace Capstone_Arrays_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            int start = 0;
            int end = 4;
            int i;


            for (i = start; myArray.Length <=end; i++)
            {
                Console.Write("Your number is:" + myArray[i]);
            }
        }
    }
}
