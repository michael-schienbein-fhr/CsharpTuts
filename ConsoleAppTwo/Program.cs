// Write a prompt to the console asking for the user's favorite number
Console.Write("What is your favorite number?");

// Read the user's response from the console
string favoriteNumberText = Console.ReadLine();

// Convert the user's response from a string to an integer
bool favoriteNumber = Convert.ToBoolean(favoriteNumberText);

// Write a message to the console stating that the user's favorite number is a great number
Console.Write(favoriteNumber + " is a great number!");