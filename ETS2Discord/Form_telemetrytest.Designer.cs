
namespace ETS2Discord
{
    partial class Form_telemetrytest
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
            this.l_updateRate = new System.Windows.Forms.Label();
            this.lbGeneral = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // l_updateRate
            // 
            this.l_updateRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l_updateRate.AutoSize = true;
            this.l_updateRate.Location = new System.Drawing.Point(477, 302);
            this.l_updateRate.Name = "l_updateRate";
            this.l_updateRate.Size = new System.Drawing.Size(35, 12);
            this.l_updateRate.TabIndex = 0;
            this.l_updateRate.Text = "label1";
            // 
            // lbGeneral
            // 
            this.lbGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGeneral.Location = new System.Drawing.Point(12, 12);
            this.lbGeneral.Multiline = true;
            this.lbGeneral.Name = "lbGeneral";
            this.lbGeneral.ReadOnly = true;
            this.lbGeneral.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lbGeneral.Size = new System.Drawing.Size(500, 287);
            this.lbGeneral.TabIndex = 1;
            // 
            // Form_telemetrytest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 326);
            this.Controls.Add(this.lbGeneral);
            this.Controls.Add(this.l_updateRate);
            this.Name = "Form_telemetrytest";
            this.Text = "Form_telemetrytest";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_updateRate;
        private System.Windows.Forms.TextBox lbGeneral;
    }
}