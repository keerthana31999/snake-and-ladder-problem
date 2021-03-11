using System;

namespace Snake_and_ladder
{
    class Program
    {

        public const int START_POINT = 0;
        public const int END_POINT = 100;
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Snake And Lader Problem and Enter player name");
            string player1 = Console.ReadLine();
            int playerPosition = START_POINT;
            Console.WriteLine("Current Position : " + playerPosition);
        }
    }
}
