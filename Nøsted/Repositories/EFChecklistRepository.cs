using Nosted.DataAccess;


namespace Nosted.Repositories
{
    public class EFChecklistRepository
    {
        private readonly DataContext dataContext;

        public EFChecklistRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Add(ChecklistEntity checklist)
        {
            dataContext.Checklist.Add(checklist);
            dataContext.SaveChanges();
        }

    }

}