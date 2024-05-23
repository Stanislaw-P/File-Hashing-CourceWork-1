using System;
using System.IO;
using System.Windows.Forms;

namespace File_Hashing
{
    public partial class FormHashFile : Form
    {
        public FormHashFile()
        {
            InitializeComponent();

            // Установка свойств окна открытия файла
            openFileDialog.Title = "Выбор файла";
            openFileDialog.Filter = "Text files(*.txt)|*.txt";
        }

        // Открытие файла
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // Получаем выбранный файл
            string fileName = openFileDialog.FileName;
            // Записываем в текс бокс путь к выбранному файлу
            textBoxSelectedFile.Text = fileName;
        }

        private void buttonClearOpen_Click(object sender, EventArgs e)
        {
            textBoxSelectedFile.Clear();
            textBoxSelectedFile.Focus();
            labelHashSum.Text = null;
        }

        private void buttonStartHash_Click(object sender, EventArgs e)
        {
            string pathForOpen = textBoxSelectedFile.Text;

            // Проверяем на корректность введеный или выбранный путь к файлу
            if (!(Path.GetExtension(pathForOpen) == ".txt") || !File.Exists(pathForOpen))
            {
                MessageBox.Show("Указан неверный путь к файлу, либо имя файла!\nВыберите файл с расширением *.txt.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Вызываем статический метод получения хеш суммы файла в 16-ти ричной системе
            string hashSumFile = PolynomialHash.HashTheFile(pathForOpen);
            labelHashSum.Text = hashSumFile;
            MessageBox.Show($"Хеширование выполнено!\n Хеш сумма файла: {hashSumFile}", "Сообщение");
        }
    }
}
