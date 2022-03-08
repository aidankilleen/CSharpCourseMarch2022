using System;
using System.Collections.Generic;
using System.Text;

namespace CardProject
{
    class CardGame
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Card Game");

            Deck deck = new Deck();
            deck.Shuffle(1000);

            bool finished = false;
            int score = 0;

            Card currentCard = deck.Deal();
            currentCard.Display();

            while (!finished)
            {
                Card nextCard = deck.Deal();
                Console.WriteLine("Higher(h) Lower(l) or Quit(q)");
                string answer = Console.ReadLine();

                if (answer.Equals("q"))
                {
                    finished = true;
                }

                nextCard.Display();

                if (answer.Equals("l")  && nextCard.Value < currentCard.Value)
                {
                    Console.WriteLine("you said lower, the card was lower");
                    score++;
                } else if (answer.Equals("h") && nextCard.Value > currentCard.Value)
                {
                    Console.WriteLine("you said higher, the card was higher");
                    score++;
                } else
                {
                    score--;
                    Console.WriteLine("wrong!");
                }

                Console.WriteLine("Score:" + score);
                currentCard = nextCard;
            }
        }
    }
}
