using System;

namespace UniversityRecords
{
    // Defining Custom Exception with error message for - AgeOutOfRangeException
    // this will be thrown when applicant will have age < 18 or age > 30.
    [Serializable]
    class AgeOutOfRangeException : Exception
    {
        public AgeOutOfRangeException()
        {

        }
        public AgeOutOfRangeException(string name)
            : base(String.Format($"Age for Applicant \'{name}\' is not between 18 to 30."))
        {

        }
    }
}