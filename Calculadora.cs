namespace Calculator
{
    public partial class Calculadora : Form
    {
        double primero, segundo;
        string operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();

        private void tbxScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!tbxScreen.Text.Contains("."))
            {
               
                tbxScreen.Text += ".";
            }
            else
            {
                MessageBox.Show("No puedes poner dos puntos decimales en un mismo número.", "Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";

            if (!string.IsNullOrEmpty(tbxScreen.Text) && double.TryParse(tbxScreen.Text, out primero))
            {
                tbxScreen.Clear();
            }
            else
            {

                MessageBox.Show("Por favor, introduce un número.", "Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";

            if (!string.IsNullOrEmpty(tbxScreen.Text) && double.TryParse(tbxScreen.Text, out primero))
            {
                tbxScreen.Clear();
            }
            else
            {

                MessageBox.Show("Por favor, introduce un número.", "Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";

            if (!string.IsNullOrEmpty(tbxScreen.Text) && double.TryParse(tbxScreen.Text, out primero))
            {
                tbxScreen.Clear();
            }
            else
            {

                MessageBox.Show("Por favor, introduce un número.", "Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";

            if (!string.IsNullOrEmpty(tbxScreen.Text) && double.TryParse(tbxScreen.Text, out primero))
            {
                tbxScreen.Clear();
            }
            else
            {

                MessageBox.Show("Por favor, introduce un número.", "Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {


            if (double.TryParse(tbxScreen.Text, out segundo))
            {
                double Sum;
                double Res;
                double Mul;
                double Div;

                switch (operador)
                {
                    case "+":
                        Sum = obj.Sumar((primero), (segundo));
                        tbxScreen.Text = Sum.ToString();
                        break;
                    case "-":
                        Res = obj2.Restar((primero), (segundo));
                        tbxScreen.Text = Res.ToString();
                        break;
                    case "*":
                        Mul = obj3.Multiplicar((primero), (segundo));
                        tbxScreen.Text = Mul.ToString();
                        break;
                    case "/":
                        if (segundo != 0 && primero != 0)
                        {
                            Div = obj4.Dividir((primero), (segundo));
                            tbxScreen.Text = Div.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cualquier division por 0 es igual a 0 cazurro.", "Atención", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation);
                        }
                        break;
                    default:
                        MessageBox.Show("Inserta otro número.", "Atención", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor, realiza una operación.", "Atención", MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length > 0)
            {
                if (tbxScreen.Text.Length == 1)
                {
                    tbxScreen.Text = "";
                }
                else
                {
                    tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
                }
            }
            else
            {
                MessageBox.Show("No hay nada que borrar.", "Atención", MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }
    }
}
