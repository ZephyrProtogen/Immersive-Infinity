using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace immersiveinfinity.Content.Items.Weapons.Melee
{
    internal class knightfall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Knight's Fall");
            Tooltip.SetDefault("Sword of the forgotten");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


        }
        public override void SetDefaults()
        {
            Item.width = 58;
            Item.height = 62;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 22;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 90;
            Item.knockBack = 8f;
            Item.crit = 10;

            Item.value = Item.buyPrice(silver: 80, copper: 50);
            Item.rare = ItemRarityID.Pink;

            Item.UseSound = SoundID.Item1;


        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.AdamantiteBar, 14);
            recipe.AddIngredient(ItemID.Diamond, 8);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.TitaniumBar, 14);
            recipe.AddIngredient(ItemID.Diamond, 8);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();


        }
    }
}
