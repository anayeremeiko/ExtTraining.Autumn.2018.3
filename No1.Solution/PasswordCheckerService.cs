using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IPasswordRepository passwordRepository;
        private readonly IPasswordValidator passwordValidator;

        public PasswordCheckerService(IPasswordRepository passwordRepository, IPasswordValidator passwordValidator)
        {
            this.passwordRepository = passwordRepository;
            this.passwordValidator = passwordValidator;
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            Tuple<bool, string> result;

            try
            {
                this.passwordValidator.Validate(password);
                this.passwordRepository.Create(password);

                result = new Tuple<bool, string>(true, "Password is Ok. User was created");
            }
            catch (Exception ex)
            {
                result = new Tuple<bool, string>(false, ex.Message);
            }

            return result;
        }
    }
}
