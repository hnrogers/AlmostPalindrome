namespace AP
{
    class StringValidation
{
    public bool AlmostPalindrome(string a)
    {

        int n = 0;
        a = a.ToLower().Trim();
        
        for (int i = 0; i < (a.Length / 2); i++)
        {
            if (a[i] != a[(a.Length - 1) - i])
            {
                n++;
            }
        }

        return n == 1;
    }
}
}