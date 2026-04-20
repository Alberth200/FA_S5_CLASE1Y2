using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_S5_CLASE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Elija Ejercicio a ejecutar 1-5");
            opcion=int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: Ej1();  break;
                case 2: Ej2();  break;
                case 3: Ej3();  break;
                case 4: Ej4(); break;
                case 5: Ej5(); break;
                default: Console.WriteLine("Opción no valida"); break;
            }
        }
        static void Ej1()
        {
            Random ale=new Random();
            int num=ale.Next(11)-5;
            Console.WriteLine("Numero:"+num);
            if (num > 0) Console.WriteLine("Positivo");
            else
            {
                if (num < 0) Console.WriteLine("Negativo");
                else
                {
                    Console.WriteLine("Neutro");
                }
            }
        }
        static void Ej2() 
        {
            Random aleatorio=new Random();
            int nota=aleatorio.Next(21);
            Console.WriteLine("Nota=" + nota);
            if (nota >= 0 && nota <= 11)
                Console.WriteLine("Desaprobado");
            else
            {
                if (nota <= 14)
                    Console.WriteLine("Aprobado");
                else
                {
                    if (nota <= 17)
                        Console.WriteLine("Bueno");
                    else
                    {
                        Console.WriteLine("Exelente");
                    }
                }
            }
        }
        static void Ej3() 
        {
            Console.WriteLine("Tabla: ");
            int tabla=int.Parse(Console.ReadLine());
            Console.WriteLine("Tabla de multiplicar del " + tabla + "\n");
            for (int i = 1; i<=12; i++) //i<13
            {
                Console.WriteLine(tabla + " x " +1+" = " + (i * tabla));
                //Console.WriteLine(i+" x "+tabla+"="+(i * tabla));
            }
        }
        static void Ej4() 
        {
            Console.WriteLine("Valor de n=");
            int n=int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + "^2=" + (i * i));
                suma += i * i;
            }
            Console.WriteLine("Suma=" + suma);
        }
        static void Ej5() 
        {
            Console.WriteLine("Valor de n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1;i<=n;i++)
            {
                Console.WriteLine(i + ":");
                for (int j = 1; j <= 1; i++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}
