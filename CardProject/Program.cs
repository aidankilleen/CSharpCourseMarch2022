using System;

namespace CardProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Card Project");

            Deck deck = new Deck();
            deck.Display();

            deck.Shuffle(1);
            deck.Display();

            deck.Shuffle(10);
            deck.Display();

            deck.Shuffle(100);
            deck.Display();

            deck.Shuffle(1000);
            deck.Display();

            /*
            Console.WriteLine("------------------------");





            Card c = new Card(13, 4);

            //Console.WriteLine(c.getValue());

            //c.Suit = 99;
            //c.Value = 3;

            Console.WriteLine(c.Value);

            //c.setValue(99); 
            //c.setSuit(99);

            c.Display();

            Card c2 = new Card(11, 2);
            c2.Display();

            Console.WriteLine("========================");
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Card card = new Card(value, suit);
                    card.Display();
                }
                Console.WriteLine();
            }

            */
        }
    }
}
