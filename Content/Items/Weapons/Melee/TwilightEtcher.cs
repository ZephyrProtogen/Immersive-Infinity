using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace immersiveinfinity.Content.Items.Weapons.Melee
{
    public class TwilightEtcher : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Twilight Etcher");
            Tooltip.SetDefault("Shiny");
        


            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 9));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;
            ItemID.Sets.ItemIconPulse[Item.type] = false;
            ItemID.Sets.ItemNoGravity[Item.type] = false;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;
            

            Item.DamageType = DamageClass.Melee;
            Item.damage = 120;
            Item.knockBack = 10f;
            Item.crit = 20;
            Item.shoot = ProjectileID.DD2SquireSonicBoom;
            Item.shootSpeed = 10f;

            Item.value = Item.buyPrice(silver: 80, copper: 50);
            Item.rare = ItemRarityID.Red;

            Item.UseSound = SoundID.Item1;


        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SpectreBar, 15);
            recipe.AddIngredient(ItemID.FragmentSolar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();


        }
    }
}