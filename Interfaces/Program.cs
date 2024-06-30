using System;

namespace Interfaces
{

    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();
            ILogger logger = new Calculator(); 
            string ressurectCalculator; 

            do
            {
                try
                {
                    logger.LogInfo("Этот калькулятор поддерживает значения от '-2147483648' до '2147483647'");
                    Console.Write("Введите первое число: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    int sum = calculator.Add(number1, number2);
                    logger.LogInfo($"Сумма чисел: {sum}");
                }
                catch (FormatException)
                {
                    logger.LogError("Ошибка: Введено не число.");
                }
                catch (OverflowException)
                {
                    logger.LogError("Ошибка: Введено слишком большое или слишком маленькое число.");
                }
                finally
                {
                    logger.LogInfo("Хотите выполнить еще одну операцию суммирования? (да/нет)");
                    ressurectCalculator = Console.ReadLine().ToLower();
                }
            } while (ressurectCalculator == "да");

            logger.LogInfo("Калькулятор завершил работу.");
        }
    }
}