using System;
using System.Windows.Forms;

namespace MayorMenor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.numbers = new int[3];
            this.cantIng = 0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!this.emptyTextBox())
            {
                if (this.cantIng < this.numbers.Length)
                {
                    int i = this.cantIng;
                    this.numbers[i] = Int32.Parse(this.txtNumero.Text);
                    this.cantIng++;
                    this.txtNumero.Text = "";
                }
            }

            if (this.cantIng == 3)
            {
                int mayor = this.numeroMayor(this.numbers);
                int menor = this.numeroMenor(this.numbers);
                MessageBox.Show("Mayor: " + mayor + ". Menor: " + menor + ".");
                this.reiniciarContador();
            }
        }
        
        private void reiniciarContador()
        {
            this.cantIng = 0;
            
            for (int i = 0; i < this.numbers.Length; i++)
            {
               this.numbers[i] = 0; 
            }
        }

        private int numeroMenor(int[] anArray)
        {
            int menor = anArray[0];
            foreach (int n in anArray)
            {
                menor = (n < menor) ? n : menor;
            }
            return menor;
        }

        private int numeroMayor(int[] anArray)
        {
            int mayor = anArray[0];
            foreach (int n in anArray)
            {
                mayor = (n > mayor) ? n : mayor;
            }
            return mayor;
        }

        private bool emptyTextBox()
        {
            string number = txtNumero.Text;
            return (number.Equals(""));
        }
    }
}
