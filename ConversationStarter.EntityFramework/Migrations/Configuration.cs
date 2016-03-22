using System.Data.Entity.Migrations;
using ConversationStarter.Migrations.SeedData;

namespace ConversationStarter.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ConversationStarter.EntityFramework.ConversationStarterDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ConversationStarter";
        }

        protected override void Seed(ConversationStarter.EntityFramework.ConversationStarterDbContext context)
        {
            new InitialDataBuilder(context).Build();
        }
    }
}
