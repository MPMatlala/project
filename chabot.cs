using System;
using System.Collections;

namespace Part_1
{
    public class chabot
    {
        private string control = string.Empty;
        private ArrayList question = new ArrayList();
        private ArrayList respond = new ArrayList();
        private string username;

        public chabot(string username)
        {
            this.username = username;

            // Predefined questions and answers
            question.Add("password");
            question.Add("phishing");
            question.Add("how are you");
            question.Add("whats your purpose");
            question.Add("what can i ask you about");

            respond.Add("To create a safe password you need to create one containing at least a number and special characters.");
            respond.Add("Phishing is a type of online scam where attackers try to trick you into revealing sensitive information like your password or even credit card details.");
            respond.Add("I'm a chatbot here to help and assist you with cybersecurity-related questions.");
            respond.Add("My purpose is to assist you with cybersecurity-related queries.");
            respond.Add("You can ask me about passwords, phishing, and general cybersecurity tips.");
        }

        public void looking()
        {
            while (true)
            {
                // Use the captured username in the prompt
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{username}: ");  // Replace "User:" with actual username
                control = Console.ReadLine().ToLower();

                // Ensure a valid input was entered
                if (string.IsNullOrWhiteSpace(control))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("✗ You didn't enter anything. Please enter a valid question.");
                    Console.ResetColor();
                    continue; // Prompt again without proceeding
                }

                ensuring();
            }
        }

        private void ensuring()
        {
            if (control == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Thank you, see you next time!");
                Environment.Exit(0);
                Console.ResetColor();
            }

            bool got_it = false;

            // Check if the question matches a predefined one
            for (int i = 0; i < question.Count; i++)
            {
                if (control == question[i].ToString())
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(respond[i]);
                    Console.ResetColor();
                    got_it = true;
                    break;
                }
            }

            if (!got_it)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I'm sorry, I don't know the answer to that question.");
                Console.ResetColor();
            }
        }//end of the ensuring method
    }//end of the chabot class
}//end of the chabot class