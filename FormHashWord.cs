using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Hashing
{
    public partial class FormHashWord : Form
    {
        public FormHashWord()
        {
            InitializeComponent();
        }

        // Очистить текст бокс ввода
        private void buttonClearWord_Click(object sender, EventArgs e)
        {
            textBoxGetWord.Clear();
            textBoxGetWord.Focus();
            labelHashWord.Text = null;
        }

        private void buttonStartHashWord_Click(object sender, EventArgs e)
        {
            string word = textBoxGetWord.Text;
            string resultHashWord = PolynomialHash.ComputeHash(word);
            labelHashWord.Text = resultHashWord;
            MessageBox.Show($"Хеширование выполнено!\n Хеш сумма слова: {resultHashWord}", "Сообщение");
        }
    }
}
