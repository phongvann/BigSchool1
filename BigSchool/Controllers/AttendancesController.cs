using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbConText _dbConText;
        
        public AttendancesController()
        {
            _dbConText = new ApplicationDbConText();
        }
        public IHttpActionResult Attend([FromBody] int courserID)
        {
            var attendance = new Attendance
            {
                CourseId = courserID,
                AttendeeeId = User.Identity.GetUserId()
            };
            _dbConText.Attendances.Add(attendance);
            _dbConText.SaveChange();
            return Ok();

        }
    }
}
