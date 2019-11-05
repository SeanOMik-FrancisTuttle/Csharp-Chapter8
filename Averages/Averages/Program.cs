using System;

using static System.Console;

namespace Averages {
    class Program {
        private static void DisplayAverages(params int[] args) {
            int sum = 0;
            foreach (int i in args) {
                sum += i;
            }

            WriteLine("Average: {0}\n", sum / args.Length);
        }
        static void Main(string[] args) {
            WriteLine("One parameter:");
            DisplayAverages(1);

            WriteLine("Two parameter:");
            DisplayAverages(84, 34);

            WriteLine("One parameter:");
            DisplayAverages(24, 43, 84);

            WriteLine("Array parameter:");
            int[] array = { 0, 30, 173, 87, 123 };
            DisplayAverages(array);
        }
    }
}
