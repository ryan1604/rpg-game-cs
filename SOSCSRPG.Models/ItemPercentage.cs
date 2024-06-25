using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSCSRPG.Models
{
    public class ItemPercentage(int id, int percentage)
    {
        public int ID { get; } = id;
        public int Percentage { get; } = percentage;
    }
}
