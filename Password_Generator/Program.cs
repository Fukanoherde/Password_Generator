using System;
using System.Linq;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Random Password generator!");
            Console.WriteLine("Press here to Password lenght");
            string line = Console.ReadLine();
            if (line.Length > 0)
            {
                if (IsNumeric(line))
                {
                    int length = Convert.ToInt32(line);
                    Console.WriteLine("Here is you're new Password generated!");
                    Console.WriteLine("Your Password: " + generatePassword(length));
                    Console.Read();
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("Please press a real number!");
            }
        }
        public static string generatePassword(int length)
        {
            Random zufall = new Random();

            string getAlphaNumeric = "QWERTZUIOPÜASDFGHJKLÖÄYXCVBNMqwertzuiopüasdfghjklöäyxcvbnm123456789!§$%&/()=?#><|[]{}+*~'";

            var password = new System.Text.StringBuilder();

            for (int i = 0; i < length; i++)
            {
                password.Append(getAlphaNumeric.ToCharArray()[zufall.Next(0, getAlphaNumeric.Length)].ToString());
            }
            return password.ToString();
        }
        private static bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}