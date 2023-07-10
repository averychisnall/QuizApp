using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Question
    {
        public string QuestionText { get; set; } = string.Empty;

        public string[] Options { get; set; } = Array.Empty<string>();

        public int AnswerIndex { get; set; }

        public bool IsAnswerCorrect(int i)
        {
            return i == AnswerIndex + 1;
        }

        public string GetCorrectanswer()
        {
            return Options[AnswerIndex];
        }
    }
}
