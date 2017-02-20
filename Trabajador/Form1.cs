using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajador
{
    public partial class Form1 : Form
    {
        Trabajador nuevoTrabajador = new Trabajador();
        public Form1()
        {
            InitializeComponent();
        }
       

        private void BBotonCrear_Click(object sender, EventArgs e)
        {
            nuevoTrabajador.Nombre = textBox1.Text;
            nuevoTrabajador.Apellidos = textBox2.Text;
            nuevoTrabajador.Edad = (int)nu1.Value;
        }

        private void BBotonJubilacion_Click(object sender, EventArgs e)
        {
            nuevoTrabajador.CalculoAnyosJubilacion();
        }
    }
}
