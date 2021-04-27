using System;
using System.Collections.Generic;

namespace UniversityRecords
{
    class DataSplit
    {
        private Applicant ApplicantObject = new Applicant();
        internal static List<Applicant> ApplicantData = new List<Applicant>();
        internal static List<Applicant> FailedApplicantData = new List<Applicant>();

        // This method checks for all types of exceptions - First - FormatException
        //                                                - Second - AgeOutOfRangeException
        //                                                - Third - MarksLessThan60Exception
        // If no exception found then it will store the data into ApplicantData List.
        internal void SplitTheData(string line)
        {
            string[] parts = line.Split(",");
            int ageOfApplicant;
            int percentageOfApplicant;

            if(!Int32.TryParse(parts[1], out ageOfApplicant))
            {
                throw new FormatException($"Inavlid Age for \'{parts[0]}\'. Age must be a number.");
            }

            if(!Int32.TryParse(parts[2], out percentageOfApplicant))
            {
                throw new FormatException($"Invalid Percentage for \'{parts[0]}\'. Percentage Must be a number.");
            }
            
            if(ageOfApplicant < 18 || ageOfApplicant > 30)
            {
                throw new AgeOutOfRangeException(parts[0]);
            }

            ApplicantObject.Name = parts[0];
            ApplicantObject.Age = ageOfApplicant;
            ApplicantObject.Percentage = percentageOfApplicant;

            if(percentageOfApplicant < 60)
            {
                FailedApplicantData.Add(new Applicant(ApplicantObject.Name, ApplicantObject.Age, ApplicantObject.Percentage));
                throw new MarksLessThan60Exception(parts[0]);
            }

            ApplicantData.Add(new Applicant(ApplicantObject.Name, ApplicantObject.Age, ApplicantObject.Percentage));
        }  

        // This function returns the ApplicantData list whenever called.
        internal List<Applicant> ReturnApplicantData()
        {
            return ApplicantData;
        }

        // This function returns the FailedApplicantData List whenever called.
        internal List<Applicant> ReturnFailedApplicantData()
        {
            return FailedApplicantData;
        }
    }
}