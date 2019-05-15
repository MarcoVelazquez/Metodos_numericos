using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;
namespace IntegracionNumerica
{
    class Integración_Numerica
    {
        public double Integrar(string fx, string metodo, int n, double a, double b)
        {
            double I = 0;

            if(metodo == "Regla del trapecio")
            {
                if(TrapecioSimple(fx, n, a, b) == 0211)
                {
                    I = 0211;
                }
                    I = TrapecioSimple(fx, n, a, b);
                
               
            }
            else if(metodo == "Regla del trapecio de aplicación multiple")
            {
                if(TrapecioMultiple(fx,n,a,b) == 0211)
                {
                    I = 0211;
                }
                    I = TrapecioMultiple(fx, n, a, b);
                
            }
            else if(metodo == "Regla de Simpson 1/3")
            {
                if (SimpsonUnTercioSimple(fx,n,a,b) == 0211)
                {
                    I = 0211;
                }
                I = SimpsonUnTercioSimple(fx, n, a, b);
            }
            else if(metodo == "Regla de Simpson 1/3 de aplicación multiple")
            {
                if (SimpsonUnTercioMultiple(fx, n, a, b) == 0211)
                {
                    I = 0211;
                }
                I = SimpsonUnTercioMultiple(fx, n, a, b);
            }
            else if(metodo == "Regla de Simpson 3/8")  
            {
                if (SimpsonTresOctavos(fx, n, a, b) == 0211)
                {
                    I = 0211;
                }
                I = SimpsonTresOctavos(fx, n, a, b);
            }

            return I;
        }

        public double Error(string fx,double I)
        {
            double error = 0;

            return error;
        }

        private double SimpsonTresOctavos(string fx, int n, double a, double b)
        {
            double h = (b - a) / n;
            double[] xi = Xi(a, h, n);
            double[] fxi = Fxi(fx, xi, n);

            if (fxi[0] == 0211)
            {
                return 0211;
            }

            return (b - a) * ((fxi[0] + 3*fxi[1] + 3*fxi[2] + fxi[3])/8);
        }

        private double SimpsonUnTercioMultiple(string fx, int n, double a, double b)
        {
            double h = (b - a) / n;
            double[] xi = Xi(a, h, n);
            double[] fxi = Fxi(fx, xi, n);

            if (fxi[0] == 0211)
            {
                return 0211;
            }

            return (b - a) * ((fxi[0] + 4 * SumatoriaSimpson_impar(fxi, 1, n) + 2 * SumatoriaSimpson_par(fxi, 2, n) + fxi[n])/(3*n));
        }

        private double SimpsonUnTercioSimple(string fx, int n, double a, double b)
        {
            double h = (b - a) / n;
            double[] xi = Xi(a,h,n+1);
            double[] fxi = Fxi(fx, xi, n+1);

            if (fxi[0] == 0211)
            {
                return 0211;
            }

            return (b - a) * ((fxi[0] + 4 * fxi[1] + fxi[2]) / 6);
        }

        private double TrapecioMultiple(string fx, int n, double a, double b)
        {
            double h = (b - a) / n;
            double[] xi = Xi(a, h, n);
            double[] fxi = Fxi(fx, xi, n);

            if (fxi[0] == 0211)
            {
                return 0211;
            }

            return (b - a) * ((fxi[0] + 2 * (SumatoriaTrapecio(fxi, 1, n)) + fxi[n]) / (2 * n));
        }

        private double[] Xi(double a, double h, int n)
        {
            double[] xi = new double[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                if (i == 0)
                {
                    xi[0] = a;
                }
                xi[i] = h * i;

            }

            return xi;
        }

        private double[] Fxi(string fx, double[] xi, int n)
        {
            double[] fxi = new double[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                if (Evaluar(fx, xi[i]) == 0211)
                {
                    fxi[i] = 0211;
                }
                fxi[i] = Evaluar(fx, xi[i]);

            }

            return fxi;
        }
        
        private double SumatoriaTrapecio(double[] fxi, int a, int b)
        {
            double sumatoria = 0;

            for (int i = a; i < b; i++)
            {
                sumatoria += fxi[i];

            }

            return sumatoria;
        }

        private double SumatoriaSimpson_impar(double[] fxi, int a, int b)
        {
            double sumatoria = 0;

            for(int i = a; i < b; i++)
            {
                if(i % 2 != 0)
                {
                    sumatoria += fxi[i];
                }
            }

            return sumatoria;
        }

        private double SumatoriaSimpson_par(double[] fxi, int a, int b)
        {
            double sumatoria = 0;

            for (int i = a; i < b-1; i++)
            {
                if (i % 2 == 0)
                {
                    sumatoria += fxi[i];
                }
            }

            return sumatoria;
        }

        private double TrapecioSimple(string fx, int n, double a, double b)
        {
            if ((Evaluar(fx, a) + Evaluar(fx, b) == 422))
            {
                return 0211;
            }
            return (b - a) * ((Evaluar(fx, a) + Evaluar(fx, b)) / n); 
        }

        private double Evaluar(string fx, double x)
        {
            Calculo C = new Calculo();

            double FuncionEvaluada = 0;
            if (C.Sintaxis(fx, 'x'))
            {
                FuncionEvaluada = C.EvaluaFx(x);

            }
            else
            {
                return 0211;
            }

            return FuncionEvaluada;
        }

    }
}
