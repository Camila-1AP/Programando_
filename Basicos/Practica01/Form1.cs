using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica01.BorderRadius;
using Practica01.SolveNote;

namespace Practica01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarNotasRecientes();
            ContarTotalNotas();
          
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            

            // aplicando color a los paneles y botones
            panelRecientes.BackColor = Color.FromArgb(255, 50, 50, 78);
            panelCantidad.BackColor = Color.FromArgb(255, 77, 76, 107);
            panelDestacadas.BackColor = Color.FromArgb(255, 108, 104, 137);
            panelModificaciones.BackColor = Color.FromArgb(255, 77, 76, 107);
            panelAgregar.BackColor = Color.FromArgb(255, 217, 217, 217);
            btnagregar.BackColor = Color.FromArgb(245, 50, 50, 78);
            panelbanner.BackColor = Color.FromArgb(255, 26, 26, 52);
            panelbanner2.BackColor = Color.FromArgb(255, 1, 1, 24);
            panelUser.BackColor = Color.FromArgb(255, 50, 50, 78);
            emailUser.ForeColor = Color.FromArgb(255, 170, 166, 203);
            listBoxRecientes.BackColor = Color.FromArgb(255, 50, 50, 78);
            
           


            // aplicando forma circular
            borderRadius.AplicarCircular(pictureUser);
            borderRadius.AplicarCircular(btnagregar);


            // aplicando border radius a los paneles y botones
            borderRadius.AplicarRadius(panelRecientes, 30);
            borderRadius.AplicarRadius(panelCantidad, 30);
            borderRadius.AplicarRadius(panelDestacadas, 30);
            borderRadius.AplicarRadius(panelModificaciones, 30);
            borderRadius.AplicarRadius(panelAgregar, 30);
            borderRadius.AplicarRadius(panelbanner2, 30);
            borderRadius.AplicarRadius(panelUser, 35);
           









        }
        private void CargarNotasRecientes()
        {
            List<Notas> notas = Notas.ObtenerNotasDesdeJSON();

            
            int maxRecientes = Math.Min(5, notas.Count);
            for (int i = 0; i < maxRecientes; i++)
            {
                listBoxRecientes.Items.Add(notas[i].Titulo);
            }
        }
        private void ContarTotalNotas()
        {
            List<Notas> notas = Notas.ObtenerNotasDesdeJSON();
            lblTotalNotas.Text = $"Total de notas: {notas.Count}";
        }


        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowrecientes_Paint(object sender, PaintEventArgs e)
        {

        }
       

        

        private void NoteNow_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            // este código oculta un formulario para presentar otro (intercambiandolo por el formulario principal que es Form1)
            //this.Hide();

            // este código: cuando se pulsa el botón agregar lo dirige al formulario HandlerAdd donde podrá agregar su nota
            this.Hide();
            HandlerAdd add = new HandlerAdd();
            add.Show();
            
        }
    }
}
