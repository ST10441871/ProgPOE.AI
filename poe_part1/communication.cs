using System;
using System.Collections;
using System.Linq;

namespace poe_part1
{
    public class communication
    {

        //declare variable 

        ArrayList replies=new ArrayList();
        ArrayList ignore=new ArrayList();


        //constructor
        public communication()
        {
            // call for both methods to store values
            store_ignore();
            store_replies();

            //promt user for questions
            Console.WriteLine("What is your name?");
            string query = Console.ReadLine();

            //array to store words
            string[] store_words = query.Split(' ');
            //temporary arrayList
            ArrayList store_final_words = new ArrayList();

            //for loop for checking and storing words

            for (int count = 0; count <store_words.Length;count++ )
            {

                // if statement for checking whether word are stored in array aren't ignored
                if (!ignore.Contains(store_words[count]))
                {
                    //store none ignored words
                    store_final_words.Add(store_words[count]);

                }//endOF


            }//endOf for loop 

            //temp variable
            Boolean found = false;
            string message=String.Empty;
            
            //for loop for answers
            for( int counting = 0; counting< store_final_words.Count;counting++)
            {
                //searching the answers by word of temp arrayList
                for (int count=0;count <replies.Count;count++ )
                {
                    //if statement for checking words found in replies
                    if (store_final_words[counting].ToString().Contains(replies[count].ToString()) )
                    {
                        //get answers
                        message += replies[count] + "\n";
                        found = true;   
                    }//endOf if statement for answers

                }//endOf nested for loop

            }//endOf for loop for answers

            //display error message or answers

            if (found)
            {
                //display
                Console.WriteLine(message);
            } else
            {
                Console.WriteLine("search for related topics");
            }//endOf dipslay

        }//endOf Constructor
        //replies method
        private void store_replies()
        {
            // storing the reply values
            replies.Add("Hope this is what you were looking for ");
            replies.Add("to be brief phishing is");
            replies.Add("phishing is when ");
            replies.Add("when it comes ");
           
            


        }//endOf replies method
        //method for ignoring words
        private void store_ignore()
        {
            // storing the ignore values
            ignore.Add("give "); ignore.Add("me");
            ignore.Add("what");
            ignore.Add("tell");
            ignore.Add("how");
            
         

        }//endOf ignore method

    }//ednOf class


}//endOf namespace file 