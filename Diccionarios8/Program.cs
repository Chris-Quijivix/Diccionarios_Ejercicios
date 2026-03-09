
Console.WriteLine("Ejercicio 8, Diccionarios");
Console.WriteLine();

Dictionary<int,string> empleado = new Dictionary<int,string>();

empleado.Add(1, "Carlos");
empleado.Add(2, "Juan");
empleado.Add(3, "Maria");
empleado.Add(4, "Pedro");

empleado[2] = "Mateo";

Console.WriteLine("Lista de empleados actualizada:");
Console.WriteLine();

foreach (var item in empleado)
{
    Console.WriteLine($"Codigo: {item.Key}, Nombre nuevo: {item.Value}");
}

Console.ReadKey();