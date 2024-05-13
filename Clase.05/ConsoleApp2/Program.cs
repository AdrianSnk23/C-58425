namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mayorEdad;
            string nuevaDireccion;
            bool gmail;

            Usuario usuario_1 = new Usuario("Adrian", "Rodriguez", 12345678, "adrian@gmail.com", 39, "Pepito 333");
            Usuario usuario_2 = new Usuario("Rodolfo", "Arruabarrena", 23456789, "rodo@hotmail.com", 17, "Sucre 66");

            mayorEdad = usuario_1.esMayorDeEdad();
            Console.WriteLine("Usuario 1 es mayor de edad: " + mayorEdad);

            mayorEdad = usuario_2.esMayorDeEdad();
            Console.WriteLine("Usuario 2 es mayor de edad: " + mayorEdad);

            gmail = usuario_1.esGmail();
            Console.WriteLine("Usuario 1 tiene correo Gmail: " + gmail);

            gmail = usuario_2.esGmail();
            Console.WriteLine("Usuario 2 tiene correo Gmail: " + gmail);

            nuevaDireccion = usuario_1.cambiarDireccion("Congreso 2500");
            Console.WriteLine("El usuario 1 tiene una nueva direccion: " + nuevaDireccion);

            nuevaDireccion = usuario_2.cambiarDireccion("Charcas 2");
            Console.WriteLine("El usuario 2 tiene una nueva direccion: " + nuevaDireccion);
        }
    }
}
