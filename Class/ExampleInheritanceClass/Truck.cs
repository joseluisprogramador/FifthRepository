using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleInheritanceClass
{
    public class Truck : Vehicle
    {
        public Truck() { }
        public Truck(int Id, string Name, string Brand, string Maker, string CountryOfOrigin, string TypePropulsion)
       : base(Id, Name, Brand, Maker, CountryOfOrigin, TypePropulsion)
        {

        }

        protected List<Truck> TruckList()
        {
            return new List<Truck>() {

                 new Truck(1,"Kenworth T680", "Kenworth", "PACCAR Inc.", "Estados Unidos", "Diesel"),
                 new Truck(2,"Volvo FH16", "Volvo", "AB Volvo", "Suecia", "Diesel"),
                 new Truck(3,"Mercedes-Benz Actros", "Mercedes-Benz", "Daimler AG", "Alemania", "Diesel"),
                 new Truck(4,"Scania R-Series", "Scania", "Scania AB", "Suecia", "Diesel"),
                 new Truck(5,"MAN TGX", "MAN", "MAN SE", "Alemania", "Diesel"),
                 new Truck(6,"DAF XF", "DAF", "DAF Trucks N.V.", "Países Bajos", "Diesel"),
                 new Truck(7,"Iveco S-Way", "Iveco", "CNH Industrial", "Italia", "GNC (Gas Natural Comprimido)"),
                 new Truck(8,"Renault Trucks T", "Renault", "Renault Trucks", "Francia", "GNL (Gas Natural Licuado)"),
                 new Truck(9,"Tesla Semi", "Tesla", "Tesla, Inc.", "Estados Unidos", "Eléctrico"),
                 new Truck(10,"Hyundai Xcient Fuel Cell", "Hyundai", "Hyundai Motor Company", "Corea del Sur", "Célula de Combustible de Hidrógeno"),
                 new Truck(11,"Nikola Tre", "Nikola", "Nikola Corporation", "Estados Unidos", "Célula de Combustible de Hidrógeno"),
                 new Truck(12,"Fuso eCanter", "Fuso", "Mitsubishi Fuso Truck and Bus Corporation", "Japón", "Eléctrico")
            };
        }

        public virtual List<Truck> ExportListTruck()
        {
            return TruckList();
        }

        public override void VehicleShow(int Id)
        {
            /*
            bool Exist = false ;
            foreach (Truck oTruck in TruckList())
            {
                if (oTruck.Id.Equals(Id))
                {
                    Console.WriteLine(
                     $"Name : {oTruck.Name} " +
                     $"Marker : {oTruck.Marker} " +
                     $"TypePropulsion : {oTruck.TypePropulsion} ");
                    Exist = true ;
                    break ;
                }         
            }
            if (!Exist) { Console.WriteLine("The vehicle does not exist");  }
            */
            bool Exist = false ;
            foreach (Truck oTruck in TruckList())
            {
                 Exist = oTruck.Id == Id ? true : false ;
                if (Exist)
                {
                    Console.WriteLine(
                    $"Name : {oTruck.Name} " +
                    $"Marker : {oTruck.Marker} " +
                    $"TypePropulsion : {oTruck.TypePropulsion} ");
                    break ;
                } 
    
            }
            if (!Exist) { Console.WriteLine("The vehicle does not exist"); }
         
        }
    }
}

