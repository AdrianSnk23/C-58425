// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string cadenaNula = null;
string cadenaVacia = string.Empty;
string cadenaSaludo = "Hola, soy una cadena...";

Console.WriteLine(cadenaSaludo + cadenaNula + cadenaVacia);

if(cadenaNula == cadenaVacia)
{
    Console.WriteLine("Las cadenas son iguales");
}
else
{
    Console.WriteLine("Las cadenas no son iguales!");
}

//Console.WriteLine(cadenaNula.Length);
Console.WriteLine(cadenaVacia.Length);
Console.WriteLine(cadenaSaludo.Length);

string mensaje = "Voy a desarrollar en C#";

Console.WriteLine("Mensaje en minuscula: " + mensaje.ToLower());
Console.WriteLine("Mensaje en minuscula: " + mensaje.ToUpper());

int numeroEntero = 23;
double numeroConDecimales = 1.88;
bool booleano = true;

Console.WriteLine("La edad de Luis es: " + numeroEntero.ToString() + " " + numeroConDecimales.ToString() + " " + booleano.ToString());

string cadena1 = "Soy una cadena ";
string cadena2 = "Soy una cadena";

if (cadena1.Equals(cadena2))
{
    Console.WriteLine("La cadena uno ES IGUAL a la cadena 2");
}
else
{
    Console.WriteLine("La cadena uno NO ES IGUAL a la cadena 2");
}

if (cadena1.Contains(cadena2))
{
    Console.WriteLine("La cadena uno CONTIENE a la cadena 2");
}
else
{
    Console.WriteLine("La cadena uno NO contiene a la cadena 2");
}

Console.WriteLine("Ingrese un numero para sumar:");

string cadena = Console.ReadLine();

double constante  = 0.5;

double numeroEnCadenaConvertidoADouble;

double sumaConNumeroDouble;

if (string.IsNullOrEmpty(cadena))
{
    Console.WriteLine("La cadena no se puede parsear ya que esta vacia.");
}
else
{
    numeroEnCadenaConvertidoADouble = double.Parse(cadena);
    sumaConNumeroDouble = numeroEnCadenaConvertidoADouble + constante;
    Console.WriteLine("El resultado es: " + sumaConNumeroDouble);
}