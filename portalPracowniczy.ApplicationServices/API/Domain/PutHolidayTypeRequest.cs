using MediatR;

namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class PutHolidayTypeRequest : IRequest<PutHolidayTypeResponse>
    {
        public string Name { get; set; }
        public int IdRCP { get; set; }
        public int IdERP { get; set; }
        //public List<Holiday> Holidays { get; set; }
        //public List<Proposal> Proposals { get; set; }
    }
}
