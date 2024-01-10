using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many random numbers do you want: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the starting number: ");
            int startingVal = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the ending number: ");
            int endingVal = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int[] randomNumbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                randomNumbers[i] = random.Next(startingVal, endingVal + 1);

                for (int j = 0; j < i; j++)
                {
                    if (randomNumbers[i] == randomNumbers[j])
                    {
                        i = i - 1;
                        break;
                    }
                }
            }
            Array.Sort(randomNumbers);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(randomNumbers[i]);
            }

            Console.ReadKey();
        }
    }
}
