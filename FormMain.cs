using System;
using System.IO;
using System.Windows.Forms;

namespace File_Hashing
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // Установка свойств окна открытия файла
            openFileDialog.Title = "Выбор файла";
            openFileDialog.Filter = "Text files(*.txt)|*.txt";
            // Тут нужно сделать открытие папки проекта для открытия папки по умолчанию


            // Установка свойств окна сохранения файла
            saveFileDialog.Title = "Выбор папки для сохранения";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt";
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

        // Путь сохранения файла
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // Получаем выбранный файл
            string fileName = saveFileDialog.FileName;
            // Записываем в текс бокс путь к выбранному файлу
            textBoxSavePath.Text = fileName;
        }



        // Запустить хеширование
        private void buttonStartHash_Click(object sender, EventArgs e)
        {
            string pathForOpen = textBoxSelectedFile.Text;
            string pathForSave = textBoxSavePath.Text;

            // Проверка на корректность введенного или выбранного пути к файлу для чтения
            if (Path.GetExtension(pathForOpen) != ".txt" || !File.Exists(pathForOpen))
            {
                MessageBox.Show("Указан неверный путь к файлу, либо имя файла!\nВыберите файл с расширением *.txt.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на корректность введенного или выбранного пути к файлу для сохранения данных
            if (Path.GetExtension(pathForSave) != ".txt" )
            {
                MessageBox.Show("Вы не указали путь для сохранения результата\nВыберите файл с расширением *.txt.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Вызываем статический метод для хеширования данных в файле
            PolynomialHash.HashTheFile(pathForOpen, pathForSave);
            MessageBox.Show($"Хеширование выполнено!\n Файл с хешем сохранен в {pathForSave}", "Сообщение");
         
        }

        // Очищение текст бокса файла для открытия
        private void buttonClearOpen_Click(object sender, EventArgs e)
        {
            textBoxSelectedFile.Clear();
            textBoxSelectedFile.Focus();
        }

        // Очищение текст бокса файла для сохранения
        private void buttonClearSave_Click(object sender, EventArgs e)
        {
            textBoxSavePath.Clear();
            textBoxSavePath.Focus();
        }

        private void toolStripMenuItemHashSumFile_Click(object sender, EventArgs e)
        {
            FormHashFile formHashFile = new FormHashFile();
            formHashFile.Show();
        }

        private void toolStripMenuItemHashWord_Click(object sender, EventArgs e)
        {
            FormHashWord formHashWord = new FormHashWord();
            formHashWord.Show();
        }

        private void toolStripMenuItemTest_Click(object sender, EventArgs e)
        {
            FormTestAlgo formTestAlgo = new FormTestAlgo();
            formTestAlgo.Show();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.Show();
        }
    }
}
