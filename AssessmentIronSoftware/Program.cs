namespace AssessmentIronSoftware
{
    using System;
    using System.Collections.Generic;

    public class MainClass
    {
        public static void Main(params string[] args)
        {
            var results = new List<string> {
                Phone.OldPhonePad("33#"),                       // Sample Case 1: E
                Phone.OldPhonePad("227*#"),                     // Sample Case 2: B
                Phone.OldPhonePad("4433555 555666#"),           // Sample Case 3: HELLO
                Phone.OldPhonePad("8 88777444666*664#"),        // Sample Case 4: TURING

                Phone.OldPhonePad("22222#"),                    // Edge Case 1: B (Circulate when pressed > 3 times)
                Phone.OldPhonePad("22***2225#"),                // Edge Case 2: CJ (Do not remove next letters when extra backspace pressed before)
                Phone.OldPhonePad("***2225#"),                  // Edge Case 3: CJ (Do not remove next letters when extra backspace pressed before)
                Phone.OldPhonePad("**#"),                       // Edge Case 4: (Empty output when only backspace but no other key pressed)
                Phone.OldPhonePad("#"),                         // Edge Case 5: (Empty output when nothing pressed.)
                Phone.OldPhonePad("22#33445"),                  // Edge Case 6: B (Skip handling characters after # symbol.)
            };


            results.ForEach(result => Console.WriteLine("Output: " + result));
        }
    }
}
