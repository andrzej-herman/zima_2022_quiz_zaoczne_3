using Newtonsoft.Json;
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
            Random = new Random();
        }

        public List<Question> AllQuestions { get; set; }
        public Question CurrentQuestion { get; set; }
        public int CurrentCategory { get; set; }
        public Random Random { get; set; }

        public void CreteAllQuestions()
        {
            var path = Directory.GetCurrentDirectory() + "\\questions.json";
            var text = File.ReadAllText(path);
            AllQuestions = JsonConvert.DeserializeObject<List<Question>>(text); 
        }

        public void GetRandomQuestionFromCurrentCategory()
        {
            var qFCC = new List<Question>();
            foreach (var q in AllQuestions)
            {
                if (q.Category == CurrentCategory)
                {
                    qFCC.Add(q);    
                }
            }

            var r = Random.Next(0, qFCC.Count);
            CurrentQuestion= qFCC[r];   
        }

    }
}
