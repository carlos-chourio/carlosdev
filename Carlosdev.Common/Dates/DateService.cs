using System;

namespace Carlosdev.Common.Dates {
    public class DateService : IDateService {
        public DateTime GetCurrentDate() {
            return DateTime.Now;
        }
    }
}
