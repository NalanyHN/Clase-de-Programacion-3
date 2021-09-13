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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Ejecutar_Click(object sender, EventArgs e)
        {
            string cadena = Txt_Cadenas.Text;

            Txt_Longitud.Text = cadena.Length.ToString();
            Txt_Primerletra.Text = cadena.Substring(0, 1);
            Txt_Ultimaletra.Text = cadena.Substring(cadena.Length -1, 1);
            Txt_Rango.Text = cadena.Substring (5, 5);
            Txt_Mayusculas.Text = cadena.ToUpper();
            Txt_Minusculas.Text = cadena.ToLower();
            Txt_Reemplazar.Text = cadena.Replace("a","e");
            Txt_Primermayuscula.Text = cadena.Substring(0, 1).ToUpper() + cadena.Substring(1,cadena.Length -1 ).ToLower() ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
