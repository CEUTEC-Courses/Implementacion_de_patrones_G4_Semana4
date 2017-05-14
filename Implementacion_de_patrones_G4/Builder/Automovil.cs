using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_de_patrones_G4.Builder
{

    public enum Tipo_Carro
    {
        Turismo,
        Sedan,
        Camioneta,
        Pickup
    }

    public class Automovil
    {
        private String Marca = "";
        private String Modelo = "";
        private String Motor = "";
        private Tipo_Carro Tipo;
        private int TamanioLlantas = -1;
        private String ColorPintura = "";
        private int NumeroPuertas = 4;

        public Automovil()
        {

        }

        public void setMarca(String marca)
        {
            Marca = marca;
        }

        public void setModelo(String modelo)
        {
            Modelo = modelo;
        }

        public void setMotor(String motor)
        {
            Motor = motor;
        }

        public void setTipo(Tipo_Carro tipo)
        {
            Tipo = tipo;
        }

        public void setTamanoLlantas(int tamanio)
        {
            if(tamanio>=15)
                TamanioLlantas = tamanio;
        }

        public void setColorPintura(String color)
        {
            ColorPintura = color;
        }

        public void setNumeroPuertas(int numero)
        {
            if (numero >= 4 && numero <= 5)
                NumeroPuertas = numero;
        }

        public void ImprimirResultado()
        {
            Console.WriteLine("--- Automovil Construido ---");
            Console.WriteLine("Marca : {0}", Marca);
            Console.WriteLine("Motor : {0}", Motor);
            Console.WriteLine("Tipo : {0}", Tipo.ToString());
            Console.WriteLine("Tamanio Llantas : {0}", TamanioLlantas);
            Console.WriteLine("Color : {0}", ColorPintura);
            Console.WriteLine("Numero de Puertas : {0}", NumeroPuertas);
            Console.WriteLine("--- FIN ---\n\n");

        }

    }
}
