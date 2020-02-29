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

                uow.Questions.Add(new Question() { Id = 1, Content = "Question Content 1" });

                uow.SaveChanges();

            }
        }
    }
}
