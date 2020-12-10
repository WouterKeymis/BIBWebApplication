﻿using BIBData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIBData.Repositories
{
    public interface IUitleningRepository
    {
        Uitlening Get(int uitleenId);
        IEnumerable<Uitlening> GetAll();
        void Add(Uitlening nieuweUitlening);
    }
}
