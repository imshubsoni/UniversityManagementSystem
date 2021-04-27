using System;
using System.Linq;
using System.Collections.Generic;

namespace UniversityRecords
{
    class DataSortingAndDisplay
    { 
        DataLayer DataLayerObject = new DataLayer();
        DataReader ReadData = new DataReader();

        public void ShowEntryInApplicantData(List<Applicant> applicantData)
        {
            var ApplicantData = applicantData;
            foreach(var applicant in ApplicantData)
            {
                Console.WriteLine($"Name: {applicant.Name}\t\tAge: {applicant.Age}\t\tPercentage: {applicant.Percentage}");
            }
            Console.WriteLine();
        }

        public void ShowEntryInFailedApplicantData(List<Applicant> failedApplicantData)
        {
            var FailedApplicantData = failedApplicantData;
            Console.WriteLine("\nFailed Applicants :");
            foreach(var applicant in FailedApplicantData)
            {
               Console.WriteLine($"Name: {applicant.Name}\t\tAge: {applicant.Age}\t\tPercentage: {applicant.Percentage}"); 
            }
            Console.WriteLine();
        }

        public void SortDataOnNameThenPercentage(List<Applicant> applicantData)
        {
            var ApplicantData = applicantData;
            var SortedApplicantData = from applicant in ApplicantData
                                        orderby applicant.Name, applicant.Percentage
                                        select applicant;

            foreach(var applicant in SortedApplicantData)
            {
                Console.WriteLine($"Name: {applicant.Name}\t\tAge: {applicant.Age}\t\tPercentage: {applicant.Percentage}");
            }
            Console.WriteLine();
        }

        public void ShowApplicantsWithGradeA(List<Applicant> applicantData)
        {
            var ApplicantData = applicantData;
            var SelectApplicantsWithGradeA = from applicant in ApplicantData
                                                where (applicant.Percentage >= DataLayerObject.GradeALowerRange && applicant.Percentage < DataLayerObject.GradeAUpperRange)
                                                select applicant;

            if(SelectApplicantsWithGradeA.Count() == 0)
            {
                Console.WriteLine("No applicant found with Grade A!");
            }
            else
            {
                Console.WriteLine("\nApplicants with Grade A :\n");
                foreach(var applicant in SelectApplicantsWithGradeA)
                {
                    Console.WriteLine($"Name - {applicant.Name}\nAge - {applicant.Age}\nPercentage - {applicant.Percentage}");
                }
                Console.WriteLine();
            }
        }
    }
}