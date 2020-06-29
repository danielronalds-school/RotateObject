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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Healthbar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Gameover_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Gameover_score = new System.Windows.Forms.Label();
            this.Startscreen_Panel = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Canvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Healthbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Gameover_Panel.SuspendLayout();
            this.Startscreen_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.Black;
            this.Canvas.Controls.Add(this.ScoreTxtDisplay);
            this.Canvas.Controls.Add(this.Healthbar);
            this.Canvas.Controls.Add(this.ScoreTxt);
            this.Canvas.Controls.Add(this.pictureBox1);
            this.Canvas.Controls.Add(this.pictureBox2);
            this.Canvas.Controls.Add(this.pictureBox3);
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
            this.tmrSpaceship.Interval = 20;
            this.tmrSpaceship.Tick += new System.EventHandler(this.tmrSpaceship_Tick);
            // 
            // tmrPlanet
            // 
            this.tmrPlanet.Enabled = true;
            this.tmrPlanet.Interval = 1;
            this.tmrPlanet.Tick += new System.EventHandler(this.tmrPlanet_Tick);
            // 
            // LifeTxt
            // 
            this.LifeTxt.AutoSize = true;
            this.LifeTxt.Location = new System.Drawing.Point(756, 51);
            this.LifeTxt.Name = "LifeTxt";
            this.LifeTxt.Size = new System.Drawing.Size(24, 13);
            this.LifeTxt.TabIndex = 1;
            this.LifeTxt.Text = "Life";
            // 
            // ScoreTxt
            // 
            this.ScoreTxt.AutoSize = true;
            this.ScoreTxt.BackColor = System.Drawing.Color.Black;
            this.ScoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTxt.ForeColor = System.Drawing.Color.Lime;
            this.ScoreTxt.Location = new System.Drawing.Point(524, 6);
            this.ScoreTxt.Name = "ScoreTxt";
            this.ScoreTxt.Size = new System.Drawing.Size(56, 20);
            this.ScoreTxt.TabIndex = 2;
            this.ScoreTxt.Text = "Score";
            // 
            // LifeTxtDisplay
            // 
            this.LifeTxtDisplay.AutoSize = true;
            this.LifeTxtDisplay.Location = new System.Drawing.Point(756, 27);
            this.LifeTxtDisplay.Name = "LifeTxtDisplay";
            this.LifeTxtDisplay.Size = new System.Drawing.Size(19, 13);
            this.LifeTxtDisplay.TabIndex = 3;
            this.LifeTxtDisplay.Text = "10";
            // 
            // ScoreTxtDisplay
            // 
            this.ScoreTxtDisplay.AutoSize = true;
            this.ScoreTxtDisplay.BackColor = System.Drawing.Color.Black;
            this.ScoreTxtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTxtDisplay.ForeColor = System.Drawing.Color.Lime;
            this.ScoreTxtDisplay.Location = new System.Drawing.Point(581, 6);
            this.ScoreTxtDisplay.Name = "ScoreTxtDisplay";
            this.ScoreTxtDisplay.Size = new System.Drawing.Size(19, 20);
            this.ScoreTxtDisplay.TabIndex = 4;
            this.ScoreTxtDisplay.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 18);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Healthbar
            // 
            this.Healthbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Healthbar.Location = new System.Drawing.Point(3, 3);
            this.Healthbar.Name = "Healthbar";
            this.Healthbar.Size = new System.Drawing.Size(200, 18);
            this.Healthbar.TabIndex = 9;
            this.Healthbar.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(521, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 26);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 24);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // Gameover_Panel
            // 
            this.Gameover_Panel.Controls.Add(this.Gameover_score);
            this.Gameover_Panel.Controls.Add(this.label1);
            this.Gameover_Panel.Location = new System.Drawing.Point(668, 117);
            this.Gameover_Panel.Name = "Gameover_Panel";
            this.Gameover_Panel.Size = new System.Drawing.Size(679, 545);
            this.Gameover_Panel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(178, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME OVER";
            // 
            // Gameover_score
            // 
            this.Gameover_score.AutoSize = true;
            this.Gameover_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gameover_score.ForeColor = System.Drawing.Color.Lime;
            this.Gameover_score.Location = new System.Drawing.Point(271, 263);
            this.Gameover_score.Name = "Gameover_score";
            this.Gameover_score.Size = new System.Drawing.Size(136, 55);
            this.Gameover_score.TabIndex = 1;
            this.Gameover_score.Text = "1000";
            // 
            // Startscreen_Panel
            // 
            this.Startscreen_Panel.Controls.Add(this.label2);
            this.Startscreen_Panel.Controls.Add(this.pictureBox4);
            this.Startscreen_Panel.Controls.Add(this.Start);
            this.Startscreen_Panel.Location = new System.Drawing.Point(671, 30);
            this.Startscreen_Panel.Name = "Startscreen_Panel";
            this.Startscreen_Panel.Size = new System.Drawing.Size(677, 547);
            this.Startscreen_Panel.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Lime;
            this.Start.Location = new System.Drawing.Point(180, 383);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(316, 48);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::RotateObject.Properties.Resources.alien1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(231, 188);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(215, 171);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(153, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 108);
            this.label2.TabIndex = 2;
            this.label2.Text = "Planets";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(679, 546);
            this.Controls.Add(this.Startscreen_Panel);
            this.Controls.Add(this.Gameover_Panel);
            this.Controls.Add(this.LifeTxtDisplay);
            this.Controls.Add(this.LifeTxt);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planets";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Canvas.ResumeLayout(false);
            this.Canvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Healthbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Gameover_Panel.ResumeLayout(false);
            this.Gameover_Panel.PerformLayout();
            this.Startscreen_Panel.ResumeLayout(false);
            this.Startscreen_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Healthbar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel Gameover_Panel;
        private System.Windows.Forms.Label Gameover_score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Startscreen_Panel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
    }
}

