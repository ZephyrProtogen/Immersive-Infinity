using immersiveinfinity.Content.Items.Placeables;
using immersiveinfinity.Rarities;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace immersiveinfinity.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class XenonHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Xenon Helmet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("5% increased melee damage");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = 1500;
            Item.rare = ModContent.RarityType<XenonRarity>();
            Item.defense = 8;
        }



        public override void UpdateEquip(Player player)
        {
            
            player.GetDamage(DamageClass.Melee) *= 1.05f;
            

        }
   


        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "12% Increased melee damage";
            player.GetDamage(DamageClass.Melee) *= 1.12f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            if (body.type == Mod.Find<ModItem>("XenonChest").Type)
            {
                return legs.type == Mod.Find<ModItem>("XenonPants").Type;
            }
            return false;
        }



        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<XenonBar>(), 12);

            recipe.AddTile(TileID.Anvils);
            recipe.Register();

        }
   
    }
}