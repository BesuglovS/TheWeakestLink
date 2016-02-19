namespace TheWeakestLink
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListPanel = new System.Windows.Forms.Panel();
            this.CashStack = new System.Windows.Forms.ListBox();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.FullScreenTimer = new System.Windows.Forms.CheckBox();
            this.MainTimerInterval = new System.Windows.Forms.MaskedTextBox();
            this.RunTimer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResetBank = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bank = new System.Windows.Forms.TextBox();
            this.ResetStack = new System.Windows.Forms.Button();
            this.ToBank = new System.Windows.Forms.Button();
            this.Raise = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Step = new System.Windows.Forms.TextBox();
            this.AddStep = new System.Windows.Forms.Button();
            this.RemoveStep = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.TimerBackColor = new System.Windows.Forms.Button();
            this.TimerForeColor = new System.Windows.Forms.Button();
            this.CloseFormOnTimer = new System.Windows.Forms.CheckBox();
            this.ListPanel.SuspendLayout();
            this.ControlsPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListPanel
            // 
            this.ListPanel.Controls.Add(this.CashStack);
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListPanel.Location = new System.Drawing.Point(0, 0);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(204, 649);
            this.ListPanel.TabIndex = 0;
            // 
            // CashStack
            // 
            this.CashStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashStack.FormattingEnabled = true;
            this.CashStack.ItemHeight = 25;
            this.CashStack.Location = new System.Drawing.Point(9, 9);
            this.CashStack.Margin = new System.Windows.Forms.Padding(0);
            this.CashStack.Name = "CashStack";
            this.CashStack.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.CashStack.Size = new System.Drawing.Size(183, 629);
            this.CashStack.TabIndex = 0;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.Controls.Add(this.CloseFormOnTimer);
            this.ControlsPanel.Controls.Add(this.TimerForeColor);
            this.ControlsPanel.Controls.Add(this.TimerBackColor);
            this.ControlsPanel.Controls.Add(this.FullScreenTimer);
            this.ControlsPanel.Controls.Add(this.MainTimerInterval);
            this.ControlsPanel.Controls.Add(this.RunTimer);
            this.ControlsPanel.Controls.Add(this.groupBox2);
            this.ControlsPanel.Controls.Add(this.ResetStack);
            this.ControlsPanel.Controls.Add(this.ToBank);
            this.ControlsPanel.Controls.Add(this.Raise);
            this.ControlsPanel.Controls.Add(this.groupBox1);
            this.ControlsPanel.Controls.Add(this.RemoveStep);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsPanel.Location = new System.Drawing.Point(204, 0);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(261, 649);
            this.ControlsPanel.TabIndex = 1;
            // 
            // FullScreenTimer
            // 
            this.FullScreenTimer.AutoSize = true;
            this.FullScreenTimer.Checked = true;
            this.FullScreenTimer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FullScreenTimer.Location = new System.Drawing.Point(12, 394);
            this.FullScreenTimer.Name = "FullScreenTimer";
            this.FullScreenTimer.Size = new System.Drawing.Size(140, 17);
            this.FullScreenTimer.TabIndex = 9;
            this.FullScreenTimer.Text = "Таймер на весь экран";
            this.FullScreenTimer.UseVisualStyleBackColor = true;
            // 
            // MainTimerInterval
            // 
            this.MainTimerInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTimerInterval.Location = new System.Drawing.Point(12, 326);
            this.MainTimerInterval.Mask = "00:00";
            this.MainTimerInterval.Name = "MainTimerInterval";
            this.MainTimerInterval.Size = new System.Drawing.Size(131, 62);
            this.MainTimerInterval.TabIndex = 8;
            this.MainTimerInterval.Text = "0500";
            // 
            // RunTimer
            // 
            this.RunTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunTimer.Location = new System.Drawing.Point(181, 326);
            this.RunTimer.Name = "RunTimer";
            this.RunTimer.Size = new System.Drawing.Size(62, 62);
            this.RunTimer.TabIndex = 7;
            this.RunTimer.Text = "Таймер";
            this.RunTimer.UseVisualStyleBackColor = true;
            this.RunTimer.Click += new System.EventHandler(this.RunTimer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResetBank);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Bank);
            this.groupBox2.Location = new System.Drawing.Point(6, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 152);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // ResetBank
            // 
            this.ResetBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetBank.Location = new System.Drawing.Point(6, 94);
            this.ResetBank.Name = "ResetBank";
            this.ResetBank.Size = new System.Drawing.Size(231, 47);
            this.ResetBank.TabIndex = 5;
            this.ResetBank.Text = "Сбросить банк";
            this.ResetBank.UseVisualStyleBackColor = true;
            this.ResetBank.Click += new System.EventHandler(this.ResetBank_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "БАНК";
            // 
            // Bank
            // 
            this.Bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bank.Location = new System.Drawing.Point(6, 56);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(231, 32);
            this.Bank.TabIndex = 3;
            // 
            // ResetStack
            // 
            this.ResetStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetStack.Location = new System.Drawing.Point(6, 115);
            this.ResetStack.Name = "ResetStack";
            this.ResetStack.Size = new System.Drawing.Size(243, 47);
            this.ResetStack.TabIndex = 5;
            this.ResetStack.Text = "Сброс";
            this.ResetStack.UseVisualStyleBackColor = true;
            this.ResetStack.Click += new System.EventHandler(this.ResetStack_Click);
            // 
            // ToBank
            // 
            this.ToBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToBank.Location = new System.Drawing.Point(6, 62);
            this.ToBank.Name = "ToBank";
            this.ToBank.Size = new System.Drawing.Size(243, 47);
            this.ToBank.TabIndex = 4;
            this.ToBank.Text = "В БАНК";
            this.ToBank.UseVisualStyleBackColor = true;
            this.ToBank.Click += new System.EventHandler(this.ToBank_Click);
            // 
            // Raise
            // 
            this.Raise.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Raise.Location = new System.Drawing.Point(6, 9);
            this.Raise.Name = "Raise";
            this.Raise.Size = new System.Drawing.Size(243, 47);
            this.Raise.TabIndex = 3;
            this.Raise.Text = "Повысить ставку";
            this.Raise.UseVisualStyleBackColor = true;
            this.Raise.Click += new System.EventHandler(this.Raise_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Step);
            this.groupBox1.Controls.Add(this.AddStep);
            this.groupBox1.Location = new System.Drawing.Point(6, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Step
            // 
            this.Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Step.Location = new System.Drawing.Point(6, 72);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(231, 32);
            this.Step.TabIndex = 3;
            // 
            // AddStep
            // 
            this.AddStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStep.Location = new System.Drawing.Point(6, 19);
            this.AddStep.Name = "AddStep";
            this.AddStep.Size = new System.Drawing.Size(231, 47);
            this.AddStep.TabIndex = 2;
            this.AddStep.Text = "Добавить ступень";
            this.AddStep.UseVisualStyleBackColor = true;
            this.AddStep.Click += new System.EventHandler(this.AddStep_Click);
            // 
            // RemoveStep
            // 
            this.RemoveStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveStep.Location = new System.Drawing.Point(6, 590);
            this.RemoveStep.Name = "RemoveStep";
            this.RemoveStep.Size = new System.Drawing.Size(243, 47);
            this.RemoveStep.TabIndex = 0;
            this.RemoveStep.Text = "Удалить ступень";
            this.RemoveStep.UseVisualStyleBackColor = true;
            this.RemoveStep.Click += new System.EventHandler(this.RemoveStep_Click);
            // 
            // TimerBackColor
            // 
            this.TimerBackColor.Location = new System.Drawing.Point(13, 434);
            this.TimerBackColor.Name = "TimerBackColor";
            this.TimerBackColor.Size = new System.Drawing.Size(102, 34);
            this.TimerBackColor.TabIndex = 10;
            this.TimerBackColor.Text = "Цвет фона";
            this.TimerBackColor.UseVisualStyleBackColor = true;
            this.TimerBackColor.Click += new System.EventHandler(this.TimerBackColor_Click);
            // 
            // TimerForeColor
            // 
            this.TimerForeColor.Location = new System.Drawing.Point(141, 434);
            this.TimerForeColor.Name = "TimerForeColor";
            this.TimerForeColor.Size = new System.Drawing.Size(102, 34);
            this.TimerForeColor.TabIndex = 11;
            this.TimerForeColor.Text = "Цвет цифр";
            this.TimerForeColor.UseVisualStyleBackColor = true;
            this.TimerForeColor.Click += new System.EventHandler(this.TimerForeColor_Click);
            // 
            // CloseFormOnTimer
            // 
            this.CloseFormOnTimer.AutoSize = true;
            this.CloseFormOnTimer.Checked = true;
            this.CloseFormOnTimer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CloseFormOnTimer.Location = new System.Drawing.Point(12, 411);
            this.CloseFormOnTimer.Name = "CloseFormOnTimer";
            this.CloseFormOnTimer.Size = new System.Drawing.Size(180, 17);
            this.CloseFormOnTimer.TabIndex = 12;
            this.CloseFormOnTimer.Text = "Закрывать окно по окончании";
            this.CloseFormOnTimer.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 649);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.ListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Слабое звено";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ListPanel.ResumeLayout(false);
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.ListBox CashStack;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Step;
        private System.Windows.Forms.Button AddStep;
        private System.Windows.Forms.Button RemoveStep;
        private System.Windows.Forms.Button ResetStack;
        private System.Windows.Forms.Button ToBank;
        private System.Windows.Forms.Button Raise;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Bank;
        private System.Windows.Forms.Button ResetBank;
        private System.Windows.Forms.Button RunTimer;
        private System.Windows.Forms.MaskedTextBox MainTimerInterval;
        private System.Windows.Forms.CheckBox FullScreenTimer;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button TimerForeColor;
        private System.Windows.Forms.Button TimerBackColor;
        private System.Windows.Forms.CheckBox CloseFormOnTimer;
    }
}

