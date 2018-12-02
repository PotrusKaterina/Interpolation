using MyApp.Model;
using MyApp.ModelLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Controller
{
    class GraphicsController
    {
        IGraphicsLogic graphicsLogic;
        public GraphicsController()
        {
            graphicsLogic = new GraphicsLogic();
        }    

        public IEnumerable<Point> GetPoints(RangesModel ranges, int functionIndex, string coefficients)
        {
            IList<Point> points = new List<Point>();
            for(double i = ranges.MinX; i <= ranges.MaxX; i+=ranges.Step)
            {
                points.Add(new Point(i, graphicsLogic.GetValue(i, functionIndex, coefficients)));
            }
            return points;
        }

        public IEnumerable<Point> GetLangrangeInterpolationPoints(RangesModel ranges, IEnumerable<Point> points)
        {
            IList<Point> resultPoints = new List<Point>();
            for (double i = ranges.MinX; i <= ranges.MaxX; i += ranges.Step*2)
            {
                double y = graphicsLogic.GetLagrangeInterpolation(i, points);
                resultPoints.Add(new Point(i, y));
            }
            return resultPoints;
        }

        public IEnumerable<Point> GetNewtonInterpolationPoints(RangesModel ranges, IEnumerable<Point> points)
        {
            IList<Point> resultPoints = new List<Point>();
            for (double i = ranges.MinX; i <= ranges.MaxX; i += ranges.Step * 2)
            {
                double y = graphicsLogic.GetNewtonInterpolation(i, points, ranges.Step);
                resultPoints.Add(new Point(i, y));
            }
            return resultPoints;
        }
    }
}
