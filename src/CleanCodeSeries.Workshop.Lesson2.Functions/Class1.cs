using System.Runtime.Remoting.Contexts;

namespace CleanCodeSeries.Workshop.Lesson2.Functions
{ 
    public static class Validator
    {
        public static bool Validate(object obj, Context context)
        {
            if (obj is BankAccount)
            {
                return true;
            }
            else if (obj is Programmer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
