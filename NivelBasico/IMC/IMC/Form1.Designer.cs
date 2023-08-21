namespace IMC
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
            lblResultado = new Label();
            btnCalcular = new Button();
            txtPeso = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAltura = new TextBox();
            lblCm = new Label();
            lblKg = new Label();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(178, 126);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 25);
            lblResultado.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(61, 122);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(92, 35);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPeso.Location = new Point(103, 28);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(79, 33);
            txtPeso.TabIndex = 2;
            txtPeso.TextAlign = HorizontalAlignment.Center;
            txtPeso.KeyPress += txtPeso_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 36);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 3;
            label2.Text = "Peso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 75);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 4;
            label3.Text = "Altura:";
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltura.Location = new Point(103, 67);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(79, 33);
            txtAltura.TabIndex = 5;
            txtAltura.TextAlign = HorizontalAlignment.Center;
            txtAltura.KeyPress += txtAltura_KeyPress;
            // 
            // lblCm
            // 
            lblCm.AutoSize = true;
            lblCm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCm.Location = new Point(188, 79);
            lblCm.Name = "lblCm";
            lblCm.Size = new Size(98, 21);
            lblCm.TabIndex = 6;
            lblCm.Text = "centrimetros";
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;
            lblKg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblKg.Location = new Point(188, 40);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(88, 21);
            lblKg.TabIndex = 7;
            lblKg.Text = "kilogramos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 181);
            Controls.Add(lblKg);
            Controls.Add(lblCm);
            Controls.Add(txtAltura);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPeso);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Índice de masa corporal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Button btnCalcular;
        private TextBox txtPeso;
        private Label label2;
        private Label label3;
        private TextBox txtAltura;
        private Label lblCm;
        private Label lblKg;
    }
}
