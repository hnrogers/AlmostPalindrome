namespace AP
{
    class Primary
    {
        public static void Main()
        {
            StringValidation sv = new StringValidation();

            Console.WriteLine(sv.AlmostPalindrome("abcdcbg"));
            Console.WriteLine(sv.AlmostPalindrome("abcdaaa"));
            Console.WriteLine(sv.AlmostPalindrome("abcdcba"));
            Console.WriteLine(sv.AlmostPalindrome("abcdcbg "));
        }
    }
}