
namespace MyFirstGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MovoBgTimer = new System.Windows.Forms.Timer(this.components);
            this.leftmove = new System.Windows.Forms.Timer(this.components);
            this.rightmove = new System.Windows.Forms.Timer(this.components);
            this.upmove = new System.Windows.Forms.Timer(this.components);
            this.downmove = new System.Windows.Forms.Timer(this.components);
            this.MainPlayer = new System.Windows.Forms.PictureBox();
            this.movefireballtimer = new System.Windows.Forms.Timer(this.components);
            this.moveenemiestimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRestart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // MovoBgTimer
            // 
            this.MovoBgTimer.Enabled = true;
            this.MovoBgTimer.Interval = 10;
            this.MovoBgTimer.Tick += new System.EventHandler(this.MovoBgTimer_Tick);
            // 
            // leftmove
            // 
            this.leftmove.Interval = 10;
            this.leftmove.Tick += new System.EventHandler(this.leftmove_Tick);
            // 
            // rightmove
            // 
            this.rightmove.Interval = 10;
            this.rightmove.Tick += new System.EventHandler(this.rightmove_Tick);
            // 
            // upmove
            // 
            this.upmove.Interval = 10;
            this.upmove.Tick += new System.EventHandler(this.upmove_Tick);
            // 
            // downmove
            // 
            this.downmove.Interval = 10;
            this.downmove.Tick += new System.EventHandler(this.downmove_Tick);
            // 
            // MainPlayer
            // 
            this.MainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.MainPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPlayer.Image = global::MyFirstGame.Properties.Resources.mesto;
            this.MainPlayer.Location = new System.Drawing.Point(86, 496);
            this.MainPlayer.Name = "MainPlayer";
            this.MainPlayer.Size = new System.Drawing.Size(89, 71);
            this.MainPlayer.TabIndex = 0;
            this.MainPlayer.TabStop = false;
            // 
            // movefireballtimer
            // 
            this.movefireballtimer.Enabled = true;
            this.movefireballtimer.Interval = 10;
            this.movefireballtimer.Tick += new System.EventHandler(this.movefireballtimer_Tick);
            // 
            // moveenemiestimer
            // 
            this.moveenemiestimer.Enabled = true;
            this.moveenemiestimer.Interval = 10;
            this.moveenemiestimer.Tick += new System.EventHandler(this.moveenemiestimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(276, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "GAME OVER";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.GameOver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(814, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "SCORE:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScore.Location = new System.Drawing.Point(969, 24);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(72, 50);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "00";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLevel.Location = new System.Drawing.Point(969, 74);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(72, 50);
            this.labelLevel.TabIndex = 5;
            this.labelLevel.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(814, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "LEVEL:";
            // 
            // labelRestart
            // 
            this.labelRestart.AutoSize = true;
            this.labelRestart.BackColor = System.Drawing.Color.Transparent;
            this.labelRestart.Font = new System.Drawing.Font("Showcard Gothic", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRestart.Location = new System.Drawing.Point(360, 245);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(322, 83);
            this.labelRestart.TabIndex = 6;
            this.labelRestart.Text = "RESTART";
            this.labelRestart.Visible = false;
            this.labelRestart.Click += new System.EventHandler(this.labelRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.labelRestart);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainPlayer);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.Name = "Form1";
            this.Text = "My First Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.MainPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MovoBgTimer;
        private System.Windows.Forms.Timer leftmove;
        private System.Windows.Forms.Timer rightmove;
        private System.Windows.Forms.Timer upmove;
        private System.Windows.Forms.Timer downmove;
        private System.Windows.Forms.PictureBox MainPlayer;
        private System.Windows.Forms.Timer movefireballtimer;
        private System.Windows.Forms.Timer moveenemiestimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRestart;
    }
}

