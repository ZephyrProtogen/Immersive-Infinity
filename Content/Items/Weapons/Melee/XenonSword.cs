using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using immersiveinfinity.Rarities;
using immersiveinfinity.Content.Items.Placeables;

namespace immersiveinfinity.Content.Items.Weapons.Melee
{
    internal class XenonSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Xenon Sword");
            Tooltip.SetDefault("Made using pure Xenon");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


        }
        public override void SetDefaults()
        {
            Item.scale = 1.6f;
            Item.width = 44;
            Item.height = 44;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.autoReuse = true;
            Item.useTurn = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 35;
            Item.knockBack = 4f;
            Item.crit = 15;

            Item.value = Item.buyPrice(silver: 80, copper: 50);
            Item.rare = ModContent.RarityType<XenonRarity>();

            Item.UseSound = SoundID.Item1;


        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<XenonBar>(), 18);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();


        }
    }
}
