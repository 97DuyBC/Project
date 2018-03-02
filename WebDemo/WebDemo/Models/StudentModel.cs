using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDemo.Models
{
    public class StudentModel : Student
    {
        public String birthdaystr
        {

            get
            {

                try
                {
                    return birthday == null ? "" : ((DateTime)birthday).ToString("yyyy-MM-dd");
                    return null;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            set
            {
                try
                {
                    birthday = DateTime.SpecifyKind(DateTime.ParseExact(value, "yyyy-MM-dd", null), DateTimeKind.Local); ;
                    return;
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }
    }
}