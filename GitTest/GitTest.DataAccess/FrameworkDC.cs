using System.Data.Entity;
using GitTest.Model;

namespace GitTest.DataAccess
{
    public partial class DataContext
    {
        public DbSet<FrameworkUser> FrameworkUsers { get; set; }
        public DbSet<FrameworkDepartment> FrameworkDepartments { get; set; }
        public DbSet<FrameworkCompany> FrameworkCompanies { get; set; }
        public DbSet<FrameworkFactory> FrameworkFactory { get; set; }
        public DbSet<ContractApprove> ContractApproves { get; set; }
    }
}
