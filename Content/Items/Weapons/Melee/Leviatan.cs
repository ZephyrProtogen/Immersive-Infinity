using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace immersiveinfinity.Content.Items.Weapons.Melee
{
    internal class Leviatan : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leviatan");
            Tooltip.SetDefault("它由最偉大的鍛造大師用最好的材料和傳說中的劍之一“地獄之劍”鍛造而成");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 30;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 653;
            Item.knockBack = 30f;
            Item.crit = 35;

            Item.value = Item.buyPrice(silver: 1000, copper: 50);
            Item.rare = ItemRarityID.Master;

            Item.UseSound = SoundID.Item1;


        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Weapons.Melee.InfernoSword>(), 1);
            recipe.AddIngredient(ItemID.ShroomiteBar, 60);
            recipe.AddIngredient(ItemID.TrueNightsEdge, 1);
            recipe.AddIngredient(ItemID.LunarBar, 15);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();


        }
    }
}
