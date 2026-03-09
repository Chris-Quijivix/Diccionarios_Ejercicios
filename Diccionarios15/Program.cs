
Console.WriteLine("Ejercicio 15, Diccionarios");
Console.WriteLine();

Dictionary<int,string> empleado = new Dictionary<int,string>();

empleado.Add(1, "Juan");
empleado.Add(2, "Mateo");
empleado.Add(3, "Isaac");

Console.WriteLine("Listado de empleados:");
Console.WriteLine();

foreach (var item in empleado)
{
    Console.WriteLine($"ID: {item.Key} - Nombre: {item.Value}");
}

Console.ReadKey();