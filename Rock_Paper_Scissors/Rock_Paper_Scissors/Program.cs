using System.ComponentModel.Design;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wolcome to Rock Paper Scissors");
            int you = 0, enemy = 0;
            Random random = new Random();
            
            while (you != 3 && enemy != 3)
            {
                Console.WriteLine($"your score- {you} enemy score-{enemy}");
                Console.WriteLine("please enter 'r' for rock ,'p' for paper and anything for scissors");
                string yourChoice = Console.ReadLine();
                int enemyChoice = random.Next(0, 3);
                if (enemyChoice == 0)
                {
                    switch(yourChoice)
                    {
                        case "r":
                            Console.WriteLine("tie!");
                            break;
                        case "p":
                            Console.WriteLine("you win!");
                            you++;
                            break;
                        default:
                            Console.WriteLine("enemy win!");
                            enemy++;
                            break;
                    }
                }
                else if (enemyChoice == 1)
                {

                    switch (yourChoice)
                    {
                        case "r":
                            Console.WriteLine("enemy win!");
                            enemy++;
                            break;
                        case "p":
                            Console.WriteLine("tie!");
                            break;
                        default:
                            Console.WriteLine("you win!");
                            you++;
                            break;
                    }

                }
                else
                {
                    switch (yourChoice)
                    {
                        case "r":
                            Console.WriteLine("you win!");
                            you++;
                            break;
                        case "p":
                            Console.WriteLine("enemy win!");
                            enemy++;
                            break;
                        default:
                            Console.WriteLine("tie!");
                            break;
                    }
                }
            }
            if(you>enemy)
            {
                Console.WriteLine("you win the game !");
            }
            else
            {
                Console.WriteLine("enemy win the game !");
            }
        }
       
    }
}
