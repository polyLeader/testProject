namespace testProject.BusinessLogic.Core
{
    using System.Collections.Generic;

    using testProject.BusinessLogic.Domain;

    public interface IStudentRepository
    {
        Student Add(Student student);

        Student Update(Student student);

        void Delete(Student student);

        IList<Student> GetAllStudents();

        IList<Student> GetAllGoodStudents();
    }
}
