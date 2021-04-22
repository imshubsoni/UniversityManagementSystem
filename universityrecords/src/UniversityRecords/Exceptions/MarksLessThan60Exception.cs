using System;

namespace UniversityRecords
{
    // This is custom Exception to handle the Less Marks - MarksLessThan60Exception
    // This will be thrown when applicant will have percentage less than 60.
    [Serializable]
    class MarksLessThan60Exception : Exception
    {
        public MarksLessThan60Exception()
        {

        }
        public MarksLessThan60Exception(string name)
            : base(String.Format($"Applicant named \'{name}\' has scored less than 60 percentage."))
        {

        }
    }
}