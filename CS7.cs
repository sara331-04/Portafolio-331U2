using System;

namespace CS7
{
    class Program
    {
        static void Main(string[] args)
        {
            // bloque de funcion
            // sesion 15: funciones
            /*
            funcion: bloque de instrucciones para realizar una tarea especifica, que ejecuta cuando es invocado
            sintaxis: definicion de funcion tipo de dato_devuelto 
            identificador_funcion(parametros)
            {
            bloque de instrucciones}
            }
            nota1; los parametros se definen incluyendo tipo de datos
            nota 2: los parametros van separados por coma
            sintaxis: invocando de funcion
            identificador_funcion(argumentos);
            argumento: valor del parametro
            */
            // ejemplo 1: funcion vacia y sin parametros
            void Saludar()
            {
                string salon = "331";
                Console.WriteLine($"hola, {salon}");
            }
            // invoacion
            Saludar();
            // ejercitacion
            //1. definir e invocar una funcion para imprimir: nombre, clave y salon
            void ejercitacion()
            {
                string nombre = "Sara Campos Nuñez";
                string clave = "331-04";
                string salon = "331";
                Console.WriteLine($"nombre: {nombre}");
                Console.WriteLine($"clave: {clave}");
                Console.WriteLine($"salon: {salon}");
            }
            // invocacion
            ejercitacion();
            // 2. definir e invocar una funcion sin parametros para desplegar el horario de hoy
            void horario()
            {
                string primera = "7:00: calculo";
                string segunda = "7:50: formacion humana";
                string tercera = "8:40: programacion";
                string cuarta = "9:50: psicologia";
                string quinta = "10:40: idiomas";
                string sexta = "11:50: dibujo tecnico";
                string septima = "12:40: dibujo tecnico";
                Console.WriteLine($"primera: {primera}");
                Console.WriteLine($"segunda: {segunda}");
                Console.WriteLine($"tercera: {tercera}");   
                Console.WriteLine($"cuarta: {cuarta}");
                Console.WriteLine($"quinta: {quinta}"); 
                Console.WriteLine($"sexta: {sexta}");
                Console.WriteLine($"septima: {septima}");
            }
            // sesion 16: funcion con parametros
            // return: palabra reservada para terminar una funcion y devolver una expresion
            // ejemplos 1: doble
            // definicion
            int CalcularDoble(int numero)
            {
                int resultado = 2 * numero;
                return resultado;
            }
            // invocacion
            int devolucion;
            devolucion = CalcularDoble(3);
            Console.WriteLine($"Devolucion: {devolucion}");
            // ejercitacion
            // 1. definir e invocar una funcion que devuelva la evolucion de la siguiente expresion: 
            // f(x) = 4x - 7/5
            double f(double x)
            {
                double y = 4 * x - 7 / 5D;
                return y;
            }
            double d;
            d = f(0);
            Console.WriteLine($"f(0): {d}");

        }
    }
}
