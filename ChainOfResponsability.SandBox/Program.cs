using ChainOfResponsability.Infrastructure.Contexts.Application;
using ChainOfResponsability.Infrastructure.UnitOfWork;

namespace ChainOfResponsability.Sandbox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var contexto = new ApplicationDBContext();
            //var statusRepository = new StatusRepository(contexto);
            var unitOfWork = new UnitOfWork(contexto);

            //var statuses = contexto.Statuses.ToList();

            //var statuses = statusRepository.GetAll().ToList();

            var statuses = unitOfWork.Statuses.GetAll().ToList();

            foreach (var status in statuses)
            {
                Console.WriteLine($"{status.Name}");
            }

            Console.ReadKey();
        }
    }
}