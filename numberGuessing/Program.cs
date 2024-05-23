namespace numberGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretNum = rnd.Next(1, 100);

            for (int guesses = 6; guesses > 0; guesses--)
            {
                Console.Write("Guess a number (from 0 - 99)! You have {0} guesses remaining...", guesses);

                int numberGuessed = Convert.ToInt32(Console.ReadLine());

                if (numberGuessed > secretNum)
                {
                    Console.WriteLine("The number is lower!");
                } else if (numberGuessed < secretNum)
                {
                    Console.WriteLine("The number is higher!");
                } else
                {
                    Console.WriteLine("You win!");
                    break;
                }
            }

            

        }
    }
}
