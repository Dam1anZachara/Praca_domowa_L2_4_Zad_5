using System;

namespace L2_4_Zad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the user data app!");
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.Write("What is your last name?: ");
            string lastName = Console.ReadLine();
            Console.Write("How old are you?: ");
            bool ageIsInt = Int32.TryParse(Console.ReadLine(), out int age);
            Console.Write("What is your phone number? (Please write wihout space): ");
            bool phoneNumberIsUlongType = ulong.TryParse(Console.ReadLine(), out ulong phoneNumber);
            Console.Write("What is your E-mail?: ");
            string emailAdress = Console.ReadLine();
            Console.Write("What is your height? (Please write in [cm], you can enter in millimeters after the decimal point \",\": ");
            bool heightUserIsFloatType = float.TryParse(Console.ReadLine(), out float heightUser);
            Console.Write("What is your gender? Write male or female: ");
            string gender = Console.ReadLine();
            string genderUpper = gender.ToUpper();

            //Console.WriteLine(ageIsInt);
            //Console.WriteLine(phoneNumberIsLongType);
            //Console.WriteLine(heightUserIsDoubleType);

            if (ageIsInt && phoneNumberIsUlongType && heightUserIsFloatType)
            {
                Console.Clear();
                Console.WriteLine($"Hello {name} {lastName}!");
                Console.WriteLine("\r\nThese are your data that you entered: ");
                Console.WriteLine($"- Age: {age} years old,");
                Console.WriteLine($"- Phone number: {phoneNumber},");
                Console.WriteLine($"- E-mail: {emailAdress},");
                Console.WriteLine($"- Height: {heightUser} [cm],");
                if (genderUpper == "MALE")
                {
                    Console.WriteLine($"- Gender: Male,");
                }
                else if (genderUpper == "FEMALE")
                {
                    Console.WriteLine($"- Gender: Female,");
                }
                else
                    Console.WriteLine($"- Gender: ERROR!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You filled out the data incorrectly in the form! Please try again.");
            }

        }
    }
}