using Terraria.ModLoader;
using Terraria.WorldBuilding;
using System.Collections.Generic;
using immersiveinfinity.Common.Systems.GenPasses;

namespace immersiveinfinity.Common.Systems
{
    internal class WorldSystem : ModSystem
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(t => t.Name.Equals("Shinies"));
            if(shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new DoblinusOreGenPass("Doblinus Ore Pass", 320f));
                tasks.Insert(shiniesIndex + 1, new XenonOreGenPass("Xenon Ore Pass", 320f));
                tasks.Insert(shiniesIndex + 1, new CoalGenPass("Coal Pass", 320f));

            }
        }

    }
}
