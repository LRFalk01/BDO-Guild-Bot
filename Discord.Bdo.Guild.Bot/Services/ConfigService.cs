using System.Linq;
using Discord.Bdo.Guild.Bot.DAL;
using Discord.Bdo.Guild.Bot.DAL.Entities;

namespace Discord.Bdo.Guild.Bot.Services
{
    public class ConfigService
    {
        public Config GetConfig()
        {
            using (var context = new BotContext())
            {
                return context.Configs.FirstOrDefault();
            }
        }
        
    }
}