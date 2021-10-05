

//1---------------------------------------------------------
/*
using System;
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
using System;
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
using System;
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
using System;
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
using System;
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
using System;
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
using System;
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
using System;
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
using System;
using System.Collections.Generic;


   
        var dLuis = new Dictionary<string, object>();
        dLuis["nombre"] = "Luis";
        dLuis["sexo"] = 'H';
        dLuis["nota"] = 7.5M;

        var dMarta = new Dictionary<string, object>();
        dMarta["nombre"] = "Marta";
        dMarta["sexo"] = 'M';
        dMarta["nota"] = 4;

        var dMarcos = new Dictionary<string, object>();
        dMarcos["nombre"] = "Marcos";
        dMarcos["sexo"] = 'H';
        dMarcos["nota"] = 6;

        var dAroa = new Dictionary<string, object>();
        dAroa["nombre"] = "Aroa";
        dAroa["sexo"] = 'M';
        dAroa["nota"] = 5;

        var dNerea = new Dictionary<string, object>();
        dNerea["nombre"] = "Nerea";
        dNerea["sexo"] = 'M';
        dNerea["nota"] = 4;

        var dKike = new Dictionary<string, object>();
        dKike["nombre"] = "Kike";
        dKike["sexo"] = 'H';
        dKike["nota"] = 6.5M;

        var dJuan = new Dictionary<string, object>();
        dJuan["nombre"] = "Juan";
        dJuan["sexo"] = 'H';
        dJuan["nota"] = 7.5M;

        var notas = new[] { dLuis, dMarta, dMarcos, dAroa, dNerea, dKike, dJuan};
        decimal media = 0M;
        for (int i = 0; i < notas.Length; i++)
        {
            media += decimal.Parse(notas[i]["nota"].ToString());
        }
        Console.WriteLine(media / notas.Length);
*/

//7---------------------------------------------------------------------------------------
/*
using System;
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
*/

//7.2--------------------------------------------------------------------------
/*

using System.Collections.Generic;
using System.Linq;
using System;

public class Hello{
    public static void Main(){
        // Your code here!

        System.Console.WriteLine("Hello C#");

		Func<String, int> longitud = n => n.Length;
        Func<int, bool> impar = n => n%2 != 0;
		var suma = 0;
		var myArray = new List<String>() {"Word", "Excel", "Access", "Powerpoint"};
		var myArraymap = myArray.Select(longitud);
		var filterArray = myArraymap.Where(impar);
			foreach( int elem in filterArray ) suma = suma + elem;
		Console.WriteLine("La suma de todos los impares es: "+suma);
		
		
    }
}

*/


//Ejercicio 8--------------------------------------------------------------------
/*
using System;
using System.Linq;

personas A1 = new personas();
A1.nombre = "Luis";
A1.sexo = 'H';
A1.nota = 7.5M;

personas A2 = new personas();
A2.nombre = "Marta";
A2.sexo = 'M';
A2.nota = 4;

personas A3 = new personas();
A3.nombre = "Marcos";
A3.sexo = 'H';
A3.nota = 6;

personas A4 = new personas();
A4.nombre = "Aroa";
A4.sexo = 'M';
A4.nota = 5;

personas A5 = new personas();
A5.nombre = "Nerea";
A5.sexo = 'M';
A5.nota = 4;

personas A6 = new personas();
A6.nombre = "Kike";
A6.sexo = 'H';
A6.nota = 6.5M;

personas A7 = new personas();
A7.nombre = "Juan";
A7.sexo = 'H';
A7.nota = 7.5M;

var notas = new[] { A1, A2, A3, A4, A5, A6, A7 };

var sistema = new Sistema(notas);
var vista = new Vista();
var controlador = new Controlador(sistema, vista);
controlador.Run();
Console.WriteLine("Fin");

//vista va a leer los datos k se metan

public class Vista{
    //Obtiene el dato introducido y mira si hay una opcion valida (esta funciona es llamada por getOpcion)
    public int getInt(){

        int opcion = 0;
        string input = "";
        bool denegado = true;

        do{
            do{

                try{
                    input = Console.ReadLine();
                    opcion = Convert.ToInt32(input);
                    denegado = false;
                }catch(FormatException){
                    Console.WriteLine("Elija una opción");
                }

            }while(denegado);

            if(opcion != 0 && opcion != 1 && opcion != 2){
                Console.WriteLine("Esa opción no existe");
            }

        }while(opcion != 0 && opcion != 1 && opcion != 2);

        return opcion;
    }
    //Genera el menu mediante u for (Esta funcion es llamada en el run)
    public int getOpcion(string[] menu){
        Console.WriteLine("Menú:");
        for (int i = 0; i < menu.Length; i++)
        {
            if(i!= menu.Length - 1){
                Console.WriteLine($"   {i + 1:##}.- {menu[i]}");
            }else
            {
                Console.WriteLine($"   0.- {menu[i]}");
            }
        }
        Console.WriteLine("Elija su opción:");
        return getInt();
    }
}

//controlador va a controlar todos los datos

public class Controlador{
    //Escribimos el menu que se escribira
    String[] menu = new[]{
        "Obtener la media de las notas",
        "Obtener los suspensos",
        "salir"
    };

    private Sistema sistema;
    private Vista vista;

    public Controlador(Sistema sistema, Vista vista){
        this.sistema = sistema;
        this.vista = vista;
    }

    //Al ejecutar el programa
    public void Run(){
        while(true){

            Console.Clear();
            var opcion = vista.getOpcion(menu);

            switch (opcion){
                
                case 1:
                    getMedia();
                    break;
                case 2:
                    getSuspensos();
                    break;
                case 0:
                    return;
            }

            Console.WriteLine("\n\nPulsa Return para continuar");
            Console.ReadLine();
        }
    }
    //Es llamada en el run y llama a la funcion nMedia que esta en sistema y con 2 decimales
    public void getMedia(){
        Console.WriteLine($"La media de la notas es: {sistema.nMedia():0.00}");
    }
    //Es llamada en el run y llama a pencardos que esta en sistema
    public void getSuspensos(){
        Console.WriteLine($"Los suspensos que han habido son: {sistema.pencardos()}");
    }

}

//Se crea la clase persona la cual va a almacenar todos los datos de las personas que hemos delcarado arriba
public class personas{
    string _nombre;
    decimal _nota;
    char _sexo;
    public string nombre{
        get => _nombre;
        set => _nombre = value;
    }
    public decimal nota{
        get => _nota;
        set => _nota = value;
    }
    public char sexo{
        get => _sexo;
        set => _sexo = value;
    }
}

public class Sistema{
    personas[] datos;
    //Pasa las notas y las llama datos
    public Sistema(personas[] datos){
        this.datos = datos;
    }
    //Devuelve la cantidad de las notas que estan suspendidas
    public int pencardos (){
       Func<personas, bool> suspensos = (n) =>{
        return n.nota < 5;
        };

        var pencos = datos.Where(suspensos).ToList();

        return pencos.Count;
    }
    //Calcula la media de las notas introducidas
    public decimal nMedia(){
        Func<personas, decimal> lnotas = (n) =>{
            return n.nota;
        };

        Func<decimal, decimal, decimal> lmedia = (siguiente, resp) =>{
            return siguiente + resp;
        };

        var misNotas = datos.Select(lnotas);
        var res = (misNotas.Aggregate(0M, lmedia)/datos.Length);
        return res;
    }

}
*/
//ejercicio 9----------------------------------------------------------------------------


using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

var repositorio = new RepositorioCSV();
var sistema = new Sistema(repositorio);
var vista = new Vista();
var controlador = new Controlador(sistema, vista);
controlador.Run();
Console.WriteLine("Fin");

//vista va a leer los datos k se metan

public class Vista{

    public int getInt(){

        int opcion = 0;
        string input = "";
        bool denegado = true;

        do{
            do{

                try{
                    input = Console.ReadLine();
                    opcion = Convert.ToInt32(input);
                    denegado = false;
                }catch(FormatException){
                    Console.WriteLine("Elija una opción");
                }

            }while(denegado);

            if(opcion != 0 && opcion != 1 && opcion != 2){
                Console.WriteLine("Esa opción no existe");
            }

        }while(opcion != 0 && opcion != 1 && opcion != 2);

        return opcion;
    }

    public int getOpcion(string[] menu){
        Console.WriteLine("Menú:");
        for (int i = 0; i < menu.Length; i++)
        {
            if(i!= menu.Length - 1){
                Console.WriteLine($"   {i + 1:##}.- {menu[i]}");
            }else
            {
                Console.WriteLine($"   0.- {menu[i]}");
            }
        }
        Console.WriteLine("Elija su opción:");
        return getInt();
    }
}

//controlador va a controlar todos los datos

public class Controlador{
    String[] menu = new[]{
        "Obtener la media de las notas",
        "Obtener los suspensos",
        "salir"
    };

    private Sistema sistema;
    private Vista vista;

    public Controlador(Sistema sistema, Vista vista){
        this.sistema = sistema;
        this.vista = vista;
    }

    public void Run(){
        while(true){

            Console.Clear();
            var opcion = vista.getOpcion(menu);

            switch (opcion){
                
                case 1:
                    getMedia();
                    break;
                case 2:
                    getSuspensos();
                    break;
                case 0:
                    return;
            }

            Console.WriteLine("\n\nPulsa Return para continuar");
            Console.ReadLine();
        }
    }

    public void getMedia(){
        Console.WriteLine($"La media de la notas es: {sistema.nMedia():0.00}");
    }

    public void getSuspensos(){
        Console.WriteLine($"Los suspensos que han habido son: {sistema.pencardos()}");
    }

}

public class personas{
    string _nombre;
    decimal _nota;

    public string nombre{
        get => _nombre;
        set => _nombre = value;
    }
    public decimal nota{
        get => _nota;
        set => _nota = value;
    }

    public override string ToString() => $"({_nombre}, {_nota})";

    internal static personas ParseRow(string row)
    {
        NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;

        //Console.WriteLine(row);
        var columns = row.Split(',');
        return new personas()
        {
            _nombre = columns[0],
            _nota = decimal.Parse(columns[1], nfi)
        };

    }
}

public class Sistema{

    IRepositorio Repositorio;
    personas[] datos;

    public Sistema(IRepositorio repositorio)
    {
        Repositorio = repositorio;
        Repositorio.Inicializar();
        datos = Repositorio.CargarCalificaciones().ToArray(); //llamo a los datos conseguidos, convirtiendols en array y los guardo en datos
    }

    public int pencardos (){
       Func<personas, bool> suspensos = (n) =>{
        return n.nota < 5;
        };

        var pencos = datos.Where(suspensos).ToList();

        return pencos.Count;
    }

    public decimal nMedia(){
        Func<personas, decimal> lnotas = (n) =>{
            return n.nota;
        };

        Func<decimal, decimal, decimal> lmedia = (siguiente, resp) =>{
            return siguiente + resp;
        };

        var misNotas = datos.Select(lnotas);
        var res = (misNotas.Aggregate(0M, lmedia)/datos.Length);
        return res;
    }

}


public interface IRepositorio //interfaz genérica que obliga a tener estos métodos a cualquier input de datos
{
    void Inicializar();
    List<personas> CargarCalificaciones();

}

public class RepositorioCSV : IRepositorio
{
    string datafile;
    void IRepositorio.Inicializar()
    {
        this.datafile = "alumnos.csv";
    }
    List<personas> IRepositorio.CargarCalificaciones()//aqui me devuelve una lista de personas en cuanto al csv que recoja
    {
        return File.ReadAllLines(datafile)
            .Skip(1)
            .Where(row => row.Length > 0)
            .Select(personas.ParseRow).ToList();
    }


}

//10------------------------------------------------------------------------------------
/*
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;


namespace Aplicacion
{
    using Services;
    using Negocio;
    using UI.Console;
    class Program
    {
        static void Main(string[] args)
        {
            var repositorio = new RepositorioCSV();
            var sistema = new Sistema(repositorio);
            var vista = new Vista();
            var controlador = new Controlador(sistema, vista);
            Console.WriteLine("Inicializando aplicación");
            controlador.Run();
            Console.WriteLine("Finalizando aplicación");
        }
    }

    namespace UI.Console
    {
        using System;
        using Negocio.Modelos;

        public class Vista
        {

            public int getInt()
            {

                int opcion = 0;
                string input = "";
                bool denegado = true;

                do
                {
                    do
                    {

                        try
                        {
                            input = Console.ReadLine();
                            opcion = Convert.ToInt32(input);
                            denegado = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Elija una opción");
                        }

                    } while (denegado);

                    if (opcion != 0 && opcion != 1 && opcion != 2)
                    {
                        Console.WriteLine("Esa opción no existe");
                    }

                } while (opcion != 0 && opcion != 1 && opcion != 2);

                return opcion;
            }

            public int getOpcion(string[] menu)
            {
                Console.WriteLine("Menú:");
                for (int i = 0; i < menu.Length; i++)
                {
                    if (i != menu.Length - 1)
                    {
                        Console.WriteLine($"   {i + 1:##}.- {menu[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"   0.- {menu[i]}");
                    }
                }
                Console.WriteLine("Elija su opción:");
                return getInt();
            }
        }
        public class Controlador
        {
            String[] menu = new[]{
        "Obtener la media de las notas",
        "Obtener los suspensos",
        "salir"
    };

            private Sistema sistema;
            private Vista vista;

            public Controlador(Sistema sistema, Vista vista)
            {
                this.sistema = sistema;
                this.vista = vista;
            }

            public void Run()
            {
                while (true)
                {

                    Console.Clear();
                    var opcion = vista.getOpcion(menu);

                    switch (opcion)
                    {

                        case 1:
                            getMedia();
                            break;
                        case 2:
                            getSuspensos();
                            break;
                        case 0:
                            return;
                    }

                    Console.WriteLine("\n\nPulsa Return para continuar");
                    Console.ReadLine();
                }
            }

            public void getMedia()
            {
                Console.WriteLine($"La media de la notas es: {sistema.nMedia():0.00}");
            }

            public void getSuspensos()
            {
                Console.WriteLine($"Los suspensos que han habido son: {sistema.pencardos()}");
            }

        }
    }
    namespace Negocio
    {
        using Negocio.Modelos;
        namespace Modelos
        {
            public class personas
            {
                string _nombre;
                decimal _nota;

                public string nombre
                {
                    get => _nombre;
                    set => _nombre = value;
                }
                public decimal nota
                {
                    get => _nota;
                    set => _nota = value;
                }

                public override string ToString() => $"({_nombre}, {_nota})";

                internal static personas ParseRow(string row)
                {
                    NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

                    //Console.WriteLine(row);
                    var columns = row.Split(',');
                    return new personas()
                    {
                        _nombre = columns[0],
                        _nota = decimal.Parse(columns[1], nfi)
                    };

                }
            }


        }

        public class Sistema
        {

            IRepositorio Repositorio;
            personas[] datos;

            public Sistema(IRepositorio repositorio)
            {
                Repositorio = repositorio;
                Repositorio.Inicializar();
                datos = Repositorio.CargarCalificaciones().ToArray(); //llamo a los datos conseguidos, convirtiendols en array y los guardo en datos
            }

            public int pencardos()
            {
                Func<personas, bool> suspensos = (n) =>
                {
                    return n.nota < 5;
                };

                var pencos = datos.Where(suspensos).ToList();

                return pencos.Count;
            }

            public decimal nMedia()
            {
                Func<personas, decimal> lnotas = (n) =>
                {
                    return n.nota;
                };

                Func<decimal, decimal, decimal> lmedia = (siguiente, resp) =>
                {
                    return siguiente + resp;
                };

                var misNotas = datos.Select(lnotas);
                var res = (misNotas.Aggregate(0M, lmedia) / datos.Length);
                return res;
            }

        }

    }
    namespace Services
    {
        using Negocio.Modelos;

        public interface IRepositorio //interfaz genérica que obliga a tener estos métodos a cualquier input de datos
        {
            void Inicializar();
            List<personas> CargarCalificaciones();

        }

        public class RepositorioCSV : IRepositorio
        {
            string datafile;
            void IRepositorio.Inicializar()
            {
                this.datafile = "alumnos.csv";
            }
            List<personas> IRepositorio.CargarCalificaciones()//aqui me devuelve una lista de personas en cuanto al csv que recoja
            {
                return File.ReadAllLines(datafile)
                    .Skip(1)
                    .Where(row => row.Length > 0)
                    .Select(personas.ParseRow).ToList();
            }


        }
    }
}

*/

//resumen de lo aprendido----------------
