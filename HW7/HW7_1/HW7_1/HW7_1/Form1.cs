using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HW7_1
{
    public partial class mainForm : Form
    {
        Random rnd = new Random();
        int n = 0;
        int m = 0;
        int userAnswer = 0;
        int min = 0;
        int max = 100;
        Stack<String> Turns = new Stack<String>();

        public mainForm()
        {
            InitializeComponent();
            Turns.Clear();
            Turns.Push(lblGameNumber.Text);
            lblCancelTurns.Text = $"Ходы для отмены: {Turns.Count - 1}";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCount.Text = "0";
        }

        private void играToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Turns.Clear();
            Turns.Push(lblGameNumber.Text);
            tbControl.SelectedIndex = 1;
            n = rnd.Next(10, 100);
            lblNumberToFind.Text = n.ToString();
            lblCancelTurns.Visible = true;
            MessageBox.Show($"Нужно угадать число {n} за минимальное число ходов");


        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Turns.Clear();
            Turns.Push(lblGameNumber.Text);
            lblGameCount.Text = "0";
            lblGameNumber.Text = "1";
            n = rnd.Next(10, 100);
            lblNumberToFind.Text = n.ToString();
            lblCancelTurns.Visible = true;
            MessageBox.Show($"Нужно угадать число {n} за минимальное число ходов");
        }

        private void btnGamePlus_Click(object sender, EventArgs e)
        {
            lblGameNumber.Text = (int.Parse(lblGameNumber.Text) + 1).ToString();
            lblGameCount.Text = (int.Parse(lblGameCount.Text) + 1).ToString();
            Turns.Push(lblGameNumber.Text);
            lblCancelTurns.Text = $"Ходы для отмены: {Turns.Count - 1}";
            if (int.Parse(lblGameNumber.Text) == n)
            {
                MessageBox.Show($"Поздравляю вы угадали число {n} за {int.Parse(lblGameCount.Text)} ходов");
            }
            
        }

        private void btnGameMulti_Click(object sender, EventArgs e)
        {
            lblGameNumber.Text = (int.Parse(lblGameNumber.Text) * 2).ToString();
            lblGameCount.Text = (int.Parse(lblGameCount.Text) + 1).ToString();
            Turns.Push(lblGameNumber.Text);
            lblCancelTurns.Text = $"Ходы для отмены: {Turns.Count - 1}";
            if (int.Parse(lblGameNumber.Text) == n)
            {
                MessageBox.Show($"Поздравляю вы угадали число {n} за {int.Parse(lblGameCount.Text)} ходов");
            }
        }

        private void btnCancelLastTurn_Click(object sender, EventArgs e)
        {
            try
            {
                Turns.Pop();
                lblGameNumber.Text = Turns.Peek();
                lblCancelTurns.Text = $"Ходы для отмены: {Turns.Count - 1}";
            }
            catch (Exception)
            {

                if(Turns.Count <= 1)
                {
                    MessageBox.Show("Вы отменили доступное количество ходов\nБольше нечего отменить.");

                }
            }
            

        }

        private void tbpGame_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsmiGame2_Click(object sender, EventArgs e)
        {
            tbControl.SelectedIndex = 2;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGame2Start_Click(object sender, EventArgs e)
        {
            m = rnd.Next(0, 100);
            lblRules.Visible = true;
            tbUserAnswer.Visible = true;
            lblUserAnswer.Visible = true;
            lblHint.Visible = true;
            lblHint1.Text = string.Empty;
            lblGame2Count.Text = "0";
            lblFinish.Text = string.Empty;

        }

        private void tbUserAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbUserAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            lblFinish.Text = string.Empty;
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    userAnswer = int.Parse(tbUserAnswer.Text);
                }
                catch (Exception)
                {
                    lblFinish.Text = "Вы не ввели число.";
                    tbUserAnswer.Clear();
                    return;
                }

                if (userAnswer < 0 || userAnswer > 100)
                {
                    lblFinish.Text = "Число должно быть от 0 до 100.";
                    tbUserAnswer.Clear();
                    return;
                }
                else
                {
                    if (userAnswer == m)
                    {
                        lblFinish.Text = $"Вы угадали число!\nПопыток - {int.Parse(lblGame2Count.Text)}";
                        lblHint1.Text = string.Empty;
                    }
                    else
                    {
                        if (userAnswer < m && userAnswer > min)
                        {
                            min = userAnswer;
                        }
                        else if (userAnswer > m && userAnswer < max)
                        {
                            max = userAnswer;
                        }
                        lblHint1.Text = $"Вы не угадали число.\nЧисло находится в диапазоне от {min} до {max}.";
                    }
                    tbUserAnswer.Clear();
                    lblGame2Count.Text = (int.Parse(lblGame2Count.Text) + 1).ToString();
                }


            }

        }
    }
}
