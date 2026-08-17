using System;
using System.Collections.Generic;
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

    }
}
