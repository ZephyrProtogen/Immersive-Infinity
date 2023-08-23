using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;
using immersiveinfinity.Projectiles;
using immersiveinfinity.Content.Items.Weapons.Throwables;

namespace immersiveinfinity.Content.Items.Weapons.Throwables

{
    public class Throwing_axe : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Throwing axe");
            Tooltip.SetDefault("Throwing axe");
        


        }
        public override void SetDefaults()
        {
           
            Item.damage = 20;
            Item.noMelee = true;
            Item.DamageType = DamageClass.Throwing;
            Item.width = 26;
            Item.height = 39;
            
            Item.useTime = 17;
            Item.useAnimation = 17;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 4;
            Item.value = 10;
            Item.rare = ItemRarityID.White;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = false;
            Item.shoot = ProjectileID.PoisonedKnife;
            Item.shootSpeed = 8f;
            Item.useTurn = true;
            Item.maxStack = 999;
            Item.consumable = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Lens, 10);
            recipe.AddIngredient(ItemID.HellstoneBar, 30);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();


        }
        public override void HoldItem(Player player)
        {
            player.itemRotation = 0f;
            player.itemLocation.Y = player.Center.Y - 100 * player.direction;
            player.itemLocation.X = player.Center.X - 18 * player.direction;
        }
    }
}
    