
namespace Examination_Mangement_System.Classes
{
    internal class Question
    {
        public Question(string header, string body, int marks , AnswerList answers)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Answers = answers;
        }

        public string Header { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public int Marks { get; set; }
        public AnswerList Answers { get; set; }
       

    }
}
