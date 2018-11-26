using System;
using System.Linq;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        /// <summary>
        /// Different repositories
        /// </summary>
        private readonly IRepository repository = new SqlRepository();

        /// <summary>
        /// Multiple predicate verification
        /// </summary>
        public (bool, string) VerifyPassword(string password, Predicate<string>[] predicates)
        {
            foreach(Predicate<string> predicate in predicates)
            {
                if (!predicate(password))
                    return (false, $"{password} is invalid");
            }

            repository.Create(password);
            return (true, "Password is Ok. User was created");
        }

        /// <summary>
        /// Standart predicates
        /// </summary>
        public Predicate<string> predicate1 = new Predicate<string>(str => str != null);
        public Predicate<string> predicate2 = new Predicate<string>(str => str != string.Empty);
        public Predicate<string> predicate3 = new Predicate<string>(str => str.Length > 7);
        public Predicate<string> predicate4 = new Predicate<string>(str => str.Length < 16);
        public Predicate<string> predicate5 = new Predicate<string>(str => str.Any(char.IsLetter));
        public Predicate<string> predicate6 = new Predicate<string>(str => str.Any(char.IsNumber));
    }
}
