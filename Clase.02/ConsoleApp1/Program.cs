// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//SWITCH

string categoria;

Console.WriteLine("Ingrese la categoria A, B o C");

categoria = Console.ReadLine();

switch (categoria)
{
    case "A":
        Console.WriteLine("Empleado Administrativo");
        break;
    case "B":
        Console.WriteLine("Empleado Profesional");
        break;
    case "C":
        Console.WriteLine("Maestranza");
        break;
    default:
        Console.WriteLine("Sin Categoria");
        break;
}

//Escuela

string comision;
int calificacion;

Console.WriteLine("Bienvenidos a CODERHOUSE");
Console.WriteLine("Ingrese su comision");
comision = Console.ReadLine();

switch (comision)
{
    case "A":
        Console.WriteLine("Turno Mañana");
        break;
    case "B":
        Console.WriteLine("Turno Tarde");
        break; 
    case "C":
        Console.WriteLine("Turno Noche");
        break;
    default:
        Console.WriteLine("Sin turno fijo");
        break;
}

Console.WriteLine("Ingrese la nota del alumno");

calificacion = Convert.ToInt32(Console.ReadLine());

if(calificacion >= 0 && calificacion < 4)
{
    Console.WriteLine("Recursa");
}
else if (calificacion >= 4 && calificacion <= 7)
{
    Console.WriteLine("Aprobo la cursada");
}
else if (calificacion > 7 && calificacion <= 10)
{
    Console.WriteLine("Promocionó la materia");
}
else
{
    Console.WriteLine("Calificar solo del 0 al 10");
}