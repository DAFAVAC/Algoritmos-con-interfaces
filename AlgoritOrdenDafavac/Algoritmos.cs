using System;

namespace AlgoritOrdenDafavac
{

    public class Algoritmos
    {
        public Array CombSort(int[] data)
        {
            double gap = data.Length;
            bool swaps = true;

            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;

                if (gap < 1)
                    gap = 1;

                int i = 0;
                swaps = false;

                while (i + gap < data.Length)
                {
                    int igap = i + (int)gap;

                    if (data[i] > data[igap])
                    {
                        int temp = data[i];
                        data[i] = data[igap];
                        data[igap] = temp;
                        swaps = true;
                    }

                    ++i;
                }
            }
            Console.WriteLine("Coleccion ordenada con CombSort:");
            foreach (int aray in data)
                Console.Write(aray + " ");
            return data;
        }


        public Array Bubblesort(int[] a)
        {
            int t;

            for (int j = 0; j <= a.Length - 2; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("Coleccion ordenada con Bubblesort:");
            foreach (int aray in a)
                Console.Write(aray + " ");
            return a;
        }
    }

}
