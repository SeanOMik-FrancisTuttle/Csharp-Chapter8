using System;

using static System.Console;

namespace BonusCalculation {
    class Program {
        private static void BonusCalculate(double salary, double bonus) {
            WriteLine("Calculate Bonus With Double:");
            WriteLine("Salary: {0}", salary.ToString("C"));
            WriteLine("Bonus:  {0}", bonus.ToString("C"));
            WriteLine("----------------");
            WriteLine("Total:  {0}\n", (salary * bonus + salary).ToString("C"));
        }

        private static void BonusCalculate(double salary, int bonus) {
            WriteLine("Calculate Bonus With Integer:");
            WriteLine("Salary: {0}", salary.ToString("C"));
            WriteLine("Bonus:  {0}", bonus.ToString("C"));
            WriteLine("----------------");
            WriteLine("Total:  {0}", (salary * (bonus/100) + salary).ToString("C"));
        }

        static void Main(string[] args) {
            double salary = 183832;
            double doubleBonus = .15;
            int bonus = 15;
            BonusCalculate(salary, doubleBonus);
            BonusCalculate(salary, bonus);
        }
    }
}
