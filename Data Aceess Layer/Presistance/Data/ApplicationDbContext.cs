using Data_Aceess_Layer.Entites.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Aceess_Layer.Presistance.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(Dbcontextoptions<ApplicationDbContext>options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextoptionBuldier optionbuilder)
        //{
        //    optionbuilder.UseSqlServer("Server = . ; Database=MVCProject ; Trusted_Connection=true; TrustedServerCertificate=true");
        //}
        protected override void OnModelCreating(Modelbuilder modelbuilder)
        {
            modelbuilder.ApplyConfigrationFromAssembly(Assembly.GetExecutingAssembly());
        }
        public Dbset<Department> Departments {  get; set; }
    }
}
