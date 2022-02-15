using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7_2
{
	public partial class Form1 : Form
	{
		private int Number = 0;
		Random random = new Random();
		public Form1()
		{
			InitializeComponent();
			Number = random.Next(0, 100);
			textBox1.Text = "";
		}

		private void btnGameStart_Click(object sender, EventArgs e)
		{
			btnGameStart.Text = "Проверить";
			int userInput = 0;
			if(int.TryParse(textBox1.Text, out userInput) == false)
			{
				lblLessOrMore.Text = "Введите число";
			}
			else
			{
				if (userInput < Number)
				{
					lblLessOrMore.Text = "Больше";
				}
				else if (userInput > Number)
				{
					lblLessOrMore.Text = "Меньше";
				}
				else
				{
					MessageBox.Show($"Поздравляем! Вы угадали число {Number}");
					btnGameStart.Text = "Угадай число";
					lblLessOrMore.Text = "";
					Number = random.Next(0, 100);
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
