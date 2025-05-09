using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCreationTool
{
    public class Question
    {
        public string QuestionText;
        public List<string> Options;
        public int CorrectAnswerIndex;

        public override string ToString()
        {
            return $"{QuestionText} - {Options[CorrectAnswerIndex]}";
        }
    }
}
