using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PR9.FolderModel
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Table_Motobike> Table_Motobike { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
