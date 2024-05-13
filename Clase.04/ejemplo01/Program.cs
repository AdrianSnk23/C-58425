//int sumar(int num1, int num2)
//{
//    return num1 + num2;
//}

//Console.WriteLine("Ingrese los numeros a sumar: ");

//Console.WriteLine("Ingrese el primer numero: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Ingrese el segundo numero: ");
//int num2 = int.Parse(Console.ReadLine());

//int total = sumar(num1, num2);

//Console.WriteLine("El total de la suma es: {0}", total);


using System;



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
            Console.WriteLine("Pedir");
            break;
        case 2:
            Console.WriteLine("Pagar");
            break;
        case 3:
            Console.WriteLine("Salir");
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}

Menu();