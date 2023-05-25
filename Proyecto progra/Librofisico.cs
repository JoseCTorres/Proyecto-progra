using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_progra
{
    internal class Librofisico:Libro
    {
        string cantidad;
        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }

        }

        public Librofisico() : base()
        {
            cantidad = string.Empty;       
        }
        public Librofisico(string titulo, string genero, string autor, string codigo, string cantidad) : base( titulo,  genero,  autor,  codigo)
        {
            this.cantidad = cantidad;
            
        }
        public override string ToString() 
        { 
        return base.ToString()+ " / " + "AMOUNT=" + cantidad+"   /   "+"DATE="+ DateTime.Now;
        }
    }
}
