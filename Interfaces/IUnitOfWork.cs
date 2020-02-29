using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEntityFramework.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        //repo 1
        IQuestionRepository Questions { get; }
        //repo 2

        void SaveChanges();
    }
}
