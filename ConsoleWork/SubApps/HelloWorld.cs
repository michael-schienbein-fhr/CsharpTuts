namespace ConsoleWork.SubApps
{
    public static class HelloWorld
    {
        public static void Run()
        {
            var random = new Random();
            var randomNumber = random.Next();

            // you can make it look nice :)
            // make the console print ugly colors
            Console.ForegroundColor = ConsoleColor.Cyan;
            // Console.BackgroundColor = ConsoleColor.White;
            // Console.Clear();
            // make each letter a different color
            Console.Write("H");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("l");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("l");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("W");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("r");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("l");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("d");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("!");
            Console.WriteLine();
            Console.ResetColor();
            string message = "Hello World!";
            ConsoleColor[] colors = (ConsoleColor[]) Enum.GetValues(typeof(ConsoleColor));
            int count = 0;
            for (int i = 0; i < message.Length; i++)
            {
                Console.ForegroundColor = colors[i % colors.Length + 1];
                Console.Write(message[i]);
            }

            Console.WriteLine();
            Console.ResetColor();
            Console.Beep(440, 500);
            Console.Beep(523, 500);
            Console.Beep(659, 500);
            do
            {
                Console.WriteLine("Random number: " + randomNumber);
                count++;
            } while (count < 10);
        }
    }
}

//
// namespace TextAdventure
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Welcome to the Adventure Game!");
//             Console.WriteLine("You are in a room with two doors. Do you go through door #1 or door #2?");
//
//             string doorChoice = Console.ReadLine();
//
//             if (doorChoice == "1")
//             {
//                 Console.WriteLine("You find yourself in a library. Do you read a book or leave?");
//
//                 string libraryChoice = Console.ReadLine();
//
//                 if (libraryChoice.ToLower() == "read a book")
//                 {
//                     Console.WriteLine("You read a book and gain knowledge. Congratulations, you win!");
//                 }
//                 else
//                 {
//                     Console.WriteLine("You leave the library and find yourself back at the start. The game ends.");
//                 }
//             }
//             else if (doorChoice == "2")
//             {
//                 Console.WriteLine("You find yourself in a garden. Do you smell the flowers or leave?");
//
//                 string gardenChoice = Console.ReadLine();
//
//                 if (gardenChoice.ToLower() == "smell the flowers")
//                 {
//                     Console.WriteLine("You smell the flowers and feel refreshed. Congratulations, you win!");
//                 }
//                 else
//                 {
//                     Console.WriteLine("You leave the garden and find yourself back at the start. The game ends.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Invalid choice. The game ends.");
//             }
//         }
//     }
// }