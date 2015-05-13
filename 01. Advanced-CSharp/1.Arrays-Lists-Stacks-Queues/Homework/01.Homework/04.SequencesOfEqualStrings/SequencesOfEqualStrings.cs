using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SequencesOfEqualStrings
    {
        static void Main()
        {
            string[] inputString = Console.ReadLine().Split(' ');
            var list = inputString.GroupBy(x => x);
            foreach (var sequence in list)
            {
                Console.WriteLine(String.Join(" ", sequence));
            }
        }
    }