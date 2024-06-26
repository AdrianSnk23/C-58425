﻿int precioCodigo(string codigo)
{
    int precio = 0;
    switch (codigo)
    {
        case "DES":
            precio = 200;
            break;
        case "JP":
            precio = 300;
            break;
        case "DET":
            precio = 250;
            break;
        default:
            precio = 0;
            break;
    }
    return precio;
}

void Menu()
{
    int opcion = 0;
    bool esNumero;

    while (opcion < 1 || opcion > 3)
    {
        Console.WriteLine("Elija la opción que desea: \n 1.Pedir \n 2.Pagar \n 3.Salir \n");

        string input = Console.ReadLine();
        esNumero = int.TryParse(input, out opcion);

        if (!esNumero || opcion < 1 || opcion > 3)
        {
            Console.WriteLine("Opción inválida. Intente de nuevo.");
        }
    }

    switch (opcion)
    {
        case 1:
            pedir();
            break;
        case 2:
            Console.WriteLine("Pagar");
            break;
        case 3:
            Console.WriteLine("Salir");
            break;
    }
}

void pedir()
{
    string codigo = "";
    int cantProductos;
    int montoAPagar = 0;
    Console.WriteLine("Codigo     Descripcion     Precio\r\n   DES     Desodorante     200\r\n    JP     Jabon en Polvo  300\r\n   DET     Detergente      250");

    while (codigo != "FIN")
    {
        Console.WriteLine("Ingrese el codigo que desea comprar");
        codigo = Console.ReadLine().ToUpper();
        if (codigo == "FIN")
        {
            break;
        }
        int precio = precioCodigo(codigo);
        Console.WriteLine("Ingrese la cantidad que desea comprar:");
        cantProductos = int.Parse(Console.ReadLine());

        montoAPagar += cantProductos * precio;
    }
    Console.WriteLine("Su monto a pagar es {0}", montoAPagar);
}

void programaVenta()
{
    
    string confirmacion = "-";
    Console.WriteLine("Bienvenido, a la tienda digital");
    Menu();
    pedir();
    Console.WriteLine("Desea realizar la compra? S/N");
    confirmacion = Console.ReadLine().ToUpper();
    if (confirmacion == "S")
    {
        Console.WriteLine("Gracias por la compra");
    }
    else
    {
    }
}

programaVenta();