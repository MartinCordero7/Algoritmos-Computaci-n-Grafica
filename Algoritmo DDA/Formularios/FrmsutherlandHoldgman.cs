using Algoritmo_DDA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo_DDA.Formularios
{
    public partial class FrmsutherlandHoldgman : Form
    {
        private List<Point> originalPolygon;
        private List<Point> clippedPolygon;
        private Rectangle clipRect;

        public FrmsutherlandHoldgman()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            originalPolygon = new List<Point>();
            clippedPolygon = null;

            clipRect = new Rectangle(100, 100, 200, 200); // Puedes cambiarlo dinámicamente si deseas

            dgwPixels.ColumnCount = 2;
            dgwPixels.Columns[0].Name = "X";
            dgwPixels.Columns[1].Name = "Y";
            dgwPixels.Rows.Clear();

            PicCanvas.Paint += PicCanvas_Paint;
            PicCanvas.MouseClick += PicCanvas_MouseClick;
            BtnCut.Click += BtnCut_Click;
            BtnReset.Click += BtnReset_Click;
        }

        private void PicCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (clippedPolygon == null)
            {
                originalPolygon.Add(e.Location);
                PicCanvas.Invalidate();
            }
        }

        private void BtnCut_Click(object sender, EventArgs e)
        {
            if (originalPolygon.Count < 3)
            {
                MessageBox.Show("Dibuja al menos 3 puntos para formar un polígono.");
                return;
            }

            var clipper = new CliperSH(clipRect);
            clippedPolygon = clipper.ClipPolygon(originalPolygon);

            dgwPixels.Rows.Clear();
            foreach (var p in clippedPolygon)
            {
                dgwPixels.Rows.Add(p.X, p.Y);
            }

            PicCanvas.Invalidate();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            originalPolygon.Clear();
            clippedPolygon = null;
            dgwPixels.Rows.Clear();
            PicCanvas.Invalidate();
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen rectPen = new Pen(Color.Green, 2);
            g.DrawRectangle(rectPen, clipRect);

            if (originalPolygon.Count > 1)
            {
                Pen polyPen = new Pen(Color.Blue, 2);
                g.DrawPolygon(polyPen, originalPolygon.ToArray());
                foreach (Point p in originalPolygon)
                    g.FillEllipse(Brushes.Black, p.X - 2, p.Y - 2, 4, 4);
            }

            if (clippedPolygon != null && clippedPolygon.Count > 1)
            {
                Pen clippedPen = new Pen(Color.Red, 2);
                g.DrawPolygon(clippedPen, clippedPolygon.ToArray());
                foreach (Point p in clippedPolygon)
                    g.FillEllipse(Brushes.Red, p.X - 2, p.Y - 2, 4, 4);
            }
        }
    }
}

