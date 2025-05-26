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
using Practica01.SolveNote;

namespace Practica01
{
    public partial class HandlerAdd : Form
    {
        public HandlerAdd()
        {
            InitializeComponent();
        }

        private void HandlerAdd_Load(object sender, EventArgs e)
        {
            // aplicando color
            panelTitulo.BackColor = Color.FromArgb(255, 77, 76, 107);
            panelDescripcion.BackColor = Color.FromArgb(255, 19, 20, 41);
            richTextBoxDescripcion.BackColor = Color.FromArgb(255, 212, 212, 233);


            panelUser.BackColor = Color.FromArgb(255, 50, 50, 78);
            emailUser.ForeColor = Color.FromArgb(255, 170, 166, 203);



            // aplicando border radius
            borderRadius.AplicarRadius(panelTitulo, 30);
            borderRadius.AplicarRadius(panelDescripcion, 30);
            borderRadius.AplicarRadius(panelUser, 35);



            // aplicando forma circular
            borderRadius.AplicarCircular(btnEliminar);
            borderRadius.AplicarCircular(btnDestacar);
            borderRadius.AplicarCircular(btnSolve);
            borderRadius.AplicarCircular(pictureUser);




        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            // Además de guardar (solve) la nota, también volverá al Dashboard
            // código para guardar la nota...
            //...
            // la propiedad .Text permite obtener los datos de entrada de estos componentes
            Notas.SolveNotesJSON(textBoxTitulo.Text, richTextBoxDescripcion.Text);
            // código para volver al Dashboard...
            this.Hide();
            Form1 back = new Form1();
            back.Show();
        }
    }
}
