using System;

namespace SnakeLadder
{

    public class LadderSnake
    {
         static int playerPos = 0;
        static Random DieRoll = new Random();
       static  Random SnakeVsLadder = new Random();
        public static  void snakeVsLadder()
        {

            while (true)
            {
                if (playerPos <= 100)
                {

                    int v = SnakeVsLadder.Next(0, 2);

                    if (v == 1)
                    {
                        if (playerPos <= 100) playerPos += DieRoll.Next(1, 7);
                    }
                    else
                    {
                        if (playerPos <= 100)
                        {
                            playerPos = playerPos - DieRoll.Next(1, 7);
                        }
                    }

                }
                else break;
                Console.WriteLine(playerPos);
            }
            if (playerPos == 100)
            {
                    Console.WriteLine("WON");

            }


                Console.WriteLine(playerPos);
            // else { snakeVsLadder(); }

        }
        public static void Main(String[] arg)
        {
            

            
            snakeVsLadder();
            
            
        }
    }
}