using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using immersiveinfinity.Projectiles;

namespace immersiveinfinity.Content.Items.Armor;

[AutoloadEquip(EquipType.Body)]
public class DoblinusChest : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Doblinus Chest");
        Tooltip.SetDefault("3% Increased critical strike chance");
    }

    public override void SetDefaults()
    {
        Item.width = 12;
        Item.height = 12;
        Item.value = 2000;
        Item.rare = 1;
        Item.defense = 5;
        
    }
    public override void UpdateEquip(Player player)
    { 
        player.GetCritChance(DamageClass.Ranged) += 3;
    }
}