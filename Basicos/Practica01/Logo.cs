using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica01.BorderRadius;

namespace Practica01
{
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
        }

        private  async void Logo_Load(object sender, EventArgs e)
        {
            // aplicando color a los paneles 
            panelDelante.BackColor = Color.FromArgb(250, 1, 1, 24);
            panelFondo.BackColor = Color.FromArgb(250, 50, 50, 78);


            //aplicando bordes radius a los paneles
            borderRadius.AplicarRadius(panelDelante, 30);
            borderRadius.AplicarRadius(panelFondo, 30);

            await Task.Delay(3000); // Espera 3 segundos
            this.Hide();
            Form1 principal = new Form1 ();
            principal.Show();
        }
    }
}
