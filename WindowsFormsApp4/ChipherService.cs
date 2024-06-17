using System;
using System.Collections.Generic;

namespace WindowsFormsApp4
{
    public class ChipherService
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        private int loopIndex(int index, int key)
        {
            if (index + key >= alphabet.Length)
            {
                return Math.Abs(alphabet.Length - (index + key));
            }
            else
            {
                return index + key;
            }
        }

        public string generateChipher(string text, int key)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    result += text[i];
                }
                else
                {
                    int index = loopIndex(alphabet.IndexOf(text[i]), key);

                    result += alphabet[index];
                }
            }

            return result;
        }
    }
}
