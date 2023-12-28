using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vb.Base.Entity;

namespace Vb.Data.Entity;

[Table("Employee", Schema = "dbo")]
public class Employee : BaseEntity
{
    public string IdentityNumber { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public double HourlySalary { get; set; }
    public int EmployeeNumber { get; set; }

}

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(x => x.InsertDate).IsRequired(true);
        builder.Property(x => x.InsertUserId).IsRequired(true);
        builder.Property(x => x.UpdateDate).IsRequired(false);
        builder.Property(x => x.UpdateUserId).IsRequired(false);
        builder.Property(x => x.IsActive).IsRequired(true).HasDefaultValue(true);

        builder.Property(x => x.IdentityNumber).IsRequired(true).HasMaxLength(11);
        builder.Property(x => x.Name).IsRequired(true).HasMaxLength(50);
        builder.Property(x => x.Email).IsRequired(true).HasMaxLength(50);
        builder.Property(x => x.Phone).IsRequired(true);
        builder.Property(x => x.DateOfBirth).IsRequired(true);
        builder.Property(x => x.HourlySalary).IsRequired(true);

        builder.HasIndex(x => x.IdentityNumber).IsUnique(true);
        builder.HasIndex(x => x.EmployeeNumber).IsUnique(true);
    }

}