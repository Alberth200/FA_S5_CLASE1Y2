using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_S5_CLASE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Ej7();
        }
        static void Ej1()
        {
            Console.Write("Ingrese nota 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nota 2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nota 3: ");
            int n3 = int.Parse(Console.ReadLine());
            float promedio = (n1 + n2 + n3) / 2;
            if (promedio >= 10)
            {
                Console.WriteLine("Fuera de rango");
            }
            else if (promedio >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else if (promedio >= 4 && promedio < 7)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
        }
        static void Ej2()
        {
            Console.Write("Ingrese un nuevo numero");
        }
        static void Ej3() 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} ** 2 = {Math.Pow(i,2)}");
            }
        }
        static void Ej4() 
        {
            Console.Write("Ingrese un numero -> ");
            int n=int.Parse(Console.ReadLine());
            for (int i = 0;i < 16;i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }
        static void Ej5()
        {
            Console.WriteLine("Ingresa cuantos numeros: ");
            int a = int.Parse(Console.ReadLine());
            int cont = 0;
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Ingrese numeros: ");
                int b = int.Parse(Console.ReadLine());
                cont = cont + b;
            }
            Console.WriteLine($"La suma es: {cont}");
            Console.WriteLine($"El promedio es: {cont/a}");
        }
        static void Ej6()
        {
            Console.Write("Ingrese numero: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = a; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void Ej7()
        {
            int cont = 0;
            for (int i = 100; i<=200 ; i++)
            {
                if (1%2 == 0 && (i<150 || i>176))
                {
                    cont=cont+i; 
                }
            }
            Console.WriteLine(cont);
        }
    }
}