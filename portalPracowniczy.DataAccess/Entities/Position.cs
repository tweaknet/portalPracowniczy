﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.Entities
{
    class Position : EntityBase
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
