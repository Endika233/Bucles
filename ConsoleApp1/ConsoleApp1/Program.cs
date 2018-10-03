using System;
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
            //int num1, suma=0;//LE TENEMOS QUE DAR VALOR A SUMAR PARA QUE PODAMOS SUMARLO AL FINAL DE FOR
            //for(int i=1; i < 5; i++)//LA PRIMERA ITERACIÓN CUENTA, SI HICIERA DE 0 A =4 SERÍAN CINCO VECES AL CONTAR EL 0
            //{
            //    Console.WriteLine("Dame un número");
            //    num1 = Int32.Parse(Console.ReadLine());
            //    suma = suma + num1;//CADA VEZ QUE PASE POR AQUI CAMBIARA LA VARIABLE SUMA
            //}
            //Console.WriteLine("Total " + suma);


            //Escribe un programa que muestre en pantalla los números del 10 al 20(incluidos los dos)
            //con una línea vacía entre ellos.
            //for(int i = 10; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine();
            //}


            //Escribe un programa que muestre en pantalla los números del 20 al 10 (incluidos los dos)
            //con una línea vacía entre ellos.
            //for (int i = 20; i >= 10; i--)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine();
            //}


            //Escribe un programa que pida 10 valores. Al final mostrar la media de esos valores.
            //int media, suma = 0;
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Escribe un número");
            //    suma = suma+Int32.Parse(Console.ReadLine());//NO TE OLVIDES DE SUMAR LA VARIABLE AL READLINE
            //}
            //media = suma / 10;
            //Console.WriteLine("La media es " + media);


            //Escribe un programa que pida valores hasta que el usuario introduzca un 0.
            //Si introduce un valor negativo, mostrar un mensaje diciendo que se ignoran los valores negativos.
            //Mostrar la suma de los valores introducidos. 
            //int num, suma=0;
            //do
            //{
            //    Console.WriteLine("Introduce un número");
            //    num = Int32.Parse(Console.ReadLine());
            //    if (num < 0) {
            //        Console.Write("El número introducido no es válido.");//Si este no se cumple salta el while,pide num again
            //    }
            //    else
            //    {
            //        suma = suma + num;//si el número introducido es correcto lo suma a suma
            //    }

            //} while (num != 0);//Mientras sea diferente de 0 repetirá
            //Console.WriteLine("La suma de los números introducidos es " + suma);


            //Escribe un programa que muestre todos los valores pares o impares entre 1 y 100,
            //dependiendo de si el usuario introduce P o I . 
            //Si introduce otra cosa, decir que ese valor no es correcto y pedirle otra vez.






            Console.ReadLine();
        }
    }
}
