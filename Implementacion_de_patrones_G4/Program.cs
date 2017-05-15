﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implementacion_de_patrones_G4.Builder;
using Implementacion_de_patrones_G4.Prototype;

namespace Implementacion_de_patrones_G4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- PATRONES DE CREACION | GRUPO 4 ----\n\n");


            /* Ejemplo Builder */
            Console.WriteLine("--- Pruebas Builder ---\n");

            AutomovilBuilder ToyotaCorolla1 = new ToyotaCorollaBuilder();
            ToyotaCorolla1.buildColor("Negro");
            ToyotaCorolla1.buildNumeroPuertas(5);
            ToyotaCorolla1.buildTamanoLlantas(17);
            ToyotaCorolla1.ImprimirResultado();

            AutomovilBuilder ToyotaHilux1 = new ToyotaHiluxBuilder();
            ToyotaHilux1.buildColor("Rojo");
            ToyotaHilux1.buildNumeroPuertas(4);
            ToyotaHilux1.buildTamanoLlantas(18);
            ToyotaHilux1.ImprimirResultado();

            AutomovilBuilder MitsubishiLancer1 = new MitsubishiLancerBuilder();
            MitsubishiLancer1.buildColor("Azul Electrico");
            MitsubishiLancer1.buildNumeroPuertas(4);
            MitsubishiLancer1.buildTamanoLlantas(16);
            MitsubishiLancer1.ImprimirResultado();

            Console.WriteLine("\n--- Fin de Builder ---\n");

            /* Fin de Builder */

            /* Pruebas Prototype */

            Console.WriteLine("--- Pruebas Prototype ---\n");

            Color rojo = new Color("Rojo");
            Color azul = new Color("Azul");
            Color verde = new Color("Verde");

            Color copiaVerde = verde.Clone() as Color;
            Color copiaAzul = azul.Clone() as Color;
            Color copiaRojo = rojo.Clone() as Color;

            Console.WriteLine("\n--- Fin de Prototype ---\n");

            /* Fin de Prototype  */

            Console.ReadLine();
        }
    }
}
