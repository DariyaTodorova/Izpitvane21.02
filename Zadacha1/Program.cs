using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
            float average = AverageOfNumbers(numbers);
            Console.WriteLine(average);
        }

        private static float AverageOfNumbers(int[] nums)
        {
            float result;
            float sum=0;
            for (int i = 0; i <nums.Length; i++)
            {
               sum = sum + nums[i];
            }
            result = sum/nums.Length;
            return result;
        }
    }
}
