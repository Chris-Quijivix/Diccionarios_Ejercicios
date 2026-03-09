
Console.WriteLine("Ejercicio 19, Diccionarios");
Console.WriteLine();

Dictionary<string,double> nota = new Dictionary<string,double>();


Console.Write("Ingrese el nombre del estudiante:");
string nombre;
nombre = Console.ReadLine();
Console.WriteLine();

Console.Write("Ingrese nota:");
double notas;
notas = double.Parse(Console.ReadLine());

nota.Add(nombre,notas);
Console.WriteLine();
Console.WriteLine();

Console.Write("Nombre del estudiante a modificar nota:");
string nueva;
nueva = Console.ReadLine();

if (nota.ContainsKey(nueva))
{
    Console.Write("Nueva nota:");
    double cambio;
    cambio = double.Parse(Console.ReadLine());

    nota[nueva] = cambio;
}

foreach (var item in nota)
{
    Console.WriteLine($"Nombre: {item.Key} - Nota: {item.Value}");
}

Console.ReadKey();


