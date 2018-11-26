using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    /*
     * Проблема использования различных репозиториев решается введением интерфейса IRepository
     * Для использования различной логики верификации можно воспользоваться как реализацией интерфейса IChecker
     * так и делегатом Func<string, (bool, string)>. В конструктор передается стратегия валидации.
     */
    public class PasswordCheckerService
    {
        private readonly IRepository repository;
        private Func<string, (bool, string)> checker;

        public PasswordCheckerService(IRepository repo, Func<string, (bool, string)> checker)
        {
            this.checker = checker ?? throw new ArgumentNullException($"{nameof(checker)} need to be not null.");
            repository = repo ?? throw new ArgumentNullException($"{nameof(repo)} need to be not null.");
        }

        public PasswordCheckerService(IRepository repo, IChecker checker)
        {
            if (checker == null)
            {
                throw new ArgumentNullException($"{nameof(checker)} need to be not null.");
            }

            repository = repo ?? throw new ArgumentNullException($"{nameof(repo)} need to be not null.");
            this.checker = checker.Check;
        }

        public (bool, string) VerifyPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentException($"{password} is null arg");
            }


            (bool suitable, string answer) = checker.Invoke(password);

            if (suitable)
            {
                repository.Create(password);
                return (true, "Password is Ok. User was created");
            }

            return (suitable, answer);

        }
    }
}
