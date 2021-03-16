using System.Drawing;
using System.Drawing.Imaging;
using ZedGraph;

namespace PointGraph
{
    /// <summary>
    /// Class for creating a graph by points
    /// </summary>
    class DotPlot
    {
        public DotPlot(double[] ax, double[] ay)
        {
            this.ax = ax;
            this.ay = ay;
        }
        private double[] ax;
        private double[] ay;
        public string FileName { get; set; }
        public void GetGraph()
        {
            GraphPane myPane = new GraphPane();
            myPane.CurveList.Clear();
            PointPairList list = new PointPairList();
            for (int i = 0; i < ax.Length; i++)
            {
                list.Add(ax[i], ay[i]);
            }
            myPane.AddCurve("Sinc", list, Color.Blue, SymbolType.None);
            Bitmap bm = new Bitmap(10, 10);
            Graphics g = Graphics.FromImage(bm);
            myPane.AxisChange(g);
            Image im = myPane.GetImage();
            im.Save($"{FileName}.png", ImageFormat.Png); // save graphic in png format 
        }
    }
}
