using Discord.Bdo.Guild.Bot.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Discord.Bdo.Guild.Bot.DAL
{
    public class BotContext : DbContext
    {
        public BotContext()
        {
            Database.Migrate();
        }

        public DbSet<Config> Configs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./App_Data/BotData.db");
        }
    }
}