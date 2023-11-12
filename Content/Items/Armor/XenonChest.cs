using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using immersiveinfinity.Projectiles;
using immersiveinfinity.Rarities;
using rail;
using immersiveinfinity.Content.Items.Placeables;

namespace immersiveinfinity.Content.Items.Armor;

[AutoloadEquip(EquipType.Body)]
public class XenonChest : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Xenon Chestplate");
        Tooltip.SetDefault("8% Melee Critical Strike Chance\n"
                + "6% Melee Damage\n"
                + "12% Melee Attack Speed\n"
               
                );
    }

    public override void SetDefaults()
    {
        Item.width = 12;
        Item.height = 12;
        Item.value = 2000;
        Item.rare = ModContent.RarityType<XenonRarity>();
        Item.defense = 12;
        
    }
    public override void UpdateEquip(Player player)
    { 
        player.GetCritChance(DamageClass.Melee) += 8f;
        player.GetDamage(DamageClass.Melee) *= 1.06f;
        player.GetAttackSpeed(DamageClass.Melee) *= 1.12f;
    }
    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ModContent.ItemType<XenonBar>(), 20);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

    }
}