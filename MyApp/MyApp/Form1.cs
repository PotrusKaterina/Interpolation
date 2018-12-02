using MyApp.Controller;
using MyApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form1 : Form
    {
        private const string originalFunction = "Original function";
        private const string laGrange = "LaGrange";
        private const string newton = "Newtone";
        private GraphicsController graphicsController;
        public Form1()
        {
            InitializeComponent();
            graphicsController = new GraphicsController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                chart1.Series.Clear();
                chart1.Series.Add(originalFunction);
                chart1.Series[originalFunction].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series.Add(laGrange);
                chart1.Series[laGrange].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                RangesModel ranges = GetRanges();
                var interpolationPoints = graphicsController
                                    .GetLangrangeInterpolationPoints(ranges,
                                                    GetPointsAndDrawOriginalFunction(ranges));
                foreach (Model.Point point in interpolationPoints)
                {
                    chart1.Series[laGrange].Points.AddXY(point.X, point.Y);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Inalid input");
            }
        }

        private IEnumerable<Model.Point> GetPointsAndDrawOriginalFunction(RangesModel ranges)
        {
            int selectedFuntion = comboBoxFunctions.SelectedIndex;
            string coefficients = textCoefficients.Text;
            var points = graphicsController.GetPoints(ranges, selectedFuntion, coefficients);
            foreach (Model.Point point in points)
            {
                chart1.Series[originalFunction].Points.AddXY(point.X, point.Y);
            }
            return points;
        }

        private RangesModel GetRanges()
        {
            double minX = Double.Parse(textMinX.Text);
            double maxX = Double.Parse(textMaxX.Text);
            if (minX >= maxX) throw new Exception();
            double step = Double.Parse(textStep.Text);
            if (step >= maxX - minX) throw new Exception();
            if (step <= 0) throw new Exception();

            return new RangesModel(minX, maxX, step);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Add(originalFunction);
            chart1.Series[originalFunction].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = comboBoxFunctions.SelectedIndex;
            if (SelectedIndex == 2)
            {
                textCoefficients.Visible = true;
                labelCoefficients.Visible = true;
            }
            else
            {
                textCoefficients.Clear();
                textCoefficients.Visible = false;
                labelCoefficients.Visible = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMaxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series.Clear();
                chart1.Series.Add(originalFunction);
                chart1.Series[originalFunction].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series.Add(newton);
                chart1.Series[newton].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                RangesModel ranges = GetRanges();
                var interpolationPoints = graphicsController
                                    .GetNewtonInterpolationPoints(ranges,
                                                    GetPointsAndDrawOriginalFunction(ranges));
                foreach (Model.Point point in interpolationPoints)
                {
                    chart1.Series[newton].Points.AddXY(point.X, point.Y);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Inalid input");
            }
        }
    }
}
