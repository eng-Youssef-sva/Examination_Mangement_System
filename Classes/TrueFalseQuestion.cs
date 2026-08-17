using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_Mangement_System.Classes
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int marks , AnswerList answers) : base(header, body, marks , answers)
        {

        }

    }
}