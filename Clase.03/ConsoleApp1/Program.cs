// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int CantidadDeNotas = 0;
double promedioNotas  = 0;
double nota;
double sumaNotas = 0;

Console.WriteLine("Ingrese la cantidad de notas a calcular: ");
CantidadDeNotas = int.Parse(Console.ReadLine());

for(int i = 1; i <= CantidadDeNotas; i++)
{
    Console.WriteLine("Ingrese la nota: ");
    nota = double.Parse(Console.ReadLine());
    sumaNotas = sumaNotas + nota;
}

promedioNotas = sumaNotas / CantidadDeNotas;

Console.WriteLine("El promedio de los alumnos cargados es: {0}", promedioNotas);