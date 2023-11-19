using IL.Terraria.Audio;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Linq;
using System.Text.RegularExpressions;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using On.Terraria.Audio;

namespace immersiveinfinity.Content.Items.Accessories
{

    [AutoloadEquip(EquipType.Wings)]
    public class SprintersOfEclipseWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sprinters Of Eclipse");
            Tooltip.SetDefault("Use the unimaginary power of Eclipse\n"
                + "Grants permament regeneration boost\n"
                + "Grants permament jump boost\n"
                + "Owner can fly and run at HUUUGE speed\n"
                + "12% attack speed\n"
                + "15% damage\n"
                + "Grants immunity to lava\n"
                + "Grants water walking ability\n"



                );


        }

        public override void SetDefaults()
        {
            Item.width = 42;
            Item.height = 34;
            Item.value = 8600;
            Item.rare = ItemRarityID.Lime;
            Item.accessory = true;




        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {


            player.GetDamage(DamageClass.Generic) += 0.15f;
            player.GetAttackSpeed(DamageClass.Generic) += 0.12f;
            player.maxRunSpeed = 8f;
            player.accRunSpeed = 12f;
            player.lifeRegen += 20;
            player.jumpBoost = true;
            player.jumpSpeedBoost = 2f;
            player.wingTimeMax = 400;
            player.lavaImmune = true;
            player.fireWalk = true;
            player.waterWalk = true;
            player.honey = true;


        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.4f;
            ascentWhenRising = 0.3f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.235f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 16f;
            acceleration += 1.5f;

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.TerrasparkBoots, 1);
            recipe.AddIngredient(ItemID.SoulofFlight, 25);
            recipe.AddIngredient(ItemID.BandofRegeneration, 1);
            recipe.AddIngredient(ItemID.AvengerEmblem, 1);
            recipe.AddIngredient(ItemID.PowerGlove, 1);
            recipe.AddIngredient(ItemID.SwiftnessPotion, 10);
            recipe.AddIngredient(ModContent.ItemType<TakeOffs>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

        }




    }
}