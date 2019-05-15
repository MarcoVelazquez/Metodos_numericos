using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace Met
{
    public partial class Form1 : Form
    {

        
        string fx, tipoDif, derivada, ordenError;
        double x, h;

        private void BorrarBtt_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CalcularBtt_Click(object sender, EventArgs e)
        {
            GetData();
            DoThat();
        }

        private void SalirBtt_Click(object sender, EventArgs e)
        {
           
        }

        public Form1()
        {
            InitializeComponent();
            ResultadoTxtBx.Enabled = false;
        }

        public void GetData()
        {
            fx = fxTxtBx.Text;
            tipoDif = TipoDeDifCmbBx.Text;
            derivada = DerivateCmbBx.Text;
            ordenError = OrdErrCmbBx.Text;
            x = double.Parse(xTxtBx.Text);
            h = double.Parse(hTxtBx.Text);

        } 

        public void DoThat()
        {
            Hacia_adelante Adelante = new Hacia_adelante();
            Hacia_atras Atras = new Hacia_atras();
            Centrada Centrada = new Centrada();
            
           if(tipoDif == "Hacia adelante")
            {
                if(derivada == "Primera derivada")
                {
                    if(ordenError == "O(h)")
                    {
                       ResultadoTxtBx.Text =  Adelante.PrimeraDerivada(fx,1,x,h).ToString();
                    }
                    else if(ordenError == "O(h^2)")
                    {
                        ResultadoTxtBx.Text = Adelante.PrimeraDerivada(fx, 2, x, h).ToString();
                    }
                }
                else if (derivada == "Segunda derivada")
                {
                    if (ordenError == "O(h)")
                    {
                        ResultadoTxtBx.Text = Adelante.SegundaDerivada(fx, 1, x, h).ToString();
                    }
                    else if (ordenError == "O(h^2)")
                    {
                        ResultadoTxtBx.Text = Adelante.SegundaDerivada(fx, 2, x, h).ToString();
                    }
                }
                else if(derivada == "Tercera derivada")
                {
                    if (ordenError == "O(h)")
                    {
                        ResultadoTxtBx.Text = Adelante.TerceraDerivada(fx, 1, x, h).ToString();
                    }
                    else if (ordenError == "O(h^2)")
                    {
                        ResultadoTxtBx.Text = Adelante.TerceraDerivada(fx, 2, x, h).ToString();
                    }
                }
                else if(derivada == "Cuarta derivada")
                {
                    if(ordenError == "O(h)")
                    {
                        ResultadoTxtBx.Text = Adelante.CuartaDerivada(fx, 1, x, h).ToString();
                    }
                    else if(ordenError == "O(h^2)")
                    {
                        ResultadoTxtBx.Text = Adelante.CuartaDerivada(fx, 2, x, h).ToString();
                    }
                }
            }
           else if(tipoDif == "Hacia atras")
            {
                if (derivada == "Primera derivada")
                {
                    if (ordenError == "O(h)")
                    {
                        ResultadoTxtBx.Text = Atras.PrimeraDerivada(fx, 1, x, h).ToString();
                    }
                    else if (ordenError == "O(h^2)")
                    {
                        ResultadoTxtBx.Text = Atras.PrimeraDerivada(fx, 2, x, h).ToString();
                    }
                }
                else if (derivada == "Segunda derivada")
                {
                    if (ordenError == "O(h)")
                    {
                        ResultadoTxtBx.Text = Atras.SegundaDerivada(fx, 1, x, h).ToString();
                    }
                    else if (ordenError == "O(h^2)")
                    {
                        ResultadoTxtBx.Text = Atras.SegundaDerivada(fx, 2, x, h).ToString();
                    }
                }
                else if (derivada == "Tercera derivada")
                {
                    if (ordenError == "O(h)")
                    {
                        ResultadoTxtBx.Text = Atras.TerceraDerivada(fx, 1, x, h).ToString();
                    }
                    else if (ordenError == "O(h^2)")
                    {
                        ResultadoTxtBx.Text = Atras.TerceraDerivada(fx, 2, x, h).ToString();
                    }
                }
                else if (derivada == "Cuarta derivada")
                {
                    if (ordenError == "O(h)")
                    {
                        ResultadoTxtBx.Text = Atras.CuartaDerivada(fx, 1, x, h).ToString();
                    }
                    else if (ordenError == "O(h^2)")
                    {
                        ResultadoTxtBx.Text = Atras.CuartaDerivada(fx, 2, x, h).ToString();
                    }
                }

            }
           else if(tipoDif == "Centrada")
            {
                if (derivada == "Primera derivada")
                {
                    if (ordenError == "O(h^2)")
                    {
                        ResultadoTxtBx.Text = Centrada.PrimeraDerivada(fx, 2, x, h).ToString();
                    }
                    else if (ordenError == "O(h^4)")
                    {
                        ResultadoTxtBx.Text = Centrada.PrimeraDerivada(fx, 4, x, h).ToString();
                    }
                }
                else if (derivada == "Segunda derivada")
                {
                    if (ordenError == "O(h^2)")
                    {
                        ResultadoTxtBx.Text = Centrada.SegundaDerivada(fx, 2, x, h).ToString();
                    }
                    else if (ordenError == "O(h^4)")
                    {
                        ResultadoTxtBx.Text = Centrada.SegundaDerivada(fx, 4, x, h).ToString();
                    }
                }
                else if (derivada == "Tercera derivada")
                {
                    if (ordenError == "O(h^2)")
                    {
                        ResultadoTxtBx.Text = Centrada.TerceraDerivada(fx, 2, x, h).ToString();
                    }
                    else if (ordenError == "O(h^4)")
                    {
                        ResultadoTxtBx.Text = Centrada.TerceraDerivada(fx, 4, x, h).ToString();
                    }
                }
                else if (derivada == "Cuarta derivada")
                {
                    if (ordenError == "O(h^2)")
                    {
                        ResultadoTxtBx.Text = Centrada.CuartaDerivada(fx, 2, x, h).ToString();
                    }
                    else if (ordenError == "O(h^4)")
                    {
                        ResultadoTxtBx.Text = Centrada.CuartaDerivada(fx, 4, x, h).ToString();
                    }
                }

            }
        }

        public void Clear()
        {
            fxTxtBx.Text = "";
            TipoDeDifCmbBx.Text = "";
            DerivateCmbBx.Text = "";
            OrdErrCmbBx.Text = "";
            xTxtBx.Text = "";
            hTxtBx.Text = "";
            ResultadoTxtBx.Text = "";
        }
    }
}
