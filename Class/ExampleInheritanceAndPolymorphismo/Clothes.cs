using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Console_App.Class.ExampleInheritanceAndPolymorphismo
{
    public class Clothes : Product
    {
        public string Size { get; set; }

        public Clothes(string Name, double Price, bool Available, string Size)
            : base(Name, Price, Available)
        {
            
            this.Size = Size ;
        }

        public override void ShowDatails()
        {
            Console.WriteLine($"Tipo: Ropa, Nombre: {Name}, Precio: {Price}, " +
                $"Disponible: {(Available ? "Sí" : "No")}, Talla: {Size}");

        }
    }
}
