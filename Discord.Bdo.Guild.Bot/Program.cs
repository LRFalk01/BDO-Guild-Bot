namespace Discord.Bdo.Guild.Bot
{
    class Program
    {
        public static void Main(string[] args)
        {
            var bot = new Bot();

            bot.RunBotAsync().GetAwaiter().GetResult();
        }
    }
}
