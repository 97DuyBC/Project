using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDemo.Models;

namespace WebDemo.Business.Students
{
    public class StudentsDAO
    {
        public List<Student> getAllStudents()
        {
            using (WebDemo.Models.Data db = new Data())
            {
                return db.Students.ToList();
            }                
        }
    }
}