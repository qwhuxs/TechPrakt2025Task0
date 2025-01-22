using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть перше число: ");
            string input1 = Console.ReadLine();
            double number1;

            while (!double.TryParse(input1, out number1))
            {
                Console.Write("Невiрний формат. Введiть перше число знову: ");
                input1 = Console.ReadLine();
            }

            Console.Write("Введiть друге число: ");
            string input2 = Console.ReadLine();
            double number2;

            while (!double.TryParse(input2, out number2))
            {
                Console.Write("Невiрний формат. Введiть друге число знову: ");
                input2 = Console.ReadLine();
            }

            double sum = number1 + number2;

            Console.WriteLine($"Сума двох чисел: {number1} + {number2} = {sum}");

            Console.ReadKey(); 
        }
    }
}
