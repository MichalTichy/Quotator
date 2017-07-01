using System.Drawing;

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
            this.components = new System.ComponentModel.Container();
            this.labQuote = new System.Windows.Forms.Label();
            this.quoteTimer = new System.Windows.Forms.Timer(this.components);
            this.autoHideTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labQuote
            // 
            this.labQuote.AutoSize = true;
            this.labQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuote.ForeColor = System.Drawing.Color.White;
            this.labQuote.Location = new System.Drawing.Point(0, 0);
            this.labQuote.MaximumSize = new System.Drawing.Size(900, 300);
            this.labQuote.MinimumSize = new System.Drawing.Size(100, 40);
            this.labQuote.Name = "labQuote";
            this.labQuote.Size = new System.Drawing.Size(100, 30);
            this.labQuote.TabIndex = 0;
            this.labQuote.Text = "TEST";
            this.labQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labQuote.Click += new System.EventHandler(this.labQuote_Click);
            // 
            // quoteTimer
            // 
            this.quoteTimer.Interval = 3600000;
            this.quoteTimer.Tick += new System.EventHandler(this.quoteTimer_Tick);
            // 
            // autoHideTimer
            // 
            this.autoHideTimer.Tick += new System.EventHandler(this.autoHideTimer_Tick);
            // 
            // Quotator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 40);
            this.ControlBox = false;
            this.Controls.Add(this.labQuote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quotator";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quotator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Quotator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labQuote;
        private System.Windows.Forms.Timer quoteTimer;
        private System.Windows.Forms.Timer autoHideTimer;
    }
}

