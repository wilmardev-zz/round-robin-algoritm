using System.Text.RegularExpressions;

namespace Round_Robin
{
    public static class TextFunctions
    {
        public static string ClearSpecialCaracteres(string text)
        {
            string clearText = Regex.Replace(text, "[^0-9A-Za-z]", "", RegexOptions.None);
            return clearText;
        }

        public static bool isLetter(string letter)
        {
            Match m = Regex.Match(letter, "[A-Za-záéíóúAÉÍÓÚÑñ]", RegexOptions.IgnoreCase);
            if (m.Success || letter == Constants.KeyDelete)
                return true;
            return false;
        }

        public static bool isNumber(string letter)
        {
            Match m = Regex.Match(letter, "^[0-9]$", RegexOptions.IgnoreCase);
            if (m.Success || letter == Constants.KeyDelete)
                return true;
            return false;
        }

        public static bool IsSpecialCharacter(string letter)
        {
            if (isLetter(letter) || isNumber(letter))
                return false;
            return true;
        }

        public static bool IsWhiteSpace(string letter)
        {
            if (string.IsNullOrWhiteSpace(letter) || letter == Constants.KeyDelete)
                return true;
            return false;
        }

        public static bool IsDefaultKey(string letter)
        {
            if (letter == Constants.KeyCopy || letter == Constants.KeyPaste || letter == Constants.KeyReturn)
                return true;
            return false;
        }

        public static bool ValidateSpaces(string letter, string completeTetx)
        {
            if (IsWhiteSpace(letter) && string.IsNullOrEmpty(completeTetx))
                return true;
            return false;
        }

        public static bool IsDecimalSeparator(string letter)
        {
            if (letter == "," || letter == ".")
                return true;
            return false;
        }
    }
}