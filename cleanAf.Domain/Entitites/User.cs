﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanAf.Domain.Entitites
{
    public class User : BaseEntity
    {

        public string Name { get; set; }
        public Adress Adress { get; set; }
    }
}
