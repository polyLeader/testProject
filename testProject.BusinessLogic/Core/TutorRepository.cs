namespace testProject.BusinessLogic.Core
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    using testProject.BusinessLogic.Domain;

    public class TutorRepository : ITutorRepository
    {
        private readonly DatabaseContext databaseContext;

        public TutorRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public Tutor Add(Tutor tutor)
        {
            this.databaseContext.Tutors.Add(tutor);
            this.databaseContext.SaveChanges();
            return tutor;
        }

        public Tutor Update(Tutor tutor)
        {
            this.databaseContext.Entry(tutor).State = EntityState.Modified;
            this.databaseContext.SaveChanges();
            return tutor;
        }

        public void Delete(Tutor tutor)
        {
            this.databaseContext.Entry(tutor).State = EntityState.Deleted;
            this.databaseContext.SaveChanges();
        }

        public IList<Tutor> GetAllTutors(Tutor tutor)
        {
            return this.databaseContext.Tutors.ToArray();
        }

        public IList<Tutor> GetExperiencedTutors(Tutor tutor)
        {
            return this.databaseContext.Tutors.Where(x => x.Experience > 5.3).ToArray();
        }
    }
}