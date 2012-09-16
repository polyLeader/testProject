namespace testProject.BusinessLogic.Core
{
    using System.Data.Entity;

    using testProject.BusinessLogic.Domain;

    public class DatabaseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Tutor> Tutors { get; set; }
    }
}
