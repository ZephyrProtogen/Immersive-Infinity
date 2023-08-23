using Terraria;
using Terraria.DataStructures;
using Terraria.ObjectData;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;


namespace immersiveinfinity.Tiles
{
    internal class CelestialGodRelicTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();

            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Celestial God Relic");

            AddMapEntry(new Microsoft.Xna.Framework.Color(200, 200, 200), CreateMapEntryName());

  
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileShine[Type] = 1500;
            Main.tileShine2[Type] = true;
        }

        
        


        


    }
}