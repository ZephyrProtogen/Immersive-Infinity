using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using immersiveinfinity.Projectiles;

namespace immersiveinfinity.Content.Items.Weapons.Flails
{
	internal class Unholy_Might : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unholy Might");
			Tooltip.SetDefault("Its Shining!");

		}

		public override void SetDefaults()
		{

			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 45;
			Item.useTime = 10;
			Item.knockBack = 3f;
			Item.width = 30;
			Item.height = 10;
			Item.damage = 85;
			Item.crit = 5;
			Item.scale = 1.1f;
			Item.noUseGraphic = true;
			Item.shoot = ModContent.ProjectileType<Unholy_Might_Projectile>();
			Item.shootSpeed = 5f;
			Item.channel = true;
			Item.UseSound = SoundID.Item1;
			Item.rare = ItemRarityID.Yellow;
			Item.value = Item.sellPrice(gold: 2, silver: 80);
			Item.DamageType = DamageClass.MeleeNoSpeed;
			Item.noMelee = true;
			
		}


		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DemoniteBar, 7);
			recipe.AddIngredient(ItemID.Chain, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

		}
	}
}
