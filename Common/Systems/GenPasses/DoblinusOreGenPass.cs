using Terraria;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using Terraria.IO;
using immersiveinfinity.Tiles;

namespace immersiveinfinity.Common.Systems.GenPasses
{
    internal class DoblinusOreGenPass : GenPass
    {
        public DoblinusOreGenPass(string name, float weight) : base(name, weight) { }

        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            progress.Message = "Spawning ImmersiveInfinity Ores";

            int maxToSpawn = (int)(Main.maxTilesX * Main.maxTilesY * 6E-05);
            for (int i = 0; i < maxToSpawn; i++)
                
                {
                int LowX = 200;                     //after ocean on left edge of map
                int HighX = Main.maxTilesX - 200;     //before ocean on right edge of map
                int LowY = 700;    
                int HighY = 1300;  

                int X = WorldGen.genRand.Next(LowX, HighX); //don't touch
                int Y = WorldGen.genRand.Next(LowY, HighY); //don't touch

                int OreMinimumSpread = 5;
                int OreMaximumSpread = 8; 

                int OreMinimumFrequency = 5; 
                int OreMaximumFrequency = 8; 

                int OreSpread = WorldGen.genRand.Next(OreMinimumSpread, OreMaximumSpread + 1); //don't touch
                int OreFrequency = WorldGen.genRand.Next(OreMinimumFrequency, OreMaximumFrequency + 1); //don't touch

                WorldGen.TileRunner(X, Y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 5), ModContent.TileType<DoblinusOre>());
            }


        }
    }
}