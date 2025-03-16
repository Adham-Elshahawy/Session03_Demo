using Data_Aceess_Layer.Presistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Aceess_Layer.Presistance.Repostories.Department
{
    // Database ==> Repository ==> services ==> controller 
    internal class DepartmentReporstory : iDepartmentReporstory
    {
        private readonly ApplicationDbContext _dbcontext;
        public DepartmentReporstory(ApplicationDbContext dbContext) // ask clr to create object from ApplicationDbContext 
        {
          _dbcontext = dbContext;
        }
        public int AddDepartment(Department entity)
        {
            _dbcontext.Departments.Add(entity);//saved locally
            return _dbcontext.SaveChanges(); // apply remotly 
        }

        public int DeleteDepartmemnt(Department entity)
        {
           _dbcontext.Departments.Remove(entity);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<Department> GetAll(bool AsnoTracking = true)
        {
           if (AsnoTracking)
            {
                return _dbcontext.Departments.AsnoTracking().ToList(); //ditached 
            }
            return _dbcontext.Departments.Tolist(); // unchanged
        }

        public IQueryable<Department> GetAllQuerable()
        {
            return _dbcontext.Departments;
        }

        public Department GetByID(int id)
        {
            //return _dbcontext.Departments.Local.FirstOrDefault(D=>D.Id == id);
            return _dbcontext.Departments.Find(id);  // search local , incase found return it 
        }

        public int updateDepartment(Department entity)
        {
            _dbcontext.Departments.Update(entity); // modify
            return _dbcontext.SaveChanges();
        }
    }
}
