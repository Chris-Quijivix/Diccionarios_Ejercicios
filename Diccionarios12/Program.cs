
Console.WriteLine("Ejercicio 12, Diccionarios");
Console.WriteLine();

Dictionary<int,string> producto = new Dictionary<int,string>();

Console.WriteLine("Productos:");
Console.WriteLine();

producto.Add(1, "Monitor");
producto.Add(2, "CPU");
producto.Add(3, "Teclado");
producto.Add(4, "Mouse");
producto.Add(5, "SSD - 1TB");
producto.Add(6, "USB - 32GB");
producto.Add(7, "Adaptador Ethernet");
producto.Add(8, "HUB - 7 Puertos");
producto.Add(9, "Audifonos de diadema");

foreach (var item in producto)
{
    Console.WriteLine($"Codigo: {item.Key} - Producto: {item.Value}");
}

Console.ReadKey();