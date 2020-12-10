﻿using BIBData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIBData.Repositories
{
    public interface IUitleenobjectRepository
    {
        Uitleenobject Get(int id);
        IEnumerable<Uitleenobject> GetAll();
    }
}
