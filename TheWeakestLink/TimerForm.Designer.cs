namespace TheWeakestLink
{
    partial class TimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.MainLabel = new System.Windows.Forms.Label();
            this.MainTmer = new System.Windows.Forms.Timer(this.components);
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 160F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(1063, 676);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "05:00";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainTmer
            // 
            this.MainTmer.Tick += new System.EventHandler(this.MainTmer_Tick);
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 450;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 676);
            this.Controls.Add(this.MainLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimerForm";
            this.Text = "Таймер";
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.Resize += new System.EventHandler(this.TimerForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Timer MainTmer;
        private System.Windows.Forms.Timer RefreshTimer;
    }
}