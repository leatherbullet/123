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
            
            const string CommandShowNumber = "1";
            const string CommandShowDayOfWeek = "2";
            const string CommandClearConsole = "3";
            const string CommandExit = "4";
            
            string userInput;
            bool cycle = true;

            while (cycle == true)
            {
               Console.WriteLine("выберете нужное действие");
               Console.WriteLine($"{CommandShowNumber} - показать случайное число");
               Console.WriteLine($"{CommandShowDayOfWeek} - узнать какой сегодня день недели");
               Console.WriteLine($"{CommandClearConsole} - очистить консоль");
               Console.WriteLine($"{CommandExit} - выход");
               userInput = Console.ReadLine();

               switch (userInput)
               {
                  case CommandShowNumber:
                      Console.WriteLine($"случайное число:{number}\n");
                      break;

                 case CommandShowDayOfWeek:
                     Console.WriteLine("воскресенье\n");
                     break;

                 case CommandClearConsole:
                     Console.Clear();
                     break;

                 case CommandExit:
                     cycle = false;
                     break;

                 default:
                     Console.WriteLine("такой команды нет\n");
                     break;
                }
            }
        }
    }
}
