using System;

using static System.Console;

namespace IntegerFacts {
    class Program {
        private static void fillArray(ref int[] array) {
            for (int i = 0; i < array.Length; ++i) {
                bool valid;
                int num;
                do {
                    Write("Enter number ({0}): ", i+1);
                    valid = int.TryParse(ReadLine(), out num);
                } while (!valid);

                array[i] = num;
            }
        }

        private static void getStats(int[] array, out int high, out int low, out int sum, out int arithmeticAverage) {
            high = 0; low = array[0]; sum = 0; arithmeticAverage = 0;

            for (int i = 0; i < array.Length; ++i) {
                if (array[i] > high) high = array[i];
                if (array[i] < low) low= array[i];
                sum += array[i];
                arithmeticAverage += array[i];
            }
            arithmeticAverage /= array.Length;
        }

        static void Main(string[] args) {
            int[] array = new int[20];
            fillArray(ref array);
            getStats(array, out int high, out int low, out int sum, out int arithmeticAverage);
            WriteLine("Highest: {0}", high);
            WriteLine("Lowest:  {0}", low);
            WriteLine("Sum:     {0}", sum);
            WriteLine("Average: {0}", arithmeticAverage);
        }
    }
}
