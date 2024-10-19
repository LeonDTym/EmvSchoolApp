namespace EmvSchoolApp
{
	public partial class Form1 : Form
	{
		private string sourceFilePath;
		private string targetFilePath;
		private string connectionString = "data source=cl-mssql-1-ag,1433;initial catalog=StudentCard;persist security info=True;user id=Checks;password=checks;MultipleActiveResultSets=True;App=EntityFramework&quot;";
		private const string filePath = "savedText.txt";
		public Form1()
		{
			InitializeComponent();
			LoadText();
		}
		private void LoadText()
		{
			if (File.Exists(filePath))
			{
				// ��������� ����� �� �����
				textBox2.Text = File.ReadAllText(filePath);
				targetFilePath = textBox2.Text;
				checkBox1.Checked = true; // ������������� ������� � ��������� "�������"
			}
		}
		private void SaveText(string text)
		{
			// ��������� ����� � ����
			File.WriteAllText(filePath, text);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					textBox1.Text = openFileDialog.FileName;
					sourceFilePath = openFileDialog.FileName;
					MessageBox.Show("������ ����: " + sourceFilePath);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(sourceFilePath))
			{
				MessageBox.Show("������� �������� ���� ��� ������.");
				return;
			}
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					targetFilePath = folderBrowserDialog.SelectedPath;
					textBox2.Text = targetFilePath.ToString();
					if (checkBox1.Checked)
					{
						// ��������� ����� � ����
						SaveText(textBox2.Text);
					}
				}
			}
		}
		private bool IsFileLocked(string filePath)
		{
			try
			{
				using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
				{
					return false; // ���� ��������
				}
			}
			catch (IOException)
			{
				return true; // ���� ������������
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(targetFilePath))
			{
				MessageBox.Show("������� �������� ���� ���������� �����.");
				return;
			}

			if (IsFileLocked(sourceFilePath))
			{
				MessageBox.Show("���� ������������ ������ ���������. ����������, �������� ��� � ���������� �����.");
				return;
			}

			try
			{
				string fileName = Path.GetFileName(sourceFilePath);
				string destinationFilePath = Path.Combine(targetFilePath, fileName);

				// ���������, ���������� �� ���� � ������� �����
				if (File.Exists(destinationFilePath))
				{
					// ���� ���� ����������, ������� ����� ��� ��� �����
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(sourceFilePath);
					string fileExtension = Path.GetExtension(sourceFilePath);
					int copyNumber = 1;

					// ���������� ����� ��� �����, ���� �� ������ ���������
					do
					{
						string newFileName = $"{fileNameWithoutExtension}_copy{copyNumber}{fileExtension}";
						destinationFilePath = Path.Combine(targetFilePath, newFileName);
						copyNumber++;
					} while (File.Exists(destinationFilePath));
				}

				// ���������� �������� ���
				progressBar1.Value = 0;
				progressBar1.Visible = true;

				// �������� ���� � ����������� �������� ����
				using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
				using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
				{
					byte[] buffer = new byte[4096]; // ����� ��� ������
					long totalBytes = sourceStream.Length;
					long totalReadBytes = 0;
					int bytesRead;

					while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
					{
						destinationStream.Write(buffer, 0, bytesRead);
						totalReadBytes += bytesRead;

						// ��������� �������� ���
						int progressPercentage = (int)((totalReadBytes * 100) / totalBytes);
						progressBar1.Value = progressPercentage;
					}
				}

				MessageBox.Show("���� ������� ���������� �: " + destinationFilePath);
			}
			catch (Exception ex)
			{
				MessageBox.Show("������ ��� ����������� �����: " + ex.Message);
			}
			finally
			{
				// �������� �������� ��� ����� ����������
				progressBar1.Visible = false;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				// ��������� ����� � ����
				SaveText(textBox2.Text);
			}
			else
			{
				// ������� ����, ���� ������� ����
				if (File.Exists(filePath))
				{
					File.Delete(filePath);
				}
			}
		}
	}
}
