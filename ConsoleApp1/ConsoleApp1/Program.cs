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


            ////Escribe un programa que pida 10 valores. Al final mostrar la media de esos valores.
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


            ////Escribe un programa que muestre todos los valores pares o impares entre 1 y 100,
            ////dependiendo de si el usuario introduce P o I . 
            ////Si introduce otra cosa, decir que ese valor no es correcto y pedirle otra vez.
            //int i;
            //string bin;
            //do
            //{
            //    Console.WriteLine("¿Números pares o impares?P/I");
            //    bin = Console.ReadLine();
            //    if (bin == "P" || bin =="p")
            //    {
            //        for (i = 2; i <= 100; i+=2) //Primero + luego igual
            //        Console.WriteLine(i);
            //    }
            //    else if (bin =="I"||bin=="i") //Primero + luego igual
            //    {
            //        for (i = 1; i <= 100; i += 2) 
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Comando no válido /n");
            //    }

            //} while (bin != "P" && bin!="p"&&bin!="i"&&bin!="I");//Repetir mientras sea verdad que cualquiera es diferente



            ////Escribe un programa que pregunte al usuario su edad. 
            ////Mostrar en pantalla “Feliz cumpleaños” repetido tantas veces como años tenga.
            //int edad,i;
            //Console.WriteLine("¿Cuántos años tienes?");
            //edad = Int32.Parse(Console.ReadLine());
            //for (i = 0; i < edad; i++)
            //{
            //    Console.WriteLine("¡¡FELIZ CUMPLEAÑOS!!");
            //}


            ////Pedir al usuario un número. Mostrar en pantalla 
            ////*
            ////**
            ////***
            ////Con tantas líneas como el número que ha introducido
            //int lineas,i,j;
            //Console.WriteLine("Escribe un número de líneas");
            //lineas = Int32.Parse(Console.ReadLine());
            //for (i = 0; i < lineas; i++)//Este escribe cuantas líneas va a hacer
            //{
            //    for (j = 0; j <= i; j++)//hasta que j iguale a i sigue escribiendo asteriscos
            //    {
            //        Console.Write("*");//Asi en la línea 4 habrá 4 asteríscos etc.
            //    }
            //    Console.WriteLine();
            //}


            ////Escribe un programa que muestre los números de 1 a 12 en una columna.
            ////En la columna de al lado de los números impares mostrar el cuadrado de ese valor 
            ////y en la de los pares mostrar el cubo.
            //int i;//Tabulado\t, salto de línea \n
            //for (i = 1; i <= 12; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i + "\t" + Math.Pow(i, 3));
            //    }
            //    else
            //    {
            //        Console.WriteLine(i + "\t" + Math.Pow(i, 2));
            //    }
            //}


            ////Mostrar en pantalla diez números, siendo el primero 1 y los siguientes la suma del número anterior y 5.
            //int num=1;
            //Console.WriteLine(num);
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(num + 5);
            //    num = num + 5;
            //}


            ////Crear un programa que muestre el valor de sumar todos los números desde 1
            ////hasta el número que introduzca el usuario. 
            ////Por ejemplo si introduce el 8 debería mostrar 36 (1 + 2+ 3+ 4+ 5+ 6+ 7+ 8)
            //int num1,i,num2=0;
            //Console.WriteLine("Introduzca un número");
            //num1 = Int32.Parse(Console.ReadLine());
            //for (i = 1; i <= num1; i++)
            //{                
            //    num2 = num2 + i;//Cada vez que la iteracion suba de valor sumamos uno y cambiamos el valor a 2              
            //}
            //Console.WriteLine(num2);


            ////Escribe un programa que muestre el resultado de sumar todos los números del 1
            ////hasta el número introducido y que vuelva a pedirle al usuario otro número 
            ////hasta que el usuario introduzca un 0.
            //int num1, i, num2 = 0;
            //Console.WriteLine("Introduzca un número");
            //num1 = Int32.Parse(Console.ReadLine());
            //while (num1 != 0) 
            //{                
            //    for (i = 1; i <= num1; i++)
            //    {
            //        num2 = num2 + i;                    
            //    }
            //    Console.WriteLine(num2);
            //    num2 = 0;//Aquí refrescamos la variable para que no vaya sumando resultados
            //    Console.WriteLine("Introduzca un número");
            //    num1 = Int32.Parse(Console.ReadLine());
            //} 


            ////Escribe un programa que muestre el número entero positivo que el usuario introduzca pero al revés 
            ////(si introduce 1478 que muestre 8741), hasta que el usuario introduzca 0.
            ////Si introduce 0 la primera vez, debería mostrarlo al revés (es decir, mostrar 0) y acabar el programa.
            //int num;
            //Console.WriteLine("Escriba un número");
            //do
            //{

            //    num = Int32.Parse(Console.ReadLine());
            //    do
            //    {
            //        Console.Write(num % 10);//Aquí saco la unidad.
            //        num = num / 10;//al dividir en el siguiente ciclo la unidad sera la centena
            //    } while (num != 0);
            //} while (num != 0);



            ////Un número factorial es el resultado de multiplicar todos los números de 1 a ese mismo número
            ////(por ejemplo el factorial de 4 es 1 x 2 x 3 x 4 = 24). 
            ////Haz un programa que muestre los números del 1 al 10 en una columna con el resultado de su factorial
            ////en la columna de al lado.
            //int i, fact = 1;
            //for (i = 1; i <= 10; i++)//Si i fuera 0 al calcular el factor primero multiplicaria por cero jodiendo lo demas
            //{

            //    fact=i*fact;//factorizacion(1*2*3=3!(factor 3)cada vez que el for vuelve, i suma uno y lo multiplica por
            //    //el factor del número anterior que ya habíamos calculado
            //    Console.WriteLine(i + "\t" + fact);

            //}



            //Escribe un programa que pida un número y muestre el resultado de sumar sus dígitos.
            int i, num,sum=0;
            Console.WriteLine("Introduzca un número");
            num = Int32.Parse(Console.ReadLine());

            do
            {
                sum = num % 10 + sum;//Vamos sacando las unidades
                num = num / 10;//y aqui las vamos sumando
            } while (num != 0);
            Console.WriteLine(sum);



        

            Console.ReadLine();
        }
    }
}
