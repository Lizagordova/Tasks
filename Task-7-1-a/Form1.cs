using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7_1_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			btnCommand1.Text = "+1";
			btnCommand2.Text = "x2";
			btnReset.Text = "Сброс";
			lblNumber.Text = "0";
			lblCommandsNumber.Text = "Количество отданных комманд = ";
			lblCommandsNumberCounter.Text = "0";
			this.Text = "Удвоитель";
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnCommand1_Click(object sender, EventArgs e)
		{
			lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
			AddCommand();
			СheckNumber();
		}

		private void btnCommand2_Click(object sender, EventArgs e)
		{
			lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
			AddCommand();
			СheckNumber();
		}

		private void lblCommandsNumber_Click(object sender, EventArgs e)
		{

		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			lblNumber.Text = "1";
			AddCommand();
		}

		private void AddCommand()
		{
			lblCommandsNumberCounter.Text = (int.Parse(lblCommandsNumberCounter.Text) + 1).ToString();
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Вы должны получить число 13 за минимальное количество ходов");
		}
		private void СheckNumber()
		{
			int number = int.Parse(lblNumber.Text);
			if(number == 13)
			{
				MessageBox.Show("Игра закончена");
			}
		}
	}
}