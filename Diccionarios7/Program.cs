
Console.WriteLine("Ejercicio 7, Diccionarios");
Console.WriteLine();

Dictionary<int,string> producto = new Dictionary<int,string>();

producto.Add(1, "Monitor");
producto.Add(2, "CPU");
producto.Add(3, "Teclado");

Console.Write("Ingrese codigo de producto:");
int codigo;
codigo = int.Parse(Console.ReadLine());
Console.WriteLine();

if (producto.ContainsKey(codigo))
{
    Console.WriteLine("El codigo de producto ya esta en uso, el producto es: " + producto[codigo]);
}
else
{
    Console.Write("Ingrese el nombre del nuevo producto:");
    string nuevo = Console.ReadLine();
    Console.WriteLine();

    producto.Add(codigo, nuevo);
    Console.WriteLine("Producto agregado");
}

Console.ReadKey();