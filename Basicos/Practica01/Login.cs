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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            


            // de esta manera nos referimos al mismo archivo (formulario)
            this.BackColor = Color.FromArgb(255, 1, 1, 24);
            panelLogin.BackColor = Color.FromArgb(255, 240 , 240, 240);
            btnGoogle.BackColor = Color.FromArgb(250, 1, 1, 24);
            labelLogin.ForeColor = Color.FromArgb(250, 1, 1, 24);
            labelEmail.ForeColor = Color.FromArgb(250, 1, 1, 24);
            labelPssword.ForeColor = Color.FromArgb(250, 1, 1, 24);

            





            borderRadius.AplicarRadius(textBoxEmail, 30);
            borderRadius.AplicarRadius(textBoxPassword, 30);
            borderRadius.AplicarRadius(panelLogin, 30);
            borderRadius.AplicarRadius(btnGoogle, 30);


        }

        private void BtnGoogle_Click(object sender, EventArgs e)
        {

        }
    }
}
