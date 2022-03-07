using System;
using System.Collections.Generic;
using System.Text;

namespace CardProject
{
    class Deck
    {
        // member variables / properties
        private Card[] cards = new Card[52];
        private int currentCard = 0;

        // member functions / methods
        // Constructor(s)
        public Deck() {
            // initialise the deck of cards
            int count = 0;
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards[count++] = new Card(value, suit);
                }
            }
        }

         // display the deck of cards
        public void Display()
        {
            for (int i = 0; i<cards.Length; i++)
            {
                cards[i].Display();

                if (i == 12 || i == 25 || i == 38)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n");
        }

        // shuffle the deck
        public void Shuffle(int count)
        {
            Random rnd = new Random();

            for (int i=0; i<count; i++)
            {
                int r1 = rnd.Next(52);
                int r2 = rnd.Next(52);

                // swap the cards[r1] with cards[r2]
                Card t = cards[r1];
                cards[r1] = cards[r2];
                cards[r2] = t;
            }
            currentCard = 0;
        }

        public Card Deal()
        {
            return cards[currentCard++];
        }
    }
}
