﻿namespace SOSCSRPG.Models
{
    public class GameDetails(string title, string subTitle, string version)
    {
        public string Title { get; } = title;
        public string SubTitle { get; } = subTitle;
        public string Version { get; } = version;

        public List<PlayerAttribute> PlayerAttributes { get; } = new List<PlayerAttribute>();
        public List<Race> Races { get; } = new List<Race>();
    }
}
