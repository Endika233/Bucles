﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0, num;
            //Console.WriteLine("Escribe el número a multiplicar");
            //num = Int32.Parse(Console.ReadLine());//O Convert.ToInt32()
            //while (i < 11)
            //{
            //    Console.WriteLine(num + " x " + i + " = " + num * i);
            //    i++;//DESPUES DE HABER HECHO LA OPERACIÓN LE SUMA UNO Y VUELVE A EMPEZAR HASTA LLEGAR AL TOPE DE WHILE
            //}
            //Console.ReadLine();//O READKEY


            //Mostrar números del 1 al 100
            //int i = 1;
            //while (i <101)
            //{
            //    Console.WriteLine(i);
            //    i++;//Sigue ejecutando esto hasta que while sea falso
            //}



            //DO-WHILE
            //int i=1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i<101);//while se comprueba al final en vez de al principio



            //Pedir números hasta que se introduzca uno negativo
            //int i;
            //Console.WriteLine("Introduzca un número");
            //i = Int32.Parse(Console.ReadLine());
            //while (i >= 0)//Mientras sea verdadero se ejecuta
            //{
            //    Console.WriteLine("Introduzca otro número");
            //    i = Int32.Parse(Console.ReadLine());//LA ACCIÓN A PEDIR AQUÍ ES OTRO INPUT
            //}
            //Console.WriteLine("Ese número es negativo");
            //Console.ReadKey();

            //Lo mismo con DOWHILE
            //int i;                      
            //do
            //{
            //    Console.WriteLine("Introduzca un número");
            //    i = Int32.Parse(Console.ReadLine());

            //} while (i > 0);//Se ejecuta hasta que sea falso
            //Console.WriteLine("Ese número es negativo");
            //Console.ReadKey();



            ////BUCLE FOR
            //for(int i = 0; i < 11; i++) {
            //Console.WriteLine(i);}
            //Console.ReadKey();

            //Pedir cuatro numeros y sumarlos
            int num1, suma=0;//LE TENEMOS QUE DAR VALOR A SUMAR PARA QUE PODAMOS SUMARLO AL FINAL DE FOR
            for(int i=1; i < 5; i++)//LA PRIMERA ITERACIÓN CUENTA, SI HICIERA DE 0 A 4 SERÍAN CINCO VECES AL CONTAR EL 0
            {
                Console.WriteLine("Dame un número");
                num1 = Int32.Parse(Console.ReadLine());
                suma = suma + num1;//CADA VEZ QUE PASE POR AQUI CAMBIARA LA VARIABLE SUMA
            }
            Console.WriteLine("Total " + suma);
            Console.ReadLine();
        }
    }
}
