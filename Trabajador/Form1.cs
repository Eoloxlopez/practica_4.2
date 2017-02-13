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
        public Form1()
        {
            InitializeComponent();
        }

        private void BBotonCrear_Click(object sender, EventArgs e)
        {
            Trabajador nuevoTrabajador;

            nuevoTrabajador = new Trabajador();
        }
    }
}
