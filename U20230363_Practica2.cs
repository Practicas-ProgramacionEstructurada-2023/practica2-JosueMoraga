using System;

namespace MyApp;// Note: actual namespace depends on the project name.

internal class Program
{
     static void Main(string[] args)
    {
        // DECLRACION DE VARIABLES DE TEXTO CAPTURANDO DESDE LA TERMINAL
    string? nombre ;
    string? apellido;

    // DECLARACION DE VARIABLES DE TEXTO CODIGO
    string? codigo_estudiantil = "U20230538";
    string? becado = "no";

    // DECLARACION DE VARIABLES DE TIPO ENTERAS CAPTURANDO DESDE LA TERMINAL
    int edad;

    // DECLARACION DE VARIABLES DE TIPO ENTERO DESDE CODIGO
    int año_ingreso = 2023;
    int año_egreso = 2028;

    // DECLARACION DE VARIABLES DECIMALES CAPTURANDO DESDE TERMINAL
    double mensualidad ;

    // DECLRACION DE VARIABLES DECIMALES DESDE CODIGO
    double transporte = 2.50 ;
    double alimentacion = 3.75 ;

    // DECLARACION DE VARIABLES DE TIEMPO O TIME
    DateTime FechaActual = DateTime.Now ;
    DateTime FechaEspecifica = new DateTime(25, 8, 19 ,16 , 20, 00);



    //OBTENCION DE DATOS DESDE LA TERMINAL 
    Console.WriteLine("Ingrese su nombre:");
    nombre = Convert.ToString(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Ingrese su apellido:");
    apellido = Convert.ToString(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Ingrese su edad:");
    edad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Ingrese su mensualidad universitaria: ");
    mensualidad =Convert.ToDouble(Console.ReadLine());


    // IMPRESION DE DATOS
    Console.WriteLine ("Su nombre es : " + nombre);
    Console.WriteLine ("Su apellido es: " + apellido);
    Console.WriteLine ("Su codigo estudiantil es: " + codigo_estudiantil);
    Console.WriteLine ("es bacado: " + becado);
    Console.WriteLine ("Su edad es : " + edad);
    Console.WriteLine ("El año en que ingreso fue : " + año_ingreso);
    Console.WriteLine ("Su año de egreso sera : " + año_egreso);
    Console.WriteLine ("Su mensualidad universitaria es : " + mensualidad);
    Console.WriteLine ("Su gasto diario de transporte es : " + transporte);
    Console.WriteLine ("su gasto diario de alimentacion es " + alimentacion);
    Console.WriteLine ("La fecha y tiempo de impresion de datos es " + FechaActual);
    Console.WriteLine ("La fecha que termina la practica es : " + FechaEspecifica);
    Console.WriteLine ("******************Fin de impresion***********************");


    Console.WriteLine ("***********************Inicio de impresion*************************");
    // APLICACION DE FUNCION DE CADENA

    // FUNCION DE COMPARACION DE CADENAS DE TEXTO
    bool cadenaComparativa = nombre == apellido;

    // FUNCION MINUSCULA
    string? funcionMinuscula1 = nombre.ToLower();
    string? funcionMinuscula2 = apellido.ToLower();

    // FUNCION MAYUSCULA
    string? funcionMayuscula1 = nombre.ToUpper();
    string? funcionMayuscula2 = apellido.ToUpper();

    // FUNCION CONCATENADO
    string? cadenaConcatenada = nombre + " " + apellido ;

    // FUNCION TAMAÑO DE CADENA
    int llongitudCdena1 = nombre.Length;
    int llongitudCdena2 = apellido.Length;

    Console.WriteLine ("Comparacion: "+ cadenaComparativa);
    Console.WriteLine ("Mayuscula Nombre y Apellido: "+ funcionMayuscula1 + " "+ funcionMayuscula2);
    Console.WriteLine ("Minuscula Nombre y Apellido : "+ funcionMinuscula1+ " "+ funcionMinuscula2);
    Console.WriteLine ("Concatenacion: "+ cadenaConcatenada);
    Console.WriteLine ("La longitus de datos de nombre es: "+ llongitudCdena1);
    Console.WriteLine ("La longitus de datos de apellido es: "+ llongitudCdena2);
    Console.WriteLine ("*****************Fin de la impresion********************");

    }
}