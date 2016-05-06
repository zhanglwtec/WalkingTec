using System.Data.Entity;
using WalkingTec.Mvvm.Core;

namespace GitTest.DataAccess
{
    [DbConfigurationType("WalkingTec.Mvvm.Core.DCConfig,WalkingTec.Mvvm.Core")]
    public partial class DataContext : FrameworkContext
    {
        public DataContext() : base("name=default")
        {
        }

        public DataContext(string cs)
            : base(cs)
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}