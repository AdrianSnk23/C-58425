using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Usuario
    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _email;
        private int _edad;
        private string _domicilio;

        public Usuario(string nombre, string apellido, int dni, string email, int edad, string domicilio)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._email = email;
            this._edad = edad;
            this._domicilio = domicilio;
        }

        public string email
        {
            get 
            {
                return this._email;
            }
            set
            {
                this._email= value;
            }
        }
        public bool esMayorDeEdad()
        {
            return this._edad > 18;
        }

        public string cambiarDireccion(string nuevaDireccion)
        {
            this._domicilio = nuevaDireccion;
            return this._domicilio;
        }

        public bool esGmail()
        {
            if (this._email.EndsWith("@gmail.com"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
