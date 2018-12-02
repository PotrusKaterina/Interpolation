using MyApp.Data;
using MyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.ModelLogic
{
    class GraphicsLogic : IGraphicsLogic
    {
        private double GetValuesByFunction(double x, Functions func, string coefficients)
        {
            switch(func)
            {
                case Functions.Sin:
                    {
                        return GetSin(x);
                    }
                case Functions.Cos:
                    {
                        return GetCos(x);
                    }
                case Functions.Palinom:
                    {
                        return GetPalinom(x, coefficients);
                    }
                default: return 0;
            }
        }

        private double GradToRad(double grad)
        {
            return grad * (Math.PI / 180);
        }

        private double GetSin(double x)
        {
            return Math.Sin(GradToRad(x));
        }

        private double GetCos(double x)
        {
            return Math.Cos(GradToRad(x));
        }

        private double GetPalinom(double x, string coefficients)
        {
            var coefficientArray = coefficients.Split('\n');
            double result = 0;
            for(int i = 0; i < coefficientArray.Length; i++)
            {
                result += Double.Parse(coefficientArray[i]) * Math.Pow(x, coefficientArray.Length - i - 1);
            }
            return result;
        }

        public double GetValue(double x, int functionIndex, string coefficients)
        {
            return GetValuesByFunction(x, (Functions)functionIndex, coefficients);
        }

        public double GetLagrangeInterpolation(double x, IEnumerable<Point> points)
        {
            double result = 0;

            for(int i = 0; i < points.Count(); i++)
            {
                double res = 1;
                Point pointAtI = points.ElementAt(i);
                for(int j = 0; j < points.Count(); j++)
                {                   
                    if (i != j)
                    {
                        Point pointAtJ = points.ElementAt(j);
                        res *= (x - pointAtJ.X) / (pointAtI.X - pointAtJ.X);
                    }
                }
                result += res * pointAtI.Y;
            }

            return result;
        }

        public double GetNewtonInterpolation(double x, IEnumerable<Point> points, double step)
        {
            int n = points.Count();
            double[,] mas = new double[n + 2, n + 1];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0)
                        mas[i, j] = points.ElementAt(j).X;
                    else if (i == 1)
                        mas[i, j] = points.ElementAt(j).Y;
                }
            }
            int m = n;
            for (int i = 2; i < n + 2; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = mas[i - 1, j + 1] - mas[i - 1, j];
                }
                m--;
            }

            double[] dy0 = new double[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                dy0[i] = mas[i + 1, 0];
            }

            double res = dy0[0];
            double[] xn = new double[n];
            xn[0] = x - mas[0, 0];

            for (int i = 1; i < n; i++)
            {
                double ans = xn[i - 1] * (x - mas[0, i]);
                xn[i] = ans;
                ans = 0;
            }

            int m1 = n + 1;
            int fact = 1;
            for (int i = 1; i < m1; i++)
            {
                fact = fact * i;
                res = res + (dy0[i] * xn[i - 1]) / (fact * Math.Pow(step, i));
            }

            return res;
        }

        public double GetMNK(double x, IEnumerable<Point> points, double step)
        {
            double sum = 0; int m = points.Count();
            double[,] mas = new double[m, m + 1];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas [i,j] = 0;    
                    for (int k = 0; k <= m; k++)
                    {
                        mas[i,j] += Math.Pow( points.ElementAt(k).X, i + j);//arr
                    }
                }
                mas[i,m] = 0;        
                for (int k = 0; k <= m; k++)
                {
                    mas [i,m] += Math.Pow(points.ElementAt(k).X, i) * points.ElementAt(k).Y;//arr
                }
            }
            double [] C = slau_zeidel(mas, m); //slau
            for (int i = 0; i < m; i++) sum += C[i] * Math.Pow(x, i);
            return sum;
        }
    }
}
