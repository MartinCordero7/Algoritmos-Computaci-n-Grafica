using Algoritmo_DDA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo_DDA.Formularios
{
    public partial class FrmBezierLineal : Form
    {
        private Lineal bezierLineal;
        private Timer animationTimer;
        public FrmBezierLineal()
        {
            InitializeComponent();
            bezierLineal = new Lineal();
            animationTimer = new Timer
            {
                Interval = 20
            };
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {


        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            bezierLineal.Draw(e.Graphics);
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (bezierLineal.AddOrResetPoint(e.Location))
            {
                StartAnimation();
            }
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            bezierLineal.ClearSelectedPoint();
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            bezierLineal.SelectPointAtLocation(e.Location);
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && bezierLineal.UpdateSelectedPoint(e.Location))
            {
                picCanvas.Invalidate();
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (bezierLineal.UpdateAnimation())
            {
                animationTimer.Stop();
            }
            picCanvas.Invalidate();
        }

        private void StartAnimation()
        {
            bezierLineal.ResetAnimation();
            animationTimer.Start();
        }
    }
}
