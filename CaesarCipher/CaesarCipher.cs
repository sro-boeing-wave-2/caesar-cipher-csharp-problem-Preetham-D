using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            
            int[] asciiArray = new int[text.Length];
            Char[] textArray = text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                asciiArray[i] = textArray[i];
                //Console.Write(asciiArray[i]);
                if ((asciiArray[i] >= (int)'A' && asciiArray[i] <= (int)'Z'))
                {
                    asciiArray[i] += shiftKey;
                    if (asciiArray[i] > (int)'Z') asciiArray[i] -= 26;
                }
                if (asciiArray[i] >= (int)'a' && asciiArray[i] <= (int)'z')
                {
                    asciiArray[i] += shiftKey;
                    if (asciiArray[i] > (int)'z') asciiArray[i] -= 26;
                }
            }
            char[] ceaserstring = new char[text.Length];
            for(int i = 0; i < text.Length; i++)
            {
               ceaserstring[i] = Convert.ToChar(asciiArray[i]);
            }
            string answer = new string(ceaserstring);
            return answer;
            //return ceaserstring.ToString();

        }
    }
}
