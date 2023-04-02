using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10Exception
{
    internal class PersonAge
    {
       public static void Age()
        {
            try
            {
                Console.WriteLine("Input a age");
                String ageString =  Console.ReadLine();
                if(ageString == null || ageString.Length == 0 ) {
                    throw new AgeCategoryException("not be empty");
                }
                foreach (char c in ageString)
                {
                    if (char.IsDigit(c)==false)
                    {
                        throw new AgeCategoryException("invalid input");
                    }
                }
                int age = int.Parse(ageString);
                Console.WriteLine(age);

                if (age < 18 && age > 1)
                {
                    Console.WriteLine(" They are  children");
                }
                if (age < 24 && age > 15)
                {
                    Console.WriteLine("They are youths");
                }
                if (age < 64 && age > 25)
                {
                    Console.WriteLine("They are adults");
                }
                if (age > 65)
                {
                    Console.WriteLine("They are seniors");
                }
            }
            catch (AgeCategoryException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Handle my own exception");
            }
        }
    }


    class AgeCategoryException : Exception
    {
        public AgeCategoryException(string message) : base(message) { }
    }
}
