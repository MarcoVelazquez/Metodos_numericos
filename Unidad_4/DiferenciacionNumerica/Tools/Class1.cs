using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;
namespace Tools
{
    public class Hacia_adelante
    {
        Calculo C = new Calculo();

        public double PrimeraDerivada(string Fx,int errorGrade,double xi, double h)
        {

            if(errorGrade == 1)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (C.EvaluaFx(xi + h)-C.EvaluaFx(xi))/(h);
                }
                
            }
            else if (errorGrade == 2)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (-1*C.EvaluaFx(xi + 2*h) + 4*C.EvaluaFx(xi+h)-3*C.EvaluaFx(xi)) / (2*h);
                }

            }

            return 0;
        }

        public double SegundaDerivada(string Fx, int errorGrade, double xi, double h)
        {
            if (errorGrade == 1)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (C.EvaluaFx(xi + 2*h)-2*C.EvaluaFx(xi + h)+C.EvaluaFx(xi)) / (h * h);
                }

            }
            else if (errorGrade == 2)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (-1*C.EvaluaFx(xi+3*h)+4*C.EvaluaFx(xi+2*h)-5*C.EvaluaFx(xi + h)+2*C.EvaluaFx(xi)) / (h*h);
                }

            }

            return 0;
        }

        public double TerceraDerivada(string Fx, int errorGrade, double xi, double h)
        {
            if (errorGrade == 1)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (C.EvaluaFx(xi+3*h)-3*C.EvaluaFx(xi +2*h)+3*C.EvaluaFx(xi + h)-C.EvaluaFx(xi)) / (h*h*h);
                }

            }
            else if (errorGrade == 2)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (-3*C.EvaluaFx(xi+4*h)+14*C.EvaluaFx(xi+3*h)-24*C.EvaluaFx(xi + 2*h)+18*C.EvaluaFx(xi + h)-5*C.EvaluaFx(xi)) / (h*h*h);
                }

            }

            return 0;
        }

        public double CuartaDerivada(string Fx, int errorGrade, double xi, double h)
        {
            if (errorGrade == 1)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (C.EvaluaFx(xi+4*h)-4*C.EvaluaFx(xi+3*h)+6*C.EvaluaFx(xi+2*h)-4*C.EvaluaFx(xi+h)+C.EvaluaFx(xi)) / (h*h*h*h);
                }

            }
            else if (errorGrade == 2)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (-2*C.EvaluaFx(xi+5*h)+11*C.EvaluaFx(xi+4*h)-24*C.EvaluaFx(xi+3*h)+26*C.EvaluaFx(xi+2*h)-14*C.EvaluaFx(xi+h)+3*C.EvaluaFx(xi)) / (h*h*h*h);
                }

            }

            return 0;
        }
    }

    public class Centrada
    {
        Calculo C = new Calculo();

        public double PrimeraDerivada(string Fx, int errorGrade, double xi, double h)
        {

            if (errorGrade == 2)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (C.EvaluaFx(xi+h)-C.EvaluaFx(xi-h)) / (2*h);
                }

            }
            else if (errorGrade == 4)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (-1*C.EvaluaFx(xi+2*h)-2*C.EvaluaFx(xi+h)-8*C.EvaluaFx(xi-h)+C.EvaluaFx(xi-2*h)) / (12*h);
                }

            }

            return 0;
        }

        public double SegundaDerivada(string Fx, int errorGrade, double xi, double h)
        {
            if (errorGrade == 2)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (C.EvaluaFx(xi+h)-2*C.EvaluaFx(xi)+C.EvaluaFx(xi-h)) / (h*h);
                }

            }
            else if (errorGrade == 4)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (-1*C.EvaluaFx(xi+2*h)+16*C.EvaluaFx(xi+h)-30*C.EvaluaFx(xi)+16*C.EvaluaFx(xi-h)-C.EvaluaFx(xi+2*h)) / (12*(h*h));
                }

            }

            return 0;
        }

        public double TerceraDerivada(string Fx, int errorGrade, double xi, double h)
        {
            if (errorGrade == 2)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (C.EvaluaFx(xi+2*h)-2*C.EvaluaFx(xi+h)+2*C.EvaluaFx(xi-h)-C.EvaluaFx(xi-2*h)) / (2*(h*h*h));
                }

            }
            else if (errorGrade == 4)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return ((-1)*C.EvaluaFx(xi+3*h)+8*C.EvaluaFx(xi+2*h)-13*C.EvaluaFx(xi+h)+13*C.EvaluaFx(xi-h)-8*C.EvaluaFx(xi-2*h)+C.EvaluaFx(xi-3*h)) / (8*(h*h*h));
                }

            }

            return 0;
        }

        public double CuartaDerivada(string Fx, int errorGrade, double xi, double h)
        {
            if (errorGrade == 2)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (C.EvaluaFx(xi+2*h)-4*C.EvaluaFx(xi+h)+6*C.EvaluaFx(xi)-4*C.EvaluaFx(xi-h)+C.EvaluaFx(xi-2*h)) / (h*h*h*h);
                }

            }
            else if (errorGrade == 4)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return ((-1)*C.EvaluaFx(xi+3*h)+12*C.EvaluaFx(xi+2*h)+39*(xi+h)+56*C.EvaluaFx(xi)-39*C.EvaluaFx(xi-h)+12*C.EvaluaFx(xi-2*h)+C.EvaluaFx(xi-3*h)) / (6*(h*h*h*h));
                }

            }

            return 0;
        }
    }

    public class Hacia_atras
    {
        Calculo C = new Calculo();

        public double PrimeraDerivada(string Fx, int errorGrade, double xi, double h)
        {

            if (errorGrade == 1)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (C.EvaluaFx(xi)-C.EvaluaFx(xi-h)) / (h);
                }

            }
            else if (errorGrade == 2)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (3*C.EvaluaFx(xi)-4*C.EvaluaFx(xi-h)+C.EvaluaFx(xi-2*h)) / (2*h);
                }

            }

            return 0;
        }

        public double SegundaDerivada(string Fx, int errorGrade, double xi, double h)
        {
            if (errorGrade == 1)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (C.EvaluaFx(xi)-2*C.EvaluaFx(xi-h)+C.EvaluaFx(xi-2*h)) / (h*h);
                }

            }
            else if (errorGrade == 2)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (2*C.EvaluaFx(xi)-5*C.EvaluaFx(xi-h)+4*C.EvaluaFx(xi-2*h)-C.EvaluaFx(xi-3*h)) / (h*h);
                }

            }

            return 0;
        }

        public double TerceraDerivada(string Fx, int errorGrade, double xi, double h)
        {
            if (errorGrade == 1)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (C.EvaluaFx(xi)-3*C.EvaluaFx(xi-h)+3*C.EvaluaFx(xi-2*h)-C.EvaluaFx(xi-3*h)) / (2*(h*h*h));
                }

            }
            else if (errorGrade == 2)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (5*C.EvaluaFx(xi)-18*C.EvaluaFx(xi-h)+24*C.EvaluaFx(xi-2*h)-14*C.EvaluaFx(xi-3*h)+3*C.EvaluaFx(xi-4*h)) / (2*(h*h*h));
                }

            }

            return 0;
        }

        public double CuartaDerivada(string Fx, int errorGrade, double xi, double h)
        {
            if (errorGrade == 1)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (C.EvaluaFx(xi)-4*C.EvaluaFx(xi-h)+6*C.EvaluaFx(xi-2*h)-4*C.EvaluaFx(xi-3*h)+C.EvaluaFx(xi-4*h)) / (h*h*h*h);
                }

            }
            else if (errorGrade == 2)
            {
                if (C.Sintaxis(Fx, 'x') == true)
                {
                    return (3*C.EvaluaFx(xi)-14*C.EvaluaFx(xi-h)+26*C.EvaluaFx(xi-2*h)-24*C.EvaluaFx(xi-3*h)+11*C.EvaluaFx(xi-4*h)-2*C.EvaluaFx(xi-5*h)     ) / (h*h*h*h);
                }

            }

            return 0;
        }
    }
}
