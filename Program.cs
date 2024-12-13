/* 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int input1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int input2 = int.Parse(Console.ReadLine());
        
        int sum = input1 + input2;
        Console.WriteLine("Сумма: " + sum);
    }
}
*/

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); 
        int userGuess = 0;

        Console.WriteLine("Угадайте число от 1 до 100:");

        while (userGuess != secretNumber)
        {
            Console.Write("Введите ваше предположение: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userGuess))
            {
                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else
                {
                    Console.WriteLine("Поздравляю! Вы угадали число!");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
        }
    }
}
