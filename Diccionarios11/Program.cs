
Console.WriteLine("Ejercicio 11, Diccionarios");
Console.WriteLine();

Dictionary<int,string> estudiante = new Dictionary<int,string>();

Console.WriteLine("Listado de estudiantes:");
Console.WriteLine();

estudiante.Add(1, "Carlos");
estudiante.Add(2, "Juan");
estudiante.Add(3, "Cristina");
estudiante.Add(4, "Mateo");
estudiante.Add(5, "Rodrigo");

foreach (var item in estudiante)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.ReadKey();