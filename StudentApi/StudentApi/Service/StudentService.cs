using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentApi.DTO;
using StudentApi.Models;
using StudentApi.Service.Interface;

namespace StudentApi.Service
{
    public class StudentService: IStudentService
    {
        private readonly StudentDatabaseContext _context;
        public StudentService(StudentDatabaseContext context)
        {
            _context = context;
        }

        public object DisplayData()
        {
            var data = _context.StudentInfos.ToList();
            if (data == null)
            {
                return "Not Found";
            }
            return data;
        }
        public object GetDataById(int id)
        {
            var data = _context.StudentInfos.Where(model => model.StudId==id).ToList();
            if(data == null)
            {
                return "Id not exist";
            }
            else
            {
                return data;
            }
        }

        public object PostData(StudentInfo s)
        {
            _context.StudentInfos.Add(s);
            _context.SaveChanges();
            return "Added Succesfully";

        }

        public object UpdateData(StudentInfo s)
        {
            if (s != null)
            {
                _context.StudentInfos.Entry(s).State = EntityState.Modified;
               
                _context.SaveChanges();

                return s;
            }
            else
            {
                return "No data Found";
            }

        }

        public object DeleteData(int id)
        {
            if (id != null)
            {
                
                var row = _context.StudentInfos.Where(model => model.StudId == id).FirstOrDefault();
                _context.StudentInfos.Entry(row).State = EntityState.Deleted;
                
                _context.SaveChanges();

                return "Deleted Succesfully";
            }
            else
            {
                return "No data Found";
            }

        }

    }
}
