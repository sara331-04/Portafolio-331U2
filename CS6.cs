using System;
namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {
            double Diana = 0;
            int Numero_de_hidratacion = 0;
            int zancadas = 0;
            int recorrido_hidratacion = 2000;
            while (Diana < 21000)
            {
                zancadas += 1;
                Diana += 0.63;
                Console.WriteLine($"metros que lleva recorridos Diana: {Diana}");
                Console.WriteLine($"numero de zancadas: {zancadas}");
                if (Diana >= recorrido_hidratacion)
                {
                    Numero_de_hidratacion += 1;
                    recorrido_hidratacion += 2000;
                    Console.WriteLine($"recorrido: {recorrido_hidratacion}");
                }
                for (int x = 33; x >= 39; x--)
                {
                    Console.WriteLine($"valor de x: {x*-1}");
                }
                Console.WriteLine("ciclo 2: ascendente");
                for (int a = 9; a <= 15; a += 1)
                {
                    if (a == 13)
                    {
                        a += 1;
                    }
                    Console.WriteLine($"a: {a}");
                }
                int titulo = 1;
                int Numero_de_Titulo = 0;
                 for (int pagina = 1; pagina <= 539; pagina ++)
                {
                    if (pagina == titulo)
                    {
                        Numero_de_Titulo += 1;
                        titulo += 88;
                        Console.WriteLine($"numero de titulo: {Numero_de_Titulo}");
                    }
                }
                }
            }
        }
    }