using System;
using System.Collections.Generic;
using System.Linq;
    class CategorizeNumbers
    {
        static void Main()
        {
            List<double> input = Array.ConvertAll(Console.ReadLine().Split(), double.Parse).ToList();
            var list1 = input.Where(x => x % (int)x == 0);
            var list2 = input.Where(x => x % (int)x != 0);
            Console.WriteLine("[{0}] - > min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", list2), list2.Min(), list2.Max(), list2.Sum(), list2.Average());
            Console.WriteLine("[{0}] - > min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", list1), list1.Min(), list1.Max(), list1.Sum(), list1.Average());
        }       
    }