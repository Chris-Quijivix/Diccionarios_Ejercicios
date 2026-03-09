
Console.WriteLine("Ejercicio 4, Diccionarios");
Console.WriteLine();

Dictionary<int,string> ciudad = new Dictionary<int,string>();

ciudad.Add(1,"Quetzaltenango");
ciudad.Add(2,"Guatemala");
ciudad.Add(3,"Antigua Guatemala");
ciudad.Add(4,"Chimaltenango");
ciudad.Add(5,"Escuintla");

Console.WriteLine("La ciudad con el codigo (1) es:" + ciudad[3]);

Console.ReadKey();