using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCount
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] arr = new char[]{ 'a', 'b', 'c', 'd', 'c', 'a', 'b', 'c', 'e', 'g', 'q', 'v', 'a', 'r', 'b', 'h', 'd', 'h', 'i', 'c', 'a', 'a' };
            char[] singular = arr.Distinct().ToArray();

            Dictionary<char, int> CharCount = new Dictionary<char, int>();

            for (var i = 0; i < singular.Length; i++)
            {
                var total = 0;
                for (var j = 0; j < arr.Length; j++)
                {
                    if (singular[i] == arr[j])
                        total++;
                }
                CharCount.Add(singular[i], total);
            }

            foreach (var record in CharCount)
            {
                Console.WriteLine("The value for key {0} is {1}", record.Key, record.Value);
            }
        }
    }
}
