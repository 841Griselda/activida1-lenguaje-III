using System;

namespace EXPEDIENTE_ALUMNO 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenidos a UMI/Universidad Coppel");
            Console.WriteLine();

            Console.WriteLine("Ingresa los datos que se te piden:");
            Console.WriteLine();

            Console.Write("Nombre completo: ");
            string nombre = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Edad: ");
            string edad = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Fecha de nacimiento (DD/MM/AAAA): ");
            string fechaNacimiento = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Carrera a la que desea ingresar: ");
            string carrera = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("DATOS CAPTURADOS:");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Fecha de nacimiento: " + fechaNacimiento);
            Console.WriteLine("Carrera: " + carrera);
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
