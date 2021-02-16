using System;

namespace PigDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var pigdice = new PigDice();
            var hiScore = 400;
            var games = 1;
            var score = pigdice.Play();

            while(score <= hiScore)
            {
                score = pigdice.Play();
                games++;
            }

            var message = String.Format("Game high score is %d after %d games.", score, games);
            System.out.println(message);

        }

        private static void println(string message)
        {
            throw new NotImplementedException();
        }
    }
}
