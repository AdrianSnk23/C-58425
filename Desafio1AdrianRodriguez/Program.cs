// See https://aka.ms/new-console-template for more information

//Actividad n°1
string nombre = "Adrian";
string apellido = "Rodriguez";
int dni = 11223344;
short edad = 39; //se cambió el int por short debido a que ocupa menos espacio
float altura = 1.79F; //se cambia el double por el float por el mismo motivo que short y cuando es float se asigna la letra F para que lo tome como float

Console.WriteLine("Actividad n°1");
Console.WriteLine(nombre);
Console.WriteLine(apellido);
Console.WriteLine(dni);
Console.WriteLine(edad);
Console.WriteLine(altura);

//Actividad n°2
Console.WriteLine("Actividad n°2");
int num1;
int num2;

Console.WriteLine("Ingrese el primer numero a sumar");
num1 =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero a sumar");
num2 = Convert.ToInt32(Console.ReadLine());

int total = num1 + num2;
Console.WriteLine("El total de la suma es: " + total);

//Actividad n°3
Console.WriteLine("Actividad n°3");
//primer manera de concatenar
Console.WriteLine("concatenar en la consola");
Console.WriteLine("Mi nombre es {0} {1} {2}.", nombre, "Manija", apellido); 
//segunda manera: concatenar en una variable
Console.WriteLine("concatenar en una variable");
string mensaje = $"Mi nombre es {nombre} \"Manija\" {apellido}";
Console.WriteLine(mensaje);

Console.ReadKey();
