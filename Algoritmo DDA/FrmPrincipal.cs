using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bresenham;
using AlgoritmoDDA;
using AlgoritmoCircunferencia;
using Algoritmo_DDA;
using Algoritmo_DDA.Formularios;

namespace Algoritmos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirUnicaVentana<T>() where T : Form, new()
        {
            foreach (var form in this.MdiChildren)
            {
                form.Close();
            }

            // Crea y muestra una nueva instancia de la ventana
            var nuevaVentana = new T { MdiParent = this };
            nuevaVentana.Show();
        }

        private void SALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmDDA>();
        }

        private void bresenhamLineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana <FrmBresenham>();
        }

        private void bresenhamCircunferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmCircunferencia>();
        }

        private void floodFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmFloodFill>();
        }

        private void scanLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmScanline>();
        }

        private void linealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmBezierLineal>();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmBezierCurvasCuadraticas>();
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmBezierCubico>();
        }

        private void cohenSutherlandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmcohenSutherland>();
        }

        private void sutherlandHodgmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmsutherlandHoldgman>();
        }

        private void bSplinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmbSplines>();
        }

        private void bresenhamElipsesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmBresenhamElipses>();
        }
    }
}
