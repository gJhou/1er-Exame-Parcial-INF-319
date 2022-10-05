using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Hago referencia App --> Cls_calculadora
        //obj crerado
        Cls_calculadora.Cls_calculadora objCalculadora = new Cls_calculadora.Cls_calculadora();



        //para + - * /
        String memoria1;
        String memoria2;
        String signo;


        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text = (txt_pantalla.Text + "0");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text = (txt_pantalla.Text + "1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text = (txt_pantalla.Text + "2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text = (txt_pantalla.Text + "3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text = (txt_pantalla.Text + "4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text = (txt_pantalla.Text + "5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text = (txt_pantalla.Text + "6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text = (txt_pantalla.Text + "7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text = (txt_pantalla.Text + "8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text = (txt_pantalla.Text + "9");
        }

        private void btn_MasMenos_Click(object sender, EventArgs e)
        {
            String cadena = txt_pantalla.Text;
            double numero = 0;
            if (!(cadena.Equals("")))
            {
                numero = (-1) * (double.Parse(cadena));
                txt_pantalla.Text = numero.ToString();
            }
        }

        private void btn_Punto_Click(object sender, EventArgs e)
        {
            String cadena = txt_pantalla.Text;
            if (cadena.Equals(""))
            {
                txt_pantalla.Text="0.";

            }
            else
            {
                if (!(objCalculadora.existePunto(cadena)))
                {
                    cadena = cadena + ".";
                    txt_pantalla.Text=cadena;
                }
            }
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            //Borrar todo
            txt_pantalla.Text = "";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            //borrar 1 numero a la vez
            String cadena = txt_pantalla.Text;
            if (!(cadena.Equals("")))
            {
                cadena = cadena.Substring(0, cadena.Length - 1);
                txt_pantalla.Text = cadena;
            }
        }

        private void btn_Inversa_Click(object sender, EventArgs e)
        {
            String cadena = txt_pantalla.Text;
            double numero = 0;
            if (!(cadena.Equals("")))
            {
                numero = 1 / (double.Parse(cadena));
                txt_pantalla.Text = numero.ToString();
            }

        }

        private void btn_Mas_Click(object sender, EventArgs e)
        {
            String cadena = txt_pantalla.Text;
            if (!(cadena.Equals("")))
            {
                memoria1 = cadena;
                signo = "+";
                txt_pantalla.Text = "";
            }
        }

        private void btn_Menos_Click(object sender, EventArgs e)
        {
            String cadena = txt_pantalla.Text;
            if (!(cadena.Equals("")))
            {
                memoria1 = cadena;
                signo = "-";
                txt_pantalla.Text = "";
            }
        }

        private void btn_Por_Click(object sender, EventArgs e)
        {
            String cadena = txt_pantalla.Text;
            if (!(cadena.Equals("")))
            {
                memoria1 = cadena;
                signo = "*";
                txt_pantalla.Text = "";
            }
        }

        private void btn_Entre_Click(object sender, EventArgs e)
        {
            String cadena = txt_pantalla.Text;
            if (!(cadena.Equals("")))
            {
                memoria1 = cadena;
                signo = "/";
                txt_pantalla.Text = "";
            }
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            String cadena = txt_pantalla.Text;
            double resultado = 0;
            if (!(cadena.Equals("")))
            {
                memoria2 = cadena;
                resultado = double.Parse(objCalculadora.calculaRespuesta(memoria1, memoria2, signo));
                txt_pantalla.Text = resultado.ToString();
            }
        }
    }
}
