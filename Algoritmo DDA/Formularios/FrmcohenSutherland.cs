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
    public partial class FrmcohenSutherland : Form
    {
        private cohenSutherland Cohen;
        private bool isDrawing = false;
        private Point startPoint;
        private Point currentPoint;
        public FrmcohenSutherland()
        {
            InitializeComponent();
            Cohen = new cohenSutherland(PicCanvas.ClientSize);
            SetupDataGridView();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            PicCanvas.Image = null;
            PicCanvas.Invalidate();
            Cohen = new cohenSutherland(PicCanvas.ClientSize);
            dgwPixels.Rows.Clear();
            isDrawing = false;
        }

        private void BtnCut_Click(object sender, EventArgs e)
        {
            Cohen.ClipLines();
            PicCanvas.Invalidate();
            PopulateDataGridView();
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            // Dibujar región de recorte
            using (Pen clipPen = new Pen(Color.Red, 1))
            {
                g.DrawRectangle(clipPen, Cohen.GetClipRegion());
            }

            // Dibujar las líneas almacenadas
            Cohen.Draw(g);

            // Dibujar la cuadrícula
            Cohen.DrawGrid(g, PicCanvas.ClientSize);

            // Dibujar la línea de vista previa
            if (isDrawing)
            {
                using (Pen previewPen = new Pen(Color.Gray, 1))
                {
                    g.DrawLine(previewPen, startPoint, currentPoint);
                }
            }
        }

        private void PicCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                Cohen.AddLine(startPoint, e.Location); // Agrega la línea a la lista
                PicCanvas.Invalidate();
            }
        }

        private void PicCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentPoint = e.Location;
                PicCanvas.Invalidate();
            }
        }

        private void PicCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
                currentPoint = e.Location;

            }
            if (e.Button == MouseButtons.Right)
            {

                if (Cohen.RemoveExternalSegmentsAtPoint(e.Location))
                {
                    PicCanvas.Invalidate();
                }
            }
        }

        private void PopulateDataGridView()
        {
            dgwPixels.Rows.Clear();

            var clippedLines = Cohen.GetClippedLineSegments();
            foreach (var line in clippedLines)
            {
                if (!line.start.IsEmpty && !line.end.IsEmpty)
                {
                    // Convertir las coordenadas a binario
                    string startBinary = $"({Convert.ToString(line.start.X, 2)}, {Convert.ToString(line.start.Y, 2)})";
                    string endBinary = $"({Convert.ToString(line.end.X, 2)}, {Convert.ToString(line.end.Y, 2)})";

                    dgwPixels.Rows.Add(
                        $"({line.start.X}, {line.start.Y})",
                        $"({line.end.X}, {line.end.Y})",
                        $"Inicio: {startBinary}, Fin: {endBinary}"
                    );
                }
            }
        }

        private void SetupDataGridView()
        {
            dgwPixels.Columns.Clear();
            dgwPixels.Columns.Add("StartPoint", "Punto Inicial");
            dgwPixels.Columns.Add("EndPoint", "Punto Final");
            dgwPixels.Columns.Add("BinaryValue", "Valor Binario");
            dgwPixels.AllowUserToAddRows = false;
        }
    }
}

