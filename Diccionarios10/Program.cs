
Console.WriteLine("Ejercicio 10, Diccionarios");
Console.WriteLine();

Dictionary<int,string> inventario = new Dictionary<int,string>();

inventario.Add(1, "Monitor");
inventario.Add(2, "CPU");
inventario.Add(3, "Teclado");

Console.Write("Ingrese codigo de producto a eliminar: ");
int codigo;
codigo = int.Parse(Console.ReadLine());
Console.WriteLine();

if (inventario.ContainsKey(codigo))
{
    inventario.Remove(codigo);
    Console.WriteLine("El producto se a eliminado");
}
else
{
    Console.WriteLine("El producto no esta registrado");
}

Console.ReadKey();