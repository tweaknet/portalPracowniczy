using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class AddUserRequest : IRequest<AddUserResponse>
    {
        public string Name { get; set; }
    }
}
