using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    public static class RailwayFence
    {
        public static int GetKey(string str)
        {
            string text = string.Join("", str.Where(char.IsDigit));

            if (int.TryParse(text, out var value))
            {
                int temp = Math.Abs(value);
                return temp == 0 ? -1 : value;
            }

            return -1;
        }

        public static string GetPlainText(string str)
        {
            StringBuilder plainText = new();
            foreach (char symbol in str)
            {
                char temp = char.ToUpper(symbol);
                if (temp is <= 'Я' and >= 'А' or 'Ё')
                    plainText.Append(temp);
            }
            return plainText.ToString();
        }

        public static string Encode(string plainText, int key)
        {
            // Error handling
            if (plainText.Length is 0)
            {
                MessageBox.Show("Некорректный исходный текст (нулевая длина или некорректные символы)!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return plainText;
            }

            if (key >= plainText.Length)
            {
                MessageBox.Show("Некорретные данные (значение ключа больше длины текста)!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return plainText;
            }

            if (key is 1)
            {
                MessageBox.Show("Некорректный ключ (длина ключа должна быть больше 1)!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return plainText;
            }

            List<List<char>> rails = new List<List<char>>();
            for (int i = 0; i < key; i++)
                rails.Add(new());

            int row = 0, direction = 1;
            for (int i = 0; i < plainText.Length; i++)
            {
                rails[row].Add(plainText[i]);
                row += direction;

                if ((row == key - 1) || (row == 0))
                    direction *= -1;
            }

            StringBuilder resText = new StringBuilder();
            for (int i = 0; i < key; i++)
            {
                foreach (var ch in rails[i])
                {
                    resText.Append(ch);
                }
                resText.Append(" ");
            }
            return resText.ToString();
        }

        public static string Decode(string CText, int key)
        {
            // Error handling
            if (CText.Length is 0)
            {
                MessageBox.Show("Некорректный исходный текст (нулевая длина)!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return CText;
            }

            if (key >= CText.Length)
            {
                MessageBox.Show("Некорретные данные (значение ключа больше длины текста)!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return CText;
            }

            if (key is 1)
            {
                MessageBox.Show("Некорректный ключ (длина ключа > 1)!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return CText;
            }

            char[,] rails = new char[key, CText.Length];
            int row = 0, direction = 1;

            for (int i = 0; i < CText.Length; i++)
            {
                rails[row, i] = '-';
                row += direction;

                if ((row == key - 1) || (row == 0))
                    direction *= -1;
            }

            int index = 0;
            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < CText.Length; j++)
                {
                    if (rails[i, j] == '-' && index < CText.Length)
                        rails[i, j] = CText[index++];
                }
            }

            StringBuilder plainText = new StringBuilder();
            row = 0;
            direction = 1;
            for (int i = 0; i < CText.Length; i++)
            {
                plainText.Append(rails[row, i]);
                row += direction;

                if (row == key - 1 || row == 0)
                    direction *= -1;
            }
            return plainText.ToString();
        }
    }
}