
namespace WinFormsApp
{
    partial class PanelPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipal));
            this.ImagenLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagenLogo
            // 
            this.ImagenLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImagenLogo.Image")));
            this.ImagenLogo.Location = new System.Drawing.Point(12, 12);
            this.ImagenLogo.Name = "ImagenLogo";
            this.ImagenLogo.Size = new System.Drawing.Size(937, 724);
            this.ImagenLogo.TabIndex = 0;
            this.ImagenLogo.TabStop = false;
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 685);
            this.Controls.Add(this.ImagenLogo);
            this.Name = "PanelPrincipal";
            this.Text = "PANEL PRINCIPAL";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenLogo;
    }
}