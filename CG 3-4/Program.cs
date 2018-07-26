using System;

namespace CG_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user for a number
            // we made a string so we can list them together but we need to make sure it's known that its an integer so we did the intParse function
            Console.Write("Enter a number: ");
            string numone = Console.ReadLine();
            int x = int.Parse(numone);


            // ask the user to input a number then ask for a second number
            Console.Write("Please enter a second number: ");
            string numtwo = Console.ReadLine();
            int y = int.Parse(numtwo);


            // now ask what they would like to do with the numbers
            Console.Write("Would you like to + , -, /, or * these numers?: ");
            string userValue = Console.ReadLine();
            int message = 0;

            // now set code to do the selected math function with the given numbers

            if (userValue == "+")
                message = x + y;
            else if (userValue == "-")
                message = x - y;
            else if (userValue == "/")
                message = x / y;
            else if (userValue == "*")
                    message = x * y;

            //depending the operation selected the answer will not output below
           
            Console.WriteLine(message);
            Console.ReadLine();


                  
            
            


        }
    }
}
