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
    public partial class FrmBresenhamElipses : Form
    {
        private Bitmap bmp;

        public FrmBresenhamElipses()
        {
            InitializeComponent();
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            lstPixeles.Items.Clear();
            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            Graphics g = Graphics.FromImage(bmp);

            int xc = int.Parse(txtXc.Text);
            int yc = int.Parse(txtYc.Text);
            int rx = int.Parse(txtXr.Text);
            int ry = int.Parse(txtYr.Text);

            var elipse = new BresenhamElipses(
                g,
                bmp,
                punto => picCanvas.Image = bmp,
                pixel => lstPixeles.Items.Add(pixel)
            );

            await elipse.DibujarElipse(xc, yc, rx, ry);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtXc.Clear();
            txtYc.Clear();
            txtXr.Clear();
            txtYr.Clear();
            lstPixeles.Items.Clear();
            picCanvas.Image = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
