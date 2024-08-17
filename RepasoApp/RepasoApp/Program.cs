//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using RepasoApp;

//object p = new Pack();

//object s = new Suelto();

//object[] productos = { p, s };

using RepasoApp;

var pack = new Pack();
pack.Precio = 100;
pack.Cantidad = 2;

var suelto = new Suelto();
suelto.Precio = 500;
suelto.Medida = 4;

Producto[] productos = {pack, suelto};

foreach (Producto p in productos)
{
    Console.WriteLine(p.CalcularPrecio());
}