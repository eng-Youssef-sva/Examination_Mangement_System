using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_Mangement_System.Classes
{
    internal class Answer
    {
        public Answer(int answerid, string answertext) 
        {
            AnswerId = answerid;
            AnswerText=answertext;


        }
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
    }
}
