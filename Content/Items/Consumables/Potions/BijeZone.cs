using immersiveinfinity.Content.Items.Consumables.Potions;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using immersiveinfinity;
using System.Reflection;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;


using ReLogic.Utilities;
using System.Collections.Generic;

using Terraria.Audio;


namespace immersiveinfinity.Content.Items.Consumables.Potions
{
    internal class BijeZone : ModItem
       
    {
        
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bije zone");
            Tooltip.SetDefault("Pij na wlasna odpowiedzialnosc");
        }

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 40;
            Item.maxStack = 999;
            
            Item.useAnimation = 45;
            Item.useTime = 45;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.UseSound = SoundID.Item1;
            Item.consumable = true;
            Item.buffType = ModContent.BuffType<Buffs.BijeZoneEfekt>();
            Item.buffTime = 137;
            Item.rare = ModContent.RarityType<Rarities.woda>();
           
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Ale, 1);
            recipe.AddTile(TileID.Bottles);
            recipe.Register();


        }



    }
}
