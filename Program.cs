using System;

namespace Testproject
{
    class MainClass {

        static void Main(string[] args) {
            string appName = "Testproject";
            string appVersion = "0.1";
            string appAuthor = "Martinsen";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version: {1} created by {2}",appName,appVersion,appAuthor);

            Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("What is your name?");

            string playerName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", playerName);


            Console.WriteLine("Two random numbers between 0 and 9 will be generated.");
            Console.WriteLine("What do you think will be one of the two numbers?");
            Console.WriteLine("Enter number:");

            int playerNumber = Convert.ToInt32(Console.ReadLine());

            
            int rNumber = RandomNumber();

            int rNumber2 = RandomNumber();

            //Console.WriteLine("Random Numbers: {0},{1}", rNumber,rNumber2);

            if (rNumber == rNumber2) {
                rNumber2++;
            }

            if (playerNumber == rNumber || playerNumber == rNumber2) {
                Console.WriteLine("The two random numbers picked are: {0} and {1}",rNumber,rNumber2);
                Console.WriteLine("The Number you selected was {0}", playerNumber);
                Console.WriteLine("Congratulations!");
            } else {
                Console.WriteLine("The two random numbers picked are: {0} and {1}",rNumber,rNumber2);
                Console.WriteLine("The Number you selected was {0}", playerNumber);
                Console.WriteLine("Better luck next time!");
            }
            
            

        }

        static int RandomNumber() {

            Random r = new Random();
            int randomInt = r.Next(0,10);
            return randomInt;
        }
    }
}
