using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleInheritanceAndPolymorphismo
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }

        public Product(string Name, double Price, bool Available)
        {
            this.Name = Name ;
            this.Price = Price;
            this.Available = Available;
        }

        public virtual void ShowDatails()
        {
            Console.WriteLine($"Nombre: {Name}, Precio: {Price}, Disponible: {(Available ? "Sí" : "No")}");
        }
    }
}


/*
 Herencia en programación orientada a objetos (POO): 
La herencia es un principio fundamental en POO que permite que una clase (llamada clase derivada o subclase)
herede propiedades y comportamientos de otra clase (llamada clase base o superclase). La clase derivada puede
extender o modificar el comportamiento de la clase base. Esto ayuda a la reutilización de código y a establecer 
relaciones entre las clases.
 */

/*
 Polimorfismo: El polimorfismo es otro concepto importante en POO, que significa "muchas formas". 
 En términos simples, el polimorfismo permite que objetos de diferentes clases se comporten de manera
 similar, proporcionando una interfaz común. Esto se logra a través de la herencia y la capacidad de las
 clases derivadas de sobrescribir o implementar métodos de la clase base. El polimorfismo permite tratar
 objetos de diferentes clases de manera uniforme.
 */

/*
 Constructores: En C#, un constructor es un método especial que se llama automáticamente cuando se
crea una instancia de una clase. Su propósito principal es inicializar los objetos de la clase, estableciendo
valores predeterminados para sus campos y realizando cualquier otra tarea de inicialización necesaria. 
Los constructores pueden tener parámetros que se utilizan para proporcionar valores iniciales a los 
campos de la clase.
En un proyecto de programación real, los constructores son fundamentales para crear y configurar 
objetos de manera apropiada. Puedes utilizarlos para establecer valores iniciales, realizar validaciones, 
inicializar conexiones a bases de datos u otros recursos externos, entre otras tareas. Al definir y utilizar
constructores de manera adecuada, puedes asegurarte de que tus objetos estén en un estado válido y coherente
desde el principio.
 */

/*
 Uno de los usos más comunes de los constructores en las subclases es llamar al constructor de la superclase
para inicializar las partes de la clase base. Esto se hace utilizando la palabra clave base seguida de los 
argumentos necesarios para llamar al constructor de la superclase.

La finalidad de hacer esto es asegurar que la inicialización de la superclase se realice correctamente
antes de proceder con la inicialización específica de la subclase. Al llamar al constructor de la superclase
desde la subclase, puedes reutilizar la lógica de inicialización de la superclase y evitar la duplicación 
de código.
 */