using ConsoleWork.SubApps;

namespace ConsoleWork
{
    static class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an application to run:");
                Console.WriteLine("1. ConsoleAppOne");
                Console.WriteLine("2. ConsoleAppTwo");
                Console.WriteLine("3. CutCalc");
                Console.WriteLine("4. HelloWorld");
                Console.WriteLine("5. NestedLoops");
                Console.WriteLine("6. Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ConsoleAppOne.Run();
                        break;
                    case "2":
                        ConsoleAppTwo.Run();
                        break;
                    case "3":
                        CutCalc.Run();
                        break;
                    case "4":
                        HelloWorld.Run();
                        break;
                    case "5":
                        NestedLoops.Run();
                        break;
                    case "6":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid selection. Please select a valid application.");
                        break;
                }

                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}