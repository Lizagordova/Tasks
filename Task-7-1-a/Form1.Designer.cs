namespace Task_7_1_a
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
			this.btnCommand1 = new System.Windows.Forms.Button();
			this.btnCommand2 = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.lblNumber = new System.Windows.Forms.Label();
			this.lblCommandsNumber = new System.Windows.Forms.Label();
			this.lblCommandsNumberCounter = new System.Windows.Forms.Label();
			this.btnPlay = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCommand1
			// 
			this.btnCommand1.Location = new System.Drawing.Point(337, 28);
			this.btnCommand1.Name = "btnCommand1";
			this.btnCommand1.Size = new System.Drawing.Size(75, 23);
			this.btnCommand1.TabIndex = 0;
			this.btnCommand1.Text = "+1";
			this.btnCommand1.UseVisualStyleBackColor = true;
			this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
			// 
			// btnCommand2
			// 
			this.btnCommand2.Location = new System.Drawing.Point(337, 57);
			this.btnCommand2.Name = "btnCommand2";
			this.btnCommand2.Size = new System.Drawing.Size(75, 23);
			this.btnCommand2.TabIndex = 1;
			this.btnCommand2.Text = "x2";
			this.btnCommand2.UseVisualStyleBackColor = true;
			this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(337, 95);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Сброс";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Location = new System.Drawing.Point(59, 28);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(13, 15);
			this.lblNumber.TabIndex = 3;
			this.lblNumber.Text = "0";
			// 
			// lblCommandsNumber
			// 
			this.lblCommandsNumber.AutoSize = true;
			this.lblCommandsNumber.Location = new System.Drawing.Point(13, 72);
			this.lblCommandsNumber.Name = "lblCommandsNumber";
			this.lblCommandsNumber.Size = new System.Drawing.Size(195, 15);
			this.lblCommandsNumber.TabIndex = 4;
			this.lblCommandsNumber.Text = "Количество отданных комманд = ";
			this.lblCommandsNumber.Click += new System.EventHandler(this.lblCommandsNumber_Click);
			// 
			// lblCommandsNumberCounter
			// 
			this.lblCommandsNumberCounter.AutoSize = true;
			this.lblCommandsNumberCounter.Location = new System.Drawing.Point(205, 72);
			this.lblCommandsNumberCounter.Name = "lblCommandsNumberCounter";
			this.lblCommandsNumberCounter.Size = new System.Drawing.Size(13, 15);
			this.lblCommandsNumberCounter.TabIndex = 5;
			this.lblCommandsNumberCounter.Text = "0";
			// 
			// btnPlay
			// 
			this.btnPlay.Location = new System.Drawing.Point(337, 135);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(75, 23);
			this.btnPlay.TabIndex = 6;
			this.btnPlay.Text = "Играть";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 170);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.lblCommandsNumberCounter);
			this.Controls.Add(this.lblCommandsNumber);
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnCommand2);
			this.Controls.Add(this.btnCommand1);
			this.Name = "Form1";
			this.Text = "Удвоитель";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnCommand1;
		private System.Windows.Forms.Button btnCommand2;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.Label lblCommandsNumber;
		private System.Windows.Forms.Label lblCommandsNumberCounter;
		private System.Windows.Forms.Button btnPlay;
	}
}