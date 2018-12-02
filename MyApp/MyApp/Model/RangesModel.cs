using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Model
{
    class RangesModel
    {
        public double MinX { get; set; }
        public double MaxX { get; set; }
        public double Step { get; set; }

        public RangesModel(double minX, double maxX, double step)
        {
            this.MinX = minX;
            this.MaxX = maxX;
            this.Step = step;
        }
    }
}
