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

        public void saveStudent(StudentModel stm)
        {
           Student st = new Student();
            st.birthday = stm.birthday;
            st.codeCN = stm.codeCN;
            st.codeSV = stm.codeSV;
            st.fullName = stm.fullName;
            st.Id = stm.Id;
            using (Data db = new Data())
            {
                    db.Students.Add(st);
                    db.SaveChanges();
            }

        }
    }
}