using Business_Layer.DTO.Department;
using Data_Aceess_Layer.Presistance.Repostories.Department;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services.Department
{
    public class DepartmentService : iDepartmentServices
    {
        private readonly iDepartmentReporstory _departmentReporstory;

        public DepartmentService(iDepartmentReporstory departmentReporstory)
        {
            _departmentReporstory = departmentReporstory;
        }

        public int CreateDepartment(DepartmentToCreateDTO department)
        {
            var deparmtentCreated = new Department()
            {
                Code = department.Code,
                Description = department.Description,
                Name = department.Name,
                creationDate = department.CreationDate,
                LastModifiedBy = 1,
                CreatedBy = 1 , 
                LastModifiedon = DateTime.UtcNow,
            };
            int rowsaffected = _departmentReporstory.AddDepartment(deparmtentCreated);
            return rowsaffected;
        }

        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
           // var departments = _departmentReporstory.GetAll();//Ienurmable of department 
           // // DEpartment ==> DepartmentToReturnDto 
           //foreach (var department in departments)
           // {
           //     yield return new DepartmentDetailsToReturnDto()
           //     {
           //         Description = department.Description,
           //         CreationDate = department.CreationDate,
           //         Code = department.Code,
           //         Id = department.Id,
           //         Name = department.Name,
           //     };
           // }
           var department  = _departmentReporstory.GetAllQuerable().Select(department => new DepartmentDetailsToReturnDto
           {
               Description = department.Description,
               CreationDate = department.CreationDate,
               Code = department.Code,
               Id = department.Id,
               Name = department.Name,
           })AsnoTracking().ToList();
            return department;
        }

        public DepartmentDetailsToReturnDto? GetDepartmentById(int id)
        {
            var department = _departmentReporstory.GetByID(id);
            if(department != null)
            {
                return new DepartmentDetailsToReturnDto()
                {
                    Code = department.Code,
                    Id = department.Id,
                    Name = department.Name,
                    createdon = department.Createdon,
                    createdbt = department.Createdbt,
                    CreationDate = department.CreationDate,
                    LastModifiedat = department.LastModifiedat,
                    LastModifiedby = department.LastModifiedby,
                    Description = department.Description,
                    IsDeleted = department.IsDeleted,

                };
            }
        }

        public int UpdateDepartment(DepartmentToUpdateDTO department)
        {
            var deparmtentUpdate = new Department()
            {
                Id= department.Id,
                Code = department.Code,
                Description = department.Description,
                Name = department.Name,
                creationDate = department.CreationDate,
                LastModifiedBy = 1,
                CreatedBy = 1,
                LastModifiedon = DateTime.UtcNow,
            };
            return _departmentReporstory.updateDepartment(deparmtentUpdate);

        }
        public bool DeleteDepartment(int id)
        {
            var department = _departmentReporstory.GetByID(id);
            if (department != null)
            {
                int rowsAffected = _departmentReporstory.DeleteDepartmemnt(department);
                return rowsAffected > 0;
            }
            return false;
        }
    }
}
