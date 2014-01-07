namespace IT151BubbleSortWin
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.pgbJValue = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(122, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 51);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(12, 12);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(104, 51);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "0";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBefore
            // 
            this.txtBefore.Location = new System.Drawing.Point(12, 69);
            this.txtBefore.Multiline = true;
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBefore.Size = new System.Drawing.Size(210, 293);
            this.txtBefore.TabIndex = 2;
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(228, 69);
            this.txtAfter.Multiline = true;
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAfter.Size = new System.Drawing.Size(206, 293);
            this.txtAfter.TabIndex = 3;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(334, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 51);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "E&xit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(228, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 51);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // pgbJValue
            // 
            this.pgbJValue.Location = new System.Drawing.Point(12, 368);
            this.pgbJValue.Name = "pgbJValue";
            this.pgbJValue.Size = new System.Drawing.Size(422, 23);
            this.pgbJValue.Step = 1;
            this.pgbJValue.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbJValue.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 398);
            this.Controls.Add(this.pgbJValue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtAfter);
            this.Controls.Add(this.txtBefore);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Bubble Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ProgressBar pgbJValue;
    }
}

