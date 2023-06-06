using System;

namespace ShootingDice
{
    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Generate a random roll between 4 and 6 (upper half of the possible range)
            return new Random().Next(4, 7);
        }
    }
}
