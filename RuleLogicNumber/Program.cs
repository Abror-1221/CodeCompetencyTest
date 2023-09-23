using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RuleLogicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberLogicRules myClass = new NumberLogicRules();

            Console.WriteLine("Console app is running.");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add Rule");
                Console.WriteLine("2. Edit Rule");
                Console.WriteLine("3. Delete Rule");
                Console.WriteLine("4. Show Rules");
                Console.WriteLine("5. Generate");
                Console.WriteLine("6. Quit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter input for the new rule: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter output for the new rule: ");
                        string output = Console.ReadLine();
                        myClass.AddRule(input, output);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Enter the input of the rule you want to edit: ");
                        int editInput = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the new output: ");
                        string newOutput = Console.ReadLine();
                        myClass.EditRule(editInput, newOutput);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("Enter the input of the rule you want to delete: ");
                        int deleteInput = Convert.ToInt32(Console.ReadLine());
                        myClass.DeleteRule(deleteInput);
                        Console.Clear();
                        break;
                    case 4:
                        myClass.ShowRules();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Write("Enter a value for n: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        myClass.Generate(n);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}

