namespace testProject.BusinessLogic.Core
{
    using System.Data.Entity;

    using testProject.BusinessLogic.Domain;

    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            context.Students.Add(new Student
                {
                  Name  = "Beseda",
                  AverageMark = (float)-3
                });
            context.Students.Add(new Student
            {
                Name = "Kovalov",
                AverageMark = (float)2
            });
            context.Tutors.Add(new Tutor
            {
                Name = "Gusev",
                Experience = (float)40
            });
            context.Tutors.Add(new Tutor()
            {
                Name = "Miroshkin",
                Experience = (float)2.6
            });
            context.SaveChanges();
        }
    }
}
