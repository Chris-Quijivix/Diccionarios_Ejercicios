
Console.WriteLine("Ejercicio 9, Diccionarios");
Console.WriteLine();

Dictionary<string,int> nombre = new Dictionary<string,int>();

nombre.Add("Alejandro", 98);
nombre.Add("Carlos", 54);
nombre.Add("Maria", 78);
nombre.Add("Cristina", 99);

Console.Write("Ingrese un nombre: ");
string nuevo;
nuevo = Console.ReadLine();

if (nombre.ContainsKey(nuevo))
{
    Console.WriteLine($"La nota del estudiante {nuevo} es {nombre[nuevo]}");
}
else
{
    Console.WriteLine("El estudiante no esta registrado");
}

Console.ReadKey();