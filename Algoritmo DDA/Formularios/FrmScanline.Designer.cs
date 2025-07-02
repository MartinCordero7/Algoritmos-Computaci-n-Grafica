namespace Algoritmo_DDA.Formularios
{
    partial class FrmScanline
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.listBoxPixels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(221, 440);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 41);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(66, 440);
            this.btnFill.Margin = new System.Windows.Forms.Padding(4);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(133, 41);
            this.btnFill.TabIndex = 8;
            this.btnFill.Text = "Rellenar";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(66, 48);
            this.pictureBoxCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(569, 384);
            this.pictureBoxCanvas.TabIndex = 7;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseClick);
            // 
            // listBoxPixels
            // 
            this.listBoxPixels.ItemHeight = 16;
            this.listBoxPixels.Location = new System.Drawing.Point(714, 48);
            this.listBoxPixels.Name = "listBoxPixels";
            this.listBoxPixels.Size = new System.Drawing.Size(200, 388);
            this.listBoxPixels.TabIndex = 9;
            // 
            // FrmScanline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 529);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Controls.Add(this.listBoxPixels);
            this.Name = "FrmScanline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmScanline";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.ListBox listBoxPixels;
    }
}