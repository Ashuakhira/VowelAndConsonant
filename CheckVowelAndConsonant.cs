﻿{
    public class VowelAndConsonant
    {
        public static void CheckVowelAndConsonant()
        {
            char ch;

            Console.WriteLine("Enter any character");
            ch = Convert.ToChar(Console.ReadLine());

            if ((ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' ))
            {
                Console.WriteLine((ch + "is a Vowel"));

            }elseif ((ch>='a' && ch<='z') || ch>='A' && ch<='Z'))
            {
            Console.WriteLine((ch + "is a Consonant"));
        }
}
