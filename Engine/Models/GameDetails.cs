using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameDetails(string title, string subTitle, string version)
    {
        public string Title { get; set; } = title;
        public string SubTitle { get; set; } = subTitle;
        public string Version { get; set; } = version;

        public List<PlayerAttribute> PlayerAttributes { get; } = new List<PlayerAttribute>();
        public List<Race> Races { get; } = new List<Race>();
    }
}
