using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using immersiveinfinity;

namespace immersiveinfinity.Content.Items.Accessories
{
	public class TakeOffs : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Take-Offs"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Give instant speed and jump boost");
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.value = 2500;
			Item.rare = 1;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed += 0.5f;
			player.accRunSpeed += 1.5f;
			player.jumpBoost = true;
		

		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Content.Items.Placeables.DoblinusBar>(), 15);
			recipe.AddRecipeGroup("IronBar" ,15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

		}
	}
}

