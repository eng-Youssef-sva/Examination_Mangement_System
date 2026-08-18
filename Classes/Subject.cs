using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Examination_Mangement_System.Classes
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public String SubjectName { get; set; } = String.Empty;
        public Subject(int subjectId, String subjectNeme)
        {
            SubjectId = subjectId;
            SubjectName = subjectNeme;

        }
        public override string ToString()
        {
            return SubjectName;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Subject subject)
            {
                return SubjectId == subject.SubjectId;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return SubjectId.GetHashCode();
        }

    }
}
