using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.DataAccess.Entities
{
    public class User : EntityBase
    {
        public int IdERP { get; set; }
        public int IdRCP { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(15)]
        public string Password { get; set; }
        [Required]
        [MaxLength(25)]
        public string Login { get; set; }
        public int IdPosition { get; set; }
        public int IdBranch { get; set; }
        public List<Proposal> Proposals { get; set; }
        public List<Holiday> Holidays { get; set; }
    }
}
