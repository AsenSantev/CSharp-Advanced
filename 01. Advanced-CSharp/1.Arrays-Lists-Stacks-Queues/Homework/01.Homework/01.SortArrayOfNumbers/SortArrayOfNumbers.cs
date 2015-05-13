using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SortArrayOfNumbers
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            string[] inpArray = inputString.Split(' ');
            int[] anotherFuckingArray = new int [inpArray.Length];

            for (int index = 0; index < inpArray.Length; index++)
            {
                anotherFuckingArray[index] = Convert.ToInt32(inpArray[index]);
            }

            Array.Sort(anotherFuckingArray);

            Console.WriteLine(string.Join(" ", anotherFuckingArray));                      
        }
    }