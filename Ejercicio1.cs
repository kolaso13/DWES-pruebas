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


