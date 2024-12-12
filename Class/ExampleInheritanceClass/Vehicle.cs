using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleInheritanceClass
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public string ? Marker { get; set; }
        public string? CountryOfOrigin { get; set; }
        public string ? TypePropulsion { get; set; }

        public Vehicle() { }
        public Vehicle(int Id, string Name,string Brand,string Marker,string CountryOfOrigin,string TypePropulsion)
        {
            this.Id = Id;
            this.Name = Name ;
            this.Brand = Brand ;
            this.Marker = Marker ;
            this.CountryOfOrigin = CountryOfOrigin ;
            this.TypePropulsion = TypePropulsion ;
        }

        public virtual string PropulsionSystem(string Propulsion = "none")
        {
            List<string> TypePropulsion 
                = ["Diesel", "Electrico", "Célula de Combustible de Hidrógeno"];

            if (TypePropulsion.Contains(Propulsion))
            {
                return Propulsion ;
            }
            return "none";       
        }

        public virtual void VehicleShow(int Id) { }
    }
}


