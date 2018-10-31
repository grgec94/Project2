﻿using System;
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

            var valid = false;
            string command;
            do
            {
                Console.Write("Command: ");
                command = Console.ReadLine();
                valid = CommandValidator.IsValidCommand(command);
                command = command.ToUpper();
                switch (command)
                {
                    case Operations.Enlist:
                        service.HandleAdd();
                        break;
                    case Operations.Display:
                        service.HandleDisplay();
                        break;
                }
            } while (command != Operations.Exit);

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