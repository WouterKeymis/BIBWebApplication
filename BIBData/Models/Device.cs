﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BIBData.Models
{
    public class Device : Uitleenobject
    {
        public OperatingSysteem Operatingsysteem { get; set; }
        public float Schermgrootte { get; set; }
    }
}
