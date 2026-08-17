using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_Mangement_System.Classes
{
    internal class QuestionList : List<Question>
    {
        private string FileName { get; set; }
        public QuestionList(string filename) { FileName = filename; }

        public new void Add(Question question)
        {
            base.Add(question);
            using (TextWriter writer = new StreamWriter(FileName, true))
            {
                writer.WriteLine(question.Header);
                writer.WriteLine(question.Body);
                writer.WriteLine($"Marks :{question.Marks}");
                writer.WriteLine("--------------------------------");






            }

        }




    }
}
