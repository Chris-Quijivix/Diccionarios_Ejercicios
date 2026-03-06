Console.WriteLine("Cree un diccionario donde la clave sea el código de producto (int) y el valor el nombre del producto. Agregue 3 productos e imprímalos");
Console.WriteLine();

Dictionary<int,string> codigo = new Dictionary<int,string>();

codigo.Add(123, "Arroz");
codigo.Add(234, "Aceite");
codigo.Add(345, "Arina");

foreach (var item in codigo)
{
    Console.WriteLine($"El codigo del producto es:{item.Key} y el producto es:{item.Value}");
}

Console.ReadKey();