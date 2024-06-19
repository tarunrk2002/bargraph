using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace bargraph
{
    public partial class Form1 : Form
    {
        List<double> x = new List<double>();
        List<double> y = new List<double>();
        public Form1()
        {
            x.Add(0);
            y.Add(1);

            x.Add(1);
            y.Add(3);

            x.Add(10);
            y.Add(3.5);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.DataBindXY(x, y);
        }
    }
}
