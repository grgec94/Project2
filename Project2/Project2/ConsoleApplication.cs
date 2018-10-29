using System;
using System.Collections.Generic;
using System.Linq;
namespace Project2
{
    class ConsoleApplication
    {
        static void Main(string[] args)
        {
            var service = new ClassLibrary();

            HandleHelp();

            string command;
            do
            {
                Console.Write("Command: ");
                command = Console.ReadLine();
                command = command.ToUpper();
                switch (command)
                {
                    case Commands.Enlist:
                        service.HandleEnlist();
                        break;
                    case Commands.Display:
                        service.HandleDisplay();
                        break;
                }
            } while (command != Commands.Exit);

        }
        static void HandleHelp()
        {
            Console.WriteLine("Possible commands are:");
            Console.WriteLine("-- Enlist");
            Console.WriteLine("---- will route you to add a new employee");
            Console.WriteLine("-- Display");
            Console.WriteLine("---- will display all employees");
        }
    }
}