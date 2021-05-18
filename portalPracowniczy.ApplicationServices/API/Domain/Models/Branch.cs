using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Domain.Models
{
    public class Branch
    {
        public string Name { get; set; }
        public int IdSuperior { get; set; }
    }
}
