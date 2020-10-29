using System;
using System.Text;

namespace StringRotator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting StringRotator Program --- Robert Aldridge 2020");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("");

            string BaseString = ("MyString");
            int CharacterLimit = BaseString.Length;
            int UserInput = GetUserInput(CharacterLimit);
            
            Console.WriteLine(BaseString.Substring(BaseString.Length - UserInput) + BaseString.Remove(BaseString.Length - UserInput));

            static int GetUserInput(int CharacterLimit)
            {
                Console.WriteLine("How many characters would you like to rotate?");
                string ConsoleInput = Console.ReadLine();
                int UserInputInt;

                if (int.TryParse(ConsoleInput, out UserInputInt) && (UserInputInt <= CharacterLimit) && (UserInputInt > 0))
                {
                    return UserInputInt;
                }
                else
                {
                    Console.WriteLine("Invalid input! Input must be a number and be between 1 and " + CharacterLimit + ". Please try again.");
                    Console.WriteLine();

                    return GetUserInput(CharacterLimit);
                }
            }
        }
    }
}
