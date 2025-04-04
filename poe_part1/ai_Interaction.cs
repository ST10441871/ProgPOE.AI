using System;
using System.Drawing.Text;

namespace poe_part1
{
    public class ai_Interaction
    {
        // Declaring the varible 
        private string userName = string.Empty;
        private string user_query = string.Empty;


        // the constructor
        public ai_Interaction()
        {
            //prompt user for name 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------------------------");
            //color for the message
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("|        Welcome to the Ai CHatBot");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------------------------");

            // promting ai to ask the user for their name 
            Console.ForegroundColor = ConsoleColor.Yellow;//Chatbot color 
            Console.Write("CHatBot: ->");
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your name ");
            
            //user enters their name here 
            //username color
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("User:->");

            //reseting the color for user to see their answer
            Console.ForegroundColor = ConsoleColor.White;

            // now prompt for the name 
           userName = Console.ReadLine();   // username is now collected 
                                            // recreating the interface design
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("CHatBot:-> ");

            //color for the questions 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Greetings" +  userName   +   " how may i be of assistance");
            // method for do-while to display 
            //call the method inside
            do
            {

                

                // color for the user name
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(userName+":-");
                //color for the user input
                Console.ForegroundColor = ConsoleColor.Blue;
                //prompt user Questions
                user_query = Console.ReadLine();

                answer(user_query);//calling the method

            } while (user_query!="exit");//endOf while loop 


        }// endOf constructor

        //method for user_query
        private void answer(string query)
        {
            // if statement to check whether user interacts or Exits
            if (query != "exit")
            {
                //search is related to the array
                //also checks the answers 
                //system must search from the ....
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Chatbot:->");
                //Color for the 
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("Thi is when a person uses cunning ways to get your information illegally");
                //Color for the 
                Console.ForegroundColor=ConsoleColor.Green;
                Console.Write("Chatbot:->");
                //color for the user
                Console.WriteLine();
                Console.ForegroundColor=ConsoleColor.Green;

               
            }
            else
            {
                //exiting app when exit
                Console.WriteLine("Thank you for using me ,ciao");
                System.Environment.Exit(0);//exiting the app

            }//endOf 

        }

    }//endOf class 

}//endOf file namespace 