
Console.WriteLine("Ejercicio 20, Diccionarios");
Console.WriteLine();

Dictionary<int, (string nombre, int edad, string carrera)> estudiante = new Dictionary<int, (string Nombre, int Edad, string Carrera)>();

estudiante.Add(1, ("Juan", 18, "Ingenieria"));
estudiante.Add(2, ("Mateo", 24, "Derecho"));
estudiante.Add(3, ("Maria", 21, "Medicina"));

foreach (var item  in estudiante)
{
    Console.WriteLine($"Codigo: {item.Key}");
    Console.WriteLine($"Nombre: {item.Value.nombre}");
    Console.WriteLine($"Edad: {item.Value.edad}");
    Console.WriteLine($"Carrera: {item.Value.carrera}");
    Console.WriteLine();
}

Console.ReadKey();