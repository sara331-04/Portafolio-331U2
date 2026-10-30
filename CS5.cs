using System;
namespace CS5;

class Program
{
    public Program()
    {
    }

    static void Main(string[] args)
    {
        // unidad 1: estructura de control 11
        // unidad 2: funciones II
        // sesion 12: instruccion while 30092026
        // sintaxis: while
        // inicializacion;
        // while(expresion)
        // {
        //     bloque de instrucciones
        //     iterador;
        // }
        // iterar; repetir
        // ejemplo 1: ciclo ascendente (rango: 1-3)
        int m = 1; // inicializacion
        while(m <= 3)
        {
            // bloque de instrucciones
            Console.WriteLine($" m: {m}");
            m += 1;

        }
        // ejercitacion
        // 1. definir un ciclo para imprimir tu nombre 5 veces
        // nota: para la expresion utilizar el operador <
        // ciclo ascendente
        int n = 0;
        while(n < 5)
        {
            Console.WriteLine(" tu nombre: sara");
            if (n == 0)
            {
                n = 10;
            }
            n += 1;        
        }
        // b. ciclo descendente
        int d = 3;
        while(d >= 1)
        {
            Console.WriteLine($"d: {d}");
            d -= 1;
        }
        // c. incrementos
        // secuencia: 3 6 12 15 18
        int i = 3;
        while(i <= 18)
        {
            Console.WriteLine($"i: {i}");
            i += 3;
        }
        // d. decrementos
        // ejercitacion
        // 1. definir un ciclo para imprimir "331" 8 veces
        // nota: para la solucion, definir un ciclo descendente con decrementos de 2 unidades
        
        int a = 16;
        while (a >= 1)
        {
            Console.WriteLine("331");
            a -= 2;
        }
    
        // actividad 1: ciclo infinito
        // 1. definir un ciclo infinito ascendente 
        // 2. definir un ciclo infinito descendente
        // nota: para la solucion, utilizar el operador de diferencia
        int c1 = 1;
        while (c1 > 0)
        {
            Console.WriteLine(c1);
            c1++;
        }
        
        int d2 = 79;
        while (d2 != 80)
        {
            Console.WriteLine(d2);
            d2--;
        }
        
    }
}