using System;

namespace UniversityRecords
{
    // Creating an Applicant entity with three fields - Name, Age, Percentage
    // Defining two Constructor - First - Empty Constructor to define an object
    //                          - Second - A Constructor with Three parameter to create a new Applicant Object.
    internal class Applicant
    {
        public Applicant()
        {
        }

        public Applicant(string name, int age, int percentage)
        {
            Name = name;
            Age = age;
            Percentage = percentage;
        }

        internal string Name { get; set; }
        internal int Age { get; set; }
        internal int Percentage { get; set; }

    }
}