﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class GetUsersRequest : IRequest<GetUsersResponse> 
    {
        public string Name { get; set; }
    }
}
