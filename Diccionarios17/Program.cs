
Console.WriteLine("Ejercicio 17, Diccionarios");
Console.WriteLine();

Dictionary<int,string> productos = new Dictionary<int,string>();

int opcion;

do
{
    Console.WriteLine("INVENTARIO DE PRODUCTOS");
    Console.WriteLine();
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Eliminar producto");
    Console.WriteLine("3. Mostrar productos");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opcion:");
    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
            {
                Console.WriteLine("Agregar producto");
                Console.WriteLine();

                Console.Write("Ingrese codigo de producto:");
                int codigo;
                codigo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese nombre del producto:");
                string producto;
                producto = Console.ReadLine();
                Console.WriteLine();

                productos.Add(codigo, producto);
                Console.WriteLine("Producto registrado");
                Console.WriteLine();
            }
        break;

        case 2:
            {
                Console.WriteLine("Eliminar producto");
                Console.WriteLine();

                Console.Write("Ingrese codigo de producto a eliminar:");
                int eliminar;
                eliminar = int.Parse(Console.ReadLine());

                if (productos.ContainsKey(eliminar))
                {
                    productos.Remove(eliminar);
                    Console.WriteLine("El producto se a eliminado");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Producto no registrado");
                    Console.WriteLine();
                }

            }
        break;

        case 3:
            {
                Console.WriteLine("Productos Registrados");
                Console.WriteLine();

                foreach (var item in productos)
                {
                    Console.WriteLine($"Codigo: {item.Key} - Producto: {item.Value}");
                }
                Console.WriteLine();

            }
        break;

        case 0:
            {
                Console.WriteLine();
                Console.WriteLine("Saliedno del programa...");
                Console.WriteLine();
            }
        break;

        default:
            {
                Console.WriteLine();
                Console.WriteLine("Opcion seleccionada no valida");
                Console.WriteLine();
            }
        break;
   
    }

}while(opcion != 0);

Console.ReadKey();
