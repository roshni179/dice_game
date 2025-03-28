using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_game
{
    public class Die
    {
        private Random _generator;
        private int _roll;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);

        }
        public Die(int roll)
        {
            _generator = new Random();
            _roll = roll;
        }
        public int Roll

        {
            get { return _roll; }
        }
        public override string ToString()
        {
            return _roll.ToString();
        }

        public void RollDie()
        {
            _roll = _generator.Next(1, 7);
        }

        public void DrawDie()
        {
            if (Roll == 1)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }
            else if (Roll == 2)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("|o  |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (Roll == 3)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|  o|");
                Console.WriteLine("|o  |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");

            }

            else if (Roll == 4)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  o|");
                Console.WriteLine("|    |");
                Console.WriteLine("|o  o|");
                Console.WriteLine("------");

            }

            else if (Roll == 5)
            {

                Console.WriteLine("-----");
                Console.WriteLine("|o  o|");
                Console.WriteLine("| O  |");
                Console.WriteLine("|o  o|");
                Console.WriteLine("------");

            }
            else if (Roll == 6)
            {

                Console.WriteLine("-----");
                Console.WriteLine("|o  o|");
                Console.WriteLine("|o  o|");
                Console.WriteLine("|o  o|");
                Console.WriteLine("------");

            }


        }
    }
}
     
    

