namespace Algoritmo_DDA.Formularios
{
    partial class FrmsutherlandHoldgman
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
            this.lblPixels = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.dgwPixels = new System.Windows.Forms.DataGridView();
            this.BtnCut = new System.Windows.Forms.Button();
            this.PicCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPixels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPixels
            // 
            this.lblPixels.AutoSize = true;
            this.lblPixels.Location = new System.Drawing.Point(26, 16);
            this.lblPixels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPixels.Name = "lblPixels";
            this.lblPixels.Size = new System.Drawing.Size(109, 16);
            this.lblPixels.TabIndex = 22;
            this.lblPixels.Text = "Tabla de Pixeles";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(753, 517);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(100, 28);
            this.BtnReset.TabIndex = 21;
            this.BtnReset.Text = "Resetear";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // dgwPixels
            // 
            this.dgwPixels.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwPixels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPixels.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwPixels.Location = new System.Drawing.Point(30, 35);
            this.dgwPixels.Margin = new System.Windows.Forms.Padding(4);
            this.dgwPixels.Name = "dgwPixels";
            this.dgwPixels.RowHeadersWidth = 51;
            this.dgwPixels.Size = new System.Drawing.Size(496, 438);
            this.dgwPixels.TabIndex = 20;
            // 
            // BtnCut
            // 
            this.BtnCut.Location = new System.Drawing.Point(591, 517);
            this.BtnCut.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCut.Name = "BtnCut";
            this.BtnCut.Size = new System.Drawing.Size(100, 28);
            this.BtnCut.TabIndex = 19;
            this.BtnCut.Text = "Recortar";
            this.BtnCut.UseVisualStyleBackColor = true;
            // 
            // PicCanvas
            // 
            this.PicCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.PicCanvas.Location = new System.Drawing.Point(534, 36);
            this.PicCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.PicCanvas.Name = "PicCanvas";
            this.PicCanvas.Size = new System.Drawing.Size(907, 437);
            this.PicCanvas.TabIndex = 18;
            this.PicCanvas.TabStop = false;
            this.PicCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PicCanvas_Paint);
            this.PicCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicCanvas_MouseClick);
            // 
            // FrmsutherlandHoldgman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 561);
            this.Controls.Add(this.lblPixels);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.dgwPixels);
            this.Controls.Add(this.BtnCut);
            this.Controls.Add(this.PicCanvas);
            this.Name = "FrmsutherlandHoldgman";
            this.Text = "FrmsutherlandHoldgmancs";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPixels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPixels;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.DataGridView dgwPixels;
        private System.Windows.Forms.Button BtnCut;
        private System.Windows.Forms.PictureBox PicCanvas;
    }
}