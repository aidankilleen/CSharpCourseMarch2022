using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ListProcessing
{
    class RecordAggregate
    {
        static void Main(string[] args)
        {
            List<Record> records = new List<Record>()
            {
                new Record(1, "Alice", "red", 10),
                new Record(2, "Bob", "green", 12),
                new Record(3, "Carol", "blue", 14),
                new Record(4, "Dan", "red", 10),
                new Record(5, "Carol", "green", 16),
                new Record(6, "Dan", "blue", 10),
                new Record(7, "Bob", "green", 1),
                new Record(8, "Alice", "green", 20),
                new Record(9, "Bob", "green", 15),
                new Record(10, "Carol", "red", 10),
                new Record(11, "Alice", "red", 10),
                new Record(12, "Bob", "green", 12),
                new Record(13, "Carol", "blue", 14),
                new Record(14, "Dan", "red", 10),
                new Record(15, "Carol", "green", 16),
                new Record(16, "Dan", "blue", 10),
                new Record(17, "Bob", "orange", 1),
                new Record(18, "Alice", "green", 20),
                new Record(19, "Bob", "green", 15),
                new Record(20, "Carol", "red", 10),
                new Record(21, "Eve", "orange", 99)
            };
            
            var result = from record in records
                         group record by record.Name into g
                         select new
                         {
                             Colour = g.Key,
                             Count = g.Count(), 
                             Total = g.Sum(r => r.Count)
                         };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Colour}\t{item.Count}\t{item.Total}");
            }
        }
    }
}
