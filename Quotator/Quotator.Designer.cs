namespace Quotator
{
    partial class Quotator
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
            this.labQuote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labQuote
            // 
            this.labQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuote.Location = new System.Drawing.Point(0, -2);
            this.labQuote.Name = "labQuote";
            this.labQuote.Size = new System.Drawing.Size(600, 30);
            this.labQuote.TabIndex = 0;
            this.labQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quotator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(600, 30);
            this.ControlBox = false;
            this.Controls.Add(this.labQuote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quotator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quotator";
            this.TopMost = true;
            this.TransparencyKey = this.BackColor;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labQuote;
    }
}

