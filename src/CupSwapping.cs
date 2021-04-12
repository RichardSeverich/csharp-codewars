using System;
using System.Collections.Generic;

namespace csharp_codewars
{
    public class CupSwapping
    {
        public static string CupSwapp(string[] swaps)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("A", 0);
            dictionary.Add("B", 1);
            dictionary.Add("C", 2);
            string[] cups = new string[] { "", "ball", "" };
            swapp(dictionary, cups, swaps);
            int indexBall = Array.IndexOf(cups, "ball");
            return getResult(dictionary, indexBall);
        }

        private static void swapp(Dictionary<string, int> dictionary, string[] cups, string[] swaps)
        {
            string aux;
            int index1, index2;
            foreach (string swap in swaps)
            {
                index1 = dictionary[swap[0].ToString()];
                index2 = dictionary[swap[1].ToString()];
                aux = cups[index1];
                cups[index1] = cups[index2];
                cups[index2] = aux;
            }
        }

        private static string getResult(Dictionary<string, int> dictionary, int indexBall)
        {
            foreach (KeyValuePair<string, int> input in dictionary)
            {
                if (input.Value == indexBall)
                {
                    return input.Key.ToString();
                }
            }
            return string.Empty;
        }
    }
}
