using System;

//1---------------------------------------------------------
/*
class Program{
     static void Main(string[] args)
    {
        int cont = 0;
        int i = 0;
        int Porcentaje;
        var notas = new[] { 7.1M, 3, 6, 5, 4, 6.5M, 7 };

        contar:
            if(notas[i]>=5)
                cont++;
            i++;

        if(i < notas.Length) goto contar;

        Porcentaje = (100*cont)/notas.Length;

        Console.WriteLine(Porcentaje+"%");
    }
}
*/
//2-------------------------------------------------------------

/*
class Program
{
    static void Main(string[] args)
    {
        int cont = 0;
        int i = 0;
        int Porcentaje;
        var notas = new[] { 7.1M, 3, 6, 5, 4, 6.5M, 7 };

        while (i < notas.Length)
        {
            if (notas[i] >= 5)
                cont++;
            i++;

        }
        Porcentaje = (100 * cont) / notas.Length;

        Console.WriteLine(Porcentaje + "%");
    }
}
*/

//3-------------------------------------------------------------
/*
int cont;
int i;
int Porcentaje;
var notas = new[] { 7.1M, 3, 6, 5, 4, 6.5M, 7 };

Inicializacion();
while (i < notas.Length) Proceso();
Finalizacion();

void Inicializacion()
{
    cont = 0;
    i = 0;
    Porcentaje = 0;
}

void Proceso()
{

    if (notas[i] >= 5)
        cont++;
    i++;


    Porcentaje = (100 * cont) / notas.Length;
}

void Finalizacion()
{
    Console.WriteLine(Porcentaje + "%");
}
*/
//4-------------------------------------------------
/*
int cont;
int i;
int Porcentaje;
var notas = new[] { 7.1M, 3, 6, 5, 4, 6.5M, 7 };

Decimal Operciones(Decimal[] notas){
    cont = 0;
    i = 0;
    while(i < notas.Length){
                if(notas[i]>=5)
                    cont++;
                i++;
            
            }
            Porcentaje = (100*cont)/notas.Length;
    return Porcentaje;
}

Console.WriteLine(Operciones(notas) + "%");
*/

//5.1-----------------------------------------------------

/*
(String,Char,Decimal) A1 =("Luis", 'H',7.1M);
(String,Char,Decimal) A2 =("Marta", 'M',4);
(String,Char,Decimal) A3 =("Marcos", 'H',6);
(String,Char,Decimal) A4 =("Aroa", 'M',5);
(String,Char,Decimal) A5 =("Nerea", 'M',4);
(String,Char,Decimal) A6 =("Kike", 'H',6.5M);
(String,Char,Decimal) A7 =("Juan", 'H',7.5M);

var notas = new[] { A1, A2, A3, A4, A5, A6, A7};
decimal media = 0M;
for (int i = 0; i < notas.Length; i++)
{
    media += notas[i].Item3;
}
Console.WriteLine(media/notas.Length);
*/
//5.2---------------------------------------------------------

/*
class Program
 {
     public struct Alumno
    {
         public String nombre;
         public Char sexo;
         public decimal nota;
     }
     public static void Main()
     {
         Console.WriteLine("Usando estructuras");

         Alumno Al1; Al1.nombre = "Luis"; Al1.sexo = 'H'; Al1.nota = 7.5M;
         Alumno Al2; Al2.nombre = "Marta"; Al2.sexo = 'M'; Al2.nota = 4;
         Alumno Al3; Al3.nombre = "Marcos"; Al3.sexo = 'H'; Al3.nota = 6;
         Alumno Al4; Al4.nombre = "Aroa"; Al4.sexo = 'M'; Al4.nota = 5;
         Alumno Al5; Al5.nombre = "Nerea"; Al5.sexo = 'M'; Al5.nota = 4;
         Alumno Al6; Al6.nombre = "Kike"; Al6.sexo = 'H'; Al6.nota = 6.5M;
         Alumno Al7; Al7.nombre = "Juan"; Al7.sexo = 'H'; Al7.nota = 7.5M;
         var notas = new[] { Al1, Al2, Al3, Al4, Al5, Al6, Al7 };

         decimal media = 0M;
        for (int i = 0; i < notas.Length; i++)
         {
             media += notas[i].nota;
         }
         Console.WriteLine(media / notas.Length);
     }
}
*/
//5.3---------------------------------------------------------------------------
/*
class Program
{
    public record Person(string FirstName, Char LastName, decimal nota);

    public static void Main()
    {
        Person person1 = new("Luis", 'h', 7.5M);
        Person person2 = new("Marta", 'M', 4);
        Person person3 = new("Marcos", 'H', 6);
        Person person4 = new("Aroa", 'M', 5);
        Person person5 = new("Nerea", 'M', 4);
        Person person6 = new("Kike", 'H', 6.5M);
        Person person7 = new("Juan", 'H', 7.5M);
        var notas = new[] { person1, person2, person3, person4, person5, person6, person7 };
        decimal media = 0M;
        for (int i = 0; i < notas.Length; i++)
        {
            media += notas[i].nota;
        }
        Console.WriteLine(media / notas.Length);
    }

}
*/
//5.4-------------------------------------------------------------------------------
/*
class Persona
{
    String _nombre;
    char _sexo;
    decimal _media;
    public Persona()
    {
        _nombre = "unknown";
    }

    public Persona(string nombre, char sexo, decimal media)
    {
        _nombre = nombre;
        _sexo = sexo;
        _media = media;
    }

    public char sexo
    {
        get => _sexo;
        set => _sexo = value;
    }

    public String nombre
    {
        get => _nombre;
        set => _nombre = value;
    }

    public decimal media
    {
        get => _media;
        set => _media = value;
    }
}
class PruebaPersona
{
    public record Person(string FirstName, Char LastName, decimal media);
    public static void Main()
    {
        var person1 = new Persona("Luis", 'h', 7.5M);
        var person2 = new Persona("Marta", 'M', 4);
        var person3 = new Persona("Marcos", 'H', 6);
        var person4 = new Persona("Aroa", 'M', 5);
        var person5 = new Persona("Nerea", 'M', 4);
        var person6 = new Persona("Kike", 'H', 6.5M);
        var person7 = new Persona("Juan", 'H', 7.5M);
        var notas = new[] { person1, person2, person3, person4, person5, person6, person7 };
        decimal media = 0M;
        for (int i = 0; i < notas.Length; i++)
        {
            media += notas[i].media;
        }
        Console.WriteLine(media / notas.Length);
    }
}*/

//6.----------------------------------------------------------------------------------------------------
/*
using System.Collections.Generic;


   
        var dLuis = new Dictionary<string, object>();
        dLuis["nombre"] = "Luis";
        dLuis["sexo"] = 'H';
        dLuis["nota"] = 7.5M;

        var dMarta = new Dictionary<string, object>();
        dLuis["nombre"] = "Marta";
        dLuis["sexo"] = 'M';
        dLuis["nota"] = 4;

        var dMarcos = new Dictionary<string, object>();
        dLuis["nombre"] = "Marcos";
        dLuis["sexo"] = 'H';
        dLuis["nota"] = 6;

        var dAroa = new Dictionary<string, object>();
        dLuis["nombre"] = "Aroa";
        dLuis["sexo"] = 'M';
        dLuis["nota"] = 5;

        var dNerea = new Dictionary<string, object>();
        dLuis["nombre"] = "Nerea";
        dLuis["sexo"] = 'M';
        dLuis["nota"] = 4;

        var dKike = new Dictionary<string, object>();
        dLuis["nombre"] = "Kike";
        dLuis["sexo"] = 'H';
        dLuis["nota"] = 6.5M;

        var dJuan = new Dictionary<string, object>();
        dLuis["nombre"] = "Juan";
        dLuis["sexo"] = 'H';
        dLuis["nota"] = 7.5M;

        var notas = new[] { dLuis,dMarta, dMarcos, dAroa, dNerea, dKike, dJuan};
        decimal media = 0M;
        for (int i = 0; i < notas.Length; i++)
        {
            media += decimal.Parse(notas[i]["nota"].ToString());
        }
        Console.WriteLine(media / notas.Length);
*/

namespace Actividad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Sistema system = new Sistema();

            Alumno A1 = new Alumno("Luis", 'H', 7.5M);
            Alumno A2 = new Alumno("Marta", 'M', 4M);
            Alumno A3 = new Alumno("Marcos", 'H', 6M);
            Alumno A4 = new Alumno("Aroa", 'M', 5M);
            Alumno A5 = new Alumno("Nerea", 'M', 4M);
            Alumno A6 = new Alumno("Kike", 'H', 6.5M);
            Alumno A7 = new Alumno("Juan", 'H', 7.5M);

            Alumno[] notas = { A1, A2, A3, A4, A5, A6, A7 };


            Console.WriteLine($"{(system.calcularMedia(notas)):0.00} ");
            Console.WriteLine($"{(system.calcularAprobados(notas)):0.00} " + "%");
        }
    }
}

class Sistema
{
    public decimal calcularMedia(Alumno[] lista)
    {
        decimal resultado = 0M;
        for (int i = 0; i < lista.Length; i++)
            resultado += lista[i].nota;
        return resultado / lista.Length;
    }

    public decimal calcularAprobados(Alumno[] lista)
    {
        decimal resultado = 0M;
        int cantidadAprobados = 0;
        for (int i = 0; i < lista.Length; i++)
            if (lista[i].nota >= 5)
                cantidadAprobados++;
        resultado = (cantidadAprobados * 100) / lista.Length;
        return resultado;
    }


}

class Alumno
{
    String nombre;
    char sexo;
    public decimal nota;
    public Alumno(String _nombre, char _sexo, decimal _nota)
    {
        nombre = _nombre;
        sexo = _sexo;
        nota = _nota;
    }
}