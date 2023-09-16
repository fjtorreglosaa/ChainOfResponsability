using ChainOfResponsability.Application.Utilities.Constants;
using ChainOfResponsability.Domain.Models;
using ChainOfResponsability.Infrastructure.Contexts.Application;
using ChainOfResponsability.Infrastructure.UnitOfWork;
using ChainOfResponsability.SandBox;
using System.Text.RegularExpressions;

namespace ChainOfResponsability.Sandbox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StatusSeeder.Seed();
        }
    }
}