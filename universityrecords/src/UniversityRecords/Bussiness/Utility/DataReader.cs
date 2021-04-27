using System;
using System.Linq;
using System.Collections.Generic;

namespace UniversityRecords
{
    class DataReader
    { 
        private DataSplit splitData = new DataSplit();

        // This is the first function to be called from Start() method
        // This function read the file and check for all the exceptions which needs to be handled.
        // It calls another method - SplitTheData() - to categorize data and store them in lists.
        public void ReadInputDataFromUniversityRecordFile(string fileName)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);  
            while((line = file.ReadLine()) != null)  
            {  
                try
                {
                    // this method will run for each and every line of input file.
                    // This method will check for any exceptions and if not found, will store the data into list
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
            file.Close();
        }
    }
}