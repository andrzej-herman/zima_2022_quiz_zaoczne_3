using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Game
    {
        public Game()
        {
            CreteAllQuestions();
            CurrentCategory = 100;
        }

        public List<Question> AllQuestions { get; set; }
        public Question CurrentQuestion { get; set; }
        public int CurrentCategory { get; set; }

        public void CreteAllQuestions()
        {
            AllQuestions = new List<Question>();
            var q = new Question();
            q.Id = 1;
            q.Category = 100;
            q.Content = "Jak miał na imię Eintein?";
            q.Answers = new List<string>();
            q.Answers.Add("Albert");
            q.Answers.Add("Aaron");
            q.Answers.Add("Anthony");
            q.Answers.Add("Basia");
            AllQuestions.Add(q);
        }

        public void GetRandomQuestionFromCurrentCategory()
        {
            // udajamy na razie że losujemy
            // niby wylosowalismy pytane z CurrentCategory
            CurrentQuestion = AllQuestions[0];
        }

    }
}
