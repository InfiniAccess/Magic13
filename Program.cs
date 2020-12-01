using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic13
{
    class Program
    {

        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine("New Number: " + i + " Sum: " + sum);
            }
        }

        public static void LoopArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int max;
            if (numbers[0] > numbers[1])
            {
                max = numbers[0];
            }
            else
            {
                max = numbers[1];
            };
            for (int i = 1; i <= numbers.Length - 2; i++)
            {
                if (max < numbers[i + 1])
                {
                    max = numbers[i + 1];
                }
            }
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine((sum / numbers.Length));
        }

        public static int[] OddArray()
        {

            var final = new List<int>();

            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    final.Add(i);
                }
            }
            int[] finalArr = final.ToArray();

            return finalArr;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int counter = 0;
            foreach (int num in numbers)
            {
                if (num > y)
                {
                    counter += 1;
                }
            }
            return counter;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        public static void EliminateNegatives(int[] numbers)
        {
            List<int> CNums = numbers.ToList();
            CNums = CNums.Where(i => i >= 0).ToList();
            Console.WriteLine(string.Join(", ", CNums));
        }

        public static int FindMin(int[] numbers)
        {
            int min;
            if (numbers[0] < numbers[1])
            {
                min = numbers[0];
            }
            else
            {
                min = numbers[1];
            };
            for (int i = 1; i <= numbers.Length - 2; i++)
            {
                if (min > numbers[i + 1])
                {
                    min = numbers[i + 1];
                }
            }
            return min;
        }

        public static void MinMaxAverage(int[] numbers)
        {
            List<int> CNums = numbers.ToList();
            int maxNumber = FindMax(CNums.ToArray());
            int minNumber = FindMin(CNums.ToArray());
            int average = (int)CNums.Average();

            Console.WriteLine("Max: " + maxNumber + " Min: " + minNumber + " Average: " + average);
        }

        public static void ShiftValues(int[] numbers)
        {
            List<int> CNums = numbers.ToList();
            CNums.RemoveAt(0);
            CNums.Add(0);
            Console.WriteLine(string.Join(", ", CNums));
        }

        public static void NumToString(int[] numbers)
        {
            List<int> CNums = numbers.ToList();
            List<object> final = new List<object>();
            foreach (int idx in CNums)
            {
                if (idx < 0)
                {
                    final.Add("Dojo");
                }
                else
                {
                    final.Add(idx);
                }
            }
            Console.WriteLine(string.Join(", ", final));
        }

        static void Main(string[] args)
        {
            NumToString(new int[] { -1, -2, 9, 3, 4 });
        }
    }
}
