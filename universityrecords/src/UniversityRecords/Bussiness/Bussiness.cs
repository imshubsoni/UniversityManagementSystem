using System;
using System.Collections.Generic;

namespace UniversityRecords
{
    internal class Bussiness
    {
        private DataLayer DataLayerObject = new DataLayer();
        private DataSplit SplitData = new DataSplit();
        private DataSortingAndDisplay DisplayData = new DataSortingAndDisplay();
        private DataReader ReadData = new DataReader();

        // This is the Start() method, which will call all other functions which needs to be implemeted -
        // - read the data from input file, sorting the data, and displaying the data on console.
        public void Start()
        {
            ReadData.ReadInputDataFromUniversityRecordFile(DataLayerObject.UniversityRecordFilePath);
            Console.WriteLine("\nAll Data Successfully stored.\n");

            List<Applicant> applicantData = SplitData.ReturnApplicantData();
            List<Applicant> failedApplicantData = SplitData.ReturnFailedApplicantData(); 

            while(true)
            {
                Console.WriteLine(DataLayerObject.WelcomeMessage);
                char userInput = Console.ReadLine()[0];

                Console.Clear();

                if(userInput == 'Q')
                {
                    break;
                }
  
                switch(userInput)
                {
                    case 'A':
                        DisplayData.ShowEntryInApplicantData(applicantData);
                        break;

                    case 'B':
                        DisplayData.ShowEntryInFailedApplicantData(failedApplicantData);
                        break;

                    case 'C':
                        DisplayData.SortDataOnNameThenPercentage(applicantData);
                        break;

                    case 'D':
                        DisplayData.ShowApplicantsWithGradeA(applicantData);
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}