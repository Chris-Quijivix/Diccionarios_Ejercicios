
Console.WriteLine("Ejercicio 18, Diccionarios");
Console.WriteLine();

Dictionary<string,int> usuario = new Dictionary<string,int>();

usuario.Add("Juan",1);

Console.Write("Ingrese un usuario:");
string usuario1;
usuario1 = Console.ReadLine();

if (usuario.ContainsKey(usuario1))
{
    Console.WriteLine("El usuario ya esta registrado");
    Console.WriteLine();
}
else
{
    Console.Write("Ingrese una clave:");
    int clave;
    clave = int.Parse(Console.ReadLine());

    usuario.Add(usuario1,clave);
    Console.WriteLine("El usuario a sido registrado");
    Console.WriteLine();
}

Console.ReadKey();
