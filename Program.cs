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

//5-----------------------------------------------------












