using TaskEmailValidator.CustomExceptions;
using TaskEmailValidator.Validations;

namespace TaskEmailValidator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var emailValidator = new EmailValidator();
            try
            {
                bool isValid = emailValidator.Validate("ali@mail.com");
                Console.WriteLine(isValid);
            }
            catch (NotAnEmailAdressException ex)
            {
                Console.WriteLine("NotAnEmailAdressException: " + ex.Message);
            }
            catch (ShortEmailException ex)
            {
                Console.WriteLine("ShortEmailException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}