using System;

using static System.Console;

namespace SwapProgram {
    class Program {
        private static void Swap(ref int one, ref int two) {
            int temp;
            temp = one;
            one = two;
            two = temp;
        }
        static void Main(string[] args) {
            int first = 34, second = 712;
            WriteLine("Before swap first is {0} and second if 567", first,);
            Swap(ref first, ref second);
            WriteLine("After swap first is {0} and second is {1}", first, second);
        }
    }
}
