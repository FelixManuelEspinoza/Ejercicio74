using System.Collections;
namespace Ejercicio74
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            Stack colaPalabras = new Stack();
            palabra = Console.ReadLine();
            while (palabra != "")
            {
                colaPalabras.Push(palabra);
                Console.WriteLine("Ingrese la siguiente palabra");
                palabra = Console.ReadLine();
            }
            while (colaPalabras.Count > 0)
            {
                Console.WriteLine((string)colaPalabras.Pop());
            }
            Console.ReadKey();
        }
    }
}