
Console.WriteLine("Ejercicio 16, Diccionarios");
Console.WriteLine();

Dictionary<int,string> estudiante = new Dictionary<int,string>();

int opcion;

do
{
    Console.WriteLine("1. Agregar estudiante");
    Console.WriteLine("2. Mostrar estudiantes");
    Console.WriteLine("0. Salir");
    Console.WriteLine("Seleccione una opcion");
    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
        {
                Console.WriteLine("Agregar nuevo estudiante");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Ingrese clave del estudiante:");
                int clave;
                clave = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Ingrese el nombre del estudiante:");
                string nombre;
                nombre = Console.ReadLine();
                Console.WriteLine();

                estudiante.Add(clave,nombre);
                Console.WriteLine("Estudiante registrado");
                Console.WriteLine();
                Console.WriteLine();
        }
        break;

        case 2:
        {
                Console.WriteLine("Listado de estudiantes");
                Console.WriteLine();
                Console.WriteLine();

                foreach (var item  in estudiante)
                {
                    Console.WriteLine($"Clave: {item.Key} - Nombre: {item.Value}");
                }
                Console.WriteLine();
                Console.WriteLine();

        }
        break;

        case 0:
        {
                Console.WriteLine("Saliendo del programa...");
        }
        break;

        default:
        {
        Console.WriteLine("Opcion seleccionada no valida");
        }
        break;



    }



} while (opcion != 0);


Console.ReadKey();