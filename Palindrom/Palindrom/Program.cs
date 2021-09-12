using System;

namespace Palindrom
{
    class Program
    {
        static bool Palindrom (string Name)
        {
            string reverse = string.Empty;

            for (int i = Name.Length - 1; i >= 0; i--)
            {
                reverse += Name[i];
            }

            if (Name == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            bool Result = Palindrom("MADAM");
            Console.WriteLine(Result);
        }
    }
}
