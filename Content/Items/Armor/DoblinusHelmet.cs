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
            Item.rare = 1;
            Item.defense = 2;
        }



        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Melee) += 0.85f;
           
        }
   


        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "15% Increased damage";
            player.GetDamage(DamageClass.Melee) += 0.15f;
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
            recipe.AddIngredient(ItemID.GoldBar, 16);
            recipe.AddIngredient(ItemID.Ruby, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

        }
   
    }
}