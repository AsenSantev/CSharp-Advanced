using System;
using System.Collections.Generic;
using System.Linq;
    class Program
    {
        static void Main()
        {
            int[] inputString = new int[] { 6, 5, 1, 3, 2, 4, 8 };
            for (int j = 0; j < inputString.Length*inputString.Length; j++)
            {
                for (int i = 0; i < inputString.Length - 1; i++)
                {
                    if (inputString[i] > inputString[i + 1])
                    {
                        int temp = inputString[i];
                        inputString[i] = inputString[i + 1];
                        inputString[i + 1] = temp;
                    }
                }                
            }
            Console.WriteLine(string.Join(", ", inputString));
        }
    }