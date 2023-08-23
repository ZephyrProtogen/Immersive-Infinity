using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using immersiveinfinity.Projectiles;
using Terraria.Audio;

namespace immersiveinfinity.Content.Items.Weapons.Flails
{
    internal class GoldenFlail : ModItem 
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Golden Flail");
            Tooltip.SetDefault("Its Shining!");

        }

        public override void SetDefaults()
        {

			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 45; 
			Item.useTime = 45; 
			Item.knockBack = 3f; 
			Item.width = 30; 
			Item.height = 10; 
			Item.damage = 22; 
			Item.crit = 5; 
			Item.scale = 1.1f;
            Item.noUseGraphic = true;
            Item.shoot = ModContent.ProjectileType<GoldenFlailProjectile>();
			Item.shootSpeed = 3f;
			Item.channel = true;
			Item.UseSound = SoundID.Item1; 
			Item.rare = ItemRarityID.Green; 
			Item.value = Item.sellPrice(gold: 2, silver: 50); 
			Item.DamageType = DamageClass.MeleeNoSpeed; 
			Item.noMelee = true;
		}


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldBar, 16);
            recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

        }

    }
}
