using BIBData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIBData.Repositories
{
    public interface IReserveringRepository
    {
        void Add(Reservering reservering);
    }
}
