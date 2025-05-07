using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreGames
{
    public partial class Form2_rememberGame : Form
    {
        List<string> usersGuess = new List<string>();
        List<string> list = new List<string>();
        private int numOfTry = 1;
        private bool IsReset = false;
        private bool IsStun = true;
        private bool IsLocked = true;
        private Task _task;
        private static CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        private CancellationToken token = cancelTokenSource.Token;
        private bool IsClosing = false;
        public Form2_rememberGame()
        {
            InitializeComponent();
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;
        }

        private async Task UpdatePrAsync()
        {

            try
            {
                while (!token.IsCancellationRequested)
                {


                    if (IsReset)
                    {
                        usersGuess.Clear();
                        list.Clear();
                        IsReset = false;
                        IsStun = true;
                        IsLocked = true;
                        pictureBox1.BackColor = Color.Red;
                        pictureBox2.BackColor = Color.Yellow;
                        pictureBox3.BackColor = Color.Blue;
                        pictureBox4.BackColor = Color.Green;
                        label1.Text = "Round 1!";
                        label2.Text = "Show your memory!";
                        numOfTry = 1;
                    }



                    Random ran = new Random();
                    for (int i = 0; i < numOfTry; i++)
                    {
                        int randNum = ran.Next(1, 5);
                        list.Add(randNum.ToString());
                        await Task.Delay(600);
                        if (list[i] == "1")
                        {
                            pictureBox1.BackColor = Color.DarkRed;
                            await Task.Delay(1000);
                            pictureBox1.BackColor = Color.Red;
                        }
                        else if (list[i] == "2")
                        {
                            pictureBox2.BackColor = Color.Gold;
                            await Task.Delay(1000);
                            pictureBox2.BackColor = Color.Yellow;
                        }
                        else if (list[i] == "3")
                        {
                            pictureBox3.BackColor = Color.DarkBlue;
                            await Task.Delay(1000);
                            pictureBox3.BackColor = Color.Blue;
                        }
                        else if (list[i] == "4")
                        {
                            pictureBox4.BackColor = Color.DarkGreen;
                            await Task.Delay(600);
                            pictureBox4.BackColor = Color.Green;
                        }

                    }
                    IsLocked = false;
                    while (IsStun && !token.IsCancellationRequested)
                    {
                        if (usersGuess.Count == numOfTry)
                        {


                            if (usersGuess.SequenceEqual(list))
                            {
                                numOfTry += 1;
                                label2.Text = "You are correct!";
                            }
                            else
                            {
                                numOfTry = 1;
                                label2.Text = "You've lost your streak, try again!";
                            }
                            label1.Text = $"Round {numOfTry}!";
                            usersGuess.Clear();
                            list.Clear();
                            IsStun = false;
                            IsLocked = true;
                        }
                        await Task.Delay(1000, token);
                    }
                    IsStun = true;
                }
            }
            catch (OperationCanceledException)
            {
                // Игнорируем отмену задачи
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void pictureBox1_ClickAsync(object sender, EventArgs e)
        {
            if (!IsLocked)
            {
                pictureBox1.BackColor = Color.DarkRed;
                usersGuess.Add("1");

                await Task.Delay(600);

                pictureBox1.BackColor = Color.Red;
            }

        }

        private async void pictureBox2_ClickAsync(object sender, EventArgs e)
        {
            if (!IsLocked)
            {
                pictureBox2.BackColor = Color.Gold;
                usersGuess.Add("2");

                await Task.Delay(600);
                pictureBox2.BackColor = Color.Yellow;
            }
        }

        private async void pictureBox3_ClickAsync(object sender, EventArgs e)
        {
            if (!IsLocked)
            {
                pictureBox3.BackColor = Color.DarkBlue;
                usersGuess.Add("3");

                await Task.Delay(600);
                pictureBox3.BackColor = Color.Blue;
            }
        }

        private async void pictureBox4_ClickAsync(object sender, EventArgs e)
        {
            if (!IsLocked)
            {
                pictureBox4.BackColor = Color.DarkGreen;
                usersGuess.Add("4");

                await Task.Delay(600);
                pictureBox4.BackColor = Color.Green;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsReset = true;
            if (_task == null || _task.IsCompleted)
            {
                cancelTokenSource?.Dispose();
                cancelTokenSource = new CancellationTokenSource();
                token = cancelTokenSource.Token;
                _task = UpdatePrAsync();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }


        private async void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_task != null && !_task.IsCompleted)
            {
                // Если задача выполняется, сначала запрашиваем подтверждение
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult result = MessageBox.Show(
                        "Вы действительно хотите закрыть программу?",
                        "Подтверждение",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                // Отменяем задачу и ждём её завершения
                cancelTokenSource.Cancel();
                e.Cancel = true; // Временно отменяем закрытие

                try
                {
                    await _task; // Ждём завершения задачи
                }
                catch (OperationCanceledException)
                {
                    // Игнорируем отмену
                }

                // После завершения задачи закрываем форму
                if (!this.IsDisposed)
                {
                    this.Close();
                }
            }
        }


    }
}

