using System;

namespace Practica01
{
    partial class HandlerAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandlerAdd));
            this.panelbanner = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.emailUser = new System.Windows.Forms.Label();
            this.nombreUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NoteNow = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelDescripcion = new System.Windows.Forms.Panel();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDestacar = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.panelbanner.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panelDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbanner
            // 
            this.panelbanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelbanner.Controls.Add(this.panelUser);
            this.panelbanner.Controls.Add(this.NoteNow);
            this.panelbanner.Location = new System.Drawing.Point(16, 12);
            this.panelbanner.Name = "panelbanner";
            this.panelbanner.Size = new System.Drawing.Size(1059, 86);
            this.panelbanner.TabIndex = 1;
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
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelTitulo.Controls.Add(this.textBoxTitulo);
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(157, 128);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(785, 72);
            this.panelTitulo.TabIndex = 14;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.Location = new System.Drawing.Point(118, 0);
            this.textBoxTitulo.Multiline = true;
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(667, 82);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitulo.Location = new System.Drawing.Point(18, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(94, 29);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título: ";
            // 
            // panelDescripcion
            // 
            this.panelDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelDescripcion.Controls.Add(this.labelDescripcion);
            this.panelDescripcion.Location = new System.Drawing.Point(157, 216);
            this.panelDescripcion.Name = "panelDescripcion";
            this.panelDescripcion.Size = new System.Drawing.Size(785, 52);
            this.panelDescripcion.TabIndex = 15;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescripcion.Location = new System.Drawing.Point(18, 11);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(131, 25);
            this.labelDescripcion.TabIndex = 1;
            this.labelDescripcion.Text = "Descripción ";
            this.labelDescripcion.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(157, 291);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(785, 442);
            this.richTextBoxDescripcion.TabIndex = 16;
            this.richTextBoxDescripcion.Text = "";
            this.richTextBoxDescripcion.WordWrap = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(979, 128);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 63);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = " 🚫";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnDestacar
            // 
            this.btnDestacar.BackColor = System.Drawing.Color.Gold;
            this.btnDestacar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDestacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestacar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDestacar.Location = new System.Drawing.Point(979, 216);
            this.btnDestacar.Name = "btnDestacar";
            this.btnDestacar.Size = new System.Drawing.Size(75, 67);
            this.btnDestacar.TabIndex = 18;
            this.btnDestacar.Text = " 🎯";
            this.btnDestacar.UseVisualStyleBackColor = false;
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSolve.CausesValidation = false;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSolve.Location = new System.Drawing.Point(979, 312);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 67);
            this.btnSolve.TabIndex = 19;
            this.btnSolve.Text = " 🔄";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // HandlerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 745);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnDestacar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.richTextBoxDescripcion);
            this.Controls.Add(this.panelDescripcion);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelbanner);
            this.Name = "HandlerAdd";
            this.Text = "HandlerAdd";
            this.Load += new System.EventHandler(this.HandlerAdd_Load);
            this.panelbanner.ResumeLayout(false);
            this.panelbanner.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelDescripcion.ResumeLayout(false);
            this.panelDescripcion.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panelbanner;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label emailUser;
        private System.Windows.Forms.Label nombreUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NoteNow;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelDescripcion;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDestacar;
        private System.Windows.Forms.Button btnSolve;
    }
}