namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guessing number game ");
            Console.WriteLine("the number between 1 and 10 will be generated ");
            Console.WriteLine("if you guess the correct number you win");
            Random random = new Random();
            int randomNum=random.Next(1,11);
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("please enter the correct number:");
                int guessingNum=Convert.ToInt32(Console.ReadLine());
                if (guessingNum > randomNum)
                {
                    Console.WriteLine("the guessing number is too high! ");

                }
                else if (guessingNum < randomNum)
                {
                    Console.WriteLine("the guessing number is too low! ");
                }
                else
                {
                    Console.WriteLine("correct!");
                    flag=true;
                }
            }

            Console.WriteLine("Congratulations you win the game!");
            

        }
    }
}
