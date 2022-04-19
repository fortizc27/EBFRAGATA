
namespace WinFormsApp
{
    partial class Ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda));
            this.DocManual = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.DocManual)).BeginInit();
            this.SuspendLayout();
            // 
            // DocManual
            // 
            this.DocManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocManual.Enabled = true;
            this.DocManual.Location = new System.Drawing.Point(0, 0);
            this.DocManual.Name = "DocManual";
            this.DocManual.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("DocManual.OcxState")));
            this.DocManual.Size = new System.Drawing.Size(963, 579);
            this.DocManual.TabIndex = 1;
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 579);
            this.Controls.Add(this.DocManual);
            this.Name = "Ayuda";
            this.Text = "AYUDA";
            ((System.ComponentModel.ISupportInitialize)(this.DocManual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF DocManual;
    }
}