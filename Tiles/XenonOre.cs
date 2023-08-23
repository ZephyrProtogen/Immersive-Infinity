using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace immersiveinfinity.Tiles
{
    internal class XenonOre : ModTile
    {
        public override void SetStaticDefaults()
        {
            TileID.Sets.Ore[Type] = true;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileShine[Type] = 900;
            Main.tileShine2[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileOreFinderPriority[Type] = 350;
            AddMapEntry(new Color(5, 120, 30), CreateMapEntryName());

            DustType = DustID.Gold;
            ItemDrop = ModContent.ItemType<Content.Items.Placeables.XenonOre>();

            HitSound = SoundID.Tink;


            MineResist = 1.5f;
            MinPick = 65;
        }

    }
}
