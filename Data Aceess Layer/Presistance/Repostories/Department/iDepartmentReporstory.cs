using Data_Aceess_Layer.Entites.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Aceess_Layer.Presistance.Repostories.Department
{
    public interface iDepartmentReporstory
    {
        IEnumerable<Department> GetAll(bool AsnoTracking = true );
        IQueryable<Department> GetAllQuerable();
        Department GetByID( int id );
        int AddDepartment(Department entity);
        int updateDepartment(Department entity);
        int DeleteDepartmemnt(Department entity);

    }
}
