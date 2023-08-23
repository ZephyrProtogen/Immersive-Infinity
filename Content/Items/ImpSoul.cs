using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace immersiveinfinity.Content.Items
{
    internal class ImpSoul : ModItem
    {
        public override void SetStaticDefaults()
        {
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(4, 4));
            Tooltip.SetDefault("The essence of Evil...");
            DisplayName.SetDefault("Imp Soul");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.value = 100;
            Item.rare = ItemRarityID.Green;
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;
            ItemID.Sets.ItemIconPulse[Item.type] = true;
            ItemID.Sets.ItemNoGravity[Item.type] = true;

        }
        public override void AddRecipes()
        {

        }
        public override void PostUpdate()
        {
            Lighting.AddLight(Item.Center, 2f,0f,0.4f);
        }
    }
}
