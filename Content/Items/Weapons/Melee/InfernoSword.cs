using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace immersiveinfinity.Content.Items.Weapons.Melee
{
    internal class InfernoSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Inferno Sword");
            Tooltip.SetDefault("It was forged by bars from Hell itself");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 90;
            Item.knockBack = 10f;
            Item.crit = 20;

            Item.value = Item.buyPrice(silver: 80, copper: 50);
            Item.rare = ItemRarityID.Red;

            Item.UseSound = SoundID.Item1;


        }
        
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Placeables.DoblinusBar>(), 30);
            recipe.AddIngredient(ItemID.HellstoneBar, 30);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();


        }
        
    }
    
}
