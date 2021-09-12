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
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        private void LimpiarControles()
        {
            txt_numero1.Clear();
            txt_numero2.Clear();
            lbl_resultado.Text = string.Empty;
        }

        private int Sumar(int valor1,int valor2)
        {
            return valor1 + valor2;
        }

        private int Restar(int valor1, int valor2)
        {
           int resta = valor1 - valor2;
            return resta;
        }

        private int Multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        private int Dividir(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
        private void btn_sumar_Click(object sender, EventArgs e)
        {
           lbl_resultado.Text = Sumar(Convert.ToInt32(txt_numero1.Text ), Convert.ToInt32(txt_numero2.Text)).ToString();
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Restar(Convert.ToInt32(txt_numero1.Text ), Convert.ToInt32(txt_numero2.Text )).ToString();
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Multiplicar(Convert.ToInt32(txt_numero1.Text ), Convert.ToInt32(txt_numero2.Text )).ToString();
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Dividir (Convert.ToInt32(txt_numero1.Text ), Convert.ToInt32(txt_numero2.Text )).ToString();
        }
    }
}
