using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using immersiveinfinity.Projectiles;

namespace immersiveinfinity.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class DoblinusPants : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Doblinus Leggings");
            Tooltip.SetDefault("7% Increased movement speed");
        }

        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.value = 1500;
            Item.rare = 1;
            Item.defense = 3;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.07f;
        }
    }
}