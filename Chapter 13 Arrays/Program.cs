using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create arrays
            int[] arrayOne = new int[4] { 10, 3, 5, 20 };
            int[] arrayTwo = new int[arrayOne.Length];

            //for loop to pass array one values into array two
            for (int i = 0; i < arrayOne.Length; i++)
            {
                //Pass arrayOne value to arrayTwo
                arrayTwo[i] = arrayOne[i];

                //Print out array values
                Console.WriteLine(arrayOne[i] + " "+ arrayTwo[i]);
            }
        }
    }
}
