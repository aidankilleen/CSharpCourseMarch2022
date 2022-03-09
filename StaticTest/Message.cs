using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTest
{
    class Message
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public static int Count { get; set; }

        private static int p = 0;

        public static int GetValueOfP()
        {
            return p;
        }

        public static int GetCount()
        {
            return Count;
        }
        public Message()
        {
            Count++;
        }
        ~Message()
        {
            // destructor
            Console.WriteLine($"Destructor called {Count}");
            Count--;
        }

        public Message(string title, string text)
        {
            Count++;
            Title = title;
            Text = text;
        }

        public override string ToString()
        {
            return $"{ Title }\n{ Text }";
        }

        public override bool Equals(object obj)
        {
            return obj is Message message &&
                   Title == message.Title &&
                   Text == message.Text;
        }
    }
}
