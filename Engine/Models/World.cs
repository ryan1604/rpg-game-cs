using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoord, int yCoord, string name, string desc, string imageName)
        {
            _locations.Add(new Location(xCoord, yCoord, name, desc, $"/Engine;component/Images/Locations/{imageName}"));
        }

        public Location LocationAt(int xCoord, int yCoord)
        {
            foreach (Location loc in _locations)
            {
                if (loc.XCoordinate == xCoord && loc.YCoordinate == yCoord)
                {
                    return loc;
                }
            }
            return null;
        }
    }
}
