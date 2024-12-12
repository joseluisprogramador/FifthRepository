using Console_App.Class.ExampleAbstracClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleClass
{
    /*Clase comun todas las propiedad y funciones pertenecen al objeto no a la clase, no es abstracta*/
    public class People
    {
        public int Id { get; set; }
        public string? Names { get; set; }
        public string? LastName { get; set; }
        public byte CurrentAge { get; set; }
        public string ? CivilStatus { get; set; }
        public string ? Profession { get; set; }
        public int CurrentSalary { get; set; }
        public long Phone { get; set; }
        public string ? Email { get; set; }

        public People() { }
        public People(int Id, string? Names, string? LastName, byte CurrentAge, 
            string? CivilStatus, string? Profession, int CurrentSalary, long Phone, string? Email)
        {
            this.Id = Id;
            this.Names = Names;
            this.LastName = LastName;
            this.CurrentAge = CurrentAge;
            this.CivilStatus = CivilStatus;
            this.Profession = Profession;
            this.CurrentSalary = CurrentSalary;
            this.Phone = Phone;
            this.Email = Email;
        }
        public void Disabilty(bool disability, string disabilityName = "None")
        {
            string Information =
                disability ? $"The disability has people is : {disabilityName}" : disabilityName ;
            Console.WriteLine(Information);                   
        }



    }
}
