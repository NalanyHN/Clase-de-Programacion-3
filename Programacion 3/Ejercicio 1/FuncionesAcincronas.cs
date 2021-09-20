using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class FuncionesAcincronas : Form
    {
        public FuncionesAcincronas()
        {
            InitializeComponent();
        }

        private void Btn_Ejecutar_Click(object sender, EventArgs e)
        {
            HornearPizzaAsync();
            Lbl_Resultato.Text = "Proceso Iniciado";
            Lbl_Resultato.Text = "Termino el Proceso";
        }

        private void HornearPizza()
        {
            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private async  void Btn_Sumar_Click(object sender, EventArgs e)
        {
            Lbl_Sumar.Text = Convert.ToString(await SumarDosValoresAsync(25M, 50M));
        }

        private async Task<decimal> SumarDosValoresAsync(decimal num1, decimal num2)
        {
            var resultado = await Task.Run(() =>
           {
               return num1 + num2;
           });
            return resultado;
        }
    }


    }



