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

        // Запустить хеширование
        private void buttonStartHash_Click(object sender, EventArgs e)
        {
            string pathForOpen = textBoxSelectedFile.Text;
            string pathForSave = textBoxSavePath.Text;

            // Проверяем на корректность введеный или выбранный путь к файлу
            if (!(Path.GetExtension(pathForOpen) == ".txt") || !File.Exists(pathForOpen))
            {
                MessageBox.Show("Указан неверный путь к файлу, либо имя файла!\nВыберите файл с расширением *.txt.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                return;
            }

            // Вызываем статический метод для хеширования данных в файле
            PolynomialHash.HashTheFile(pathForOpen, pathForSave);
            MessageBox.Show($"Хеширование выполнено!\n Файл с хешем сохранен в {pathForSave}", "Сообщение");
            clearTextBoxes();
        }

        // Очистить текст боксы
        private void clearTextBoxes()
        {
            textBoxSelectedFile.Clear();
            textBoxSelectedFile.Focus();
            textBoxSavePath.Clear();
        }

        private void toolStripMenuItemHashSumFile_Click(object sender, EventArgs e)
        {
            FormHashFile formHashFile = new FormHashFile();
            formHashFile.Show();
        }

        private void toolStripMenuItemHashWord_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemTest_Click(object sender, EventArgs e)
        {

        }
    }
}
