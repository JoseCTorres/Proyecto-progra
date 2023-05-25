using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_progra
{
    internal class Libro
    {
        public string titulo;
        public string autor;
        private string genero;
        private string codigo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }

        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }

        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public Libro()
        {
            titulo = string.Empty;
            autor = string.Empty;
            genero = string.Empty;
            codigo = string.Empty;
        }
        public Libro(string titulo, string genero, string autor, string codigo)
        {
            char[] delimitador = { ',' };
            string libro= titulo.Split(',')[0];
            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
            this.codigo = codigo;
        }
        public override string ToString()

        {
          
            return  "TITLE=" + titulo.ToUpper() + "  /  " +"AUTHOR=" + autor.ToUpper() + "  /  " + " GENDER= " + genero.ToUpper()+"  /  "+"CODE=" +  codigo.ToUpper();

        }
        }
}
