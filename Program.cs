using System;
using System.Collections.Generic;
using Examination_Mangement_System.Classes;

namespace Examination_Mangement_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject ID: ");
            int subjectId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Subject Name: ");
            string subjectName = Console.ReadLine() ?? "";

            Subject subject = new Subject(subjectId, subjectName);

            Console.Write("Enter Number Of Questions: ");
            int numberOfQuestions = Convert.ToInt32(Console.ReadLine());

            Dictionary<Question, Answer> questionAnswers =
                new Dictionary<Question, Answer>();

            for (int i = 1; i <= numberOfQuestions; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"========== Question {i} ==========");

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine() ?? "";

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine() ?? "";

                Console.Write("Enter Marks: ");
                int marks = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number Of Answers: ");
                int numberOfAnswers = Convert.ToInt32(Console.ReadLine());

                AnswerList answers = new AnswerList();

                for (int j = 1; j <= numberOfAnswers; j++)
                {
                    Console.Write($"Enter Answer {j}: ");
                    string answerText = Console.ReadLine() ?? "";

                    answers.Add(new Answer(j, answerText));
                }

                Console.Write("Enter Correct Answer ID: ");
                int correctAnswerId = Convert.ToInt32(Console.ReadLine());

                Answer correctAnswer = answers.Find(
                    answer => answer.AnswerId == correctAnswerId
                );

                Question question = new Question(
                    header,
                    body,
                    marks,
                    answers
                );

                questionAnswers.Add(question, correctAnswer);
            }

            Console.WriteLine();
            Console.WriteLine("========== Exam ==========");

            Console.Write("Enter Exam Time: ");
            int time = Convert.ToInt32(Console.ReadLine());

            PracticeExam practiceExam = new PracticeExam(
                time,
                numberOfQuestions,
                questionAnswers,
                subject);

            practiceExam.ShowExam();
        }
    }
}