using MediatR;
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
    public class HolidayTypeController : ControllerBase
    {
        private readonly IMediator mediator;

        public HolidayTypeController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> HolidayType([FromBody] AddHolidayTypeRequest request)
            {
            var response = await this.mediator.Send(request);
            return this.Ok(response); 
            }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllHolidaysType([FromQuery] GetHolidaysTypeRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetHolidayTypeById([FromRoute] int Id)
        {
            var request = new GetHolidayTypeByIdRequest()
            {
                Id = Id
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpDelete]
        [Route("{holidaytypeId}")]
        public async Task<IActionResult> DeleteHolidayType([FromRoute] int holidaytypeId)
        {

            var request = new DeleteHolidayTypeByIdRequest()
            {
                Id = holidaytypeId
            };
            var response = await this.mediator.Send(request);
            return this.Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> PutHolidayType([FromBody] PutHolidayTypeRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
