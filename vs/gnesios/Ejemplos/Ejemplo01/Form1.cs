using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMuestraMensaje_Click(object sender, EventArgs e)
        {
            txtboxMensaje.Clear();
            txtboxMensaje.Text = "Hola Mundo";
        }
    }
}
