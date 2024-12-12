using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Console_App.Class.ExampleInheritanceAndPolymorphismo
{
    public class Books : Product
    {
        public string Author { get; set; }

        public Books(string Name, double Price, bool Available, string Author)
            : base(Name,Price, Available)
        {
            this.Author = Author;
            
        }

        public override void ShowDatails()
        {
            Console.WriteLine($"Tipo: Libro, Nombre: {Name}, " +
                $"Precio: {Price}, Disponible: {(Available ? "Sí" : "No")}, Autor: {Author}");
        }
    }
}
