using System.Security.Cryptography.X509Certificates;

namespace dice_game
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int bet, wallet = 100;
            Die die1, die2;
            int bet, wallet = 100;
            string choice = "";


            Console.WriteLine("Welcome to the Casino Dice Game");
            Console.WriteLine("<o-o-o-o-o-o-o-o-o--o-o-o-o-o-o-o-o-o-o-o-o-o-o-o-o-o-o-o-o>");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Important note before we begin: ");
            Console.WriteLine();
            Console.WriteLine("DOUBLES        -    you'll win double your bet ");
            Console.WriteLine("NOT DOUBLES    -    you'll win half your bet");
            Console.WriteLine("EVEN SUM       -    you'll win your bet");
            Console.WriteLine("ODD SUM        -    you'll win your bet");
            Console.WriteLine("Anything else  -    you'll loose your bet");
            Console.WriteLine();
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            
            while (choice != "q")
            {
                Console.WriteLine ("OPTIONS: ---> ");
                Console.WriteLine("1. DOUBLES");
                Console.WriteLine("2. NOT DOUBLES");
                Console.WriteLine("3. EVEN SUM");
                Console.WriteLine("4. ODD SUM");             
                Console.WriteLine("Q. QUIT");
                Console.WriteLine();
                Console.Write("What would you like to bet on?   ");
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                Console.Write($"Enter your bet amount, [REMINDER: you have {wallet:C} Bet Big, Win Big!!]: $ ");
                while (!int.TryParse(Console.ReadLine(), out bet) || bet >= wallet && bet > 0 )
                    Console.WriteLine($"You have {wallet:C} amount available, please enter a valid amount."); 

                die1 = new Die(); die2 = new Die();
                //System.Threading.Thread.Sleep(10);
                //die2 = new Die();
                die1.DrawDie();
                die2.DrawDie();
                if (choice == "1" || choice == "DOUBLES")
                {
                     if (die1.Roll == die2.Roll)
                        {
                        wallet = bet * 2;
                        Console.WriteLine($"Congratulations you got doubles! You won {wallet:c}!!");

                        }
                     else
                    {
                        wallet -= bet;
                        Console.WriteLine($"Oops, not doubles. You now have {wallet:c} ");
                    }

                    Console.Clear();
                }
                else if (choice == "2" || choice == "NOT DOUBLES")
                {

                }
                else if (choice == "3" || choice == "EVEN SUM")
                {

                }
                else if (choice == "4" || choice == "ODD SUM")
                {

                }
                else if (choice == "5")
                {

                }
                else
                { }



                
            }





                 

        }
  }
}


