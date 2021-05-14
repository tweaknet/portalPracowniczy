using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.Entities
{
    class Status : EntityBase
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public List<Proposal> Proposals { get; set; }

    }
}
