using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 43;

            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            Console.WriteLine("Our array contains: ");

            Array.ForEach(array, x => Console.Write($"{ x } "));

            Console.Write($"\n\nThe result of a binary search for {theValue} is: ");
            Console.WriteLine(binarySearch(array, theValue));
            
            Console.ReadLine();
        }


        public static int binarySearch(int[] theArray, int valueWeAreSearchingFor)
        {
            // Step 1 - initialize the variables
            int firstIndex = 0;  //Beginning of the range
            int lastIndex = theArray.Length - 1;  //The end of the range aka the last slot


            //Step 2 - we do something (search for our value)
            while (firstIndex <= lastIndex)  //When true, we are still in the range
            {
                int midPointOfTheArray = (firstIndex + lastIndex) / 2; // Find the midpoint of the array

                if (valueWeAreSearchingFor < theArray[midPointOfTheArray])
                {
                    lastIndex = midPointOfTheArray - 1;
                }
                else if (valueWeAreSearchingFor > theArray[midPointOfTheArray])
                {
                    firstIndex = midPointOfTheArray + 1;
                }
                else
                {
                    return midPointOfTheArray;
                }
            }
            
            //Step 3 - Did not find the value we are searching for
            return -1;
        }
    }
}
