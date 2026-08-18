using System;
using System.Collections.Generic;

namespace Examination_Mangement_System.Classes
{
    internal abstract class Exam : ICloneable, IComparable
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

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(object? obj)
        {
            if (obj is Exam exam)
            {
                return Time.CompareTo(exam.Time);
            }

            return 1;
        }

        public override string ToString()
        {
            return $"Subject: {Subject}, Time: {Time}, Number Of Questions: {NumberOfQuestions}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Exam exam)
            {
                return Time == exam.Time &&
                       NumberOfQuestions == exam.NumberOfQuestions &&
                       Subject.Equals(exam.Subject);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(
                Time,
                NumberOfQuestions,
                Subject);
        }
    }
}