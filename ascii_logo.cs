using System;
using System.Drawing;

namespace Part_1
{//start of namespace for the ascii logo class
    public class ascii_logo
    {//constructor for the ascii logo class
        public ascii_logo()
        {
            // Call the ascii method to display the logo
            asci();
        }

        // ASCII drawing method
        private void asci()
        {
            string path = string.Empty;
            string fullpath = AppDomain.CurrentDomain.BaseDirectory;
            path = fullpath.Replace(@"bin\Debug\", "logo4.jpg");

            try
            {
                Bitmap image = new Bitmap(path);

                // Resize for better console fit
                int width = 150;
                int height = 70;
                Bitmap resized = new Bitmap(image, new Size(width, height));

                // Default color for the ASCII characters
                Console.ForegroundColor = ConsoleColor.Red;
                string asciiChars = "@#S%?*+;:,. ";

                // Start drawing by height
                for (int y = 0; y < resized.Height; y++)
                {
                    for (int x = 0; x < resized.Width; x++)
                    {
                        Color pixel = resized.GetPixel(x, y);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3; // Convert to grayscale
                        int index = (gray * (asciiChars.Length - 1)) / 255;

                        Console.Write(asciiChars[index]);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }
        }//end of the asci method
    }//end of the ascii method
}//end of the namespace