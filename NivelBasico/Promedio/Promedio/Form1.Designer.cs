namespace Promedio
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
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            lblPromedio = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(56, 185);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(82, 35);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 31);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 1;
            label1.Text = "Nota 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 87);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 2;
            label2.Text = "Nota 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 143);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 3;
            label3.Text = "Nota 3:";
            // 
            // txtNota1
            // 
            txtNota1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNota1.Location = new Point(92, 23);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 29);
            txtNota1.TabIndex = 4;
            txtNota1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNota2
            // 
            txtNota2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNota2.Location = new Point(92, 79);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 29);
            txtNota2.TabIndex = 5;
            txtNota2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNota3
            // 
            txtNota3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNota3.Location = new Point(92, 135);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 29);
            txtNota3.TabIndex = 6;
            txtNota3.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPromedio.Location = new Point(213, 78);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(72, 30);
            lblPromedio.TabIndex = 7;
            lblPromedio.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 242);
            Controls.Add(lblPromedio);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Promedio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Label lblPromedio;
    }
}
