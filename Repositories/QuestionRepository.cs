using RepositoryEntityFramework;
using RepositoryEntityFramework.Domain;
using RepositoryEntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEntityFramework.Repositories
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {

        public QuestionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public int GetAllQuestionsCount()
        {
            return (_context as ApplicationDbContext).Questions.Count();
        }
    }
}
