using System.Collections.Generic;

namespace UniversityRecords
{
    internal class DataLayer
    {
        // File Path of the CSV File, from which program will read the data of applicants
        internal string UniversityRecordFilePath = @"C:\Users\shubham.soni\universityrecords\UniRecords.csv";

        // Welcome message for the user
        public string WelcomeMessage = "Enter A to see data of all passed students.\nEnter B to see data of all failed students.\nEnter C to see the sorted data based on name.\nEnter D to see the students with Grade \'A\'.\nEnter \'Q\' to exit the program.";

        // Defining the range of Grade A, lowest possible marks and highest possible marks to be awarded grade A
        public int GradeAUpperRange = 100;
        public int GradeALowerRange = 90;
    }
}