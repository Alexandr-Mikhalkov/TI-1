using System;
using System.Text;

namespace Laba1
{
    public static class Vigener
    {
        public const int LetterCount = 33;

        public static string GetPlainTextOrKey(string str)
        {
            StringBuilder sb = new();
            foreach (char symbol in str)
            {
                var upperSymbol = char.ToUpper(symbol);
                if (upperSymbol is >= 'А' and <= 'Я' or 'Ё')
                    sb.Append(upperSymbol);
            }
            return sb.ToString();
        }

        private static string GetPlainTextWithSpaces(string str)
        {
            StringBuilder sb = new();
            foreach (char symbol in str)
            {
                var upperSymbol = char.ToUpper(symbol);
                if (upperSymbol is >= 'А' and <= 'Я' or 'Ё' or ' ')
                    sb.Append(upperSymbol);
            }
            return sb.ToString();
        }

        public static string Encode(string plainText, string key)
        {
            plainText = GetPlainTextWithSpaces(plainText);
            var resultText = GetPlainTextOrKey(plainText);
            if (resultText == "") return "";

            char[] letterArray = GenerateAlphabet();
            StringBuilder CText = new StringBuilder();
            char[] currentKey = key.ToCharArray();
            int index = 0;

            for (int i = 0; i < resultText.Length; i++)
            {
                char keyLetter = currentKey[index % key.Length];

                int changedLetter = GetLetterIndex(resultText[i]);
                int changedKeyLetter = GetLetterIndex(keyLetter);

                CText.Append(letterArray[(changedLetter + changedKeyLetter) % LetterCount]);

                index++;

                if (index % key.Length == 0)
                    currentKey = ShiftKey(currentKey, letterArray);
            }

            return RestoreSpaces(plainText, CText);
        }

        public static string Decode(string cipher, string key)
        {
            cipher = GetPlainTextWithSpaces(cipher);
            var resultText = GetPlainTextOrKey(cipher);
            if (resultText == "") return "";

            char[] letterArray = GenerateAlphabet();
            StringBuilder sbPlainText = new StringBuilder();
            char[] currentKey = key.ToCharArray();
            int index = 0;

            for (int i = 0; i < resultText.Length; i++)
            {
                char keyLetter = currentKey[index % key.Length];

                int changedLetter = GetLetterIndex(resultText[i]);
                int changedKeyLetter = GetLetterIndex(keyLetter);

                sbPlainText.Append(letterArray[(changedLetter + LetterCount - changedKeyLetter) % LetterCount]);

                index++;

                if (index % key.Length == 0)
                    currentKey = ShiftKey(currentKey, letterArray);
            }

            return RestoreSpaces(cipher, sbPlainText);
        }

        private static char[] GenerateAlphabet()
        {
            char[] letterArray = new char[LetterCount];
            int letter = 0;
            for (char i = 'А'; i <= 'Я'; i++)
            {
                if (letter == 6)
                    letterArray[letter++] = 'Ё';
                letterArray[letter++] = i;
            }
            return letterArray;
        }

        private static int GetLetterIndex(char letter)
        {
            return letter == 'Ё' ? 6 : letter <= 'Е' ? letter - 'А' : letter - 'А' + 1;
        }

        private static string RestoreSpaces(string original, StringBuilder modified)
        {
            StringBuilder sbResultText = new StringBuilder(original);
            int index = 0;
            for (int i = 0; i < sbResultText.Length; i++)
            {
                if (sbResultText[i] == ' ') continue;
                sbResultText[i] = modified[index++];
            }
            return sbResultText.ToString();
        }

        private static char[] ShiftKey(char[] key, char[] alphabet)
        {
            char[] newKey = new char[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                int index = Array.IndexOf(alphabet, key[i]);
                newKey[i] = alphabet[(index + 1) % LetterCount];
            }
            return newKey;
        }
    }
}