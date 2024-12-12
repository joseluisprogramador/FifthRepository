using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

/*
El propósito de crear clases, propiedades y métodos abstractos en una clase en programación orientada
a objetos es permitir la creación de una estructura base que define un conjunto de comportamientos y 
propiedades comunes, pero que deja la implementación de ciertos detalles específicos a las clases derivadas o subclases.
Clases abstractas: Sirven como plantillas para otras clases. No pueden ser instanciadas por sí mismas, sino que
se utilizan como base para definir comportamientos comunes que las clases derivadas pueden heredar y, 
opcionalmente, sobrescribir.

Propiedades abstractas: Son propiedades que se declaran en la clase base pero no se les proporciona una
implementación. Las clases derivadas deben proporcionar una implementación concreta para estas propiedades.

Métodos abstractos: Son métodos que se declaran en la clase base pero no se les proporciona una implementación
concreta. Las clases derivadas deben implementar estos métodos según sus necesidades específicas.

El propósito principal de estas abstracciones es promover la reutilización del código, la cohesión y la
extensibilidad del sistema. Al definir una clase base con métodos y propiedades abstractas, estás estableciendo
un contrato que las clases derivadas deben cumplir, lo que facilita la creación de nuevas clases que se ajusten
a una cierta estructura predefinida pero que pueden tener comportamientos y características únicas.
Esto ayuda a organizar y mantener el código de manera más eficiente y facilita la escalabilidad del sistema.
 */
namespace Console_App.Class.ExampleAbstracClass
{
    public abstract class School : ITeacher, IProceduresSchool
    {
        public abstract  string? TeacherName { get ; set; }
        public abstract string? TeacherProfession { get ; set; }
        public abstract void AddSchool(string SchoolName);
        public abstract void DeleteSchool(string StudenName);
        public abstract void QuerySchool(string Student); 
    }
}
