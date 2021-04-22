using System.Collections.Generic;

namespace UniversityRecords
{
    internal class Bussiness
    {
        private DataLayer DataLayerObject = new DataLayer();
        private DataSplit SplitData = new DataSplit();
        private DataSortingAndDisplay DisplayData = new DataSortingAndDisplay();
        private DataReader ReadData = new DataReader();

        public void Start()
        {
            ReadData.ReadInputDataFromUniversityRecordFile(DataLayerObject.UniversityRecordFilePath);

            List<Applicant> applicantData = SplitData.ReturnApplicantData();
            List<Applicant> failedApplicantData = SplitData.ReturnFailedApplicantData(); 

            // ReadData.PrintData();

            // List<Applicant> applicantData = ReadData.ReturnApplicantDataFromDataReader();
            // List<Applicant> failedApplicantData = ReadData.ReturnFailedApplicantDataFromDataReader();

            DisplayData.ShowEntryInApplicantData(applicantData);

            DisplayData.ShowEntryInFailedApplicantData(failedApplicantData);

            DisplayData.SortDataOnNameThenPercentage(applicantData);

            DisplayData.ShowApplicantsWithGradeA(applicantData);
        }

    }
}