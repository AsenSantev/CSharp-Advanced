using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SortArrayOfNumbers2
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            string[] inpArray = inputString.Split(' ');
            int[] anotherFuckingArray = new int[inpArray.Length];

            for (int index = 0; index < inpArray.Length; index++)
            {
                anotherFuckingArray[index] = Convert.ToInt32(inpArray[index]);
            }

            for (int j = 0; j < anotherFuckingArray.Length * anotherFuckingArray.Length; j++)
            {
                for (int i = 0; i < anotherFuckingArray.Length - 1; i++)
                {
                    if (anotherFuckingArray[i] > anotherFuckingArray[i + 1])
                    {
                        int temp = anotherFuckingArray[i];
                        anotherFuckingArray[i] = anotherFuckingArray[i + 1];
                        anotherFuckingArray[i + 1] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", anotherFuckingArray)); 
        }
    }