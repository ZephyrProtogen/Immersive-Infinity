using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using immersiveinfinity.Projectiles;
using immersiveinfinity.Content.Items.Placeables;

namespace immersiveinfinity.Content.Items.Armor;

[AutoloadEquip(EquipType.Body)]
public class DoblinusChest : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Doblinus Leggings");
        Tooltip.SetDefault("10% Increased Critical Strike Chance\n"
            + "20% Melee Damage\n"

            );
    }

    public override void SetDefaults()
    {
        Item.width = 12;
        Item.height = 12;
        Item.value = 2000;
        Item.rare = ItemRarityID.Purple;
        Item.defense = 35;
        
    }
    public override void UpdateEquip(Player player)
    { 
        player.GetCritChance(DamageClass.Melee) += 10f;
        player.GetDamage(DamageClass.Melee) *= 1.2f;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ModContent.ItemType<DoblinusBar>(), 20);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

    }
}