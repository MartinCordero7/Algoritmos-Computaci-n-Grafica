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
    public partial class FrmBezierCubico : Form
    {
        private Cubica bezierCubic;
        private Timer animationTimer;

        public FrmBezierCubico()
        {
            InitializeComponent();
            bezierCubic = new Cubica();
            animationTimer = new Timer
            {
                Interval = 20
            };
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (bezierCubic.AddOrResetPoint(e.Location))
            {
                StartAnimation();
            }
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            bezierCubic.SelectPointAtLocation(e.Location);
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && bezierCubic.UpdateSelectedPoint(e.Location))
            {
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            bezierCubic.ClearSelectedPoint();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            bezierCubic.Draw(e.Graphics);
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (bezierCubic.UpdateAnimation())
            {
                animationTimer.Stop();
            }
            picCanvas.Invalidate();
        }

        private void StartAnimation()
        {
            bezierCubic.ResetAnimation();
            animationTimer.Start();
        }
    }
}
