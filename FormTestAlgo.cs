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
    public partial class FormTestAlgo : Form
    {
        public FormTestAlgo()
        {
            InitializeComponent();
        }

        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            // Считываем количество тестов
            int countTest = Convert.ToInt32(textBoxCountTest.Text);
            AutoTest tester = new AutoTest();
            tester.GoTestRandom(countTest, labelResult);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сообщение о коллизии выводится следующим образом:\n (I) и (J) - номера совпавших строк\n Далее идет совпавший Хеш\nЗатем (в скобках) строки, хеши которых совпали", "Информация");
        }
    }
}
