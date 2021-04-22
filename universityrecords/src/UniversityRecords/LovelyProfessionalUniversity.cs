using System;

namespace UniversityRecords
{
    class LovelyProfessionalUniversity
    {
        private Bussiness BussinessObject = new Bussiness();

        static void Main(string[] args)
        {
            // Calling Start() function to start the program..
            LovelyProfessionalUniversity Lpu = new LovelyProfessionalUniversity();
            Lpu.BussinessObject.Start();
        }
    }
}
