using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoritmoDDA;

namespace Bresenham
{
    public partial class FrmBresenham : Form
    {
        private Bresenham algoritmoBresenham = new Bresenham();

        public FrmBresenham()
        {
            InitializeComponent();
        }

        private void FrmBresenham_Load(object sender, EventArgs e) { }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            algoritmoBresenham.LeerCoordenas(txtXi, txtYi, txtXf, txtYf, picCanvas, lstPixeles);
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            algoritmoBresenham.DibujarPlanoCartesiano(e.Graphics, picCanvas);
            algoritmoBresenham.DibujarLineaBresenham(e.Graphics, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtXi.Clear();
            txtYi.Clear();
            txtXf.Clear();
            txtYf.Clear();
            lstPixeles.Items.Clear();
            algoritmoBresenham.Reset();
            picCanvas.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
