using immersiveinfinity.Content.Items.Placeables;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace immersiveinfinity.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class DoblinusHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Doblinus Helmet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("5% increased melee damage");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = 1500;
            Item.rare = ItemRarityID.Purple;
            Item.defense = 22;
        }



        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Melee) *= 1.05f;
           
        }
   


        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "15% Increased melee damage";
            player.GetDamage(DamageClass.Melee) *= 1.15f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            if (body.type == Mod.Find<ModItem>("DoblinusChest").Type)
            {
                return legs.type == Mod.Find<ModItem>("DoblinusPants").Type;
            }
            return false;
        }



        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<DoblinusBar>(), 16);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

        }
   
    }
}