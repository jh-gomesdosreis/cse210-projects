using System;

/* Exceeding requirements 
I tried to improve the process of saving an loading to be able to save
as a .csv file.
 */

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();
        Console.WriteLine("Welcome to my Journal!");

        bool running = true;
        while (running)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                //Write
                case 1:
                    journal.NewEntry();
                    Console.WriteLine();
                    break;
                //Display
                case 2:
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;
                //Load
                case 3:
                    Console.Write("Please enter the file name you want to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadEntries(loadFileName);
                    Console.WriteLine();
                    break;
                //Save
                case 4:
                    Console.Write("Please enter the file name you want to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveEntries(saveFileName);
                    Console.WriteLine("File was saved successfully!");
                    Console.WriteLine();
                    break;
                //Quit
                case 5:
                    running = false;
                    Console.WriteLine("Thank you, and have a nice day!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please choose one of the following choices.");
                    break;
            }
        }
    }
}