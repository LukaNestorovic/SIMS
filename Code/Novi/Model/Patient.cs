/***********************************************************************
 * Module:  Patient.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using System;

namespace Model
{
   public class Patient : User
   {
      public int RateDoctor()
      {
         // TODO: implement
         return 0;
      }
      
      public int RateHospital()
      {
         // TODO: implement
         return 0;
      }
   
      public String InsuranceCarrier { get; set; }
      public Boolean Guest { get; set; }

        public Patient(string insuranceCarrier, bool guest)
        {
            InsuranceCarrier = insuranceCarrier;
            Guest = guest;
        }
        public Patient(string name, string surname, string jmbg, string telephone, string email, DateTime birthDate, string adress, string insuranceCarrier, bool guest, int id):base(name, surname, jmbg, telephone, email, birthDate, adress, id)
        {
            InsuranceCarrier = insuranceCarrier;
            Guest = guest;
        }
        public Patient()
        {
        }
    }
}
