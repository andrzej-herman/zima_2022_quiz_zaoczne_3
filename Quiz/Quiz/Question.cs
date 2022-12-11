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


        private void ShowQuestion()
        {
            Console.WriteLine();
            Console.WriteLine($"Pytanie za {Category} pkt");
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();
            foreach (var answer in Answers)
            {
                Console.WriteLine($"{answer.DisplayOrder}. {answer.Content}");
            }
            Console.WriteLine();
            Console.Write("Naciśnij numer poprawnej oddpowiedzi: 1, 2, 3 lub 4 => ");
        }



        public int Display()
        {
            ShowQuestion();
            var playerAnswer = Console.ReadLine();
            var correctKey = IsCorrectKey(playerAnswer);
            while (!correctKey)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Nacisnąłeś nieprawidłowy klawisz !!!");
                Console.ForegroundColor = ConsoleColor.White;
                ShowQuestion();
                playerAnswer = Console.ReadLine();
                correctKey = IsCorrectKey(playerAnswer);
            }

            return int.Parse(playerAnswer);

        }

        private bool IsCorrectKey(string key)
        {
            bool isNumber = int.TryParse(key, out int number);
            if (!isNumber)
            {
                return false;
            }
            else
            {
                if (number > 0 && number < 5)
                    return true;       
            }

            return false;
        }


    }
}



// 100, 200, 300, 400, 500, 750, 1000