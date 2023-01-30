using System;

namespace Modulo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, email, carrera = "";
            int edad = 0;

            while (true)
            {

                Console.Write("Nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Apellido: ");
                apellido = Console.ReadLine();

                Console.Write("Edad: ");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Correo electronico: ");
                email = Console.ReadLine();

                Console.WriteLine($"DATOS: \n Nombre    :   {nombre} \n Apellido  :   {apellido} \n Edad      :   {edad} \n Email     :   {email}");
                Console.WriteLine("\n\n ¿Los datos son correctos? \n En caso de ser correctos ingresar S\n En caso de ser erroneos ingresar N");

                Console.Write("Afiramar: S || Rehacer: N: ");
                string afirmacion = Console.ReadLine();

                if (afirmacion == "S" || afirmacion == "s")
                {
                    break;
                }
                Console.Clear();
            }
            Console.Clear();

            
            while (true)
            {

                Console.WriteLine("<<< Selecciona el código de la carrera elegida >>>");
                Console.WriteLine("1. Programación .NET \n2. Programación Java \n3. Programación .PHP");

                Console.Write("\n\nCodigo de carrera: ");
                int codigoCarrera = Convert.ToInt32(Console.ReadLine());
                        

                Console.Clear() ;
                switch (codigoCarrera)
                {
                    case 1:
                        carrera = "Programación .NET";
                        break;
                    case 2:
                        carrera = "Programación Java";
                        break;
                    case 3:
                        carrera = "Programación PHP";
                        break;
                    default:
                        Console.WriteLine("Carrera inexistente\nDatos incorrectos, elija nuevamente: ");
                        continue;
                }
                break;
            }
            Console.WriteLine($"<<<Constancia de inscripción>>>\n\nAlumno: {nombre} {apellido}\nCorreo electronico: {email}\nCarrera: {carrera}");


            Console.ReadKey();
        }
    }
}
