using System;
using System.Threading;

namespace Part_1
{//start of namespace
    public class welcome_and_user
    {//start of class
        public string username = string.Empty;

        private void TypingEffect(string message, int delayMs)
        {//start of the typing method
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.ResetColor();
        }

        public void welcome()
        {
            // Display a welcome message with a typing effect
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════╗");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║                    WELCOME TO CyberGuard                 ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Thread.Sleep(800);
        }

        public void ask_user()
        {
            bool validInput = false;

            // Keep prompting for valid name until the user enters one
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\n🤖 CyberGuard: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hello! May i please know your name?");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("👤 User: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                username = Console.ReadLine();

                // Check if the username is valid (not empty and at least 2 characters long)
                if (string.IsNullOrWhiteSpace(username))  // No input or just spaces
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("✗ Sorry You didn't enter anything. Please enter a valid name.");
                    Console.ResetColor();
                }
                else if (username.Length < 2)  // Only one character or less
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("✗ The name must be at least 2 characters long. Please enter a valid name.");
                    Console.ResetColor();
                }
                else  // Valid input
                {
                    validInput = true; // Exit the loop if the input is valid
                }

            } while (!validInput); // Loop until a valid input is provided

            // Typing effect simulation for the welcome message
            TypingEffect($"🤖 CyberGuard: Welcome, {username}! I'm your Cybersecurity Awareness Bot.", 30);
            Console.WriteLine();
            Thread.Sleep(500);
        }

        public string GetUsername()
        {
            return username;
        }
    }//end of class
}//end of namespace