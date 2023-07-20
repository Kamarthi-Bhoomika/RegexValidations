using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string mobilepattern = @"^\d{10}$";
            Regex regex = new Regex(mobilepattern);
            string[] mobiles = new string[] { "+91-99887766", "9923456789" };
            foreach(string mobile in mobiles)
            {
                if(regex.IsMatch(mobile)) 
                {
                    Console.WriteLine($"{mobile} is a valid mobile number");
                }
                else
                {
                    Console.WriteLine($"{mobile} is not a valid mobile number");
                }
            }
            Console.ReadKey();*/

            string name, mobile, pincode;
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Mobile: ");
            mobile = Console.ReadLine();
            Console.WriteLine("Enter Pincode: ");
            pincode = Console.ReadLine();
            // Name with caps\small letters with underscore in between and more than 4characters
            string namepattern = "^[A-Za-z][A-Za-z_]{4,29}$";
	        // MObile NUmber: +91-9876545678
            string mobilepattern = @"^(\+?\d{1,4}[\s-])?(?!0+\s+,?$)\d{10}\s*,?$";
	        // any 6 digit number
            string pincodepattern = @"^\d{6}$";
            Regex regexname = new Regex(namepattern);
            Regex regexmobile = new Regex(mobilepattern);
            Regex regexpincode = new Regex(pincodepattern);

            if(regexname.IsMatch(name))
            {
                Console.WriteLine($"{name} is a valid Name");
            }
            else
            {
                Console.WriteLine($"{name} is not a valid Name ");
            }
            if (regexmobile.IsMatch(mobile))
            {
                Console.WriteLine($"{mobile} is a valid mobile number");
            }
            else
            {
                Console.WriteLine($"{mobile} is not a valid mobile number");
            }
            if (regexpincode.IsMatch(pincode))
            {
                Console.WriteLine($"{pincode} is a valid pincode");
            }
            else
            {
                Console.WriteLine($"{pincode} is not a valid pincode");
            }
            Console.ReadKey();

        }
    }
}
