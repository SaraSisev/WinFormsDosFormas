namespace WinFormsDosFormas
{
    public partial class Form1 : Form
    {
        public static int numero = 21;
        public static int numero2 = 770;
        public Form1()
        {
            InitializeComponent();
            this.textBoxData.Text = "";
        }

        private void buttonForm1_Click(object sender, EventArgs e)
        {
            string dato;
            dato = this.textBoxData.Text;
            Form3 f3 = new Form3(dato);
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void buttonForm2_Click(object sender, EventArgs e)
        {
            string dato;
            dato = this.textBoxData.Text;
            Form2 f2 = new Form2(dato);
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
