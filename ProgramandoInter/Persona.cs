using System;
using System.Collections.Generic;
using System.Text;
using AlgoritOrdenDafavac;


namespace ProgramandoInter 
{
    class Persona : IProgramadorDaniel
    {
        public string Nombre { get; set; }

        Algoritmos algoritmo = new Algoritmos();
        public Array Arreglo1(int numero1, int numero2, int numero3, int numero4, int numero5, int numero6, int numero7, int numero8)
        {
            int[] number = new int[8];
            number[0] = numero1;
            number[1] = numero2;
            number[2] = numero3;
            number[3] = numero4;
            number[4] = numero5;
            number[5] = numero6;
            number[6] = numero7;
            number[7] = numero8;

            return algoritmo.Bubblesort(number);

        }

        public Array Arreglo2(int numero1, int numero2, int numero3, int numero4, int numero5, int numero6, int numero7, int numero8)
        {
            int[] number = new int[8];
            number[0] = numero1;
            number[1] = numero2;
            number[2] = numero3;
            number[3] = numero4;
            number[4] = numero5;
            number[5] = numero6;
            number[6] = numero7;
            number[7] = numero8;


            return algoritmo.CombSort(number);
        }
    }
}
