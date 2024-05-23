using System;
using System.Text;

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

        public void GoTestRandom(int countIteration)
        {
            int countCoints = 0;

            string stringTemp;
            string resultTemp;

            string[] arrayString = new string[countIteration];
            string[] arrayHash = new string[countIteration];

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
                            // Вывод сообщения на экран
                            Console.WriteLine($"Collision! (I): {i} {arrayHash[i]} ({arrayString[i]}) (J): {j} {arrayHash[j]} ({arrayString[j]})");
                            countCoints++;
                        }
                }
            }


            Console.WriteLine($"Count collision: {countCoints / 2} / {countIteration}");
        }

    }
}
