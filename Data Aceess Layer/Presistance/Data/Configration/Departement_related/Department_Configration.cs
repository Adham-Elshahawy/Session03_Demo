using Data_Aceess_Layer.Entites.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Aceess_Layer.Presistance.Data.Configration.Departement_related
{
    //internal class Department_Configration : IEntityTypeConfigration<Department>
    //{
    //    public void Configure(EntityTypeBuilder<Department> builder) 
    //    {
    //        builder.Property(D => D.Id).UseIdentifyColumn(10,10);
    //        builder.Property(D=>D.Name).HasColumnType("nvarchar(50)").IsRequired();
    //        builder.Property(D => D.Code).HasColumnType("nvarchar(20)").IsRequired();
    //        builder.Property(D => D.LastModified).HasComputedColumnSql("GETDATE");
    //        builder.Property(D => D.Createdon).HasDefaultvalueSql("GETDATE");
    //    }
    //}
}
