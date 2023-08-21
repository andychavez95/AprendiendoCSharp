namespace Promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(!this.emptyTextBox())
            {
                float nota1 = float.Parse(txtNota1.Text);
                float nota2 = float.Parse(txtNota2.Text);
                float nota3 = float.Parse(txtNota3.Text);

                float promedio = (nota1 + nota2 + nota3) / 3;

                lblPromedio.Text = "" + this.roundFloat(promedio);
            }
        }

        private string roundFloat(float f)
        {
            string s = f.ToString("#");
            return s;
        }

        private bool emptyTextBox()
        {
            bool empty = false;
            TextBox[] txtBox = new TextBox[3];

            txtBox[0] = this.txtNota1;
            txtBox[1] = this.txtNota2;
            txtBox[2] = this.txtNota3;

            foreach (TextBox textBox in txtBox)
            {
                if (textBox.Text.Equals(""))
                {
                    return true;
                }
            }

            return empty;
        }
    }
}
