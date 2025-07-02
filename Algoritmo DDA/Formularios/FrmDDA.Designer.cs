namespace AlgoritmoDDA
{
    partial class FrmDDA
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtYf = new System.Windows.Forms.TextBox();
            this.lblYf = new System.Windows.Forms.Label();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.lblXf = new System.Windows.Forms.Label();
            this.txtYi = new System.Windows.Forms.TextBox();
            this.lblYi = new System.Windows.Forms.Label();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.lblXi = new System.Windows.Forms.Label();
            this.lstPixeles = new System.Windows.Forms.ListBox();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbProcess.SuspendLayout();
            this.grbInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCanvas.Location = new System.Drawing.Point(352, 21);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbCanvas.Size = new System.Drawing.Size(796, 514);
            this.grbCanvas.TabIndex = 19;
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
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(14, 222);
            this.grbProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProcess.Size = new System.Drawing.Size(291, 94);
            this.grbProcess.TabIndex = 18;
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
            this.grbInputs.Controls.Add(this.txtYf);
            this.grbInputs.Controls.Add(this.lblYf);
            this.grbInputs.Controls.Add(this.txtXf);
            this.grbInputs.Controls.Add(this.lblXf);
            this.grbInputs.Controls.Add(this.txtYi);
            this.grbInputs.Controls.Add(this.lblYi);
            this.grbInputs.Controls.Add(this.txtXi);
            this.grbInputs.Controls.Add(this.lblXi);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(14, 32);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbInputs.Size = new System.Drawing.Size(291, 166);
            this.grbInputs.TabIndex = 17;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entrada";
            // 
            // txtYf
            // 
            this.txtYf.Location = new System.Drawing.Point(168, 126);
            this.txtYf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYf.Name = "txtYf";
            this.txtYf.Size = new System.Drawing.Size(100, 23);
            this.txtYf.TabIndex = 8;
            // 
            // lblYf
            // 
            this.lblYf.AutoSize = true;
            this.lblYf.Location = new System.Drawing.Point(186, 98);
            this.lblYf.Name = "lblYf";
            this.lblYf.Size = new System.Drawing.Size(59, 17);
            this.lblYf.TabIndex = 7;
            this.lblYf.Text = "Y final:";
            // 
            // txtXf
            // 
            this.txtXf.Location = new System.Drawing.Point(22, 126);
            this.txtXf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(100, 23);
            this.txtXf.TabIndex = 6;
            // 
            // lblXf
            // 
            this.lblXf.AutoSize = true;
            this.lblXf.Location = new System.Drawing.Point(38, 98);
            this.lblXf.Name = "lblXf";
            this.lblXf.Size = new System.Drawing.Size(59, 17);
            this.lblXf.TabIndex = 5;
            this.lblXf.Text = "X final:";
            // 
            // txtYi
            // 
            this.txtYi.Location = new System.Drawing.Point(168, 58);
            this.txtYi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYi.Name = "txtYi";
            this.txtYi.Size = new System.Drawing.Size(100, 23);
            this.txtYi.TabIndex = 4;
            // 
            // lblYi
            // 
            this.lblYi.AutoSize = true;
            this.lblYi.Location = new System.Drawing.Point(186, 32);
            this.lblYi.Name = "lblYi";
            this.lblYi.Size = new System.Drawing.Size(70, 17);
            this.lblYi.TabIndex = 3;
            this.lblYi.Text = "Y inicial:";
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(22, 58);
            this.txtXi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(100, 23);
            this.txtXi.TabIndex = 2;
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(38, 32);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(70, 17);
            this.lblXi.TabIndex = 0;
            this.lblXi.Text = "X inicial:";
            //this.lblXi.Click += new System.EventHandler(this.lblSide_Click);
            // 
            // lstPixeles
            // 
            this.lstPixeles.FormattingEnabled = true;
            this.lstPixeles.ItemHeight = 16;
            this.lstPixeles.Location = new System.Drawing.Point(21, 333);
            this.lstPixeles.Name = "lstPixeles";
            this.lstPixeles.Size = new System.Drawing.Size(284, 196);
            this.lstPixeles.TabIndex = 20;
            // 
            // FrmDDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 558);
            this.Controls.Add(this.lstPixeles);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1184, 605);
            this.MinimumSize = new System.Drawing.Size(1184, 605);
            this.Name = "FrmDDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmo DDA";
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbProcess.ResumeLayout(false);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.Label lblXf;
        private System.Windows.Forms.TextBox txtYi;
        private System.Windows.Forms.Label lblYi;
        private System.Windows.Forms.TextBox txtYf;
        private System.Windows.Forms.Label lblYf;
        private System.Windows.Forms.ListBox lstPixeles;
    }
}

