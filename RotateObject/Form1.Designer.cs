namespace RotateObject
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
            this.components = new System.ComponentModel.Container();
            this.Canvas = new System.Windows.Forms.Panel();
            this.tmrSpaceship = new System.Windows.Forms.Timer(this.components);
            this.tmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.LifeTxt = new System.Windows.Forms.Label();
            this.ScoreTxt = new System.Windows.Forms.Label();
            this.LifeTxtDisplay = new System.Windows.Forms.Label();
            this.ScoreTxtDisplay = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.Canvas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.Silver;
            this.Canvas.Controls.Add(this.menuStrip1);
            this.Canvas.Location = new System.Drawing.Point(12, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(650, 522);
            this.Canvas.TabIndex = 0;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // tmrSpaceship
            // 
            this.tmrSpaceship.Interval = 1;
            this.tmrSpaceship.Tick += new System.EventHandler(this.tmrSpaceship_Tick);
            // 
            // tmrPlanet
            // 
            this.tmrPlanet.Interval = 1;
            this.tmrPlanet.Tick += new System.EventHandler(this.tmrPlanet_Tick);
            // 
            // LifeTxt
            // 
            this.LifeTxt.AutoSize = true;
            this.LifeTxt.Location = new System.Drawing.Point(668, 21);
            this.LifeTxt.Name = "LifeTxt";
            this.LifeTxt.Size = new System.Drawing.Size(24, 13);
            this.LifeTxt.TabIndex = 1;
            this.LifeTxt.Text = "Life";
            // 
            // ScoreTxt
            // 
            this.ScoreTxt.AutoSize = true;
            this.ScoreTxt.Location = new System.Drawing.Point(668, 34);
            this.ScoreTxt.Name = "ScoreTxt";
            this.ScoreTxt.Size = new System.Drawing.Size(35, 13);
            this.ScoreTxt.TabIndex = 2;
            this.ScoreTxt.Text = "Score";
            // 
            // LifeTxtDisplay
            // 
            this.LifeTxtDisplay.AutoSize = true;
            this.LifeTxtDisplay.Location = new System.Drawing.Point(709, 21);
            this.LifeTxtDisplay.Name = "LifeTxtDisplay";
            this.LifeTxtDisplay.Size = new System.Drawing.Size(19, 13);
            this.LifeTxtDisplay.TabIndex = 3;
            this.LifeTxtDisplay.Text = "10";
            // 
            // ScoreTxtDisplay
            // 
            this.ScoreTxtDisplay.AutoSize = true;
            this.ScoreTxtDisplay.Location = new System.Drawing.Point(709, 34);
            this.ScoreTxtDisplay.Name = "ScoreTxtDisplay";
            this.ScoreTxtDisplay.Size = new System.Drawing.Size(13, 13);
            this.ScoreTxtDisplay.TabIndex = 4;
            this.ScoreTxtDisplay.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuStop});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuStart
            // 
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(43, 20);
            this.MnuStart.Text = "Start";
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuStop
            // 
            this.MnuStop.Name = "MnuStop";
            this.MnuStop.Size = new System.Drawing.Size(43, 20);
            this.MnuStop.Text = "Stop";
            this.MnuStop.Click += new System.EventHandler(this.MnuStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 546);
            this.Controls.Add(this.ScoreTxtDisplay);
            this.Controls.Add(this.LifeTxtDisplay);
            this.Controls.Add(this.ScoreTxt);
            this.Controls.Add(this.LifeTxt);
            this.Controls.Add(this.Canvas);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Canvas.ResumeLayout(false);
            this.Canvas.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Timer tmrSpaceship;
        private System.Windows.Forms.Timer tmrPlanet;
        private System.Windows.Forms.Label LifeTxt;
        private System.Windows.Forms.Label ScoreTxt;
        private System.Windows.Forms.Label LifeTxtDisplay;
        private System.Windows.Forms.Label ScoreTxtDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuStop;
    }
}

