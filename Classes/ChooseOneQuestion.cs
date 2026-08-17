using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_Mangement_System.Classes
{
    internal class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string header, string body, int marks , AnswerList answers) : base(header, body, marks ,answers) 
        {
        

        }
    }
}
