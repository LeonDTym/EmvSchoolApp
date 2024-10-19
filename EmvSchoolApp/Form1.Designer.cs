namespace EmvSchoolApp
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
			button1 = new Button();
			button2 = new Button();
			label1 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label2 = new Label();
			button3 = new Button();
			progressBar1 = new ProgressBar();
			checkBox1 = new CheckBox();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(423, 48);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(86, 31);
			button1.TabIndex = 0;
			button1.Text = "Обзор";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(423, 123);
			button2.Margin = new Padding(3, 4, 3, 4);
			button2.Name = "button2";
			button2.Size = new Size(86, 31);
			button2.TabIndex = 1;
			button2.Text = "Обзор";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(14, 24);
			label1.Name = "label1";
			label1.Size = new Size(197, 20);
			label1.TabIndex = 2;
			label1.Text = "Выберите файл для чтения";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(14, 48);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Name = "textBox1";
			textBox1.ReadOnly = true;
			textBox1.Size = new Size(413, 27);
			textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(14, 123);
			textBox2.Margin = new Padding(3, 4, 3, 4);
			textBox2.Name = "textBox2";
			textBox2.ReadOnly = true;
			textBox2.Size = new Size(413, 27);
			textBox2.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(14, 99);
			label2.Name = "label2";
			label2.Size = new Size(237, 20);
			label2.TabIndex = 5;
			label2.Text = "Выберете место для сохранения";
			// 
			// button3
			// 
			button3.Location = new Point(138, 161);
			button3.Margin = new Padding(3, 4, 3, 4);
			button3.Name = "button3";
			button3.Size = new Size(145, 31);
			button3.TabIndex = 6;
			button3.Text = "Конвертировать";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// progressBar1
			// 
			progressBar1.Location = new Point(14, 200);
			progressBar1.Margin = new Padding(3, 4, 3, 4);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(414, 31);
			progressBar1.TabIndex = 7;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(14, 249);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(101, 24);
			checkBox1.TabIndex = 8;
			checkBox1.Text = "checkBox1";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
			Controls.Add(checkBox1);
			Controls.Add(progressBar1);
			Controls.Add(button3);
			Controls.Add(label2);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(button2);
			Controls.Add(button1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button button2;
		private Label label1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label2;
		private Button button3;
		private ProgressBar progressBar1;
		private CheckBox checkBox1;
	}
}
