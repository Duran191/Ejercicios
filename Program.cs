using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //EJERCICIO 1                                                           1

            //int a, b, suma, resta, multiplicacion, division;

            //Console.WriteLine("Escribe el 1mer número");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Escribe el 2do número");
            //b = int.Parse(Console.ReadLine());

            //suma = a + b;
            //resta = b - a;
            //multiplicacion = a * b;
            //division = a / b;

            //Console.WriteLine("La suma de estos dos números da: " + suma.ToString());
            //Console.WriteLine("La resta de estos dos números da: " + resta.ToString());
            //Console.WriteLine("La multiplicación de estos dos números da: " + multiplicacion.ToString());
            //Console.WriteLine("La división de estos dos números da: " + division.ToString());
            //Console.ReadKey();








            //EJERCICIO 2                                                                    2

            //decimal sueldo_neto, sueldo_bruto, descuento, pago_hora, horas_trabajadas, afp, sfs;

            //Console.WriteLine("Ingrese de cuanto es el pago por hora: ");
            //pago_hora = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese cuantas horas trabajó el empleado: ");
            //horas_trabajadas = int.Parse(Console.ReadLine());

            //sueldo_bruto = pago_hora * horas_trabajadas;
            //afp = sueldo_bruto * 0.0287m;
            //sfs = sueldo_bruto * 0.0304m;
            //descuento = afp + sfs;
            //sueldo_neto = sueldo_bruto - descuento;

            //Console.WriteLine("El Sueldo Neto del empleado es: " + sueldo_neto.ToString());
            //Console.ReadKey();









            //EJERCICIO 3                                                                    3

            //double a, b, c, suma, resta, divide, multiplica;
            //Console.WriteLine("Primer valor: ");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("segundo valor: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("tercer valor: ");
            //c = double.Parse(Console.ReadLine());

            //suma = a + b + c;
            //resta = a - b - c;
            //divide = a / b / c;
            //multiplica = a * b * c;

            //Console.WriteLine("La suma de estos tres números da: " + suma.ToString());
            //Console.WriteLine("La resta de estos tres números da: " + resta.ToString());
            //Console.WriteLine("La divición de estos tres números da: " + divide.ToString());
            //Console.WriteLine("La multiplicación de estos tres números da: " + multiplica.ToString());
            //Console.ReadKey();









            //EJERCICIO 4                                                               4

            //int promedio, n1, n2, n3, n4, n5;

            //Console.WriteLine("Valor 1:");
            //n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("valor 2: ");
            //n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("valor 3: ");
            //n3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("valor 4: ");
            //n4 = int.Parse(Console.ReadLine());
            //Console.WriteLine("valor 5: ");
            //n5 = int.Parse(Console.ReadLine());

            //promedio = (n1 + n2 + n3 + n4 + n5) / 5;

            //Console.WriteLine("El promedio de estos 5 valores es: " + promedio.ToString());
            //Console.ReadKey();








            //EJERCICIO 5                                                                       5
            //int precio, cantidad, importe;

            //Console.WriteLine("Ingrese el precio unitario del artículo: ");
            //precio = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese la cantidad del artículo a comprar: ");
            //cantidad = int.Parse(Console.ReadLine());

            //importe = precio * cantidad;

            //Console.WriteLine("El importe del artículo es:" + importe.ToString());
            //Console.ReadKey();










            //EJERCICIO 1                                                         6

            //    double precio, cantidad, importe, itbis, descuento, total;

            //Console.WriteLine("Ingrese el precio del artículo: ");
            //precio = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese la cantidad del artículo a comprar: ");
            //cantidad = int.Parse(Console.ReadLine());

            //importe = precio * cantidad;
            //itbis = importe * 0.18;
            //descuento = importe * 0.10;
            //total = importe - descuento + itbis;

            //Console.WriteLine("El importe es: " + importe.ToString());
            //Console.WriteLine("El ITBIS es: " + itbis.ToString());
            //Console.WriteLine("El Descuento es: " + descuento.ToString());
            //Console.WriteLine("El Total general es: " + total.ToString());

            //Console.ReadKey();









            //EJERCICIO 2                                                                  7

            //double sueldo_emp, aumento, total;


            //Console.WriteLine("¿Cúal es el sueldo actual del empleado?");
            //sueldo_emp = double.Parse(Console.ReadLine());

            //aumento = 0.15;

            //total = (sueldo_emp * aumento) + sueldo_emp;

          
            //Console.WriteLine("El aumento es "+aumento.ToString());
            //Console.WriteLine("El sueldo final del empleado es de: " + total.ToString());
            //Console.ReadKey();








            //EJERCICIO 1                                                                8

            //string genero;
            //int edad;

            //Console.WriteLine("¿Cúal es su edad?");
            //edad = int.Parse(Console.ReadLine());

            //if (edad >= 18)
            //{
            //    Console.WriteLine("¿Es usted hembra o varón?");
            //    genero = Console.ReadLine();

            //    if (genero == "hembra")
            //    {
            //        Console.WriteLine("Puede Entrar gratis");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Debe entrar pagando");
            //    }
            //} else
            //{
            //    Console.WriteLine("no puede ingresar");

            //}
            //Console.ReadKey();







            //EJERCICIO 2                                                                 9
            //double precio, descuento, precioCondescuento, total;



            //    Console.WriteLine("Cuanto cuesta el artículo?");
            //    precio = double.Parse(Console.ReadLine());

            //    if (precio >= 1000 && precio <= 5000)
            //    {
            //        descuento = 0.03;
            //        precioCondescuento = precio * descuento;
            //        total = precio - precioCondescuento;
            //        Console.WriteLine("Su descuento es de 3%");
            //        Console.WriteLine("Su precio final es de: " + total);

            //    }
            //    else if (precio >= 5001 && precio <= 10000)
            //    {
            //        descuento = 0.05;
            //        precioCondescuento = precio * descuento;
            //        total = precio - precioCondescuento;
            //        Console.WriteLine("Su descuento es de 5%");
            //        Console.WriteLine("Su precio final es de: " + total);

            //    }
            //    else if (precio >= 10001 && precio <= 15000)
            //    {
            //        descuento = 0.08;
            //        precioCondescuento = precio * descuento;
            //        total = precio - precioCondescuento;
            //        Console.WriteLine("Su descuento es de 5%");
            //        Console.WriteLine("Su precio final es de: " + total);

            //    }
            //    else if (precio >= 15001 && precio <= 20000)
            //    {
            //        descuento = 0.10;
            //        precioCondescuento = precio * descuento;
            //        total = precio - precioCondescuento;
            //        Console.WriteLine("Su descuento es de 5%");
            //        Console.WriteLine("Su precio final es de: "+total);


            //    }
            //    else
            //    {
            //        Console.WriteLine("Su descuento es de 0%");
            //    }


            //    Console.ReadKey();








            //EJERCICIO 3                                                        10

            //int nota1, nota2, nota3, nota4, promedio;

            //Console.WriteLine("Nota 1");
            //nota1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nota 2");
            //nota2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nota 3");
            //nota3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nota 4");
            //nota4 = int.Parse(Console.ReadLine());

            //promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            //Console.WriteLine("Su promedio es de:" + promedio.ToString());

            //if (promedio >= 70)
            //{
            //    Console.WriteLine("Aprobó");
            //}
            //else
            //{
            //    Console.WriteLine("Reprobó");
            //}


            //Console.ReadKey();







            //EJERCICIO  4                                                     11

            //int nota1, nota2, nota3, nota4, promedio, literal;

            //Console.WriteLine("Nota 1");
            //nota1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nota 2");
            //nota2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nota 3");
            //nota3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nota 4");
            //nota4 = int.Parse(Console.ReadLine());

            //promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            //Console.WriteLine("Su promedio es de:" + promedio.ToString());

            //if (promedio >= 90 && promedio <= 100)
            //{
            //    Console.WriteLine("Exelente");
            //}
            //else if (promedio >= 80 && promedio <= 89)
            //{
            //    Console.WriteLine("Muy bueno");
            //}
            //else if (promedio >= 75 && promedio <= 79)
            //{
            //    Console.WriteLine("Bueno");
            //}
            //else if (promedio >= 70 && promedio <= 74)
            //{
            //    Console.WriteLine("Regural");
            //}
            //else
            //{
            //    Console.WriteLine("Deficiente");
            //}

            //Console.ReadKey();








            //EJERCICIO  5                                                     12
            //int numero;
            //Console.WriteLine("Ingrese un número");
            //numero = int.Parse(Console.ReadLine());

            //if (numero > 0)
            //{
            //    Console.WriteLine("El número es Positivo");
            //}

            //else if (numero < 0)
            //{
            //    Console.WriteLine("El número es Negativo");
            //}

            //else {
            //    Console.WriteLine("El número es neutro");
            //}

            //Console.ReadKey();






            //EJERCICIO  6                                                     13

            //int residuoNum;


            //Console.WriteLine("Ingrese el número");
            //residuoNum = int.Parse(Console.ReadLine());

            //if (residuoNum % 2 == 0) {
            //    Console.WriteLine("El número que ingresó es par");
            //}
            //else
            //{
            //    Console.WriteLine("El número es impar");
            //}

            //Console.ReadKey();







            //EJERCICIO    7                                                   14

            //int first, second;

            //Console.WriteLine("Ingrese el 1er número");
            //first = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el 2do número");
            //second = int.Parse(Console.ReadLine());

            //if (first > second)
            //{
            //    Console.WriteLine("El número mayor es: " + first.ToString());
            //}
            //else if (first < second)
            //{
            //    Console.WriteLine("El número mayor es: " + second.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Es el mismo número");
            //}
            //Console.ReadKey();








            //EJERCICIO    8                                                   15
            //int first, second, third;

            //Console.WriteLine("Ingrese el 1er número");
            //first = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el 2do número");
            //second = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el 3er número");
            //third = int.Parse(Console.ReadLine());

            //if (first > second && first > third)
            //{
            //    Console.WriteLine("El número mayor es: " + first.ToString());
            //}
            //else if (second > first && second >third )
            //{
            //    Console.WriteLine("El número mayor es: " + second.ToString());
            //}
            //else if (third > first && third>second)
            //{
            //    Console.WriteLine("El número mayor es: " + third.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Ingrese valores diferentes");
            //}
            //Console.ReadKey();







            //EJERCICIO    9                                                   16
            //int first, second, third;

            //Console.WriteLine("Ingrese el 1er número");
            //first = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el 2do número");
            //second = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el 3er número");
            //third = int.Parse(Console.ReadLine());

            //if (first > second && first > third && second > third)
            //{
            //    Console.WriteLine("El número mayor es: " + first.ToString());
            //    Console.WriteLine("El número central es: " + second.ToString());
            //    Console.WriteLine("El número menor es: " + third.ToString());

            //}
            //else if (first > second && first > third && second < third)
            //{
            //    Console.WriteLine("El número mayor es: " + first.ToString());
            //    Console.WriteLine("El número central es: " + third.ToString());
            //    Console.WriteLine("El número menor es: " + second.ToString());

            //}
            //else if (second > first && second > third && first > third)
            //{
            //    Console.WriteLine("El número mayor es: " + second.ToString());
            //    Console.WriteLine("El número central es: " + first.ToString());
            //    Console.WriteLine("El número menor es: " + third.ToString());

            //}
            //else if (second > first && second > third && first < third)
            //{
            //    Console.WriteLine("El número mayor es: " + second.ToString());
            //    Console.WriteLine("El número central es: " + third.ToString());
            //    Console.WriteLine("El número menor es: " + first.ToString());

            //}
            //else if (third > first && third > second && first > second)
            //{
            //    Console.WriteLine("El número mayor es: " + third.ToString());
            //    Console.WriteLine("El número central es: " + first.ToString());
            //    Console.WriteLine("El número menor es: " + second.ToString());

            //}
            //else if (third > first && third > second && first < second)
            //{
            //    Console.WriteLine("El número mayor es: " + third.ToString());
            //    Console.WriteLine("El número central es: " + second.ToString());
            //    Console.WriteLine("El número menor es: " + first.ToString());

            //}
            //else
            //{
            //    Console.WriteLine("Ingrese valores diferentes");

            //}
            //Console.ReadKey();








            //EJERCICIO    10                                                   17
            //double sueldoBruto, isr, sueldoNeto;
            //double afp = 0.0287;
            //double sfs = 0.0304;
            //double exentoISR = 499884.00;
            //double tramo1 = 749822.00;
            //double tramo2 = 1041224.00;

            //Console.Write("Ingrese el sueldo mensual del empleado: ");
            //sueldoBruto = double.Parse(Console.ReadLine());

            //afp = sueldoBruto * afp;
            //sfs = sueldoBruto * sfs;

            //double sueldoAnual = sueldoBruto * 12;

            //isr = 0;
            //if (sueldoAnual > exentoISR)
            //{
            //    if (sueldoAnual <= tramo1)
            //    {
            //        isr = (sueldoAnual - exentoISR) * 0.15;
            //    }
            //    else if (sueldoAnual <= tramo2)
            //    {
            //        isr = (sueldoAnual - tramo1) * 0.20 + 37_491.00;
            //    }
            //    else
            //    {
            //        isr = (sueldoAnual - tramo2) * 0.25 + 75_082.00;
            //    }
            //}
            //sueldoNeto = sueldoBruto - afp - sfs - (isr / 12);
            //Console.WriteLine("Descuento AFP: RD$ " + afp);
            //Console.WriteLine("Descuento SFS: RD$ " + sfs);

            //if (isr > 0)
            //{
            //    Console.WriteLine("isr Mensual: RD$ " + (isr / 12));
            //}
            //else
            //{
            //    Console.WriteLine("isr: No Aplica");
            //}

            //Console.WriteLine("Sueldo Neto Mensual: RD$ " + sueldoNeto);
            //Console.ReadKey();







            //EJERCICIO    11                                                   18
            //double lunes, martes, miercoles, jueves, viernes, promedio, produccion;

            //Console.WriteLine("De cuanto fue la producción del Lunes");
            //lunes = double.Parse(Console.ReadLine());
            //Console.WriteLine("De cuanto fue la producción del martes");
            //martes = double.Parse(Console.ReadLine());
            //Console.WriteLine("De cuanto fue la producción del miercoles");
            //miercoles = double.Parse(Console.ReadLine());
            //Console.WriteLine("De cuanto fue la producción del jueves");
            //jueves = double.Parse(Console.ReadLine());
            //Console.WriteLine("De cuanto fue la producción del viernes");
            //viernes = double.Parse(Console.ReadLine());

            //produccion = lunes + martes + miercoles + jueves + viernes;
            //promedio = produccion/5;

            //Console.WriteLine("El total de la producción de la semana es de: "+produccion.ToString());
            //Console.WriteLine("El promedio de la producción es de: "+promedio.ToString());


            //if (promedio >= 20.000){
            //    Console.WriteLine("Le corresponde un incentivo de 3,000 pesos");
            //}
            //else { Console.WriteLine("N/A"); }
            //Console.ReadKey();







            //EJERCICIO    12                                                   19

            //int hijos;
            //double sueldoEm, incentivos;

            //Console.WriteLine("Ingrese su sueldo mensual");
            //sueldoEm = double.Parse(Console.ReadLine());

            //Console.WriteLine("¿Cúantos hjos tiene?");
            //hijos = int.Parse(Console.ReadLine());

            //if (hijos > 0)
            //{
            //    incentivos = hijos * 500;
            //    Console.WriteLine("Su incentivo es de: "+incentivos.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("N/A");
            //}
            //Console.ReadKey();





            //EJERCICIO    1                                                   20


            //Console.WriteLine( "¿Cúal es su nombre?");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("¿Nombre de la materia?");
            //string materia = Console.ReadLine();


            //Console.WriteLine("Ingrese la nota 1: ");
            //double nota1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese la nota 2: ");
            //double nota2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese la nota 3: ");
            //double nota3 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese la nota 4: ");
            //double nota4 = double.Parse(Console.ReadLine());

            //double promedio = (nota1 + nota2 + nota3 + nota4) / 4;


            //if (promedio >= 70)
            //{
            //    Console.WriteLine("El alumno " + nombre);
            //    Console.Write(" ha aprobado la materia de " + materia);
            //    Console.ReadKey();
            //}
            //else
            //{

            //    Console.WriteLine("El alumno " + nombre);
            //    Console.Write("Va a completivo en la materia de " + materia);
            //    double completivoPromedio = promedio * 0.50;
            //    Console.Write(" Con un promedio de:  " + promedio);


            //    Console.Write(" Ingrese la nota del examen completivo: ");
            //    double notaCompletivo = Convert.ToDouble(Console.ReadLine());
            //    double completivoExamen = notaCompletivo * 0.50;

            //    double notaFinalCompletivo = completivoPromedio + completivoExamen;
            //    Console.ReadKey();

            //    if (notaFinalCompletivo >= 70)
            //    {

            //        Console.WriteLine("Ha aprobado la parte completiva con una calificación de: " + notaFinalCompletivo.ToString());
            //        Console.ReadKey();
            //    }
            //    else
            //    {
            //        Console.WriteLine("El alumno " + nombre);
            //        Console.Write(" Va a extraordinario en la materia de " + materia);
            //        Console.Write(" con una calificación de: " + notaFinalCompletivo.ToString());

            //        double extraordinarioPromedio = promedio * 0.30;

            //        Console.Write("Ingrese la nota del examen extraordinario: ");
            //        double notaExtraordinario = Convert.ToDouble(Console.ReadLine());
            //        double extraordinarioExamen = notaExtraordinario * 0.70;

            //        double notaFinalExtraordinario = extraordinarioPromedio + extraordinarioExamen;
            //        Console.ReadKey();

            //        if (notaFinalExtraordinario >= 70)
            //        {
            //            Console.WriteLine("El alumno " + nombre);
            //            Console.Write(" Aprobó extraordinario con una calificación de: " + notaExtraordinario);
            //            Console.ReadKey();

            //        }
            //        else
            //        {
            //            Console.WriteLine("El alumno " + nombre);
            //            Console.Write(" Reprobó extraordinario con una calificación de: " + notaExtraordinario);
            //            Console.ReadKey();

            //        }

            //        Console.ReadKey();

            //}

            //}
        }


    }
}
