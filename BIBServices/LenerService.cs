using BIBData.Models;
using BIBData.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIBServices
{
    public class LenerService
    {
        private ILenerRepository lenerRepository;

        public LenerService(ILenerRepository lenerRepository)
        {
            this.lenerRepository = lenerRepository;
        }

        public IEnumerable<Lener> GetAllLeners()
        {
            return lenerRepository.GetAll();
        }

        public Lener GetLener(int id)
        {
            return lenerRepository.Get(id);
        }
    }
}
