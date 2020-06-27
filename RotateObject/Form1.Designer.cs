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
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.Silver;
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
            this.tmrSpaceship.Enabled = true;
            this.tmrSpaceship.Interval = 1;
            this.tmrSpaceship.Tick += new System.EventHandler(this.tmrSpaceship_Tick);
            // 
            // tmrPlanet
            // 
            this.tmrPlanet.Enabled = true;
            this.tmrPlanet.Interval = 50;
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
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
    }
}

