using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {

        int mes, ano;

        //criar a variavel estatico que consiga passar para outro form p/ mes e ano;
        public static int static_mes, static_ano;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarDias();
        }

        private void mostrarDias()
        {
            DateTime now = DateTime.Now;

            mes = now.Month;
            ano = now.Year;

            //atribuir nome para o mes
            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = nomeMes + " " + ano;

            //para EventosForm
            static_mes = mes;
            static_ano = ano;

            //pegar o primeiro dia do mes
            DateTime startofthemonth = new DateTime(ano, mes, 1);

            //pegar a quantidade de dias do mes
            int days = DateTime.DaysInMonth(ano, mes);

            //converter "startofthemonth" para inteiro
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //criar o blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank1 ucblank = new UserControlBlank1();
                conteinerDia.Controls.Add(ucblank);
            }
            //criar o novo usarcontrol para dias
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Dias(i);
                conteinerDia.Controls.Add(ucdays);

            }

        }

        //BOTÃO ANTERIOR
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            
            //limpar o container
            conteinerDia.Controls.Clear();

            //decrementa o mes para o mes anterior
            mes--;

            //para EventosForm
            static_mes = mes;
            static_ano = ano;

            //atribuir nome para o mes
            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = nomeMes + " " + ano;

            //pegar o primeiro dia do mes
            DateTime startofthemonth = new DateTime(ano, mes, 1);

            //pegar a quantidade de dias do mes
            int days = DateTime.DaysInMonth(ano, mes);

            //converter "startofthemonth" para inteiro
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //criar o blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank1 ucblank = new UserControlBlank1();
                conteinerDia.Controls.Add(ucblank);
            }

            //criar o novo usarcontrol para dias
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Dias(i);
                conteinerDia.Controls.Add(ucdays);
            }
        }

        //BOTÃO POSTERIOR
        private void btnPosterior_Click(object sender, EventArgs e)
        {
            
            //limpar o container
            conteinerDia.Controls.Clear();

            //incrementa o mes para o proximo mes
            mes++;

            //para EventosForm
            static_mes = mes;
            static_ano = ano;

            //atribuir nome para o mes
            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = nomeMes + " " + ano;

            //pegar o primeiro dia do mes
            DateTime startofthemonth = new DateTime(ano, mes, 1);

            //pegar a quantidade de dias do mes
            int days = DateTime.DaysInMonth(ano, mes);

            //converter "startofthemonth" para inteiro
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //criar o blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank1 ucblank = new UserControlBlank1();
                conteinerDia.Controls.Add(ucblank);
            }

            //criar o novo usarcontrol para dias
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Dias(i);
                conteinerDia.Controls.Add(ucdays);
            }
        }

    }
}