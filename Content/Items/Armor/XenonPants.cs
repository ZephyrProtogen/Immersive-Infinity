using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using immersiveinfinity.Rarities;
using immersiveinfinity.Content.Items.Placeables;

namespace immersiveinfinity.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class XenonPants : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Xenon Pants");
            Tooltip.SetDefault("15% Increased movement speed");
        }

        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.value = 1500;
            Item.rare = ModContent.RarityType<XenonRarity>();
            Item.defense = 7;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed *= 1.15f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<XenonBar>());
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

        }
    }
}