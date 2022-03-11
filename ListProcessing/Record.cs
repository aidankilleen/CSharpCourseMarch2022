using System;
using System.Collections.Generic;
using System.Text;

namespace ListProcessing
{
    class Record
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Count { get; set; }

        public Record()
        {
        }
        public Record(int id, string name, string colour, int count)
        {
            Id = id;
            Name = name;
            Colour = colour;
            Count = count;
        }
    }
}
