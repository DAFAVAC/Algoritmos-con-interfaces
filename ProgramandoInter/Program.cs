using System;



namespace ProgramandoInter
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("¿Hola como te llamas?");
            var name = Console.ReadLine();

            Console.WriteLine("Ingrese datos:(8 numeros enteros):");
            var numero1 = Convert.ToInt32(Console.ReadLine());
            var numero2 = Convert.ToInt32(Console.ReadLine());
            var numero3 = Convert.ToInt32(Console.ReadLine());
            var numero4 = Convert.ToInt32(Console.ReadLine());
            var numero5 = Convert.ToInt32(Console.ReadLine());
            var numero6 = Convert.ToInt32(Console.ReadLine());
            var numero7 = Convert.ToInt32(Console.ReadLine());
            var numero8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Ordenando : {0},{1},{2},{3},{4},{5},{6},{7}", numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8);


            Persona Daniel = new Persona();
            Daniel.Nombre = name; 

            Console.WriteLine(".........................................................................");
            Daniel.Arreglo1(numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8);
            Console.WriteLine("");
            Daniel.Arreglo2(numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8);


            

        }
    }
}
