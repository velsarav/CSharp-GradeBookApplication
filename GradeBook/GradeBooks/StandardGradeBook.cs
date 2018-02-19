using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool weightage) : base (name,weightage)
        {
            Type = GradeBookType.Standard;
        }
    }
}
