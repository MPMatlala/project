#CyberGuard - Cybersecurity Awareness Bot
Overview

CyberGuard is a cybersecurity awareness chatbot built in C#. The bot helps users understand key cybersecurity concepts, such as creating secure passwords, identifying phishing attacks, and general security tips. The project also includes a voice greeting, ASCII art logo display, and interactive user prompts.

Features
Voice Greeting: Plays an audio greeting (greet.wav) when the program starts.
ASCII Art Logo: Displays an ASCII art logo based on an image (logo4.jpg).
Interactive Chatbot: Responds to common cybersecurity-related questions from the user:
Password creation
Phishing awareness
General cybersecurity tips
User Interaction: Prompts the user for their name and engages them in conversation.
Requirements
.NET Core SDK (any recent version should work)
A .wav file for the voice greeting (greet.wav)
A .jpg image for the ASCII logo (logo4.jpg)
Setup

Clone the Repository:

Clone or download this project to your local machine.
git clone https://github.com/your-username/CyberGuard.git
Add Required Files:
Place the greet.wav (voice greeting file) and logo4.jpg (image for ASCII art logo) in the root folder of the project.
Build and Run the Application:
Open the project in Visual Studio or your preferred C# IDE.
Build and run the project.
Interact with the Bot:
The bot will prompt you for your name and then provide a list of cybersecurity-related questions you can ask.
Enter questions like:
"password"
"phishing"
"how are you"
"whats your purpose"
"what can i ask you about"
Type exit to close the chatbot.
Example Interaction
╔══════════════════════════════════════════════════════════╗
║                    WELCOME TO CyberGuard                 ║
╚══════════════════════════════════════════════════════════╝

🤖 CyberGuard: Hello! May I know your name?
👤 User: John

🤖 CyberGuard: Welcome, John! I'm your Cybersecurity Awareness Bot.

John: What is phishing?
🤖 CyberGuard: Phishing is a type of online scam where attackers try to trick you into revealing sensitive information like your password or even credit card details.

John: exit
🤖 CyberGuard: Thank you, see you next time!
