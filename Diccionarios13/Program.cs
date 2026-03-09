
Console.WriteLine("Ejercicio 13, Diccionarios");
Console.WriteLine();

Dictionary<string,double> nota = new Dictionary<string,double>();

nota.Add("Juan", 85);
nota.Add("Isaac", 52);
nota.Add("Mateo", 75);
nota.Add("Pedro", 92);
nota.Add("Alejandro", 61);

double suma  = 0;

Console.WriteLine("Lista de estudiantes y notas:");

foreach (var item in nota)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.WriteLine();

foreach (var item in nota)
{
    suma += item.Value;
}

double promedio;
promedio = suma / nota.Count;

Console.WriteLine($"El promedio de las notas es de: {promedio}");

Console.ReadKey();