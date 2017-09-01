using SamsonErp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SamsonErp.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SamsonErpDbContext _context;

        public InitialHostDbBuilder(SamsonErpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
