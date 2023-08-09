using StudentApi.Models;

namespace StudentApi.Service.Interface
{
    public interface IStudentService
    {
        public object DisplayData();
        public object GetDataById(int id);
        public object UpdateData(StudentInfo s);
        public object DeleteData(int id);
        public object PostData(StudentInfo s);
    }
}
