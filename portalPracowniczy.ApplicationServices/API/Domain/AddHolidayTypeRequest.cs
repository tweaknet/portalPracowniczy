﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class AddHolidayTypeRequest : IRequest<AddHolidayTypeResponse>
    {
        public string Name { get; set; }
        public int IdRCP { get; set; }
        public int IdERP { get; set; }
        //public List<Holiday> Holidays { get; set; }
        //public List<Proposal> Proposals { get; set; }
    }
}
