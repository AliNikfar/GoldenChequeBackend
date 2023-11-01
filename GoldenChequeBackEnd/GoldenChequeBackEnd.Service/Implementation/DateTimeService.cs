using GoldenChequeBackEnd.Service.Contract;
using System;

namespace GoldenChequeBackEnd.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}