
Console.WriteLine("Ejercicio 5, Diccionarios");
Console.WriteLine();

Dictionary<string,string> usuario = new Dictionary<string,string>();

usuario.Add("Carlos", "car123");
usuario.Add("Juan", "juan4235");
usuario.Add("Maria", "mar5465");

Console.WriteLine("La contraseña del usuario (Juan) es:" + usuario["Juan"]);

Console.ReadKey();