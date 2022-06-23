using bigSchool_NguyenTranDau.DTOs;
using bigSchool_NguyenTranDau.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace bigSchool_NguyenTranDau.Controllers
{
    
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        //[HttpPost]
        //public IHttpActionResult Attend([FromBody] int courseId)
        //{
        //    var userId = User.Identity.GetUserId();
        //    if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == courseId))
        //        return BadRequest("The Attendance already exitsts!");

        //    var attendance = new Attendance
        //    {
        //        CourseId = courseId,
        //        AttendeeId = userId
        //    };
        //    _dbContext.Attendances.Add(attendance);
        //    _dbContext.SaveChangesAsync();
        //    return Ok();
        //}
        [HttpPost]
        public IHttpActionResult Attend(AttendaneDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
            {
                return BadRequest("The Attendance already exitsts!");
            }
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
    
}
