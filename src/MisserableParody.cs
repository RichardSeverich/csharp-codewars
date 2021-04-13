using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace csharp_codewars
{
    class MisserableParody
    {
        internal static double Calculator(string str)
        {
            string operationsString = Regex.Replace(str, "[0-9]", "");
            string[] arrayNumbers = str.Split('+','*','/','-');
            List<string> listNumbers = new List<string>(arrayNumbers);
            List<string> listOperations = convertStringToList(operationsString);
            if (str.StartsWith("-"))
            {
                listNumbers.RemoveAt(0);
                listOperations.RemoveAt(0);
                string value = listNumbers[0];
                listNumbers.RemoveAt(0);
                listNumbers.Insert(0,"-" + value);
            }
            listNumbers = operations(listOperations, listNumbers, "/");
            listNumbers = operations(listOperations, listNumbers, "*");
            listNumbers = operations(listOperations, listNumbers, "-");
            listNumbers = operations(listOperations, listNumbers, "+");
            return Double.Parse(listNumbers[0]);
        }

        internal static List<string> operations(
            List<string> listOperations,
            List<string> listNumbers,
            string operation
            )
        {
            if (!listOperations.Contains(operation))
            {
                return listNumbers;
            }
            int index = listOperations.IndexOf(operation);
            double number1 = Double.Parse(listNumbers[index]);
            double number2 = Double.Parse(listNumbers[index + 1]);
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }
            listOperations.RemoveAt(index);
            listNumbers.RemoveAt(index);
            listNumbers.Insert(index, result.ToString());
            listNumbers.RemoveAt(index + 1);
            if (listOperations.Contains(operation) )
            {
                listNumbers = operations(listOperations, listNumbers, operation);
            }
            return listNumbers;
        }


        internal static List<string> convertStringToList(string operationsString)
        {
            List<string> listString = new List<string>();
            char[] charArr = operationsString.ToCharArray();
            foreach (char ch in charArr)
            {
                listString.Add(ch.ToString());
            }
            return listString;
        }
    }
}
