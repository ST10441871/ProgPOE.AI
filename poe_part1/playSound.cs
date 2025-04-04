namespace poe_part1
   

{
     using System.Media;
    using System;
    using System.IO;

    public class playSound
    {
        //this is a constructor
        public playSound()
        {
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello! Weclome to the cybersecurity awerness bot i am here to help you stay safe online!!!!" +
                "");

            //getting the project
            string project_location = AppDomain.CurrentDomain.BaseDirectory;
            //checking for the Directory 
            Console.WriteLine(project_location);

            //replacing the bin\debug to get the audio
            string updated_path = project_location.Replace("bin\\debug\\","");
            //combining the wav name as aiSound.wav with updated path 
            string full_path = Path.Combine(updated_path,"aiSound.wav");

            //playing to method play_wav
            Play_wav(full_path);

        }// end Constructor

        //method to play Sound
        private void Play_wav(string full_path)
        {
            //try and catch
            try
            {
                //play sound
                using (SoundPlayer play = new SoundPlayer(full_path)) {
                    //play Sound till finish

                    play.PlaySync();
                }//end of 

            }catch(Exception error )
            {
               
                Console.WriteLine( error.Message );
            }//end try and catch 
            
        }//end of method play sound

    }//end Class

}//end Filenamespace