namespace Algoritmos
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rasterizacionDeLineasYCurvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamLineasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamCircunferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamElipsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rellenoDeRegionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floodFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorteGeometricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cohenSutherlandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sutherlandHodgmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasBezierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bSplinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rasterizacionDeLineasYCurvasToolStripMenuItem,
            this.rellenoDeRegionesToolStripMenuItem,
            this.recorteGeometricoToolStripMenuItem,
            this.curvasBezierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rasterizacionDeLineasYCurvasToolStripMenuItem
            // 
            this.rasterizacionDeLineasYCurvasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.bresenhamLineasToolStripMenuItem,
            this.bresenhamCircunferenciasToolStripMenuItem,
            this.bresenhamElipsesToolStripMenuItem});
            this.rasterizacionDeLineasYCurvasToolStripMenuItem.Name = "rasterizacionDeLineasYCurvasToolStripMenuItem";
            this.rasterizacionDeLineasYCurvasToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.rasterizacionDeLineasYCurvasToolStripMenuItem.Text = "Rasterizacion de lineas y curvas";
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // bresenhamLineasToolStripMenuItem
            // 
            this.bresenhamLineasToolStripMenuItem.Name = "bresenhamLineasToolStripMenuItem";
            this.bresenhamLineasToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.bresenhamLineasToolStripMenuItem.Text = "Bresenham (Lineas)";
            this.bresenhamLineasToolStripMenuItem.Click += new System.EventHandler(this.bresenhamLineasToolStripMenuItem_Click);
            // 
            // bresenhamCircunferenciasToolStripMenuItem
            // 
            this.bresenhamCircunferenciasToolStripMenuItem.Name = "bresenhamCircunferenciasToolStripMenuItem";
            this.bresenhamCircunferenciasToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.bresenhamCircunferenciasToolStripMenuItem.Text = "Bresenham (Circunferencias)";
            this.bresenhamCircunferenciasToolStripMenuItem.Click += new System.EventHandler(this.bresenhamCircunferenciasToolStripMenuItem_Click);
            // 
            // bresenhamElipsesToolStripMenuItem
            // 
            this.bresenhamElipsesToolStripMenuItem.Name = "bresenhamElipsesToolStripMenuItem";
            this.bresenhamElipsesToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.bresenhamElipsesToolStripMenuItem.Text = "Bresenham (Elipses)";
            this.bresenhamElipsesToolStripMenuItem.Click += new System.EventHandler(this.bresenhamElipsesToolStripMenuItem_Click);
            // 
            // rellenoDeRegionesToolStripMenuItem
            // 
            this.rellenoDeRegionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.floodFillToolStripMenuItem,
            this.scanLineToolStripMenuItem});
            this.rellenoDeRegionesToolStripMenuItem.Name = "rellenoDeRegionesToolStripMenuItem";
            this.rellenoDeRegionesToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.rellenoDeRegionesToolStripMenuItem.Text = "Relleno de Regiones";
            // 
            // floodFillToolStripMenuItem
            // 
            this.floodFillToolStripMenuItem.Name = "floodFillToolStripMenuItem";
            this.floodFillToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.floodFillToolStripMenuItem.Text = "Flood Fill";
            this.floodFillToolStripMenuItem.Click += new System.EventHandler(this.floodFillToolStripMenuItem_Click);
            // 
            // scanLineToolStripMenuItem
            // 
            this.scanLineToolStripMenuItem.Name = "scanLineToolStripMenuItem";
            this.scanLineToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.scanLineToolStripMenuItem.Text = "Scan Line";
            this.scanLineToolStripMenuItem.Click += new System.EventHandler(this.scanLineToolStripMenuItem_Click);
            // 
            // recorteGeometricoToolStripMenuItem
            // 
            this.recorteGeometricoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cohenSutherlandToolStripMenuItem,
            this.sutherlandHodgmanToolStripMenuItem});
            this.recorteGeometricoToolStripMenuItem.Name = "recorteGeometricoToolStripMenuItem";
            this.recorteGeometricoToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.recorteGeometricoToolStripMenuItem.Text = "Recorte Geometrico";
            // 
            // cohenSutherlandToolStripMenuItem
            // 
            this.cohenSutherlandToolStripMenuItem.Name = "cohenSutherlandToolStripMenuItem";
            this.cohenSutherlandToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.cohenSutherlandToolStripMenuItem.Text = "Cohen Sutherland";
            this.cohenSutherlandToolStripMenuItem.Click += new System.EventHandler(this.cohenSutherlandToolStripMenuItem_Click);
            // 
            // sutherlandHodgmanToolStripMenuItem
            // 
            this.sutherlandHodgmanToolStripMenuItem.Name = "sutherlandHodgmanToolStripMenuItem";
            this.sutherlandHodgmanToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.sutherlandHodgmanToolStripMenuItem.Text = "Sutherland Hodgman";
            this.sutherlandHodgmanToolStripMenuItem.Click += new System.EventHandler(this.sutherlandHodgmanToolStripMenuItem_Click);
            // 
            // curvasBezierToolStripMenuItem
            // 
            this.curvasBezierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linealToolStripMenuItem,
            this.cToolStripMenuItem,
            this.cToolStripMenuItem1,
            this.bSplinesToolStripMenuItem});
            this.curvasBezierToolStripMenuItem.Name = "curvasBezierToolStripMenuItem";
            this.curvasBezierToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.curvasBezierToolStripMenuItem.Text = "Curvas Paramètricas";
            // 
            // linealToolStripMenuItem
            // 
            this.linealToolStripMenuItem.Name = "linealToolStripMenuItem";
            this.linealToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.linealToolStripMenuItem.Text = "Bezier Lineal";
            this.linealToolStripMenuItem.Click += new System.EventHandler(this.linealToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cToolStripMenuItem.Text = "Bezier Cuadrática";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem1
            // 
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.cToolStripMenuItem1.Text = "Bezier Cúbica";
            this.cToolStripMenuItem1.Click += new System.EventHandler(this.cToolStripMenuItem1_Click);
            // 
            // bSplinesToolStripMenuItem
            // 
            this.bSplinesToolStripMenuItem.Name = "bSplinesToolStripMenuItem";
            this.bSplinesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bSplinesToolStripMenuItem.Text = "B-Splines";
            this.bSplinesToolStripMenuItem.Click += new System.EventHandler(this.bSplinesToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rasterizacionDeLineasYCurvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamLineasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamCircunferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamElipsesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rellenoDeRegionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floodFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorteGeometricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cohenSutherlandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sutherlandHodgmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasBezierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bSplinesToolStripMenuItem;
    }
}