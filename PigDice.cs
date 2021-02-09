using System;
namespace PigDiceGame
{
    public class PigDice
    {
        public int Play() {
            var score = 0;
            var roll = Roll();
            while (roll != 1)
            {
                score += roll;
                roll = Roll();
            }
            return score;
        }

        public int Roll()
        {
            return (int)(Math.random() * 983421) % 6 + 1;
        }
    }
}
