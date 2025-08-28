// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var cliente1 = new Clientes();
cliente1.Id = 1;
cliente1.Nombre = "Darlink";
cliente1.Altura = 1.52m;
cliente1.FechaNacimiento = DateTime.Now;
cliente1.Compras = new List<Compras>();
cliente1.Compras.Add(new Compras() { Id = 103, CantidadProductos = 1 });
cliente1.Compras.Add(new Compras() { Id = 102, CantidadProductos = 1 });

foreach (var elemento in cliente1.Compras)
{
    Console.WriteLine(elemento.Id);
}

public class Productos
{
    public int Id;
    public string? Nombre;
    public decimal Precio;
    public bool Existencia;

}

public class Limpiapisos : Productos
{
    public string? Aroma;
    public string? Marca;

}

public class Compras
{
    public int Id;
    public int CantidadProductos;
    public Productos? Producto;

}

public class Clientes
{
    public int Id;
    public string? Nombre;
    public decimal Altura;
    public DateTime FechaNacimiento;
    public List<Compras>? Compras;

}
