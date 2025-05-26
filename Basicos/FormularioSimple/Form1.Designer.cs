namespace FormularioSimple
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelBienvenida = new Label();
            btnCambiar = new Button();
            labelCambio = new Label();
            btnMostrar = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // labelBienvenida
            // 
            labelBienvenida.AutoSize = true;
            labelBienvenida.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenida.ForeColor = SystemColors.ButtonHighlight;
            labelBienvenida.Location = new Point(12, 18);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(529, 25);
            labelBienvenida.TabIndex = 0;
            labelBienvenida.Text = "Bienvenido al formulario de Camila MT-2024-00369";
            labelBienvenida.Click += labelBienvenida_Click;
            // 
            // btnCambiar
            // 
            btnCambiar.Location = new Point(60, 103);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(94, 29);
            btnCambiar.TabIndex = 1;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // labelCambio
            // 
            labelCambio.AutoSize = true;
            labelCambio.Location = new Point(187, 107);
            labelCambio.Name = "labelCambio";
            labelCambio.Size = new Size(140, 20);
            labelCambio.TabIndex = 2;
            labelCambio.Text = "Este texto cambiará";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(67, 209);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 659);
            Controls.Add(textBox1);
            Controls.Add(btnMostrar);
            Controls.Add(labelCambio);
            Controls.Add(btnCambiar);
            Controls.Add(labelBienvenida);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBienvenida;
        private Button btnCambiar;
        private Label labelCambio;
        private Button btnMostrar;
        private TextBox textBox1;
    }
}
