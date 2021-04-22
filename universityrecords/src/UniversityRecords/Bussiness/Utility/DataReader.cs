using System;
using System.Linq;
using System.Collections.Generic;

namespace UniversityRecords
{
    class DataReader
    { 
        private DataSplit splitData = new DataSplit();

        public void ReadInputDataFromUniversityRecordFile(string fileName)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);  
            while((line = file.ReadLine()) != null)  
            {  
                try
                {
                    splitData.SplitTheData(line);
                }
                catch (AgeOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (MarksLessThan60Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }  
            file.Close(); // TODO: Security Concern
        }

        public void PrintData()
        {
            List<Applicant> applicantData = splitData.ReturnApplicantData();
            
            foreach (var applicant in applicantData)
            {
                Console.WriteLine($"Name: {applicant.Name}");
            }
        }

        public List<Applicant> ReturnApplicantDataFromDataReader()
        {
            return splitData.ReturnApplicantData();
        }

        public List<Applicant> ReturnFailedApplicantDataFromDataReader()
        {
            return splitData.ReturnFailedApplicantData();
        }
    }
}