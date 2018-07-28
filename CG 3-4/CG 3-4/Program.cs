using System;

namespace CG_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //I first thought about what I needed to know - I need two numbers from the user. I asked for one number first and assigned that
            //response to numberOne. I asked the program to print that number to the console.
            //I then asked for a second number and assigned that to numberTwo. I asked the program to also print that to the console. 
            //I then needed to ask the user what they wanted to do with the numbers
            Console.WriteLine("Please enter a number: ");
            string numberOne = Console.ReadLine();
            int x = int.Parse(numberOne);

            Console.WriteLine("Please enter a second number: ");
            string numberTwo = Console.ReadLine();
            int y = int.Parse(numberTwo);

            //I decided to list out the actual options to enter because I did not know if someone would type out the response or choose a symbol
            //I included int message = 0 because we had to define the message and also define it as a number (parse was used above to do this for x and y)
            //I then used the if and else if statements to go through all of the possible options and outcomes 
            //Next I instructed the program to write the message for whichever value was chosen by the user

            Console.WriteLine("Would you like to add, subtract, multiply, or divide? Please enter +, -, *, or /:" );
            string userValue = Console.ReadLine();
            int message = 0;

            if (userValue == "+")
                message = x + y;
            else if (userValue == "-")
                message = x - y;
            else if (userValue == "*")
                message = x * y;
            else if (userValue == "/")
                message = x / y;

            Console.WriteLine(message);
            Console.ReadLine();

    

      
        }
    }
}
