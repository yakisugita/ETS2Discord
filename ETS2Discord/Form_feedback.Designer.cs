
namespace ETS2Discord
{
    partial class Form_feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_feedback));
            this.feedback_text = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.address_text = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // feedback_text
            // 
            this.feedback_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedback_text.Location = new System.Drawing.Point(12, 12);
            this.feedback_text.Multiline = true;
            this.feedback_text.Name = "feedback_text";
            this.feedback_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.feedback_text.Size = new System.Drawing.Size(460, 208);
            this.feedback_text.TabIndex = 0;
            // 
            // sendbutton
            // 
            this.sendbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendbutton.Location = new System.Drawing.Point(397, 226);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(75, 23);
            this.sendbutton.TabIndex = 1;
            this.sendbutton.Text = "送信";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // address_text
            // 
            this.address_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.address_text.Location = new System.Drawing.Point(133, 228);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(258, 19);
            this.address_text.TabIndex = 2;
            // 
            // address_label
            // 
            this.address_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(12, 231);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(115, 12);
            this.address_label.TabIndex = 3;
            this.address_label.Text = "Twitter,メール等(任意)";
            // 
            // Form_feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.feedback_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_feedback";
            this.Text = "フィードバック・意見の送信";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox feedback_text;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label address_label;
    }
}