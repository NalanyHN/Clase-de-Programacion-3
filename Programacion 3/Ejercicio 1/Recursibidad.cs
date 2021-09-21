using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Recursibidad : Form
    {
        public Recursibidad()
        {
            InitializeComponent();
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
           
            RecorrerDeUnoEnUno(1,10);
           
        }

        private void RecorrerDeUnoEnUno(int num1, int num2)
        {

            listBox1.Items.Add(num1);
            if (num1 < num2)
            {
                RecorrerDeUnoEnUno(num1 +1, num2);
            }
             listBox1.DataSource = null;
        
        }

        private void Btn_For_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("El factorial de" + Txt_Factorial.Text  + "es" + FactoaialDe(Convert.ToDecimal(Txt_Factorial.Text).ToString());
        }
        private decimal FactoaialDe(decimal numero)
        {
            if (numero == 1)
            {
                return numero;
            }
            else
            {
                return numero * FactoaialDe(numero - 1);
            }
        }
    }
}
