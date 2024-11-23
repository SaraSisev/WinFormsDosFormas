using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDosFormas
{
    public partial class Form3 : Form
    {
        private static int numero;
        private string name;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string name)
        {
            this.name = name;
            Form3.numero = Form1.numero2;
            InitializeComponent();
            this.textBoxNombre.Text = name;
            this.textBoxNumero.Text = Convert.ToString(Form3.numero);
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voy de regreso");
            this.Close();
        }
    }
}
