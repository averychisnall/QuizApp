using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Quiz
    {
        public List<Question> Questions { get; set; }

        public int CorrectAnswers { get; protected set; }

        public Quiz(Question[] questions) 
        {
            Questions = questions.ToList();
        }     

        public void NextQuestion()
        {
            var rnd = new Random();
            int q = rnd.Next(Questions.Count - 1);
            var question = Questions[q];
            Console.WriteLine(question.QuestionText);
            for(int i = 0; i < question.Options.Length; i++)
            {
                string ans = question.Options[i];
                Console.WriteLine("Option {0}: {1}", i + 1, ans);
            }
            int? answer;

            while (true)
            {
                answer = GetAnswer();
                if(answer == null)
                {
                    Console.WriteLine("Only input an integer");
                }
                else
                {
                    break;
                }
            }


            bool result = question.IsAnswerCorrect((int)answer);

            if (result) CorrectAnswers++;

            Console.WriteLine(result ? "Correct! Well done!!" : "Incorrect. The correct answer is {0}", question.GetCorrectanswer());
            Console.WriteLine();

            Questions.Remove(question);
        }
        
        private int? GetAnswer()
        {
            var line = Console.ReadLine();

            return int.TryParse(line, out var answer) ? answer : null;
        }
}   
}
