namespace FormularioSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelBienvenida.BackColor = Color.FromArgb(255, 50, 50, 78);


        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            labelCambio.Text = "Texto cambiado";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
        


        }
    }
}
