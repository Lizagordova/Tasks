
namespace Task_7_2
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
			this.btnGameStart = new System.Windows.Forms.Button();
			this.lblLessOrMore = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnGameStart
			// 
			this.btnGameStart.Location = new System.Drawing.Point(180, 112);
			this.btnGameStart.Name = "btnGameStart";
			this.btnGameStart.Size = new System.Drawing.Size(164, 36);
			this.btnGameStart.TabIndex = 0;
			this.btnGameStart.Text = "Угадай число";
			this.btnGameStart.UseVisualStyleBackColor = true;
			this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
			// 
			// lblLessOrMore
			// 
			this.lblLessOrMore.AutoSize = true;
			this.lblLessOrMore.Location = new System.Drawing.Point(245, 65);
			this.lblLessOrMore.Name = "lblLessOrMore";
			this.lblLessOrMore.Size = new System.Drawing.Size(10, 15);
			this.lblLessOrMore.TabIndex = 1;
			this.lblLessOrMore.Text = " ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(60, 82);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 23);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 204);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblLessOrMore);
			this.Controls.Add(this.btnGameStart);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGameStart;
		private System.Windows.Forms.Label lblLessOrMore;
		private System.Windows.Forms.TextBox textBox1;
	}
}

