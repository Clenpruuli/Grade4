using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID code:");
            string usersID = Console.ReadLine();

            if (Validate(usersID))
            {
                Console.WriteLine("Welcome!");
                HelloUser(usersID);
                Console.WriteLine("Enter credit card number?");
                string creditCard = Console.ReadLine();
                CreditCardNumber(creditCard);
                Console.WriteLine("Enter yor cvv code: ");
                string CvvCode = Console.ReadLine();
                CVVValidations(CvvCode);




            }
            else
            {
                Console.WriteLine("Wrong format.Try again.");
            }

            Console.ReadLine();

        }

        public static bool Validate(string idCode)
        {
            if (idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public static void HelloUser(string idCode)
        {
            int FirstNum = Int32.Parse(idCode[0].ToString());
            if (FirstNum == 1 || FirstNum == 3 || FirstNum == 5)
            {
                Console.WriteLine("Hello,sir!");

            }
            else if (FirstNum == 2 || FirstNum == 4 || FirstNum == 6)
            {
                Console.WriteLine("Hello,Madam!");
            }
        }

        public static bool CreditCardNumber(string creditCard)
        {
            if (creditCard.Length == 16)
            {
                try
                {

                    long.Parse(creditCard);
                    Console.WriteLine("Successfully parsed!");
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }

            }
            else
            {
                Console.WriteLine("Number too short");
                return false;
            }
        }

        public static bool CVVValidations(string Cvvcode)
        {

            if (Cvvcode.Length == 3)
            {
                
                try
                {
                    Int32.Parse(Cvvcode);
                    Console.WriteLine("Your card has been accepted!");
                    return true;
                    
                }
                catch (Exception error)
                {
                    Console.WriteLine("You card has been declined!");
                    return false;
                }


            }
            else
            {
                return false;
            }
        }
    }
}
