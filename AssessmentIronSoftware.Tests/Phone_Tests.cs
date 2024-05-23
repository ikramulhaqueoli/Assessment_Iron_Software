namespace AssessmentIronSoftware.Tests;

using NUnit.Framework;
using AssessmentIronSoftware;

[TestFixture]
public class Phone_Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Should_Return_Correct_Result_On_Exanple_Unit_Tests()
    {
        Assert.Equal(actual: Phone.OldPhonePad("33#"), expected: "E");
        Assert.Equal(actual: Phone.OldPhonePad("227*#"), expected: "B");
        Assert.Equal(actual: Phone.OldPhonePad("4433555 555666#"), expected: "HELLO");
        Assert.Equal(actual: Phone.OldPhonePad("8 88777444666*664#"), expected: "TURING");
    }

    [Test]
    public void Should_Return_1st_Letter_On_Single_Button_press()
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

    
    [Test]
    public void Should_Return_2nd_Letter_On_Twice_Button_press()
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

    [Test]
    public void Should_Return_3rd_Letter_On_Trice_Button_press()
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

    [Test]
    public void Should_Return_4th_Letter_On_4_Times_Button_press()
    {
        Assert.Equal(actual: Phone.OldPhonePad("7777#"), expected: "S");
        Assert.Equal(actual: Phone.OldPhonePad("9999#"), expected: "Z");
    }

    [Test]
    public void Should_Return_Circulated_Letter_On_5_times_Button_press()
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

    [Test]
    public void Should_Return_Proper_Result_On_Backspace_Press()
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

    [Test]
    public void Should_Return_Empty_Result_On_No_Button_Press()
    {
        Assert.Equal(actual: Phone.OldPhonePad("#"), expected: "");
    }
}
