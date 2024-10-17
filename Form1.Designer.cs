namespace areas
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
            label1 = new Label();
            cuadrado = new Button();
            circulo = new Button();
            rectangulo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 35);
            label1.Name = "label1";
            label1.Size = new Size(299, 41);
            label1.TabIndex = 0;
            label1.Text = "Selecciona una figura";
            // 
            // cuadrado
            // 
            cuadrado.Image = Properties.Resources.cir;
            cuadrado.Location = new Point(31, 132);
            cuadrado.Name = "cuadrado";
            cuadrado.Size = new Size(159, 165);
            cuadrado.TabIndex = 1;
            cuadrado.UseVisualStyleBackColor = true;
            cuadrado.Click += cuadrado_Click;
            // 
            // circulo
            // 
            circulo.Image = Properties.Resources.circ;
            circulo.Location = new Point(211, 132);
            circulo.Name = "circulo";
            circulo.Size = new Size(167, 165);
            circulo.TabIndex = 2;
            circulo.UseVisualStyleBackColor = true;
            circulo.Click += circulo_Click;
            // 
            // rectangulo
            // 
            rectangulo.Image = Properties.Resources.rect;
            rectangulo.Location = new Point(396, 132);
            rectangulo.Name = "rectangulo";
            rectangulo.Size = new Size(287, 165);
            rectangulo.TabIndex = 3;
            rectangulo.UseVisualStyleBackColor = true;
            rectangulo.Click += rectangulo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 334);
            Controls.Add(rectangulo);
            Controls.Add(circulo);
            Controls.Add(cuadrado);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Figuras";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button cuadrado;
        private Button circulo;
        private Button rectangulo;
    }
}
