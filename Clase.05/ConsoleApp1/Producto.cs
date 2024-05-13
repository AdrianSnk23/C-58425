using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Producto
    {
        //aqui se crean las variables
        private int _codigo;
        private string _descripcion;
        private double _precioDeCompra;
        private double _precioDeVenta;
        private string _categoria;

        public Producto(int codigo, string descripcion, double precioDeCompra, double precioDeVenta, string categoria)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precioDeCompra = precioDeCompra;
            this._precioDeVenta = precioDeVenta;
            this._categoria = categoria;
        }

        public string categoria
        {
            get
            {
                if (!string.IsNullOrEmpty(this._categoria))
                {
                    return this._categoria;
                }
                else
                {
                    return "Sin Categoria";
                }
            }
            set
            {
                this._categoria = value;
            }
        }
    public bool hayPrecioDeVenta()
        {
            return this._precioDeVenta > 0;
        }
    }
}
