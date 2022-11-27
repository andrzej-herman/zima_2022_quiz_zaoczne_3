using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Question
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }

        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"Pytanie za {Category} pkt");
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();
            foreach (var answer in Answers)
            {
                Console.WriteLine($"{answer.Id}. {answer.Content}");
            }
            Console.WriteLine();
            Console.Write("Naciśnij numer poprawnej oddpowiedzi: 1, 2, 3 lub 4 => ");
            Console.WriteLine();
        }
    }
}



// 100, 200, 300, 400, 500, 750, 1000