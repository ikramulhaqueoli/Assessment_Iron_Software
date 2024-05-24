namespace AssessmentIronSoftware.Tests
{
    public class Phone_Tests
    {
        [Fact]
        public void ShouldReturnCorrectResultOnExanpleUnitTests()
        {
            Assert.Equal(actual: Phone.OldPhonePad("33#"), expected: "E");
            Assert.Equal(actual: Phone.OldPhonePad("227*#"), expected: "B");
            Assert.Equal(actual: Phone.OldPhonePad("4433555 555666#"), expected: "HELLO");
            Assert.Equal(actual: Phone.OldPhonePad("8 88777444666*664#"), expected: "TURING");
        }

        [Fact]
        public void ShouldReturn1stLetterOnSingleButtonPress()
        {
            Assert.Equal(actual: Phone.OldPhonePad("0#"), expected: " ");
            Assert.Equal(actual: Phone.OldPhonePad("1#"), expected: "&");
            Assert.Equal(actual: Phone.OldPhonePad("2#"), expected: "A");
            Assert.Equal(actual: Phone.OldPhonePad("3#"), expected: "D");
            Assert.Equal(actual: Phone.OldPhonePad("4#"), expected: "G");
            Assert.Equal(actual: Phone.OldPhonePad("5#"), expected: "J");
            Assert.Equal(actual: Phone.OldPhonePad("6#"), expected: "M");
            Assert.Equal(actual: Phone.OldPhonePad("7#"), expected: "P");
            Assert.Equal(actual: Phone.OldPhonePad("8#"), expected: "T");
            Assert.Equal(actual: Phone.OldPhonePad("9#"), expected: "W");
        }


        [Fact]
        public void ShouldReturn2ndLetterOnTwiceButtonPress()
        {
            Assert.Equal(actual: Phone.OldPhonePad("00#"), expected: " ");
            Assert.Equal(actual: Phone.OldPhonePad("11#"), expected: "'");
            Assert.Equal(actual: Phone.OldPhonePad("22#"), expected: "B");
            Assert.Equal(actual: Phone.OldPhonePad("33#"), expected: "E");
            Assert.Equal(actual: Phone.OldPhonePad("44#"), expected: "H");
            Assert.Equal(actual: Phone.OldPhonePad("55#"), expected: "K");
            Assert.Equal(actual: Phone.OldPhonePad("66#"), expected: "N");
            Assert.Equal(actual: Phone.OldPhonePad("77#"), expected: "Q");
            Assert.Equal(actual: Phone.OldPhonePad("88#"), expected: "U");
            Assert.Equal(actual: Phone.OldPhonePad("99#"), expected: "X");
        }

        [Fact]
        public void ShouldReturn3rdLetterOnTriceButtonPress()
        {
            Assert.Equal(actual: Phone.OldPhonePad("000#"), expected: " ");
            Assert.Equal(actual: Phone.OldPhonePad("111#"), expected: "(");
            Assert.Equal(actual: Phone.OldPhonePad("222#"), expected: "C");
            Assert.Equal(actual: Phone.OldPhonePad("333#"), expected: "F");
            Assert.Equal(actual: Phone.OldPhonePad("444#"), expected: "I");
            Assert.Equal(actual: Phone.OldPhonePad("555#"), expected: "L");
            Assert.Equal(actual: Phone.OldPhonePad("666#"), expected: "O");
            Assert.Equal(actual: Phone.OldPhonePad("777#"), expected: "R");
            Assert.Equal(actual: Phone.OldPhonePad("888#"), expected: "V");
            Assert.Equal(actual: Phone.OldPhonePad("999#"), expected: "Y");
        }

        [Fact]
        public void ShouldReturn4thLetterOn4TimesButtonPress()
        {
            Assert.Equal(actual: Phone.OldPhonePad("7777#"), expected: "S");
            Assert.Equal(actual: Phone.OldPhonePad("9999#"), expected: "Z");
        }

        [Fact]
        public void ShouldReturnCirculatedLetterOn5TimesButtonPress()
        {
            Assert.Equal(actual: Phone.OldPhonePad("00000#"), expected: " ");
            Assert.Equal(actual: Phone.OldPhonePad("11111#"), expected: "'");
            Assert.Equal(actual: Phone.OldPhonePad("22222#"), expected: "B");
            Assert.Equal(actual: Phone.OldPhonePad("33333#"), expected: "E");
            Assert.Equal(actual: Phone.OldPhonePad("44444#"), expected: "H");
            Assert.Equal(actual: Phone.OldPhonePad("55555#"), expected: "K");
            Assert.Equal(actual: Phone.OldPhonePad("66666#"), expected: "N");
            Assert.Equal(actual: Phone.OldPhonePad("77777#"), expected: "P");
            Assert.Equal(actual: Phone.OldPhonePad("88888#"), expected: "U");
            Assert.Equal(actual: Phone.OldPhonePad("99999#"), expected: "W");
        }

        [Fact]
        public void ShouldReturnProperResultOnBackspacePress()
        {
            Assert.Equal(actual: Phone.OldPhonePad("22 2225#"), expected: "BCJ");
            Assert.Equal(actual: Phone.OldPhonePad("22 2225*#"), expected: "BC");
            Assert.Equal(actual: Phone.OldPhonePad("22 2225**#"), expected: "B");
            Assert.Equal(actual: Phone.OldPhonePad("22***2225#"), expected: "CJ");
            Assert.Equal(actual: Phone.OldPhonePad("***2225#"), expected: "CJ");
            Assert.Equal(actual: Phone.OldPhonePad("22 2225***#"), expected: "");
            Assert.Equal(actual: Phone.OldPhonePad("22 2225****#"), expected: "");
            Assert.Equal(actual: Phone.OldPhonePad("22*222*5*#"), expected: "");
            Assert.Equal(actual: Phone.OldPhonePad("***#"), expected: "");
        }

        [Fact]
        public void ShouldReturnEmptyResultOnNoButtonPress()
        {
            Assert.Equal(actual: Phone.OldPhonePad("#"), expected: "");
        }

        [Fact]
        public void ShouldSkipHandlingCharactersAfterHashSymbolInTheInput()
        {
            Assert.Equal(actual: Phone.OldPhonePad("22#33445"), expected: "B");
        }
    }
}