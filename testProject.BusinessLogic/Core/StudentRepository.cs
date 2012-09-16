namespace testProject.BusinessLogic.Core
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    using testProject.BusinessLogic.Domain;

    public class StudentRepository : IStudentRepository
    {
        private readonly DatabaseContext databaseContext;

        public StudentRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public Student Add(Student student)
        {
            this.databaseContext.Students.Add(student);
            this.databaseContext.SaveChanges();
            return student;
        }

        public Student Update(Student student)
        {
            this.databaseContext.Entry(student).State = EntityState.Modified;
            this.databaseContext.SaveChanges();
            return student;
        }

        public void Delete(Student student)
        {
            this.databaseContext.Entry(student).State = EntityState.Deleted;
            this.databaseContext.SaveChanges();
        }

        public IList<Student> GetAllStudents()
        {
            return this.databaseContext.Students.ToArray();
        }

        public IList<Student> GetAllGoodStudents()
        {
            return this.databaseContext.Students.Where(x => x.AverageMark > 4).ToArray();
        }
    }
}
