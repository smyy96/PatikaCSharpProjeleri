using System;

namespace FibonacciOrt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fibNum = 0;
            Console.Write("Sayı giriniz: ");
            fibNum = int.Parse(Console.ReadLine());

            double sum = 0;
            double seri = 1;
            double seri2= 2;
            double tut = 0;
            for (int i = 1; i <= (fibNum-2); i++) // serinin ilk iki degerini almadıgım için döngüyü 2 azalttım
            {
                tut = seri2;
                seri2 += seri;
                seri = tut;

                sum += tut;
            }

            double ort =(1 + 1 + sum) / fibNum; // 1 + 1 fibonacci serisinin ilk iki degeri
            Console.WriteLine("Fibonacci Ortalama: "+ ort);
        }
    }
}
