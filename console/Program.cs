using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next();

            string userInput;

            bool cycle = true;

            while (cycle == true)
            {
                Console.WriteLine("выберете нужное действие");
                Console.WriteLine("1 - показать случайное число");
                Console.WriteLine("2 - узнать какой сегодня день недели");
                Console.WriteLine("3 - очистить консоль");
                Console.WriteLine("4 - выход");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine($"случайное число:{number}\n");
                        break;
                    case "2":
                        Console.WriteLine("воскресенье\n");
                        break;
                    case "3":
                        Console.Clear();
                        break;
                    case "4":
                        cycle = false;
                        break;
                    default:
                        Console.WriteLine("введена неверная операция\n");
                        break;
                }
            }
        }
    }
}
