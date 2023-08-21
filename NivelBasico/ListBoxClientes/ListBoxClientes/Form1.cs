namespace ListBoxClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.clientes = new List<Cliente>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();

            c.Nombre = txtNombre.Text;
            c.Apellido = txtApellido.Text;
            c.DNI = txtDNI.Text;

            this.clientes.Add(c);
            lstBoxClientes.Items.Add(c);

            resetTextBox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstBoxClientes.SelectedIndex != -1)
            {
                int indice = lstBoxClientes.SelectedIndex;
                lstBoxClientes.Items.RemoveAt(indice);
                this.clientes.RemoveAt(indice);
            }
        }

        private void resetTextBox()
        {
            TextBox[] textBoxes = new TextBox[3]
            {
                txtNombre, txtApellido, txtDNI
            };

            foreach (TextBox txtBox in textBoxes)
            {
                txtBox.Text = "";
            }
        }
    }
}