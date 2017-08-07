using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Services
{
    public class HrRequestService
    {
        public string AssignHrManager(DateTime date)
        {
            var day = date.Day;

            if(day < 15)
            {
                return "Ben";
            }
            return "John";
        }
    }
}