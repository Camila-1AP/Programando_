namespace Practica01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelbanner = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.emailUser = new System.Windows.Forms.Label();
            this.nombreUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NoteNow = new System.Windows.Forms.Label();
            this.panelbanner2 = new System.Windows.Forms.Panel();
            this.modificaciones = new System.Windows.Forms.Label();
            this.destacadas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.recientes = new System.Windows.Forms.Label();
            this.cantidadNotas = new System.Windows.Forms.Label();
            this.panelRecientes = new System.Windows.Forms.Panel();
            this.panelCantidad = new System.Windows.Forms.Panel();
            this.lblTotalNotas = new System.Windows.Forms.Label();
            this.panelDestacadas = new System.Windows.Forms.Panel();
            this.panelModificaciones = new System.Windows.Forms.Panel();
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.listBoxRecientes = new System.Windows.Forms.ListBox();
            this.panelbanner.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.panelbanner2.SuspendLayout();
            this.panelRecientes.SuspendLayout();
            this.panelCantidad.SuspendLayout();
            this.panelAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbanner
            // 
            this.panelbanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelbanner.Controls.Add(this.panelUser);
            this.panelbanner.Controls.Add(this.NoteNow);
            this.panelbanner.Location = new System.Drawing.Point(12, 12);
            this.panelbanner.Name = "panelbanner";
            this.panelbanner.Size = new System.Drawing.Size(1059, 86);
            this.panelbanner.TabIndex = 0;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelUser.Controls.Add(this.pictureUser);
            this.panelUser.Controls.Add(this.emailUser);
            this.panelUser.Controls.Add(this.nombreUser);
            this.panelUser.Controls.Add(this.button1);
            this.panelUser.Location = new System.Drawing.Point(551, 14);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(505, 59);
            this.panelUser.TabIndex = 13;
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.Location = new System.Drawing.Point(393, 6);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(59, 50);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUser.TabIndex = 16;
            this.pictureUser.TabStop = false;
            // 
            // emailUser
            // 
            this.emailUser.AutoSize = true;
            this.emailUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailUser.Location = new System.Drawing.Point(13, 32);
            this.emailUser.Name = "emailUser";
            this.emailUser.Size = new System.Drawing.Size(255, 20);
            this.emailUser.TabIndex = 15;
            this.emailUser.Text = "camilacamacho2907@gmail.com";
            // 
            // nombreUser
            // 
            this.nombreUser.AutoSize = true;
            this.nombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombreUser.Location = new System.Drawing.Point(13, 10);
            this.nombreUser.Name = "nombreUser";
            this.nombreUser.Size = new System.Drawing.Size(160, 22);
            this.nombreUser.TabIndex = 14;
            this.nombreUser.Text = "Camila Camacho";
            this.nombreUser.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(40, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NoteNow
            // 
            this.NoteNow.AutoSize = true;
            this.NoteNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteNow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoteNow.Location = new System.Drawing.Point(15, 24);
            this.NoteNow.Name = "NoteNow";
            this.NoteNow.Size = new System.Drawing.Size(159, 38);
            this.NoteNow.TabIndex = 0;
            this.NoteNow.Text = "NoteNow";
            this.NoteNow.Click += new System.EventHandler(this.NoteNow_Click);
            // 
            // panelbanner2
            // 
            this.panelbanner2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelbanner2.Controls.Add(this.modificaciones);
            this.panelbanner2.Controls.Add(this.destacadas);
            this.panelbanner2.Location = new System.Drawing.Point(12, 380);
            this.panelbanner2.Name = "panelbanner2";
            this.panelbanner2.Size = new System.Drawing.Size(1059, 69);
            this.panelbanner2.TabIndex = 5;
            // 
            // modificaciones
            // 
            this.modificaciones.AutoSize = true;
            this.modificaciones.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modificaciones.Location = new System.Drawing.Point(660, 19);
            this.modificaciones.Name = "modificaciones";
            this.modificaciones.Size = new System.Drawing.Size(144, 22);
            this.modificaciones.TabIndex = 1;
            this.modificaciones.Text = "Modificaciones";
            // 
            // destacadas
            // 
            this.destacadas.AutoSize = true;
            this.destacadas.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destacadas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.destacadas.Location = new System.Drawing.Point(200, 19);
            this.destacadas.Name = "destacadas";
            this.destacadas.Size = new System.Drawing.Size(113, 22);
            this.destacadas.TabIndex = 0;
            this.destacadas.Text = "Destacadas";
            this.destacadas.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 6;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnagregar.Location = new System.Drawing.Point(80, 144);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(62, 54);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = " +";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // recientes
            // 
            this.recientes.AutoSize = true;
            this.recientes.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recientes.Location = new System.Drawing.Point(263, 28);
            this.recientes.Name = "recientes";
            this.recientes.Size = new System.Drawing.Size(96, 22);
            this.recientes.TabIndex = 2;
            this.recientes.Text = "Recientes";
            // 
            // cantidadNotas
            // 
            this.cantidadNotas.AutoSize = true;
            this.cantidadNotas.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadNotas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cantidadNotas.Location = new System.Drawing.Point(122, 28);
            this.cantidadNotas.Name = "cantidadNotas";
            this.cantidadNotas.Size = new System.Drawing.Size(172, 22);
            this.cantidadNotas.TabIndex = 3;
            this.cantidadNotas.Text = "Cantidad de Notas";
            this.cantidadNotas.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelRecientes
            // 
            this.panelRecientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelRecientes.Controls.Add(this.listBoxRecientes);
            this.panelRecientes.Controls.Add(this.recientes);
            this.panelRecientes.Location = new System.Drawing.Point(12, 104);
            this.panelRecientes.Name = "panelRecientes";
            this.panelRecientes.Size = new System.Drawing.Size(637, 270);
            this.panelRecientes.TabIndex = 8;
            // 
            // panelCantidad
            // 
            this.panelCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelCantidad.Controls.Add(this.lblTotalNotas);
            this.panelCantidad.Controls.Add(this.cantidadNotas);
            this.panelCantidad.Location = new System.Drawing.Point(655, 104);
            this.panelCantidad.Name = "panelCantidad";
            this.panelCantidad.Size = new System.Drawing.Size(416, 270);
            this.panelCantidad.TabIndex = 9;
            // 
            // lblTotalNotas
            // 
            this.lblTotalNotas.AutoSize = true;
            this.lblTotalNotas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalNotas.Location = new System.Drawing.Point(176, 125);
            this.lblTotalNotas.Name = "lblTotalNotas";
            this.lblTotalNotas.Size = new System.Drawing.Size(44, 16);
            this.lblTotalNotas.TabIndex = 4;
            this.lblTotalNotas.Text = "label2";
            // 
            // panelDestacadas
            // 
            this.panelDestacadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelDestacadas.Location = new System.Drawing.Point(12, 455);
            this.panelDestacadas.Name = "panelDestacadas";
            this.panelDestacadas.Size = new System.Drawing.Size(545, 278);
            this.panelDestacadas.TabIndex = 10;
            // 
            // panelModificaciones
            // 
            this.panelModificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelModificaciones.Location = new System.Drawing.Point(563, 455);
            this.panelModificaciones.Name = "panelModificaciones";
            this.panelModificaciones.Size = new System.Drawing.Size(325, 278);
            this.panelModificaciones.TabIndex = 11;
            // 
            // panelAgregar
            // 
            this.panelAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelAgregar.Controls.Add(this.btnagregar);
            this.panelAgregar.Location = new System.Drawing.Point(894, 455);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(177, 278);
            this.panelAgregar.TabIndex = 12;
            // 
            // listBoxRecientes
            // 
            this.listBoxRecientes.FormattingEnabled = true;
            this.listBoxRecientes.ItemHeight = 16;
            this.listBoxRecientes.Location = new System.Drawing.Point(33, 81);
            this.listBoxRecientes.Name = "listBoxRecientes";
            this.listBoxRecientes.Size = new System.Drawing.Size(568, 164);
            this.listBoxRecientes.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1087, 745);
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.panelModificaciones);
            this.Controls.Add(this.panelDestacadas);
            this.Controls.Add(this.panelCantidad);
            this.Controls.Add(this.panelRecientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelbanner2);
            this.Controls.Add(this.panelbanner);
            this.Name = "Form1";
            this.Text = "NoteNow";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panelbanner.ResumeLayout(false);
            this.panelbanner.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.panelbanner2.ResumeLayout(false);
            this.panelbanner2.PerformLayout();
            this.panelRecientes.ResumeLayout(false);
            this.panelRecientes.PerformLayout();
            this.panelCantidad.ResumeLayout(false);
            this.panelCantidad.PerformLayout();
            this.panelAgregar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelbanner;
        private System.Windows.Forms.Label NoteNow;
        private System.Windows.Forms.Panel panelbanner2;
        private System.Windows.Forms.Label modificaciones;
        private System.Windows.Forms.Label destacadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label cantidadNotas;
        private System.Windows.Forms.Label recientes;
        private System.Windows.Forms.Panel panelRecientes;
        private System.Windows.Forms.Panel panelCantidad;
        private System.Windows.Forms.Panel panelDestacadas;
        private System.Windows.Forms.Panel panelModificaciones;
        private System.Windows.Forms.Panel panelAgregar;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label nombreUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label emailUser;
        private System.Windows.Forms.Label lblTotalNotas;
        private System.Windows.Forms.ListBox listBoxRecientes;
    }
}

