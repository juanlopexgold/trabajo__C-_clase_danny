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
    public static void Tabla()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Por Favor Ingrese un número: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{numero}x{i} = {numero * i}");
                }
            }
            else
            {
                Console.WriteLine("caracter incorrecto, favor ingresar otro.");
            }

            Console.Write("¿Desea ingreasar otro numero para realizar otra operacion? (si/no): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "si");
        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
    //Funcion Factorial
    public static void Factorial()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese un número entero positivo: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                int factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"El factorial de {numero} es {factorial}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
            }

            Console.Write("¿Desea calcular otro factorial? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");

        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
    static double FactorialDe(double numero)
    {
        if (numero == 0)
            return 1;
        double factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    //Funcion Primos
    public static void Primos()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese un número entero positivo: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                Console.WriteLine("Números primos en orden inverso: ");
                for (int i = numero; i >= 2; i--)
                {
                    if (EsPrimo(i))
                        Console.Write(i + " ");
                }
                Console.WriteLine();

                var numerosPrimos = Enumerable.Range(2, numero - 1).Where(EsPrimo);
                double media = numerosPrimos.Average();
                double factorialMedia = FactorialDe(media);
                Console.WriteLine($"Media de los números primos: {media}");
                Console.WriteLine($"Factorial de la media {media} es: {factorialMedia}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
            }

            Console.Write("¿Desea realizar otra operación en Números Primos? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");

        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        if (numero <= 3)
            return true;
        if (numero % 2 == 0 || numero % 3 == 0)
            return false;
        for (int i = 5; i * i <= numero; i += 6)
        {
            if (numero % i == 0 || numero % (i + 2) == 0)
                return false;
        }
        return true;
    }
}
