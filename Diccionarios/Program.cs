
Console.WriteLine("Cree un diccionario que almacene ID (int) y nombre (string) de 3 estudiantes. Luego muestre el nombre de uno específico usando su ID");
Console.WriteLine();

Dictionary<int,string> nombre = new Dictionary<int,string>();

nombre.Add(1, "Juan");
nombre.Add(2, "Pedro");
nombre.Add(3, "Carlos");
nombre.Add(4, "Maria");

int buscar  = 1;
Console.WriteLine("El estudiante con el ID (1) es:" + nombre[buscar]);

Console.ReadKey();