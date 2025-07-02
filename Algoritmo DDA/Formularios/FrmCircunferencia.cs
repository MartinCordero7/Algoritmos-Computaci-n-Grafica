using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algoritmo_DDA;

namespace AlgoritmoCircunferencia
{
    public partial class FrmCircunferencia : Form
    {
        private Bitmap canvas;
        AlgoritmoCircunferencia AlgoritmoCircunferencia = new AlgoritmoCircunferencia();
        private Timer animacionTimer = new Timer();
        private List<Point> puntosCircunferencia = new List<Point>();
        private int indiceAnimacion = 0;

        public FrmCircunferencia()
        {
            InitializeComponent();
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = canvas;

            animacionTimer.Interval = 30;
            animacionTimer.Tick += AnimacionTimer_Tick;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstPixeles.Items.Clear();
            AlgoritmoCircunferencia.LeerCoordenas(txtX, txtY, txtRadio, picCanvas);

            Task.Delay(100).ContinueWith(_ =>
            {
                puntosCircunferencia = new List<Point>(AlgoritmoCircunferencia.pixelesEncendidos);
                indiceAnimacion = 0;

                using (Graphics g = Graphics.FromImage(picCanvas.Image))
                {
                    g.Clear(Color.White);
                    AlgoritmoCircunferencia.DibujarPlanoCartesiano(g, picCanvas);
                }

                animacionTimer.Start();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void AnimacionTimer_Tick(object sender, EventArgs e)
        {
            if (indiceAnimacion >= puntosCircunferencia.Count)
            {
                animacionTimer.Stop();
                return;
            }

            using (Graphics g = Graphics.FromImage(picCanvas.Image))
            {
                SolidBrush brush = new SolidBrush(Color.Red);
                Point p = puntosCircunferencia[indiceAnimacion];
                g.FillRectangle(brush, p.X, p.Y, 2, 2);
                lstPixeles.Items.Add($"({p.X}, {p.Y})");
            }

            picCanvas.Invalidate();
            indiceAnimacion++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtRadio.Clear();
            lstPixeles.Items.Clear();

            AlgoritmoCircunferencia.Reset();
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = canvas;
            picCanvas.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            AlgoritmoCircunferencia.DibujarPlanoCartesiano(e.Graphics, picCanvas);
            AlgoritmoCircunferencia.DibujarCircunferencia(e.Graphics, picCanvas);
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            // Puedes usar esto si quieres rellenar luego con FloodFill, etc.
        }
    }
}


