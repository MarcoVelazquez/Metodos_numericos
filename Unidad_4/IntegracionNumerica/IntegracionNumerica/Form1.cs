using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegracionNumerica
{
    public partial class Form1 : Form
    {
        Integración_Numerica I = new Integración_Numerica();

        string fx, metodo;
        int n;
        double a, b, i, error;

        public Form1()
        {
            InitializeComponent();
            ResultadoTxtBox.Enabled = false;
            ErrortxtBox.Enabled = false;
            ErrortxtBox.Visible = false;
            label5 .Visible = false;
        }

        public void Borrar()
        {
            FxTxtBox.Text = "";
            MethCmbBox.Text = "";
            nTxtBox.Text = "";
            aTxtBox.Text = "";
            bTxtBox.Text = "";
            ResultadoTxtBox.Text = "";
            ErrortxtBox.Text = "";

        }

        private void BorrarBtt_Click_1(object sender, EventArgs e)
        {
            Borrar();
        }

        private void CalcularBtt_Click(object sender, EventArgs e)
        {
            GetData();
            ResultadoTxtBox.Text = i.ToString();
        }

        

        private void MethCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nTxtBox.Enabled = true;
            nTxtBox.Text = "";

            
            if(MethCmbBox.Text == "Regla del trapecio")
            {
                nTxtBox.Text = "2";
                nTxtBox.Enabled = false;
            }
            else if (MethCmbBox.Text == "Regla de Simpson 1/3")
            {
                nTxtBox.Text = "2";
                nTxtBox.Enabled = false;
            }
        }
        
    

        public void GetData()
        {
            if (FxTxtBox.Text == "" || MethCmbBox.Text == "" || nTxtBox.Text == "" || aTxtBox.Text == "" || bTxtBox.Text == "")
            {
                MessageBox.Show("Uno de los campos está vacio. Intente llenar todos los campos disponibles antes de calcular la aproximación.");
            }
            else
            {
                fx = FxTxtBox.Text;
                metodo = MethCmbBox.Text;
                n = int.Parse(nTxtBox.Text);
                a = double.Parse(aTxtBox.Text);
                b = double.Parse(bTxtBox.Text);
                if (b < a)
                {
                    MessageBox.Show("El valor de 'b' no puede ser menor que el de 'a'");
                }
                else
                {
                    if (I.Integrar(fx, metodo, n, a, b) == 0211)
                    {
                        MessageBox.Show("Error de sintaxis");
                    }
                    else
                    {
                        i = I.Integrar(fx, metodo, n, a, b);
                        error = I.Error(fx, i);
                    }
                }
                
             

            }
            
            
        }

        private void BorrarBtt_Click(object sender, EventArgs e)
        {
            nTxtBox.Enabled = true;
            Borrar();
        }


    }
}
