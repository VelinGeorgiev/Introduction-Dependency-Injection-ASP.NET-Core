using System;

namespace Demo.Services
{
    public class HrRequestService
    {
        public string AssignHrManager()
        {
            var day = DateTime.UtcNow.Day;

            if(day < 15)
            {
                return "Ben";
            }
            return "John";
        }
    }
}