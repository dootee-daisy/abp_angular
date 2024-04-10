namespace abp_angular.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly abp_angularDbContext _context;

        public InitialHostDbBuilder(abp_angularDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
