namespace Flappy_goat
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.flappyGoat = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipe_down = new System.Windows.Forms.PictureBox();
            this.pipe_up = new System.Windows.Forms.PictureBox();
            this.lb_score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappyGoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyGoat
            // 
            this.flappyGoat.Image = global::Flappy_goat.Properties.Resources.bird;
            this.flappyGoat.Location = new System.Drawing.Point(34, 225);
            this.flappyGoat.Margin = new System.Windows.Forms.Padding(2);
            this.flappyGoat.Name = "flappyGoat";
            this.flappyGoat.Size = new System.Drawing.Size(79, 69);
            this.flappyGoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyGoat.TabIndex = 0;
            this.flappyGoat.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_goat.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-8, 461);
            this.ground.Margin = new System.Windows.Forms.Padding(2);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(490, 128);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // pipe_down
            // 
            this.pipe_down.Image = global::Flappy_goat.Properties.Resources.pipe;
            this.pipe_down.Location = new System.Drawing.Point(369, 304);
            this.pipe_down.Margin = new System.Windows.Forms.Padding(2);
            this.pipe_down.Name = "pipe_down";
            this.pipe_down.Size = new System.Drawing.Size(77, 229);
            this.pipe_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_down.TabIndex = 2;
            this.pipe_down.TabStop = false;
            // 
            // pipe_up
            // 
            this.pipe_up.Image = global::Flappy_goat.Properties.Resources.pipedown;
            this.pipe_up.Location = new System.Drawing.Point(269, -3);
            this.pipe_up.Margin = new System.Windows.Forms.Padding(2);
            this.pipe_up.Name = "pipe_up";
            this.pipe_up.Size = new System.Drawing.Size(77, 144);
            this.pipe_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_up.TabIndex = 3;
            this.pipe_up.TabStop = false;
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lb_score.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score.Location = new System.Drawing.Point(-4, -3);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(169, 52);
            this.lb_score.TabIndex = 4;
            this.lb_score.Text = "Score:0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 571);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.pipe_up);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe_down);
            this.Controls.Add(this.flappyGoat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Flappy Goat";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappyGoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

