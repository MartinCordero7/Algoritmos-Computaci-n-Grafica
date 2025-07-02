using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo_DDA
{
    public partial class FrmFloodFill : Form
    {
        private Bitmap canvas;
        private FloodFill floodFill = new FloodFill();
        private Graphics g;
        private Color rellenoColor = Color.LightBlue;
        private Color bordeColor = Color.Black;

        private int userX, userY, userRadio;

        public FrmFloodFill()
        {
            InitializeComponent();
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            g = Graphics.FromImage(canvas);
            picCanvas.Image = canvas;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtX.Text, out userX) ||
                !int.TryParse(txtY.Text, out userY) ||
                !int.TryParse(txtRadio.Text, out userRadio))
            {
                MessageBox.Show("Ingrese valores válidos para X, Y y Radio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userRadio <= 0)
            {
                MessageBox.Show("El radio debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DibujarRombo(userX, userY, userRadio);
        }

        private void DibujarRombo(int x, int y, int radio)
        {
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            g = Graphics.FromImage(canvas);

            // Convertir a coordenadas de pantalla (centro en pantalla)
            int origenX = picCanvas.Width / 2;
            int origenY = picCanvas.Height / 2;

            int centroX = origenX + x;
            int centroY = origenY - y;

            Point[] puntos = new Point[]
            {
                new Point(centroX, centroY - radio), // Arriba
                new Point(centroX + radio, centroY), // Derecha
                new Point(centroX, centroY + radio), // Abajo
                new Point(centroX - radio, centroY)  // Izquierda
            };

            g.Clear(Color.White);
            g.DrawPolygon(new Pen(bordeColor, 2), puntos);
            picCanvas.Image = canvas;
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtX.Text, out userX) ||
                !int.TryParse(txtY.Text, out userY) ||
                !int.TryParse(txtRadio.Text, out userRadio))
            {
                MessageBox.Show("Ingrese valores válidos antes de pintar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lstPixeles.Items.Clear();

            int origenX = picCanvas.Width / 2;
            int origenY = picCanvas.Height / 2;
            int px = origenX + userX;
            int py = origenY - userY;

            Color targetColor = canvas.GetPixel(px, py);

            floodFill.Fill(canvas, new Point(px, py), targetColor, rellenoColor, picCanvas, lstPixeles, 5);
            picCanvas.Image = canvas;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtRadio.Clear();
            lstPixeles.Items.Clear();
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            g = Graphics.FromImage(canvas);
            g.Clear(Color.White);
            picCanvas.Image = canvas;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
