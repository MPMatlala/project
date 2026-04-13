using System;
using System.Media;
using System.Threading;
using System.IO;

namespace Part_1
{//namespace for the voice greeting class
    public class voice_greeting
    {//constructor for the voice greeting class
        public voice_greeting()
        {//call the greet method to play the greeting audio
            greet();
        }

        private void greet()
        {//try to play the greeting audio, if it fails, catch the exception and display an error message
            try
            {
                //this is the code to call in the voice for greeting, it will look for the greet.wav file in the project folder and play it if it exists
                string paths = AppDomain.CurrentDomain.BaseDirectory;
                string fullpath = paths.Replace(@"bin\Debug\", "greeting.wav");

                if (File.Exists(fullpath))
                {
                    SoundPlayer voice_play = new SoundPlayer(fullpath);
                    voice_play.Load();
                    voice_play.Play();
                    voice_play.PlaySync();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("[✓] Voice greeting playing...");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("[!] Voice file not found. Continuing with text greeting...");
                    Console.WriteLine("[!] Place your greet.wav file in the project folder");
                    Thread.Sleep(2000);
                }
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[!] Audio error: {ex.Message}");
                Console.ResetColor();
            }
        }//end of the greet method
    }//end of the voice greeting class
}//end of the namespace