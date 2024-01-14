using System;
using System.Collections.Generic;


namespace Unit02.Game
{

    public class Director
    {
        List<Card> cards = new List<Card>();
        bool isPlaying = true;
        int score = 300;
        int newcard;
        int oldcard;

        public Director()
        {
            for (int i = 0; i < 5; i++)
            {
                Card card = new Card();
                cards.Add(card);
            }
        }

        public void StartGame()
        {
            while (isPlaying)
            {
                foreach (Card card in cards)
                {
                    card.gettingCard();
                    oldcard = card.card;
                }

                Maingame();

                Console.Write("Play again? [y/n]? ");
                string Answer = Console.ReadLine();
                Console.WriteLine();

                if (Answer == "n")
                {
                    Console.WriteLine("Good Game, Thank for playing.");
                    break;
                }

            }

        }

        public void Maingame()
        {
            Console.WriteLine($"The card is: {oldcard}");
            Console.Write("Higher or Lower? (h/l): ");
            String input = Console.ReadLine();
            
            foreach (Card card in cards)
            {
                card.gettingCard();
                newcard = card.card;
            }
            Console.WriteLine($"The card is: {newcard}");
            // Console.WriteLine($"Next Card was {newcard}");

            if (newcard < oldcard && input == "l")
            {
                score += 100;
                Console.WriteLine($"Your score {score}");
            }
            else if (newcard > oldcard && input == "h")
            {
                score += 100;
                Console.WriteLine($"Your score {score}");
            }
            else
            {
                score -= 75;
                Console.WriteLine($"Your score {score}");
            }
            oldcard = newcard;
        }


    }
}


