using System;
using System.Collections.Generic;

namespace UniversityRecords
{
    class DataSplit
    {
        private Applicant ApplicantObject = new Applicant();
        public static List<Applicant> ApplicantData = new List<Applicant>();
        internal List<Applicant> FailedApplicantData = new List<Applicant>();

        internal void SplitTheData(string line)
        {
            string[] parts = line.Split(",");
            int ageOfApplicant;
            int percentageOfApplicant;

            if(!Int32.TryParse(parts[1], out ageOfApplicant))
            {
                throw new FormatException($"Inavlid Age for \'{parts[0]}\'. Age must be an integer.");
            }

            if(!Int32.TryParse(parts[2], out percentageOfApplicant))
            {
                throw new FormatException($"Invalid Percentage for \'{parts[0]}\'. Percentage Must be an integer.");
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
                this.FailedApplicantData.Add(new Applicant(ApplicantObject.Name, ApplicantObject.Age, ApplicantObject.Percentage));
                throw new MarksLessThan60Exception(parts[0]);
            }

            ApplicantData.Add(new Applicant(ApplicantObject.Name, ApplicantObject.Age, ApplicantObject.Percentage));
        }  

        internal List<Applicant> ReturnApplicantData()
        {
            return ApplicantData;
        }

        internal List<Applicant> ReturnFailedApplicantData()
        {
            return FailedApplicantData;
        }
    }
}