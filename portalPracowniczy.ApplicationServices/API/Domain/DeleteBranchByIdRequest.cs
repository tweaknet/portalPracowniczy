using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class DeleteBranchByIdRequest : IRequest<DeleteBranchByIdResponse>
    {
        public int Id { get; set; }
    }
}
