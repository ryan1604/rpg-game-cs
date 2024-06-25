using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSCSRPG.Models
{
    public class Recipe(int id, string name, List<ItemQuantity> ingredients, List<ItemQuantity> outputItems)
    {
        public int ID { get; } = id;
        [JsonIgnore]
        public string Name { get; } = name;
        [JsonIgnore]
        public List<ItemQuantity> Ingredients { get; } = ingredients;
        [JsonIgnore]
        public List<ItemQuantity> OutputItems { get; } = outputItems;

        [JsonIgnore]
        public string ToolTipContents =>
            "Ingredients" + Environment.NewLine +
            "===========" + Environment.NewLine +
            string.Join(Environment.NewLine, Ingredients.Select(i => i.ItemQuantityDescription)) +
            Environment.NewLine + Environment.NewLine +
            "Creates" + Environment.NewLine +
            "===========" + Environment.NewLine +
            string.Join(Environment.NewLine, OutputItems.Select(i => i.ItemQuantityDescription));
    }
}
