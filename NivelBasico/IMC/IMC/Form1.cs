namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!emptyTextBox())
            {
                float peso = float.Parse(txtPeso.Text);
                float altura = float.Parse(txtAltura.Text);
                altura = altura / 100;
                float resultado = peso / (altura * 2);
                lblResultado.Text = "" + resultado;
            }
        }

        private bool emptyTextBox()
        {
            bool empty = false;
            TextBox[] txtBox = new TextBox[2];

            txtBox[0] = txtPeso;
            txtBox[1] = txtAltura;

            foreach (TextBox textBox in txtBox)
            {
                if (textBox.Text.Equals(""))
                {
                    return true;
                }
            }

            return empty;
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * Si NO es un caracter de control o
             * NO es un d�gito o
             * NO es el punto(.) el cuadro de texto se bloquear� para que no
             * ingrese.
             */
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                    && (e.KeyChar != '.'))
            {
                e.Handled = true; // True: No permitir� que ingrese al cuadro.yy
            }

            /*
             * Si se ingresa el primer punto, el cuadro de texto lo aceptar�.
             * Si ingresa otro punto, el cuadro de texto lo detectar� con el
             * m�todo IndexOf() y se bloquear� para que no ingrese.
             */
            if ((e.KeyChar == '.')
                    && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // True: No permitir� que ingrese al cuadro.yy
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * Si NO es un caracter de control o
             * NO es un d�gito o
             * NO es el punto(.) el cuadro de texto se bloquear� para que no
             * ingrese.
             */
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                    && (e.KeyChar != '.'))
            {
                e.Handled = true; // True: No permitir� que ingrese al cuadro.yy
            }

            /*
             * Si se ingresa el primer punto, el cuadro de texto lo aceptar�.
             * Si ingresa otro punto, el cuadro de texto lo detectar� con el
             * m�todo IndexOf() y se bloquear� para que no ingrese.
             */
            if ((e.KeyChar == '.')
                    && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // True: No permitir� que ingrese al cuadro.yy
            }
        }
    }
}
