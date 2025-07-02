using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoritmoDDA
{
    internal class AlgoritmoDDA
    {
        private float xInicial, yInicial, xFinal, yFinal;
        private bool graficarLinea = false;
        private int SF = 20;

        private List<Point> pixelesEncendidos = new List<Point>();
        private Timer timer;
        private int pasoActual = 0;
        private PictureBox canvas;
        private ListBox listaPixeles;
        private Graphics graficos;

        public void SetCoordenadas(float xi, float yi, float xf, float yf, int escala = 20)
        {
            xInicial = xi;
            yInicial = yi;
            xFinal = xf;
            yFinal = yf;
            SF = escala;
            graficarLinea = true;
        }

        public void LeerCoordenas(TextBox txtXi, TextBox txtYi, TextBox txtXf, TextBox txtYf, PictureBox picCanvas, ListBox lstPixeles)
        {
            try
            {
                float xi = float.Parse(txtXi.Text);
                float yi = float.Parse(txtYi.Text);
                float xf = float.Parse(txtXf.Text);
                float yf = float.Parse(txtYf.Text);

                SetCoordenadas(xi, yi, xf, yf, 10);
                lstPixeles.Items.Clear();
                pixelesEncendidos.Clear();

                float dx = xf - xi;
                float dy = yf - yi;
                float pasos = Math.Max(Math.Abs(dx), Math.Abs(dy));
                float xInc = dx / pasos;
                float yInc = dy / pasos;

                float x = xi;
                float y = yi;

                for (int i = 0; i <= pasos; i++)
                {
                    int px = (int)(x * SF);
                    int py = (int)(y * SF);
                    pixelesEncendidos.Add(new Point(px, py));
                    lstPixeles.Items.Add($"({Math.Round(x, 2)}, {Math.Round(y, 2)})");
                    x += xInc;
                    y += yInc;
                }

                pasoActual = 0;
                canvas = picCanvas;
                listaPixeles = lstPixeles;
                graficarLinea = true;

                graficos = picCanvas.CreateGraphics();

                if (timer != null)
                {
                    timer.Stop();
                    timer.Dispose();
                }

                timer = new Timer();
                timer.Interval = 50; // Velocidad de animación
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pasoActual >= pixelesEncendidos.Count)
            {
                timer.Stop();
                timer.Dispose();

                DibujarLineaFinal(graficos);
                return;
            }

            int origenX = 0;
            int origenY = canvas.Height;

            Point p = pixelesEncendidos[pasoActual];
            int x = origenX + p.X;
            int y = origenY - p.Y;

            graficos.FillRectangle(Brushes.MediumVioletRed, x, y, 3, 3);
            pasoActual++;
        }
        private void DibujarLineaFinal(Graphics g)
        {
            int origenX = 0;
            int origenY = canvas.Height;

            for (int i = 0; i < pixelesEncendidos.Count - 1; i++)
            {
                Point p1 = pixelesEncendidos[i];
                Point p2 = pixelesEncendidos[i + 1];

                int x1 = origenX + p1.X;
                int y1 = origenY - p1.Y;
                int x2 = origenX + p2.X;
                int y2 = origenY - p2.Y;

                g.DrawLine(Pens.MediumVioletRed, x1, y1, x2, y2);
            }
        }


        public void DibujarPlanoCartesiano(Graphics g, PictureBox picCanvas)
        {
            int origenX = 0;
            int origenY = picCanvas.Height;

            Pen penPlano = new Pen(Color.Gray, 1);
            g.DrawLine(penPlano, origenX, origenY - 1, picCanvas.Width, origenY - 1);
            g.DrawLine(penPlano, origenX, 0, origenX, origenY);

            for (int i = 0; i <= picCanvas.Width; i += SF)
                g.DrawLine(penPlano, i, origenY - 3, i, origenY + 3);

            for (int i = 0; i <= picCanvas.Height; i += SF)
                g.DrawLine(penPlano, origenX - 3, origenY - i, origenX + 3, origenY - i);
        }

        public void DibujarLineaDDA(Graphics g, PictureBox picCanvas)
        {
            // Ya no se dibuja aquí, porque se anima en Timer_Tick.
        }

        public void Reset()
        {
            graficarLinea = false;
            pixelesEncendidos.Clear();
            pasoActual = 0;

            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
        }
    }
}
