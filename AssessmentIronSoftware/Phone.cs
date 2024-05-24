namespace AssessmentIronSoftware
{
    public static class Phone
    {
        private static readonly Dictionary<char, string> oldPhoneButtonMap = 
            new()
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

            int repeatCharStreak = 1;
            char previousChar = '!';
            
            foreach (var currentChar in input)
            {
                /*
                    Count the consecutive repeated character Streak by using 
                    repeatCharStreak: int while looping through each input character.
                */
                if (currentChar == previousChar)
                {
                    repeatCharStreak++;
                }
                else
                {
                    /*
                        When the character is not a repeat to the previous character,
                        Handle the repeated Streak count of the previous digit and 
                        choose the appropriete letter from the oldPhoneButtonMap: Dictionary.
                    */
                    if (previousChar >= '0' && previousChar <= '9')
                    {
                        var buttonString = oldPhoneButtonMap[previousChar];
                        var resultLetterIndex = (repeatCharStreak-1) % buttonString.Length;
                        result += buttonString[resultLetterIndex];
                    }
                    /*
                        When the previous character is * (backspace). 
                        Remove characters from the end of result: string by repeated count of *.
                    */
                    else if (previousChar == '*')
                    {
                        var removeCount = Math.Min(result.Length, repeatCharStreak);
                        result = result.Substring(0, result.Length - removeCount);
                    }
                    
                    // reset the repeatCharStreak: int to 1 for the currentChar
                    repeatCharStreak = 1;
                }

                // break the loop considering `#` as the last character in the input.
                if (currentChar == '#') break;
                
                previousChar = currentChar;
            }

            return result.ToUpper();
        }
    }
}
