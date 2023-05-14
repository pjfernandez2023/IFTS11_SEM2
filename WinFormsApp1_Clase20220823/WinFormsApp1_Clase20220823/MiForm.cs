using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_Clase20220823
{
    public partial class MiForm : Form
    {
        public MiForm()
        {
            InitializeComponent();
        }

        //public void controlbotonigual(String texto1, String texto2)
        //{
        //    if (texto1.Length == 0)
        //    {
        //        MessageBox.Show("Ingrese almenos un numero");
        //        return;
        //    }
        //    if (texto2.Length == 0)
        //    {
        //        MessageBox.Show("Ingrese almenos un numero");
        //        return;
        //    }
        //}
        public void controltxtbox (String texto) {
            double abalbeginVal;
            bool parsed = double.TryParse(texto, out abalbeginVal);
            if (parsed && abalbeginVal >= 0.0 || texto == "")
            {

            }
            else
            {
                MessageBox.Show("Ingrese solamente numeros");
                texto = texto.Remove(texto.Length - 1);
            }

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            
            // agregar manejo de excepciones

            Double dResultado = 0, dNumero1 = 0, dNumero2 = 0;
            //controlbotonigual(txtNumero1.Text, txtNumero2.Text);
            if (txtNumero1.Text.Length == 0)
            {
                MessageBox.Show("Ingrese almenos un numero");
                return;
            }
            if (txtNumero2.Text.Length == 0)
            {
                MessageBox.Show("Ingrese almenos un numero");
                return;
            }
            dNumero1 = double.Parse(txtNumero1.Text);
            dNumero2 = double.Parse(txtNumero2.Text);
            dResultado = dNumero1 + dNumero2;
            txtResultado.Text = dResultado.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
        }
        private void LimpiarEntrada(object sender, EventArgs e)
        {
            //limpia el contenido de todos los datos de los controles de  texto y setea el foco en el primer número
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Text = "";

            // setear el foco para que el cursor quede en el control txtNumero1
            txtNumero1.Focus();
        }

        private void txtNumero1_MouseHover(object sender, EventArgs e)
        {
            if (txtNumero1.BackColor == System.Drawing.SystemColors.HotTrack)
            {
                txtNumero1.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                txtNumero1.BackColor = System.Drawing.SystemColors.HotTrack;
            }

            
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            controltxtbox(txtNumero1.Text);

        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Completar la lectura del método para que evalue la respuesta y determine si limpia o no los controles

            //MessageBox.Show("Ojo con lo que vas a hacer", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //LimpiarEntrada();
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
            txtNumero1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_resta_Click(object sender, EventArgs e)
        {
            if (textBox1_resta.Text.Length == 0)
            {
                MessageBox.Show("Ingrese almenos un numero");
                return;
            }
            if (textBox2_resta.Text.Length == 0)
            {
                MessageBox.Show("Ingrese almenos un numero");
                return;
            }
            // agregar manejo de excepciones
            Double dResultado = 0, dNumero1 = 0, dNumero2 = 0;
            dNumero1 = double.Parse(textBox1_resta.Text);
            dNumero2 = double.Parse(textBox2_resta.Text);
            dResultado = dNumero1 - dNumero2;
            textBoxresultado_resta.Text = dResultado.ToString();
        }

        private void textBox1_resta_TextChanged(object sender, EventArgs e)
        {
            controltxtbox(textBox1_resta.Text);
        }

        private void textBoxresultado_resta_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_resta_Click(object sender, EventArgs e)
        {
            textBox1_resta.Text = "";
            textBox2_resta.Text = "";
            textBoxresultado_resta.Text = "";
            textBox1_resta.Focus();

        }

        private void button1_multi_Click(object sender, EventArgs e)
        {
            if (textBox1_multi.Text.Length == 0)
            {
                MessageBox.Show("Ingrese almenos un numero");
                return;
            }
            if (textBox2_multi.Text.Length == 0)
            {
                MessageBox.Show("Ingrese almenos un numero");
                return;
            }
            // agregar manejo de excepciones
            Double dResultado = 0, dNumero1 = 0, dNumero2 = 0;
            dNumero1 = double.Parse(textBox1_multi.Text);
            dNumero2 = double.Parse(textBox1_multi.Text);
            dResultado = dNumero1 * dNumero2;
            textBox3_resultado_multi.Text = dResultado.ToString();
        }

        private void button2_limpia_multi_Click(object sender, EventArgs e)
        {
            textBox1_multi.Text = "";
            textBox2_multi.Text = "";
            textBox3_resultado_multi.Text= "";
            textBox1_multi.Focus();
        }

        private void button1_div_Click(object sender, EventArgs e)
        {

            if (textBox1_div.Text.Length == 0)
            {
                MessageBox.Show("Ingrese almenos un numero");
                return;
            }
            if (textBox2_div.Text.Length == 0)
            {
                MessageBox.Show("Ingrese almenos un numero");
                return;
            }
            // agregar manejo de excepciones
            Double dResultado = 0, dNumero1 = 0, dNumero2 = 0;
            dNumero1 = double.Parse(textBox1_div.Text);
            dNumero2 = double.Parse(textBox2_div.Text);
            double answer;
            try
            {
                
                //answer = dNumero1 / dNumero2;
                //textBox1_div.Text = String.Format("{0:0.0}", answer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail due to division by zero");
                string excpt = ex.InnerException.ToString();
            }
            dResultado = dNumero1 / dNumero2;
            textBox3_div.Text = dResultado.ToString();
        }

        private void button2_limpia_div_Click(object sender, EventArgs e)
        {
            textBox1_div.Text = "";
            textBox2_div.Text = "";
            textBox3_div.Text = "";
            textBox1_div.Focus();
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            controltxtbox(txtNumero2.Text);
        }

        private void textBox2_resta_TextChanged(object sender, EventArgs e)
        {
            controltxtbox(textBox1_resta.Text);
        }

        private void textBox1_multi_TextChanged(object sender, EventArgs e)
        {
            controltxtbox(textBox2_multi.Text);
        }

        private void textBox2_multi_TextChanged(object sender, EventArgs e)
        {
            controltxtbox(textBox2_multi.Text);
        }

        private void textBox1_div_TextChanged(object sender, EventArgs e)
        {
            controltxtbox(textBox1_div.Text);
        }

        private void textBox2_div_TextChanged(object sender, EventArgs e)
        {
            controltxtbox(textBox2_div.Text);
        }

        private void MiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
