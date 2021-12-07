using MediatR;
using portalPracowniczy.ApplicationServices.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class PutBranchRequest : IRequest<PutBranchResponse>
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public int IdSuperior { get; set; }
    }
}
