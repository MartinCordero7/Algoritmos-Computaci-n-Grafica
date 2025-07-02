namespace Algoritmo_DDA
{
    partial class FrmFloodFill
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
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lstPixeles = new System.Windows.Forms.ListBox();
            this.btnPintar = new System.Windows.Forms.Button();
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
            this.grbCanvas.Location = new System.Drawing.Point(352, 18);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbCanvas.Size = new System.Drawing.Size(796, 514);
            this.grbCanvas.TabIndex = 28;
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
            this.grbProcess.Controls.Add(this.btnPintar);
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(14, 219);
            this.grbProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProcess.Size = new System.Drawing.Size(291, 106);
            this.grbProcess.TabIndex = 27;
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
            this.grbInputs.Controls.Add(this.txtRadio);
            this.grbInputs.Controls.Add(this.lblRadio);
            this.grbInputs.Controls.Add(this.txtY);
            this.grbInputs.Controls.Add(this.lblY);
            this.grbInputs.Controls.Add(this.txtX);
            this.grbInputs.Controls.Add(this.lblX);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(14, 30);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbInputs.Size = new System.Drawing.Size(291, 166);
            this.grbInputs.TabIndex = 26;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entrada";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(95, 126);
            this.txtRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 23);
            this.txtRadio.TabIndex = 6;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(116, 99);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(55, 17);
            this.lblRadio.TabIndex = 5;
            this.lblRadio.Text = "Radio:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(168, 58);
            this.txtY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 23);
            this.txtY.TabIndex = 4;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(186, 32);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(23, 17);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(22, 58);
            this.txtX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 23);
            this.txtX.TabIndex = 2;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(38, 32);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 17);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X:";
            // 
            // lstPixeles
            // 
            this.lstPixeles.FormattingEnabled = true;
            this.lstPixeles.ItemHeight = 16;
            this.lstPixeles.Location = new System.Drawing.Point(12, 332);
            this.lstPixeles.Name = "lstPixeles";
            this.lstPixeles.Size = new System.Drawing.Size(293, 212);
            this.lstPixeles.TabIndex = 29;
            // 
            // btnPintar
            // 
            this.btnPintar.Location = new System.Drawing.Point(99, 76);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(96, 23);
            this.btnPintar.TabIndex = 3;
            this.btnPintar.Text = "Pintar";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // FrmFloodFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 551);
            this.Controls.Add(this.lstPixeles);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "FrmFloodFill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFloodFill";
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
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.ListBox lstPixeles;
        private System.Windows.Forms.Button btnPintar;
    }
}