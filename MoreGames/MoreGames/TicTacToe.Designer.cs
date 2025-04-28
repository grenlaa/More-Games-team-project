namespace Игры
{
    partial class TicTacToe
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            NewGameBtn = new Button();
            labelTurn = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 36F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(35, 12);
            button1.Name = "button1";
            button1.Size = new Size(80, 80);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 36F, FontStyle.Bold);
            button2.Location = new Point(144, 12);
            button2.Name = "button2";
            button2.Size = new Size(80, 80);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 36F, FontStyle.Bold);
            button3.Location = new Point(255, 12);
            button3.Name = "button3";
            button3.Size = new Size(80, 80);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 36F, FontStyle.Bold);
            button4.Location = new Point(35, 107);
            button4.Name = "button4";
            button4.Size = new Size(80, 80);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Arial", 36F, FontStyle.Bold);
            button5.Location = new Point(144, 107);
            button5.Name = "button5";
            button5.Size = new Size(80, 80);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Arial", 36F, FontStyle.Bold);
            button6.Location = new Point(255, 107);
            button6.Name = "button6";
            button6.Size = new Size(80, 80);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Arial", 36F, FontStyle.Bold);
            button7.Location = new Point(35, 203);
            button7.Name = "button7";
            button7.Size = new Size(80, 80);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Arial", 36F, FontStyle.Bold);
            button8.Location = new Point(144, 203);
            button8.Name = "button8";
            button8.Size = new Size(80, 80);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Arial", 36F, FontStyle.Bold);
            button9.Location = new Point(255, 203);
            button9.Name = "button9";
            button9.Size = new Size(80, 80);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            // 
            // NewGameBtn
            // 
            NewGameBtn.Location = new Point(192, 299);
            NewGameBtn.Name = "NewGameBtn";
            NewGameBtn.Size = new Size(143, 33);
            NewGameBtn.TabIndex = 9;
            NewGameBtn.Text = "Новая игра";
            NewGameBtn.UseVisualStyleBackColor = true;
            // 
            // labelTurn
            // 
            labelTurn.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTurn.Location = new Point(35, 299);
            labelTurn.Name = "labelTurn";
            labelTurn.Size = new Size(151, 33);
            labelTurn.TabIndex = 10;
            labelTurn.Text = "Ходит: X";
            labelTurn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 344);
            Controls.Add(labelTurn);
            Controls.Add(NewGameBtn);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button newGameBtn;
        private Label labelTurn;
    }
}