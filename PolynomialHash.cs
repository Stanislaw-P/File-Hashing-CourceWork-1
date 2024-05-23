using System;
using System.Globalization;
using System.IO;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace File_Hashing
{
    public class PolynomialHash
    {
        private const int p = 51;
        private const int mod = 1000000007;

        /// <summary>
        /// Основная хеш функция
        /// </summary>
        /// <param name="input">Входная строка данных</param>
        /// <returns>Сумма хеш функции в 16-ти ричной системе</returns>
        public static string ComputeHash(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            long hash = 0;
            long[] pows = _getPows(input);

            //input = Regex.Replace(input, "[-.?!)(,:]", "");

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                hash = (hash + (c - '!' + 1) * pows[i]) % mod;
            }
            return hash.ToString("X");
        }

        /// <summary>
        /// Перегрузка метода ComputeHash, хеширует массив строк
        /// </summary>
        /// <param name="inputArray">Массив исходных строк</param>
        /// <returns>Массив хешей для каждой строки соотвественно</returns>
        public static string[] ComputeHash(string[] inputArray)
        {
            long size = inputArray.Length;
            string[] result = new string[size];
            for (int i = 0; i < inputArray.Length; i++)
            {
                string temp = inputArray[i];
                result[i] = ComputeHash(temp);
            }
            return result;
        }

        /// <summary>
        /// Хеширование строк в файле "fileForOpen" и записывание результата в файл "fileForHash"
        /// </summary>
        /// <param name="fileForOpen">Исходный файл</param>
        /// <param name="fileForHash">Файл для сохранения хеш</param>
        public static void HashTheFile(string fileForOpen, string fileForHash)
        {
            string[] strings = File.ReadAllLines(fileForOpen);
            string[] hashString = ComputeHash(strings);

            File.WriteAllLines(fileForHash, hashString);
        }

        /// <summary>
        /// Получение хеш суммы файла в 16-ти ричной системе
        /// </summary>
        /// <param name="fileName">Исходный файл</param>
        /// <returns>Хеш сумма файла в 16-ти ричной системе</returns>
        public static string HashTheFile(string fileName)
        {
            string[] strings = File.ReadAllLines(fileName);
            string[] hashSting = ComputeHash(strings);

            long result = 0;

            for (int i = 0; i < hashSting.Length; i++)
            {
                long tempNum = Int64.Parse(hashSting[i], NumberStyles.HexNumber);
                result += tempNum;
            }
            return result.ToString("X");
        }  

        /// <summary>
        /// Создает массив со степенями константы p от p^0 до p^n
        /// </summary>
        /// <param name="input">Исходная строка</param>
        /// <returns>Массив длины n типа long</returns>
        private static long[] _getPows(string input)
        {
            long[] arr = new long[input.Length];
            arr[0] = 1;
            for (int i = 1; i < input.Length; i++)
            {
                arr[i] = (arr[i - 1] * p) % mod;
            }
            return arr;
        }


    }
}
