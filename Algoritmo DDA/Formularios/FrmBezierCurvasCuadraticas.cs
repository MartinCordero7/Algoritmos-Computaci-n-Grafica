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
    public partial class FrmBezierCurvasCuadraticas : Form
    {
        private Cuadratica bezierCuadratico;
        private Timer animationTimer;
        public FrmBezierCurvasCuadraticas()
        {
            InitializeComponent();
            bezierCuadratico = new Cuadratica();
            animationTimer = new Timer
            {
                Interval = 20
            };
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (bezierCuadratico.AddOrResetPoint(e.Location))
            {
                StartAnimation();
            }
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            bezierCuadratico.SelectPointAtLocation(e.Location);
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            bezierCuadratico.Draw(e.Graphics);
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && bezierCuadratico.UpdateSelectedPoint(e.Location))
            {
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            bezierCuadratico.ClearSelectedPoint();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (bezierCuadratico.UpdateAnimation())
            {
                animationTimer.Stop();
            }
            picCanvas.Invalidate();
        }

        private void StartAnimation()
        {
            bezierCuadratico.ResetAnimation();
            animationTimer.Start();
        }
    }
}
