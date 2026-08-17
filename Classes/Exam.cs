using System;
using System.Collections.Generic;

namespace Examination_Mangement_System.Classes
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }

        public Dictionary<Question, Answer> QuestionAnswerDictionary { get; set; }

        public Subject Subject { get; set; }

        public Exam(
            int time,
            int numberOfQuestions,
            Dictionary<Question, Answer> questionAnswerDictionary,
            Subject subject)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            QuestionAnswerDictionary = questionAnswerDictionary;
            Subject = subject;
        }

        public abstract void ShowExam();
    }
}