using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_Mangement_System.Classes
{
    internal class FinalExam :Exam
    {
        public FinalExam(
               int time,
               int numberOfQuestions,
               Dictionary<Question, Answer> questionAnswerDictionary,
               Subject subject)
               : base(time, numberOfQuestions, questionAnswerDictionary, subject)
        {
        }
        public override void ShowExam()
        {
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Time: {Time}");

            foreach (var item in QuestionAnswerDictionary)
            {
                Question question = item.Key;

                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);

                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
                }

                Console.Write("Your Answer: ");
                int answerId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }
        }
    }
}
