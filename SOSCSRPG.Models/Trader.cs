using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSCSRPG.Models
{
    public class Trader(int id, string name) : LivingEntity(name, 9999, 9999, new List<PlayerAttribute>(), 9999)
    {
        public int ID { get; } = id;
    }
}
