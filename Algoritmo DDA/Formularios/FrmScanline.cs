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
    public partial class FrmScanline : Form
    {
        private PerformanceMonitor performanceMonitor;
        private List<Point> polygon;
        private Bitmap canvas;
        public FrmScanline()
        {
            InitializeComponent();
            canvas = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
            polygon = new List<Point>();
            pictureBoxCanvas.Image = canvas;
            DrawGrid(); // Dibujar la cuadrícula al iniciar
            performanceMonitor = new PerformanceMonitor();
        }

        private void DrawGrid()
        {
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White); // Fondo blanco

                int cellSize = 50; // Tamaño de cada celda
                int rows = pictureBoxCanvas.Height / cellSize; // Número de filas
                int cols = pictureBoxCanvas.Width / cellSize;  // Número de columnas

                // Dibujar líneas verticales
                for (int x = 0; x <= pictureBoxCanvas.Width; x += cellSize)
                {
                    g.DrawLine(Pens.LightGray, x, 0, x, pictureBoxCanvas.Height);
                }

                // Dibujar líneas horizontales
                for (int y = 0; y <= pictureBoxCanvas.Height; y += cellSize)
                {
                    g.DrawLine(Pens.LightGray, 0, y, pictureBoxCanvas.Width, y);
                }

                // Dibujar ejes de coordenadas
                g.DrawLine(Pens.Black, 0, 0, 0, pictureBoxCanvas.Height); // Eje Y
                g.DrawLine(Pens.Black, 0, pictureBoxCanvas.Height - 1, pictureBoxCanvas.Width, pictureBoxCanvas.Height - 1); // Eje X

                // Dibujar etiquetas de coordenadas en el eje X (comienza desde 0)
                for (int x = 0; x <= cols; x++)
                {
                    g.DrawString(x.ToString(), new Font("Arial", 8), Brushes.Black, x * cellSize + 5, pictureBoxCanvas.Height - 20);
                }

                // Dibujar etiquetas de coordenadas en el eje Y (comienza desde 0)
                for (int y = 0; y <= rows; y++)
                {
                    g.DrawString(y.ToString(), new Font("Arial", 8), Brushes.Black, 5, pictureBoxCanvas.Height - y * cellSize - 20);
                }
            }

            pictureBoxCanvas.Refresh(); // Actualizar la vista
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (polygon.Count < 3) return;

            int cellSize = 50; // Tamaño de cada celda

            using (Graphics g = Graphics.FromImage(canvas))
            {
                Relleno fillAlgorithm = new Relleno(pictureBoxCanvas.ClientSize);
                List<Point> paintedPixels = fillAlgorithm.FillPolygon(g, polygon, Color.Blue);

                // Usar un HashSet para evitar duplicados
                HashSet<string> uniquePixels = new HashSet<string>();

                // Mostrar los píxeles ajustados a la cuadrícula en el ListBox
                listBoxPixels.Items.Clear();
                foreach (var pixel in paintedPixels)
                {
                    int gridX = (pixel.X / cellSize) + 1; // Ajustar el eje X para comenzar desde 1
                    int gridY = (pictureBoxCanvas.Height - pixel.Y) / cellSize; // Ajustar el eje Y para invertir y comenzar desde 1
                    string coordinate = $"({gridX}, {gridY})";

                    if (!uniquePixels.Contains(coordinate)) // Verificar si ya está agregado
                    {
                        uniquePixels.Add(coordinate);
                        listBoxPixels.Items.Add(coordinate);
                    }
                }
                Relleno relleno = new Relleno(pictureBoxCanvas.ClientSize);
                performanceMonitor.MeasureAlgorithm(
                    () => relleno.FillPolygon(pictureBoxCanvas.CreateGraphics(), polygon, Color.Blue),
                    "Scanline Fill",
                    "Algoritmo de Relleno"
                );
            }

            pictureBoxCanvas.Refresh();
        }

        private void pictureBoxCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            int cellSize = 50; // Tamaño de cada celda (debe coincidir con el de DrawGrid)

            // Ajustar las coordenadas al centro de la celda más cercana
            int adjustedX = (e.X / cellSize) * cellSize + cellSize / 2;
            int adjustedY = (e.Y / cellSize) * cellSize + cellSize / 2;

            using (Graphics g = Graphics.FromImage(canvas))
            {
                if (polygon.Count > 0)
                {
                    g.DrawLine(Pens.Black, polygon[polygon.Count - 1], new Point(adjustedX, adjustedY));
                }
                polygon.Add(new Point(adjustedX, adjustedY));
                g.FillEllipse(Brushes.Red, adjustedX - 2, adjustedY - 2, 4, 4);
            }

            pictureBoxCanvas.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Limpiar la lista de puntos del polígono
            polygon.Clear();

            // Reiniciar el lienzo a blanco y volver a dibujar la cuadrícula
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
            }
            DrawGrid();

            // Limpiar el ListBox de píxeles
            listBoxPixels.Items.Clear();

            // Refrescar la vista para mostrar los cambios
            pictureBoxCanvas.Refresh();
        }
    }
}
