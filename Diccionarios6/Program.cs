
Console.WriteLine("Ejercicio 6, Diccionarios");
Console.WriteLine();

Dictionary<int,string> estudiantes = new Dictionary<int,string>();

estudiantes.Add(1, "Carlos");
estudiantes.Add(2, "Juan");
estudiantes.Add(3, "Maria");

estudiantes.Remove(2);

foreach (var item in estudiantes)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.ReadKey();