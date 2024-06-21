using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace File_Hashing
{
    public class AutoTest : PolynomialHash
    {
        private string _chars = "1234567980qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNMйцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
        private static Random rnd = new Random();

        
        private string _genearationString()
        {
            StringBuilder str = new StringBuilder();

            int lenString = rnd.Next(5, 24);
            for (int i = 0; i < lenString; i++)
            {
                str.Append(_chars[rnd.Next(0, _chars.Length)]);
            }
            return str.ToString();
        }

        //public void GoTestRandom(int countIteration)
        //{
        //    int countCoints = 0;

        //    string stringTemp;
        //    string resultTemp;

        //    string[] arrayString = new string[countIteration];
        //    string[] arrayHash = new string[countIteration];

        //    // Заполнение
        //    for (int i = 0; i < countIteration; i++)
        //    {
        //        stringTemp = _genearationString();
        //        resultTemp = PolynomialHash.ComputeHash(stringTemp);

        //        arrayString[i] = stringTemp;
        //        arrayHash[i] = resultTemp;

        //    }
        //    // Поиск совпадений
        //    for (int i = 0; i < countIteration; i++)
        //    {
        //        for (int j = 0; j < countIteration; j++)
        //        {
        //            // Не сравниваем строку саму с собой
        //            if (i == j)
        //                continue;
        //            // Если есть совпадение
        //            if (arrayHash[i] == arrayHash[j])
        //                // Проверяем не равны ли строки
        //                if (arrayString[i] != arrayString[j] && i <= j)
        //                {
        //                    // Вывод сообщения на экран
        //                    Console.WriteLine($"Collision! (I): {i} {arrayHash[i]} ({arrayString[i]}) (J): {j} {arrayHash[j]} ({arrayString[j]})");
        //                    countCoints++;
        //                }
        //        }
        //    }


        //    Console.WriteLine($"Count collision: {countCoints / 2} / {countIteration}");
        //}



        public void GoTestRandom(int countIteration, Label labelForResult)
        {
            int countCollisions = 0;

            string stringTemp;
            string resultTemp;

            string[] arrayString = new string[countIteration];
            string[] arrayHash = new string[countIteration];

            // Лист с повторами
            List<string> listRepeat = new List<string>();

            // Заполнение
            for (int i = 0; i < countIteration; i++)
            {
                stringTemp = _genearationString();
                resultTemp = PolynomialHash.ComputeHash(stringTemp);

                arrayString[i] = stringTemp;
                arrayHash[i] = resultTemp;

            }
            // Поиск совпадений
            for (int i = 0; i < countIteration; i++)
            {
                for (int j = 0; j < countIteration; j++)
                {
                    // Не сравниваем строку саму с собой
                    if (i == j)
                        continue;
                    // Если есть совпадение
                    if (arrayHash[i] == arrayHash[j])
                        // Проверяем не равны ли строки
                        if (arrayString[i] != arrayString[j] && i <= j)
                        {
                            // Сохранение сообщения в лист где хранятся повторы
                            listRepeat.Add($"Коллизия! (I): {i} {arrayHash[i]} ({arrayString[i]})\t (J): {j} {arrayHash[j]} ({arrayString[j]})\n");
                            countCollisions++;
                        }
                }
            }

            // Если количество коллизий равно 0, то сообщаем об этом
            if (countCollisions == 0)
            {
                MessageBox.Show($"Количество коллизий равно 0 на {countIteration} тестов!");
                labelForResult.Text = "0";
            }
            else
            {
                // Иначе выводим количество коллизий и спрашиваем: нужно ли показать коллизии?
                DialogResult result = MessageBox.Show($"Количество коллизий равно {countCollisions}, показать их?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                labelForResult.Text = countCollisions.ToString();
                if (result == DialogResult.Yes)
                {
                    labelForResult.Text = "";
                    foreach (var line in listRepeat)
                    {
                        labelForResult.Text += line;
                    }
                }
            }
        }

    }
}
