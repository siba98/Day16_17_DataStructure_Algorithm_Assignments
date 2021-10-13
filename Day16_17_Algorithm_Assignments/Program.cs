using System;
using System.Collections;

namespace Day16_17_Algorithm_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************ALGORITHMS PROBLEMS**********************\n\n");

            //String_Permutation.PrintPermutationOfString();

            //PrimeNumber_Range.GetPrime();

            //Anagram_String.IsAnagram();

            //PrimeWith_Anagram_Palindrome.GetPrimePalindromes();

            #region Message Demonstration

            Message_Demonstration pattern1 = new Message_Demonstration();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter FullName: ");
            string fullname = Console.ReadLine();
            Console.Write("Enter Phone Number With Country Code Like(91-XXXXXXXXXX): ");
            string PhNum = Console.ReadLine();
            Console.Write("Enter Date: ");
            string date = Console.ReadLine();
            
            var r1 = pattern1.ValidateName(name);
            Console.WriteLine(r1);

            var r2 = pattern1.ValidateFullName(fullname);
            Console.WriteLine(r2);

            var r3 = pattern1.ValidatePhoneNumber(PhNum);
            Console.WriteLine(r3);

            var r4 = pattern1.ValidateDate(date);
            Console.WriteLine(r4);

            if (r1 && r2 && r3 && r4 == true)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Hello {0}, We have your full name as {1} in our system. Your contact number is {2}. Please, let us know in case of any clarification Thank you BridgeLabz {3}", name, fullname, PhNum, date);
            }
            else
                Console.WriteLine("Enter Valid Input");

            #endregion

        }
    }
}
