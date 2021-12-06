namespace portalPracowniczy.Controllers
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