namespace AssessmentIronSoftware
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MainClass
    {
        public static void Main(params string[] args)
        {
            var results = new List<string> {
                Phone.OldPhonePad("33#"),
                Phone.OldPhonePad("227*#"),
                Phone.OldPhonePad("4433555 555666#"),
                Phone.OldPhonePad("8 88777444666*664#"),
                Phone.OldPhonePad("22222#"),
                Phone.OldPhonePad("#")
            };
            
            
            results.ForEach(result => Console.WriteLine("Output: " + result));
        }
    }
}
