using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exploritas.Domain.Repositories
{
    public interface IUnitOfWork
    {
        public Task<bool> Commit();
    }
}
