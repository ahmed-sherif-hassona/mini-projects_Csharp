namespace Simple_Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player = 0;
            int enemy = 0;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("press any key to roll the dice");
                Console.ReadKey();
                int playerRoll=random.Next(1,7);
                Console.WriteLine($"you rolled : a {playerRoll}");
                Console.WriteLine("........");
                System.Threading.Thread.Sleep(1000);
                int enemyRoll = random.Next(1, 7);
                Console.WriteLine($"AI rolled : a {enemyRoll}");
                if (playerRoll > enemyRoll)
                {
                    player++;
                    Console.WriteLine(" you win this round!");
                }
                else if(playerRoll < enemyRoll)
                { 
                    enemy++;
                    Console.WriteLine(" the AI win this round!");
                }
                else
                {
                    Console.WriteLine("Draw this round!");
                }
                Console.WriteLine($"the score now is : you {player} _ enemy {enemy}");

                Console.WriteLine("\n\n------------------------------------------\n\n");
                

            }
            if (player > enemy)
                Console.WriteLine("you win!");
            else if (player < enemy)
                Console.WriteLine("AI win!");
            else
                Console.WriteLine("Draw!");
                
        }
    }
}
