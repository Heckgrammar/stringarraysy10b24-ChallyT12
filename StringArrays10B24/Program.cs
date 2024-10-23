namespace StringArrays10B24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a subroutine called Prefix from your pseudo-code 
             * The subroutine takes two, character arrays called word and pre as parameters and 
             * The subroutine determines whether the start of the character array word is the 
             * same as all of the character array pre.*/

            /* Your subroutine should also:
	•           work for character arrays of all lengths greater than 0
	•           not assume that the length of pre is less than the length of word.*/

            /* use fixed (hard coded) string arrays to test your code. 
             Call your subroutine using your test arrays from Main() routine
             and return the result to Main() */

            /* Starter code for your subroutine has been provided*/
            string[] array1 = { "h", "e", "r", "l", "u", ",", "h", "p", "w", " ", "j", "s", "e", " ", "p", "o", "o" };
            string[] array2 = { "y", "o", "l", "l", "o" };
            Console.WriteLine(Prefix(array1, array2));
        }
        static bool Prefix(string[] wor, string[] pre)
        {
            if (pre.Length > wor.Length)
            {
                return false;
            }
            else
            {
                bool IsPrefix = true;
                int i = 0;
                while (i < pre.Length)
                {
                    if (wor[i] != pre[i])
                    {
                        IsPrefix = false;
                    }
                    i++;
                }
                return IsPrefix;
            }
        }
    }
}

