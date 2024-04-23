// See https://aka.ms/new-console-template for more information
// Supongamos que debemos hacer un control basico de stock de nuestros productos en un deposito
// Nos brindan la cantidad de productos en depósito y la cantidad de productos vendidos.
//

int CantidadProductosVendidos;
int CantidadProductoDeposito = 50;
int stock;

Console.WriteLine("Ingrese la cantidad de productos vendidos: ");

CantidadProductosVendidos = Convert.ToInt32(Console.ReadLine());

stock = CantidadProductoDeposito - CantidadProductosVendidos;

if (stock == 0)
{
    Console.WriteLine("Reponer stock de productos.");
    CantidadProductoDeposito += 10;
    Console.WriteLine("Productos cargados al deposito.");
}
else
{
    if (stock <= 5)
    {
        Console.WriteLine("Stock minimo, reponer productos.");
        CantidadProductoDeposito += 5;
        Console.WriteLine("productos cargados al deposito");
        Console.WriteLine("Informar a ventas {0} productos sin vender", stock);
    }
    else
    {
        Console.WriteLine("informar a ventas {0} productos sin vender",stock);
    }
}