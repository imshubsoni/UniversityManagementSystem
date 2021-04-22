using System.Collections.Generic;

namespace UniversityRecords
{
    internal class DataLayer
    {
        // File Path of the CSV File, from which program will read the data of applicants
        internal string UniversityRecordFilePath = @"C:\Users\shubham.soni\universityrecords\UniRecords.csv";

        // Defining the range of Grade A, lowest possible marks and highest possible marks to be awarded grade A
        public int GradeAUpperRange = 100;
        public int GradeALowerRange = 90;
    }
}