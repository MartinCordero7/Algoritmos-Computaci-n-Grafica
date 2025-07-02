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
    public partial class FrmbSplines : Form
    {
        private BSplines bspline = new BSplines();
        private bool isDragging = false;
        private Point currentMouse = Point.Empty;
        private bool isAnimating = false;
        private List<PointF> animatedCurve = new List<PointF>();

        public FrmbSplines()
        {
            InitializeComponent();
            picCanvas.BackColor = Color.White;

        }

        private async void PicCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bspline.AddPoint(e.Location);
                animatedCurve.Clear();
                picCanvas.Invalidate();

                if (bspline.ControlPoints.Count >= 4 && !isAnimating)
                    await AnimateBSplineAsync();
            }
            else if (e.Button == MouseButtons.Right)
            {
                bspline.ClearPoints();
                animatedCurve.Clear();
                picCanvas.Invalidate();
            }
        }

        private async Task AnimateBSplineAsync()
        {
            isAnimating = true;
            animatedCurve.Clear();
            var curve = bspline.GenerateBSplinePoints(100);

            foreach (var pt in curve)
            {
                animatedCurve.Add(pt);
                picCanvas.Invalidate();
                await Task.Delay(10); // Velocidad de la animación
            }

            isAnimating = false;
        }

        private void PicCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void PicCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void PicCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            currentMouse = e.Location;
            if (isDragging)
                picCanvas.Invalidate();
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var controlPoints = bspline.ControlPoints;

            // Líneas entre puntos de control
            if (controlPoints.Count > 1)
            {
                using (Pen pen = new Pen(Color.Gray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
                {
                    g.DrawLines(pen, controlPoints.ToArray());
                }
            }

            // Puntos de control
            foreach (var p in controlPoints)
            {
                g.FillEllipse(Brushes.Red, p.X - 3, p.Y - 3, 6, 6);
            }

            // Curva animada
            if (animatedCurve.Count > 1)
            {
                using (Pen pen = new Pen(Color.Blue, 2))
                {
                    g.DrawLines(pen, animatedCurve.ToArray());
                }
            }

            // Si no se está animando, dibuja la curva completa de inmediato
            if (!isAnimating && controlPoints.Count >= 4)
            {
                var curve = bspline.GenerateBSplinePoints(100);
                if (curve.Count > 1)
                {
                    using (Pen pen = new Pen(Color.Blue, 2))
                    {
                        g.DrawLines(pen, curve.ToArray());
                    }
                }
            }

            // Punto de seguimiento del mouse
            if (isDragging)
            {
                g.FillEllipse(Brushes.Green, currentMouse.X - 3, currentMouse.Y - 3, 6, 6);
            }


        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            bspline.ClearPoints();
            animatedCurve.Clear();
            isAnimating = false;
            picCanvas.Invalidate();
        }
    }
}
