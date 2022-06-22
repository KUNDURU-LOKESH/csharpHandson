using EntityFramework.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data
{
    public class Empedu
    {
        private DemoDbContext demoDb;
        public Empedu()
        {
            demoDb = new DemoDbContext();
        }
        public List<EmployeeEducation> GetEmployeeEdu()
        {
            var allval=demoDb.EmployeeEducations.ToList();
            return allval;
        }

        public void Insert(EmployeeEducation empedu)
        {
            demoDb.Add(empedu);
            demoDb.SaveChanges();
        }
        public void Update(int id, EmployeeEducation updata)
        {
            var result=demoDb.EmployeeEducations.Where(x=>x.ID == id).FirstOrDefault();
            if (result == null)
            {
                Console.WriteLine($"Employee with ID:{id} not Found");
            }
            result.CourseName = updata.CourseName;
            result.UniversityName = updata.UniversityName;
            result.PassingYear = updata.PassingYear;
            result.MarksPercentage= updata.MarksPercentage;
            demoDb.EmployeeEducations.Update(result);
            demoDb.SaveChanges();

        }
        public void delete(int id)
        {
            var res=demoDb.EmployeeEducations.Where(x=>x.ID == id).FirstOrDefault();
            if (res == null)
            {
                Console.WriteLine($"Employee with ID:{id} not Found");
            }
            demoDb.EmployeeEducations.Remove(res);
        }

    }
}
