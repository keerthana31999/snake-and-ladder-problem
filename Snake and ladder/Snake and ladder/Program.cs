using System;

namespace Snake_and_ladder
{
    class Program
    {
        public const int START_POINT = 0;
        public const int END_POINT = 100;
        public const int NO_PLAY = 0;
        public const int SNAKE = 1;
        public const int LADDER = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snakes and ladders game \nEnter player name");
            string player1 = Console.ReadLine();
            int currentPositionOfPlayer = START_POINT;
            for (int noOfTimesRoll = 1; currentPositionOfPlayer < 100; noOfTimesRoll++)
            {
                int diceRoll = DiceRoll();
                Console.WriteLine("You Got Number After rolled: " + diceRoll);
                currentPositionOfPlayer = PlayerMovement(diceRoll, currentPositionOfPlayer);
                Console.WriteLine("Your Current position: " + currentPositionOfPlayer);
                Console.WriteLine("you rolled you dice total time from stating::" + noOfTimesRoll);
                if (currentPositionOfPlayer == 100)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                Console.ReadLine();
            }
        }
        static int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
        static int PlayerMovement(int numbRolled, int positionPlayer)
        {
            Random random = new Random();
            int move = random.Next(0, 3);
            switch (move)
            {
                case NO_PLAY:
                    Console.WriteLine("==No Play==");
                    break;
                case SNAKE:
                    Console.WriteLine("==you are bitten by Snake==");
                    if (positionPlayer - numbRolled >= 0)
                    {
                        positionPlayer = positionPlayer - numbRolled;
                        break;
                    }
                    else
                    {
                        positionPlayer = START_POINT;
                        break;
                    }
                case LADDER:
                    Console.WriteLine("==You got Ladder==");
                    if (positionPlayer + numbRolled <= 100)
                    {
                        positionPlayer = positionPlayer + numbRolled;
                        break;
                    }
                    else
                        break;
            }
            return positionPlayer;
        }
    }
}




