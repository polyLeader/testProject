namespace testProject.BusinessLogic.Core
{
    using System.Collections.Generic;

    using testProject.BusinessLogic.Domain;

    public interface ITutorRepository
    {
        Tutor Add(Tutor tutor);

        Tutor Update(Tutor tutor);

        void Delete(Tutor tutor);

        IList<Tutor> GetAllTutors(Tutor tutor);

        IList<Tutor> GetExperiencedTutors(Tutor tutor);
    }
}