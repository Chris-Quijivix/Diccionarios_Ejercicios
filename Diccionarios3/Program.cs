Console.WriteLine("Ejercicio 3, Diccionarios");

Dictionary<string,double> nombre = new Dictionary<string,double>();

nombre.Add("Juan", 56.2);
nombre.Add("Pedro", 89.3);
nombre.Add("Carlos", 20);
nombre.Add("Maria", 95);

Console.WriteLine("La nota del estudiante Carlos es:" + nombre["Carlos"]);

Console.ReadKey();


