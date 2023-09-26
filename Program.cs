using System;
using System.Net;
using System.Text;
using System.Web;

namespace tarea1
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool Continuar = true;
            while (Continuar == true) {
                consolle.WriteLine("Biemvenido al menu multiprograma seleccione la accion que desea")
                consolle.WriteLine(@"
                1- Pares e Impares
                2- Tabla de multiplicar
                3- Factorial de un número
                4- Números Primos
                5- Sucesión de Fibonacci
                6- Salir
                ")
                var ops= Herramientas.input_int("Digite su elccion con los numeros del 1 al6: ");
                switch (ops)
                {
                    case 1:
                    Ejercicios.Pares();
                    break;
                    case 2:
                    Ejercicios.Tablas();
                    break;
                    case 3:
                    Ejercicios.Factorial();
                    break;
                    case 4:
                    Ejercicios.Primos();
                    break;
                    case 5:
                    Ejercicios.Fibonacci();
                    break;
                    default:
                    Console.WriteLine("Digite una opcion valida!!_____");
                    Console.Readkye();
                }
            }
        }
    }
}
class Herramientas
{
    public static int input_int (string msg){
        int resul;
        Console.Write(msg);
        var conclusion= int32.TryParse(consolle.WriteLine(), out resul);
        if (conclusion == false){
            consolle.WriteLine("Digite un enero valido: ");
            resul= input_int(msg);
        }
        return resul;
    }
}
class Ejercicios
{
    public static void pares()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Por Favor Ingrese un número: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                Console.WriteLine("los numero pares son: ");
                for (int i = 0; i <= numero; i++)
                {
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine("los numeros impares son: ");
                for (int i = 0; i <= numero; i++)
                {
                    if (i % 2 != 0)
                        Console.Write(i + " ");
                }
                Console.WriteLine();

                int suma_par = Enumerable.Range(0, numero + 1).Where(x => x % 2 == 0).Sum();
                int suma_Impar = Enumerable.Range(0, numero + 1).Where(x => x % 2 != 0).Sum();
                Console.WriteLine($"Suma de los numeros pares es: {suma_par}");
                Console.WriteLine($"Suma de los numeros impares es: {suma_Impar}");
                Console.WriteLine(suma_par > suma_Impar ? "el resultado de la suma de pares es mayor." : "el resultado de la suma de impares es mayor.");
            }
            else
            {
                Console.WriteLine("caracter incorrecto, favor ingresar otro.");
            }

            Console.Write("¿Desea ingreasar otro numero para realizar otra operacion? (si/no): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "si");
        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
}
