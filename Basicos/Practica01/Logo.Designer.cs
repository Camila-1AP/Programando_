namespace Practica01
{
    partial class Logo
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
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelDelante = new System.Windows.Forms.Panel();
            this.logNote = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDelante.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelFondo.Location = new System.Drawing.Point(377, 197);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(247, 238);
            this.panelFondo.TabIndex = 0;
            // 
            // panelDelante
            // 
            this.panelDelante.AllowDrop = true;
            this.panelDelante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelDelante.Controls.Add(this.label2);
            this.panelDelante.Controls.Add(this.logNote);
            this.panelDelante.Location = new System.Drawing.Point(432, 251);
            this.panelDelante.Name = "panelDelante";
            this.panelDelante.Size = new System.Drawing.Size(253, 238);
            this.panelDelante.TabIndex = 1;
            // 
            // logNote
            // 
            this.logNote.AutoSize = true;
            this.logNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logNote.Location = new System.Drawing.Point(53, 58);
            this.logNote.Name = "logNote";
            this.logNote.Size = new System.Drawing.Size(160, 69);
            this.logNote.TabIndex = 2;
            this.logNote.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(72, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Now";
            // 
            // Logo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 745);
            this.Controls.Add(this.panelDelante);
            this.Controls.Add(this.panelFondo);
            this.Name = "Logo";
            this.Text = "Logo";
            this.Load += new System.EventHandler(this.Logo_Load);
            this.panelDelante.ResumeLayout(false);
            this.panelDelante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel panelDelante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label logNote;
    }
}