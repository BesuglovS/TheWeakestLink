using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWeakestLink
{
    public partial class MainForm : Form
    {
        List<int> InitialStack = new List<int> {1000, 2000, 5000, 10000, 20000, 30000, 40000, 50000};
        private int BankAmmount;
        public static Color TimerBackgroundColor = Color.FromArgb(0, 255, 0);
        public static Color TimerDigitsColor = Color.FromArgb(255, 0, 0);

        public MainForm()
        {
            InitializeComponent();

            TimerBackColor.BackColor = TimerBackgroundColor;
            TimerForeColor.BackColor = TimerDigitsColor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("steps.txt"))
            {
                InitialStack.Clear();

                StreamReader sr = new StreamReader("steps.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        InitialStack.Add(int.Parse(line));
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
                sr.Close();
            }

            for (int i = 0; i < InitialStack.Count; i++)
            {
                CashStack.Items.Add(InitialStack[i]);
            }

            BankAmmount = 0;
            Bank.Text = BankAmmount.ToString();
        }

        private void AddStep_Click(object sender, EventArgs e)
        {
            var correct = true;
            var value = -1;
            try
            {
                value = int.Parse(Step.Text);
            }
            catch (Exception)
            {
                correct = false;
            }

            if (correct)
            {
                CashStack.Items.Add(value);
            }
            else
            {
                MessageBox.Show("Необходимо целое положительное число", "Неправильный формат");
            }
        }

        private void RemoveStep_Click(object sender, EventArgs e)
        {
            while (CashStack.SelectedItems.Count > 0)
            {
                CashStack.Items.Remove(CashStack.SelectedItems[0]);
            }
        }

        private void Raise_Click(object sender, EventArgs e)
        {
            if (CashStack.SelectedItems.Count == 0)
            {
                CashStack.SelectedIndex = 0;
                return;
            }

            if (CashStack.SelectedItems.Count > 1)
            {
                MessageBox.Show("Слишком много выделено", "Ошибочка вышла");
                return;
            }

            if (CashStack.SelectedItems.Count == 1)
            {
                var index = CashStack.SelectedIndex + 1;

                if (index < CashStack.Items.Count)
                {
                    CashStack.ClearSelected();
                    CashStack.SelectedIndex = index;
                }
                else
                {
                    MessageBox.Show("Не куда повышать уже", "Финиш");
                }
                return;
            }
        }

        private void ToBank_Click(object sender, EventArgs e)
        {
            var selectedItem = (int)CashStack.SelectedItem;

            BankAmmount += selectedItem;

            Bank.Text = BankAmmount.ToString();

            CashStack.ClearSelected();
            CashStack.SelectedIndex = 0;
        }

        private void ResetStack_Click(object sender, EventArgs e)
        {
            CashStack.ClearSelected();
            CashStack.SelectedIndex = 0;
        }

        private void ResetBank_Click(object sender, EventArgs e)
        {
            BankAmmount = 0;
            Bank.Text = BankAmmount.ToString();
        }

        private void RunTimer_Click(object sender, EventArgs e)
        {
            var minCount = int.Parse(MainTimerInterval.Text.Substring(0, 2));
            var secCount = int.Parse(MainTimerInterval.Text.Substring(3, 2));

            var timerIntervalInSeconds = minCount*60 + secCount;
            
            var timerForm = new TimerForm(timerIntervalInSeconds, FullScreenTimer.Checked, CloseFormOnTimer.Checked);
            timerForm.Show();
        }

        private void TimerBackColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = TimerBackgroundColor;

            var result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                TimerBackgroundColor = colorDialog.Color;

                TimerBackColor.BackColor = TimerBackgroundColor;
            }
            
        }

        private void TimerForeColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = TimerDigitsColor;

            var result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                TimerDigitsColor = colorDialog.Color;

                TimerForeColor.BackColor = TimerDigitsColor;
            }
        }
    }
}
