﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portalPracowniczy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HolidayController : ControllerBase
    {
        private readonly IMediator mediator;

        public HolidayController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddHoliday([FromBody] AddHolidayRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllHolidays([FromQuery] GetHolidaysRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetHolidayById([FromRoute] int Id)
        {
            var request = new GetHolidayByIdRequest()
            {
                Id = Id
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpDelete]
        [Route("{holidayId}")]
        public async Task<IActionResult> DeleteHoliday([FromRoute] int holidayId)
        {

            var request = new DeleteHolidayRequest()
            {
                Id = holidayId
            };
            var response = await this.mediator.Send(request);
            return this.Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> PutHoliday([FromBody] PutHolidayRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
