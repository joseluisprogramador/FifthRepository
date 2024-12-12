using Console_App.Class.ExampleClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleObject
{
    public class PeopleShow
    {
       
        public void PeopleShow1()
        {
            People oPeople1 = new People();
            oPeople1.Id = 1;
            oPeople1.Names = "Jose Luis";
            oPeople1.LastName = "Maldonado Muriel";
            oPeople1.CurrentAge = 25 ;
            oPeople1.CivilStatus = "Single" ;
            oPeople1.Profession = "Systems Engineer";
            oPeople1.CurrentSalary = 3000000 ;
            oPeople1.Phone = 3146552595;
            oPeople1.Email = "Josemaldonado10@People.com";
            Console.WriteLine($"Names : {oPeople1.Names} , LastNames : {oPeople1.LastName} ," +
                $" CurrentAge : {oPeople1.CurrentAge} , Email : {oPeople1.Email}");
            oPeople1.Disabilty(true,"blind");

            People oPeople2 = new People()
            {
                Id = 2,
                Names = "Jose Luis",
                LastName = "Maldonado Muriel",
                CurrentAge = 25,
                CivilStatus = "Single",
                Profession = "Systems Engineer",
                CurrentSalary = 3000000,
                Phone = 3146552595,
                Email = "Josemaldonado10@People.com"

            };

 
            Console.WriteLine($"Names : {oPeople2.Names} , LastNames : {oPeople2.LastName} ," +
                $" CurrentAge : {oPeople2.CurrentAge} , Email : {oPeople2.Email}");
            oPeople1.Disabilty(true, "blind");


            People oPeople3 = new People(3,"Luis Miguel","Arias Hernandez",34,"Single","Nurse",1000000,3135359803,"LuisArias23@People.com");

            Console.WriteLine($"Names : {oPeople3.Names} , LastNames : {oPeople3.LastName} ," +
              $" CurrentAge : {oPeople3.CurrentAge} , Email : {oPeople3.Email}");
            oPeople1.Disabilty(true, "blind");

        }
    }
}
