using System;
using System.Drawing;
using System.IO;
namespace poe_part1
{
    public class Logo
    {
        public Logo()
        {
            //getting full path
            string path_project = AppDomain.CurrentDomain.BaseDirectory;

            // replacing the bin
            string new_path_project = path_project.Replace("bin\\Debug\\","");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //combining the project image name and full path with format
            string full_path = Path.Combine(new_path_project, "ai image.jpg");

            // the logo using Ascii
            Bitmap image = new Bitmap(full_path);
            image = new Bitmap(image,new Size(80,100));

            //nested for loop for inner and outer
            for (int height = 0; height <image.Height;height++)
            {
                //creating the width
                for (int width = 0; width < image.Width; width++)
                {
                    //making the ascii design
                    Color pixelColor = image.GetPixel(width,height);    
                    int color =(pixelColor.R+pixelColor.G+pixelColor.B)/3;

                    //using char
                    char ascii_design = color > 100 ? ',' : color > 120 ? '*' : color > 90 ? '0' : color > 45 ? '#' : '@';
                    //displaying the ascii design
                    Console.Write(ascii_design);

                }//end of inner for loop 
                Console.WriteLine();//skip line 
            }//end of outer for loop
        }
    }
}