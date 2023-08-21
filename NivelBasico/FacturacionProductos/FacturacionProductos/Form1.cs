namespace FacturacionProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!this.emptyTextBoxes())
            {
                string codDescuento = txtCodigo.Text.Trim();

                float total;

                uint cantPant = UInt16.Parse(this.txtPantalon.Text);
                uint cantCami = UInt16.Parse(this.txtCamisa.Text);
                uint cantZapatos = UInt16.Parse(this.txtZapatos.Text);

                uint subTotal = this.calcularSubtotal(cantPant, cantCami, cantZapatos);

                total = subTotal - this.calcularDescuento(subTotal, codDescuento);

                this.lblPrecFinal.Text = "" + total;
            }
        }

        private bool emptyTextBoxes()
        {
            bool empty = false;
            TextBox[] txtBox = new TextBox[3];

            txtBox[0] = this.txtPantalon;
            txtBox[1] = this.txtCamisa;
            txtBox[2] = this.txtZapatos;

            foreach (TextBox textBox in txtBox)
            {
                if (textBox.Text.Equals(""))
                {
                    return true;
                }
            }
            return false;
        }

        private float calcularDescuento(uint monto, string codigo)
        {
            float porcDescuento = 0;

            switch (codigo.ToUpper())
            {
                case "NAVIDAD":
                    porcDescuento = 0.1f;
                    break;
            }

            float montoDescuento = monto * porcDescuento;
            return montoDescuento;
        }

        private uint calcularSubtotal(uint cantPant, uint cantCami, uint cantZapatos)
        {
            uint subtotalPant = precPant * cantPant;
            uint subtotalCami = precCamisa * cantCami;
            uint subtotalZapatos = precZapatos * cantZapatos;
            return (subtotalPant + subtotalCami + subtotalZapatos);
        }

        private void chkDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescuento.Checked)
            {
                this.txtCodigo.Enabled = true;
            }
            else
            {
                this.txtCodigo.Text = "";
                this.txtCodigo.Enabled = false;
            }
        }
    }
}