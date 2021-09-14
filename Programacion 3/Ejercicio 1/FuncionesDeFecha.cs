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
    public partial class FuncionesDeFecha : Form
    {
        public FuncionesDeFecha()
        {
            InitializeComponent();
        }

        private void Btn_Ejecutar_Click(object sender, EventArgs e)
        {
            
            DateTime FechaIngresada = Dtp_Fecha.Value;
            Txt_Numerodia.Text = FechaIngresada.Day.ToString ();
            Txt_Numeromes.Text = FechaIngresada.Month.ToString();
            Txt_año.Text = FechaIngresada.Year.ToString();
            Txt_Hora.Text = FechaIngresada.Hour.ToString();

            Txt_Meslestras.Text = FechaIngresada.ToString("MMMMM");
            Txt_Dialetras.Text = FechaIngresada.ToString("dddd");

            int numerodias = Convert.ToInt32(Txt_Agregardias.Text);
            Txt_Nuevafecha.Text = FechaIngresada.AddDays(numerodias).ToString();

            int restarnumerodias = Convert.ToInt32(Txt_Restardias.Text);
            Txt_Nuevafechamenos.Text = FechaIngresada.AddDays(restarnumerodias).ToString();
            Txt_Edad.Text = DevolverEdad(FechaIngresada).ToString();
        }

        private int DevolverEdad(DateTime FechaNacimiento)
        {
            DateTime _fechanacimiento = FechaNacimiento;
            DateTime _fechaactual = DateTime.Now;

            int edad;

            if(_fechanacimiento.Day > _fechaactual.Day )
            {
                return 0;
            }
            {
                edad = _fechaactual.Year - _fechanacimiento.Year;
                if (_fechanacimiento.Month > _fechaactual.Month )
                {
                    --edad;
                }
                return edad;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void FuncionesDeFecha_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
