using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class AddBranchRequest :IRequest<AddBranchResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdSuperior { get; set; }
    }
}
