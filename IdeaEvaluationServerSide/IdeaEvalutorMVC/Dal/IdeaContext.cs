using IdeaEvalutorMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdeaEvalutorMVC.Dal
{
    public class IdeaContext: DbContext
    {
        public IdeaContext():base("IdeaContext")
        {

        }
        public DbSet<JudgeEO> JudgeModels { get; set; }
        public DbSet<IdeaEO> IdeaModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JudgeEO>().ToTable("tblJudge");
            modelBuilder.Entity<IdeaEO>().ToTable("tblIdea");
        }
    }
}