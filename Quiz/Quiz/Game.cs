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
            var qFCC = AllQuestions.Where(x => x.Category == CurrentCategory).ToList();
            var r = Random.Next(0, qFCC.Count);
            var question = qFCC[r];
            question.Answers = question.Answers.OrderBy(x => Random.Next()).ToList();
            
            // uzywając petli for
            //for (int i = 0; i < question.Answers.Count; i++)
            //{
            //    question.Answers[i].DisplayOrder = i + 1;
            //}

            // uzywając pętli foreach
            var index = 1;
            foreach (var answer in question.Answers)
            { 
                answer.DisplayOrder = index;
                index++;
            }

            CurrentQuestion = question;
        }


        public bool CheckPlayerAnswer(int playerAnswer)
        {
            var answer = CurrentQuestion.Answers.FirstOrDefault(x => x.DisplayOrder== playerAnswer);   
            return answer.IsCorrect;
        }


    }
}
