using RepositoryEntityFramework.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEntityFramework
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("name=ApplicationContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public virtual DbSet<Question> Questions { get; set; }
    }
}
