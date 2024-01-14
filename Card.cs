using System;


namespace Unit02.Game
{
    /// <summary>
    /// Two will be drawn, and we will compare the two card togeter, to see if the user guess it right
    /// </summary> 
    public class Card
    {
        public int card = 0;

        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
        public Card()
        {
            Random random = new Random();
            card = random.Next(1,14);
        }

        /// <summary>
        /// Generates a new random value for the card
        /// </summary>
        public void gettingCard ()
        {
            Random random = new Random();
            card = random.Next(1, 14);
        }

    }
}