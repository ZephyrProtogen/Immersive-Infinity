using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using immersiveinfinity.Projectiles;
using immersiveinfinity.Content.Items.Placeables;

namespace immersiveinfinity.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class DoblinusPants : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Doblinus Leggings");
            Tooltip.SetDefault("20% Increased speed\n"
                + "Adds Buff: Inferno\n"
                + "20% Melee Attack Speed\n"

                );
        }

        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.value = 1500;
            Item.rare = ItemRarityID.Purple;
            Item.defense = 18;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.20f;
            player.AddBuff(BuffID.Inferno,5);
            player.GetAttackSpeed(DamageClass.Melee) *= 1.2f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<DoblinusBar>(), 12);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

        }
    }
}