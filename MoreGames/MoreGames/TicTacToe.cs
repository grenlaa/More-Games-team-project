using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игры
{
    public partial class TicTacToe : Form
    {

        /*public bool? IsHost { get; set; }
        public string IpAddress { get; set; }
        public int Port { get; set; }*/

        // Переменные для отслеживания игры
        private bool isXturn = true; // true - ход X, false - ход O
        private int turnCount = 0;
        private Button[,] buttons;
        // private Label labelTurn;
        private Button NewGameBtn;

        public TicTacToe()
        {
            InitializeComponent();

            // Инициализация массива кнопок
            buttons = new Button[3, 3];

            // Находим все элементы управления на форме
            int index = 0;
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Name.StartsWith("button"))
                {
                    int row = index / 3;
                    int col = index % 3;
                    buttons[row, col] = (Button)control;
                    buttons[row, col].Click += Btn_Click;
                    index++;
                }
                else if (control is Button && control.Name == "NewGameBtn")
                {
                    newGameBtn = (Button)control;
                    newGameBtn.Click += NewGameBtn_Click;
                }
                else if (control is Label && control.Name == "labelTurn")
                {
                    labelTurn = (Label)control;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Проверяем, пустая ли кнопка
            if (string.IsNullOrEmpty(clickedButton.Text))
            {
                // Устанавливаем значение (X или O)
                clickedButton.Text = isXturn ? "X" : "O";

                // Обновляем счетчик ходов
                turnCount++;

                // Проверяем победу
                if (CheckWin())
                {
                    MessageBox.Show($"Победил {clickedButton.Text}!");
                    ResetGame();
                    return;
                }

                // Проверяем ничью
                if (turnCount == 9)
                {
                    MessageBox.Show("Ничья!");
                    ResetGame();
                    return;
                }

                // Меняем очередь игроков
                isXturn = !isXturn;
                labelTurn.Text = $"Ходит: {(isXturn ? "X" : "O")}";
            }
        }

        private bool CheckWin()
        {
            // Проверяем строки
            for (int i = 0; i < 3; i++)
            {
                if (!string.IsNullOrEmpty(buttons[i, 0].Text) &&
                    buttons[i, 0].Text == buttons[i, 1].Text &&
                    buttons[i, 1].Text == buttons[i, 2].Text)
                    return true;
            }

            // Проверяем столбцы
            for (int i = 0; i < 3; i++)
            {
                if (!string.IsNullOrEmpty(buttons[0, i].Text) &&
                    buttons[0, i].Text == buttons[1, i].Text &&
                    buttons[1, i].Text == buttons[2, i].Text)
                    return true;
            }

            // Проверяем диагонали
            if (!string.IsNullOrEmpty(buttons[0, 0].Text) &&
                buttons[0, 0].Text == buttons[1, 1].Text &&
                buttons[1, 1].Text == buttons[2, 2].Text)
                return true;

            if (!string.IsNullOrEmpty(buttons[0, 2].Text) &&
                buttons[0, 2].Text == buttons[1, 1].Text &&
                buttons[1, 1].Text == buttons[2, 0].Text)
                return true;

            return false;
        }

        private void ResetGame()
        {
            // Очищаем текст всех кнопок в массиве
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = string.Empty;
                }
            }
            isXturn = true;
            turnCount = 0;
            labelTurn.Text = "Ходит: X";
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}