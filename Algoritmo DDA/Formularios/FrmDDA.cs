using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoDDA
{
    public partial class FrmDDA : Form
    {
        private AlgoritmoDDA algoritmoDDA = new AlgoritmoDDA();

        public FrmDDA()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            algoritmoDDA.LeerCoordenas(txtXi, txtYi, txtXf, txtYf, picCanvas, lstPixeles);
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            algoritmoDDA.DibujarPlanoCartesiano(e.Graphics, picCanvas);
            algoritmoDDA.DibujarLineaDDA(e.Graphics, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtXi.Clear();
            txtYi.Clear();
            txtXf.Clear();
            txtYf.Clear();
            lstPixeles.Items.Clear();
            algoritmoDDA.Reset();
            picCanvas.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
