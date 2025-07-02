namespace Algoritmo_DDA.Formularios
{
    partial class FrmBresenhamElipses
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
            this.lstPixeles = new System.Windows.Forms.ListBox();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtYr = new System.Windows.Forms.TextBox();
            this.lblYf = new System.Windows.Forms.Label();
            this.txtXr = new System.Windows.Forms.TextBox();
            this.lblXf = new System.Windows.Forms.Label();
            this.txtYc = new System.Windows.Forms.TextBox();
            this.lblYi = new System.Windows.Forms.Label();
            this.txtXc = new System.Windows.Forms.TextBox();
            this.lblXi = new System.Windows.Forms.Label();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbProcess.SuspendLayout();
            this.grbInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPixeles
            // 
            this.lstPixeles.FormattingEnabled = true;
            this.lstPixeles.ItemHeight = 16;
            this.lstPixeles.Location = new System.Drawing.Point(23, 334);
            this.lstPixeles.Name = "lstPixeles";
            this.lstPixeles.Size = new System.Drawing.Size(284, 196);
            this.lstPixeles.TabIndex = 24;
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCanvas.Location = new System.Drawing.Point(354, 22);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbCanvas.Size = new System.Drawing.Size(796, 514);
            this.grbCanvas.TabIndex = 23;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(5, 22);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(776, 485);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(16, 223);
            this.grbProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProcess.Size = new System.Drawing.Size(291, 94);
            this.grbProcess.TabIndex = 22;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(201, 44);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(99, 44);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(7, 44);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtYr);
            this.grbInputs.Controls.Add(this.lblYf);
            this.grbInputs.Controls.Add(this.txtXr);
            this.grbInputs.Controls.Add(this.lblXf);
            this.grbInputs.Controls.Add(this.txtYc);
            this.grbInputs.Controls.Add(this.lblYi);
            this.grbInputs.Controls.Add(this.txtXc);
            this.grbInputs.Controls.Add(this.lblXi);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(16, 33);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbInputs.Size = new System.Drawing.Size(291, 166);
            this.grbInputs.TabIndex = 21;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entrada";
            // 
            // txtYr
            // 
            this.txtYr.Location = new System.Drawing.Point(168, 126);
            this.txtYr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYr.Name = "txtYr";
            this.txtYr.Size = new System.Drawing.Size(100, 23);
            this.txtYr.TabIndex = 8;
            // 
            // lblYf
            // 
            this.lblYf.AutoSize = true;
            this.lblYf.Location = new System.Drawing.Point(186, 98);
            this.lblYf.Name = "lblYf";
            this.lblYf.Size = new System.Drawing.Size(65, 17);
            this.lblYf.TabIndex = 7;
            this.lblYf.Text = "Y radio:";
            // 
            // txtXr
            // 
            this.txtXr.Location = new System.Drawing.Point(22, 126);
            this.txtXr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXr.Name = "txtXr";
            this.txtXr.Size = new System.Drawing.Size(100, 23);
            this.txtXr.TabIndex = 6;
            // 
            // lblXf
            // 
            this.lblXf.AutoSize = true;
            this.lblXf.Location = new System.Drawing.Point(38, 98);
            this.lblXf.Name = "lblXf";
            this.lblXf.Size = new System.Drawing.Size(65, 17);
            this.lblXf.TabIndex = 5;
            this.lblXf.Text = "X radio:";
            // 
            // txtYc
            // 
            this.txtYc.Location = new System.Drawing.Point(168, 58);
            this.txtYc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYc.Name = "txtYc";
            this.txtYc.Size = new System.Drawing.Size(100, 23);
            this.txtYc.TabIndex = 4;
            // 
            // lblYi
            // 
            this.lblYi.AutoSize = true;
            this.lblYi.Location = new System.Drawing.Point(186, 32);
            this.lblYi.Name = "lblYi";
            this.lblYi.Size = new System.Drawing.Size(78, 17);
            this.lblYi.TabIndex = 3;
            this.lblYi.Text = "Y central:";
            // 
            // txtXc
            // 
            this.txtXc.Location = new System.Drawing.Point(22, 58);
            this.txtXc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXc.Name = "txtXc";
            this.txtXc.Size = new System.Drawing.Size(100, 23);
            this.txtXc.TabIndex = 2;
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(38, 32);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(78, 17);
            this.lblXi.TabIndex = 0;
            this.lblXi.Text = "X central:";
            // 
            // FrmBresenhamElipses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 558);
            this.Controls.Add(this.lstPixeles);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "FrmBresenhamElipses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBresenhamElipses";
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbProcess.ResumeLayout(false);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPixeles;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtYr;
        private System.Windows.Forms.Label lblYf;
        private System.Windows.Forms.TextBox txtXr;
        private System.Windows.Forms.Label lblXf;
        private System.Windows.Forms.TextBox txtYc;
        private System.Windows.Forms.Label lblYi;
        private System.Windows.Forms.TextBox txtXc;
        private System.Windows.Forms.Label lblXi;
    }
}