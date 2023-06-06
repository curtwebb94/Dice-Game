using System;

namespace ShootingDice
{
    // A Player who always rolls in the upper half of their possible role and
    // who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : UpperHalfPlayer
    {
        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            if (myRoll <= otherRoll)
            {
                throw new Exception("I won't lose!");
            }
            else
            {
                Console.WriteLine($"{Name} wins!");
            }
        }
    }
}
