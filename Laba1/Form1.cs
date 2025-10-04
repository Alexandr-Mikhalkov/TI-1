using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Execbtn_Click(object sender, EventArgs e)
        {
            if (RFradioButton.Checked)
            {
                int key = RailwayFence.GetKey(KeytextBox.Text);
                if (key == -1)
                {
                    MessageBox.Show("Некорректный ключ (отсутствие цифр)!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                KeytextBox.Text = key.ToString();
                string plainText = RailwayFence.GetPlainText(PltextBox.Text);
                Func<string, int, string> processFunction =
                    EncoderadioButton.Checked ? RailwayFence.Encode : RailwayFence.Decode;

                string resText = processFunction(plainText, key);
                if (resText != plainText)
                {
                    RestextBox.Text = resText;
                }
            }
            else if (VradioButton.Checked)
            {
                string key = Vigener.GetPlainTextOrKey(KeytextBox.Text);
                if (key is "")
                {
                    MessageBox.Show("Некорректный ключ (отсутствие русских букв)!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                KeytextBox.Text = key;

                Func<string, string, string> processFunction =
                    EncoderadioButton.Checked ? Vigener.Encode : Vigener.Decode;
                var result = processFunction(PltextBox.Text, key);

                if (result == "")
                {
                    MessageBox.Show("Некорректный исходный текст (отсутствие русских букв)!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                RestextBox.Text = result;
            }
        }

        private void openFilems_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                using StreamReader sr = new StreamReader(openFileDialog.FileName);
                StringBuilder sb = new StringBuilder();

                string str = sr.ReadToEnd();
                str = str.Replace("\n", "");

                sb.Append(str);
                PltextBox.Text = sb.ToString();
            }
        }

        private void saveAsms_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RestextBox.Text))
            {
                MessageBox.Show("Выполните одно из действий для получения результата!",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.DefaultExt = "txt";

            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, RestextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла:\n{ex.Message}",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PltextBox_TextChanged(object sender, EventArgs e)
        {
            RestextBox.Clear();
        }

        private void clearPLbtn_Click(object sender, EventArgs e)
        {
            PltextBox.Clear();
        }

        private void clearKbtn_Click(object sender, EventArgs e)
        {
            KeytextBox.Clear();
        }

        private void DecoderadioButton_Click(object sender, EventArgs e)
        {
            KeytextBox.Clear();
        }
    }
}
