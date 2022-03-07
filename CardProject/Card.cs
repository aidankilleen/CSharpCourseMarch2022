using System;
using System.Collections.Generic;
using System.Text;

namespace CardProject
{
    class Card
    {
        // A = 1, 2 = 2, 3 = 3, ... , 10, J = 11, Q = 12, K = 13
        public int Value { get; set; }

        // H = 1, S = 2, D = 3, C = 4
        public int Suit { get; set; }



        /*
        // member variables  (Properties)
        // A = 1, 2 = 2, 3 = 3, ... , 10, J = 11, Q = 12, K = 13
        private int _value;
        // H = 1, S = 2, D = 3, C = 4
        private int _suit;

        public int Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }

        public int Suit
        {
            get
            {
                return this._suit;
            }
            set
            {
                if (value >= 1 && value <= 4)
                {
                    this._suit = value;

                }
                else
                {
                    Console.WriteLine("Invalid suit:" + value);
                }
            }
        }
        */
        /*
        public int getValue()
        {
            return value;
        }
        public void setValue(int value)
        {
            if (value >=1 && value <=13)
            {
                this.value = value;

            } else
            {
                Console.WriteLine("Invalid value:" + value + "\n");
            }
        }
        public int getSuit()
        {
            return suit;
        }
        public void setSuit(int suit)
        {
            if (suit >= 1 && suit <=4)
            {
                this.suit = suit;

            } else
            {
                Console.WriteLine("Invalid suit:" + suit);
            }
        }
        */


        // member functions  (Methods)
        //  function to create a card (Constructor)
        public Card(int value, int suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
        //  function to display a card
        public void Display()
        {
            string card = "";

            switch(Value)
            {
                case 1:
                    card += " A";
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    card += " " + Value;
                    break;
                case 10:
                    card += "" + Value;
                    break;
                case 11:
                    card += " J";
                    break;
                case 12:
                    card += " Q";
                    break;
                case 13:
                    card += " K";
                    break;
                default:
                    card += " ?";
                    //card = card + " ?";
                    break;
            }
            
            if (Suit == 1)
            {
                card += "H ";
            } else if (Suit == 2)
            {
                card += "S ";
            } else if (Suit == 3)
            { 
                card += "D ";
            } else if (Suit == 4)
            {
                card += "C ";
            } else
            {
                card += "? ";
            }
            Console.Write(card);
        }
    }
}
