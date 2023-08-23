using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEmailValidator.CustomExceptions;

namespace TaskEmailValidator.Validations
{
    public class EmailValidator
    {
        public bool Validate(string email)
        {

            if (!email.EndsWith("@mail.com"))
            {
                throw new NotAnEmailAdressException("The string must end with @mail.com");
            }

            if (email.Length < 10)
            {
                throw new ShortEmailException("The minimum length of the string must be 10 characters");
            }
            return true;
        }
    }
}
