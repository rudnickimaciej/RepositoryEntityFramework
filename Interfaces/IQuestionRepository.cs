﻿using RepositoryEntityFramework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEntityFramework.Interfaces
{
    public interface IQuestionRepository:IRepository<Question>
    {
        //methods specific for this repository

        int GetAllQuestonsCount();
    }
}
