
Console.WriteLine("Ejercicio 14, Diccionarios");
Console.WriteLine();

Dictionary<int,string> ciudad = new Dictionary<int,string>();

ciudad.Add(1, "Quetzaltenango");
ciudad.Add(2, "Guatemala");
ciudad.Add(3, "Antigua Guatemala");
ciudad.Add(4, "Chimaltenango");
ciudad.Add(5, "Escuintla");

Console.WriteLine("Codigos de ciudades:");

foreach (var item  in ciudad)
{
    Console.WriteLine($"Codigo de ciudad: {item.Key}");
}

Console.WriteLine();

Console.WriteLine("Ciudades:");

foreach (var item in ciudad)
{
    Console.WriteLine($"Ciudad: {item.Value}");
}

Console.ReadKey();