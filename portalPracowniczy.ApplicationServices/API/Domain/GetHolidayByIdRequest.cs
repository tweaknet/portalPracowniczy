namespace portalPracowniczy.ApplicationServices.API.Domain
{
    public class GetHolidayByIdRequest
    {
        public GetHolidayByIdRequest()
        {
        }

        public int UserId { get; set; }
        public int HolidayId { get; set; }
    }
}