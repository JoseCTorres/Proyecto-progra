using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Proyecto_progra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        Librofisico[]  a = new Librofisico[44];
        int i = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {

            if (i < a.Length)
            {

                Librofisico x = new Librofisico();
                StreamWriter sw = new StreamWriter("..prograproyec.txt", true, Encoding.ASCII);
                x.Titulo = textBoxTITULO.Text;
                x.Autor = textBoxAUTOR.Text;
                x.Cantidad = textBoxCANTIDAD.Text;
                x.Genero = comboBox1.Text;
                x.Codigo = textBoxCODIGO.Text;

               
                sw.WriteLine(x.ToString());
                sw.Close();

                StreamReader sr = new StreamReader("..prograproyec.txt");
                richTextBox1.Text = sr.ReadToEnd();

                
                sr.Close();
            }






        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
