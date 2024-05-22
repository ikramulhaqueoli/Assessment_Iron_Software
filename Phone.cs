namespace AssessmentIronSoftware
{
    public static class Phone
    {
        private static Dictionary<char, string> oldPhoneButtonMap = 
            new Dictionary<char, string>()
            {
                {'0', " "},
                {'1', "&'("},
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"}
            };

        public static string OldPhonePad(string input)
        {
            string result = string.Empty;

            int sameCharStrict = 1;
            char previousChar = '!';
            
            foreach (var currentChar in input)
            {
                if (currentChar == previousChar)
                {
                    sameCharStrict++;
                }
                else
                {
                    if (previousChar >= '0' && previousChar <= '9')
                    {
                        var buttonString = oldPhoneButtonMap[previousChar];
                        var resultLetterIndex = (sameCharStrict-1) % buttonString.Length;
                        result += buttonString[resultLetterIndex];
                    }
                    else if (previousChar == '*')
                    {
                        var removeCount = Math.Min(result.Length, sameCharStrict);
                        result = result.Substring(0, result.Length - removeCount);
                    }

                    sameCharStrict = 1;
                }

                if (currentChar == '#') break;
                
                previousChar = currentChar;
            }

            return result.ToUpper();
        }
    }
}
