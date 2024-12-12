using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleAbstraction
{
    interface Dispositivos
    {
       void Encienden();
        void ConsumenEnergia();
        void Apagar();
    }

    interface IEscucharMusica
    {
        public void ConsumirMusica();
    }
    interface IGuardarAlimentos
    {
        public void ConservarAlimentos();
    }
    interface ILavarRopa
    {
        public void LimpiarRopa();
    }
    interface IRefrescarAmbiente
    {
        public void AmbienteCalido();
    }

    interface  IEquiposElectronicos : Dispositivos 
    {
        public abstract void Desenchufar();
    }

    class Moto 
    {
        public void Encienden() { Console.WriteLine("Se encienden mediante un boton en su base"); }
        public void ConsumenEnergia() { Console.WriteLine("Consume energia mediante electricidad"); }
        public void Apagar() { Console.WriteLine("Se apaga mediante un boton en su base"); }
    }
    class Portatil : IEquiposElectronicos , IEscucharMusica
    {
        public  void Encienden() { Console.WriteLine("Se encienden mediante un boton en su base"); }
        public void ConsumenEnergia() { Console.WriteLine("Consume energia mediante electricidad"); }
        public void Apagar() { Console.WriteLine("Se apaga mediante un boton en su base"); }
        public void Desenchufar() { Console.WriteLine("Se desenchufa mediante un cable"); }
        public void ConsumirMusica() { Console.WriteLine("Se consume musica sin audifonos o con audifonos"); }
      
    }

    class Celular : IEquiposElectronicos , IEscucharMusica
    {
        public void Encienden() { Console.WriteLine("Se encienden mediante un boton en su parte derecha superior"); }
        public void ConsumenEnergia() { Console.WriteLine("Consume energia mediante electricidad"); }
        public void Apagar() { Console.WriteLine("Se apaga mediante un boton en su parte derecha superior"); }
        public void Desenchufar() { Console.WriteLine("Se desenchufa mediante un cable"); }
        public void ConsumirMusica() { Console.WriteLine("Se consume musica sin audifonos o con audifonos"); }
    }


    class EquipoDeSonido : IEquiposElectronicos , IEscucharMusica
    {
        public void Encienden() { Console.WriteLine("Se encienden mediante un boton en su parte frontal"); }
        public void ConsumenEnergia() { Console.WriteLine("Consume energia mediante electricidad"); }
        public void Apagar() { Console.WriteLine("Se apaga mediante un boton en su parte frontal"); }
        public void Desenchufar() { Console.WriteLine("Se desenchufa mediante un cable"); }
        public void ConsumirMusica() { Console.WriteLine("Se consume musica sin audifonos o con audifonos"); }
    }

    class Lavadora : IEquiposElectronicos , ILavarRopa
    {
        public void Encienden() { Console.WriteLine("Se encienden mediante un boton en su parte frontal"); }
        public void ConsumenEnergia() { Console.WriteLine("Consume energia mediante electricidad"); }
        public void Apagar() { Console.WriteLine("Se apaga mediante un boton en su parte frontal"); }
        public void Desenchufar() { Console.WriteLine("Se desenchufa mediante un cable"); }
        public void LimpiarRopa() { Console.WriteLine("lava la ropa mediante un proceso de centrifugacion"); }
    }
    class AireAcondicionado : IEquiposElectronicos , IRefrescarAmbiente
    {
        public void Encienden() { Console.WriteLine("Se encienden mediante un control en su parte frontal"); }
        public void ConsumenEnergia() { Console.WriteLine("Consume energia mediante electricidad"); }
        public void Apagar() { Console.WriteLine("Se apaga mediante un control en su parte frontal"); }
        public void Desenchufar() { Console.WriteLine("Se desenchufa mediante un cable"); }
        public void AmbienteCalido() { Console.WriteLine("Refresca el lugar donde esta posicionado mediante un abanico externo que subciona el aire del ambiente"); }
      
    }

    class Nevera : IEquiposElectronicos, IGuardarAlimentos
    {
        public void Encienden() { Console.WriteLine("Se encienden automaticamnte"); }
        public void ConsumenEnergia() { Console.WriteLine("Consume energia mediante electricidad"); }
        public void Apagar() { Console.WriteLine("Se apaga solo desconectando el cable"); }
        public void Desenchufar() { Console.WriteLine("Se desenchufa mediante un cable"); }
        public void ConservarAlimentos() { Console.WriteLine("Guarda todo tipo de alimento mediante, mediante su motor que produce temeperaturas bajas"); }
     
    }

  
}
