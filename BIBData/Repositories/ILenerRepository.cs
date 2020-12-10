using BIBData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIBData.Repositories
{
    public interface ILenerRepository
    {
        Lener Get(int id);
        IEnumerable<Lener> GetAll();
    }
}
