using System;

namespace Part_1
{//start of namespace
    public class Program
    {//start of class
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            // 1. Voice Greeting
            voice_greeting voiceGreeting = new voice_greeting();

            // 2. ASCII Art Logo Display
            ascii_logo logo = new ascii_logo();

            // 3. Welcome and User Interaction
            welcome_and_user welcomeAndUser = new welcome_and_user();
            welcomeAndUser.welcome();
            welcomeAndUser.ask_user();

            // 4. Main Chatbot Loop
            chabot bot = new chabot(welcomeAndUser.GetUsername());  // Pass the username to the chatbot
            bot.looking();
        }
    }//end of class
}//end of namespace