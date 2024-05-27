using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Database
{
    internal class GestorBaseDeDatos
    {
        private string connectionString;
        public GestorBaseDeDatos()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_"
        }
    }
}
