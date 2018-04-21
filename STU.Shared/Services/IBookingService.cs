using STU.Common.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Services
{
    public interface IBookingService
    {
        Result BookRoom(string roomId, DateTime time);
        Result CancelBooking(string bookingId);
        Result<List<string>> CancelBooking(string roomId, DateTime time);
    }
}
