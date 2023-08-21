namespace FacturacionProductos
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
            lblPantalon = new Label();
            txtPantalon = new TextBox();
            txtCamisa = new TextBox();
            lblCamisa = new Label();
            txtZapatos = new TextBox();
            lblZapatos = new Label();
            chkDescuento = new CheckBox();
            txtCodigo = new TextBox();
            btnCalcular = new Button();
            lblPrecFinal = new Label();
            SuspendLayout();
            // 
            // lblPantalon
            // 
            lblPantalon.AutoSize = true;
            lblPantalon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPantalon.Location = new Point(24, 37);
            lblPantalon.Name = "lblPantalon";
            lblPantalon.Size = new Size(70, 21);
            lblPantalon.TabIndex = 0;
            lblPantalon.Text = "Pantalón";
            // 
            // txtPantalon
            // 
            txtPantalon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPantalon.Location = new Point(112, 29);
            txtPantalon.Name = "txtPantalon";
            txtPantalon.Size = new Size(78, 29);
            txtPantalon.TabIndex = 1;
            txtPantalon.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCamisa
            // 
            txtCamisa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCamisa.Location = new Point(112, 82);
            txtCamisa.Name = "txtCamisa";
            txtCamisa.Size = new Size(78, 29);
            txtCamisa.TabIndex = 3;
            txtCamisa.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCamisa
            // 
            lblCamisa.AutoSize = true;
            lblCamisa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCamisa.Location = new Point(24, 90);
            lblCamisa.Name = "lblCamisa";
            lblCamisa.Size = new Size(61, 21);
            lblCamisa.TabIndex = 2;
            lblCamisa.Text = "Camisa";
            // 
            // txtZapatos
            // 
            txtZapatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtZapatos.Location = new Point(112, 135);
            txtZapatos.Name = "txtZapatos";
            txtZapatos.Size = new Size(78, 29);
            txtZapatos.TabIndex = 5;
            txtZapatos.TextAlign = HorizontalAlignment.Center;
            // 
            // lblZapatos
            // 
            lblZapatos.AutoSize = true;
            lblZapatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblZapatos.Location = new Point(24, 143);
            lblZapatos.Name = "lblZapatos";
            lblZapatos.Size = new Size(65, 21);
            lblZapatos.TabIndex = 4;
            lblZapatos.Text = "Zapatos";
            // 
            // chkDescuento
            // 
            chkDescuento.AutoSize = true;
            chkDescuento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkDescuento.Location = new Point(24, 201);
            chkDescuento.Name = "chkDescuento";
            chkDescuento.Size = new Size(175, 25);
            chkDescuento.TabIndex = 6;
            chkDescuento.Text = "Código de descuento";
            chkDescuento.UseVisualStyleBackColor = true;
            chkDescuento.CheckedChanged += chkDescuento_CheckedChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(205, 197);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(145, 29);
            txtCodigo.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(236, 28);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(99, 38);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPrecFinal
            // 
            lblPrecFinal.AutoSize = true;
            lblPrecFinal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecFinal.Location = new Point(219, 90);
            lblPrecFinal.Name = "lblPrecFinal";
            lblPrecFinal.Size = new Size(131, 21);
            lblPrecFinal.TabIndex = 9;
            lblPrecFinal.Text = "Monto a pagar: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 254);
            Controls.Add(lblPrecFinal);
            Controls.Add(btnCalcular);
            Controls.Add(txtCodigo);
            Controls.Add(chkDescuento);
            Controls.Add(txtZapatos);
            Controls.Add(lblZapatos);
            Controls.Add(txtCamisa);
            Controls.Add(lblCamisa);
            Controls.Add(txtPantalon);
            Controls.Add(lblPantalon);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturación productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPantalon;
        private TextBox txtPantalon;
        private TextBox txtCamisa;
        private Label lblCamisa;
        private TextBox txtZapatos;
        private Label lblZapatos;
        private CheckBox chkDescuento;
        private TextBox txtCodigo;
        private Button btnCalcular;
        private Label lblPrecFinal;

        // Precios de productos.
        private const ushort precPant = 20;
        private const ushort precCamisa = 35;
        private const ushort precZapatos = 24;
    }
}