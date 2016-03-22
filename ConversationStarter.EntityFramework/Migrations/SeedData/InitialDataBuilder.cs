using ConversationStarter.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ConversationStarter.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly ConversationStarterDbContext _context;

        public InitialDataBuilder(ConversationStarterDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
