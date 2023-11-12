using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using immersiveinfinity.Rarities;

namespace immersiveinfinity.Content.Items.Weapons.Tools
{
    internal class XenonPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Xenon Pickaxe");
            Tooltip.SetDefault("Made using pure Xenon");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


        }
        public override void SetDefaults()
        {
            Item.width = 36;
            Item.height = 36;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 10;
            Item.useAnimation = 15;
            Item.autoReuse = true;
            Item.useTurn = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 12;
            Item.knockBack = 1f;
            Item.crit = 20;
            Item.pick = 80;
            

            Item.value = Item.buyPrice(silver: 80, copper: 50);
            Item.rare = ModContent.RarityType<XenonRarity>();

            Item.UseSound = SoundID.Item1;


        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Placeables.XenonBar>(), 15);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();


        }
    }
}
