namespace MoreGames
{
    partial class Flappy_goat
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flappy_goat));
            flappyGoat = new PictureBox();
            ground = new PictureBox();
            pipe_down = new PictureBox();
            pipe_up = new PictureBox();
            lb_score = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)flappyGoat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe_down).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe_up).BeginInit();
            SuspendLayout();
            // 
            // flappyGoat
            // 
            flappyGoat.Image = (Image)resources.GetObject("flappyGoat.Image");
            flappyGoat.InitialImage = null;
            flappyGoat.Location = new Point(40, 260);
            flappyGoat.Margin = new Padding(2);
            flappyGoat.Name = "flappyGoat";
            flappyGoat.Size = new Size(92, 80);
            flappyGoat.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyGoat.TabIndex = 0;
            flappyGoat.TabStop = false;
            // 
            // ground
            // 
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.InitialImage = null;
            ground.Location = new Point(-9, 532);
            ground.Margin = new Padding(2);
            ground.Name = "ground";
            ground.Size = new Size(572, 148);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 1;
            ground.TabStop = false;
            // 
            // pipe_down
            // 
            pipe_down.Image = (Image)resources.GetObject("pipe_down.Image");
            pipe_down.InitialImage = null;
            pipe_down.Location = new Point(430, 351);
            pipe_down.Margin = new Padding(2);
            pipe_down.Name = "pipe_down";
            pipe_down.Size = new Size(90, 264);
            pipe_down.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe_down.TabIndex = 2;
            pipe_down.TabStop = false;
            // 
            // pipe_up
            // 
            pipe_up.Image = (Image)resources.GetObject("pipe_up.Image");
            pipe_up.InitialImage = null;
            pipe_up.Location = new Point(314, -3);
            pipe_up.Margin = new Padding(2);
            pipe_up.Name = "pipe_up";
            pipe_up.Size = new Size(90, 166);
            pipe_up.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe_up.TabIndex = 3;
            pipe_up.TabStop = false;
            // 
            // lb_score
            // 
            lb_score.AutoSize = true;
            lb_score.BackColor = Color.FromArgb(255, 192, 128);
            lb_score.Font = new Font("Microsoft YaHei", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_score.Location = new Point(-5, -3);
            lb_score.Margin = new Padding(4, 0, 4, 0);
            lb_score.Name = "lb_score";
            lb_score.Size = new Size(137, 42);
            lb_score.TabIndex = 4;
            lb_score.Text = "Score:0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Flappy_goat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(553, 659);
            Controls.Add(lb_score);
            Controls.Add(pipe_up);
            Controls.Add(ground);
            Controls.Add(pipe_down);
            Controls.Add(flappyGoat);
            Margin = new Padding(2);
            Name = "Flappy_goat";
            Text = "Flappy Goat";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)flappyGoat).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe_down).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe_up).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyGoat;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipe_down;
        private System.Windows.Forms.PictureBox pipe_up;
        private System.Windows.Forms.Label lb_score;
        internal System.Windows.Forms.Timer timer1;
    }
}

