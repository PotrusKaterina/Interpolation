using MyApp.Data;
using MyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.ModelLogic
{
    public interface IGraphicsLogic
    {
        double GetValue(double x, int functionIndex, string coefficients);
        double GetLagrangeInterpolation(double x, IEnumerable<Point> points);
        double GetNewtonInterpolation(double x, IEnumerable<Point> points, double step);
    }
}
