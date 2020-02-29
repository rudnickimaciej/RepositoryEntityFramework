using RepositoryEntityFramework.Domain;
using RepositoryEntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEntityFramework
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var uow = new UnitOfWork(new ApplicationDbContext()))
            {

                var q = uow.Questions.Get(1);
                var questions = uow.Questions.GetAll();

                uow.SaveChanges();

            }
        }
    }
}
