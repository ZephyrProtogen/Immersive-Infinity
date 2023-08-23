using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using immersiveinfinity.Projectiles;

namespace immersiveinfinity.Content.Items.Weapons.Melee
{
    internal class BerghamBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bergham Blade");
            Tooltip.SetDefault("Sword of The Elemental Gods");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


        }
        public override void SetDefaults()
        {
            Item.width = 80;
            Item.height = 80;
            Item.scale = 1.6f;
            Item.useTurn = true;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 40;
            Item.useAnimation = 25;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 420;
            Item.knockBack = 12f;
            Item.crit = 50;

            Item.value = Item.buyPrice(gold: 30, silver: 80, copper: 50);
            Item.value = Item.sellPrice(gold: 30, silver: 80);
            Item.rare = ItemRarityID.Master;

            Item.UseSound = SoundID.Item1;
            Item.shoot = ModContent.ProjectileType<BerghamBladeProjectile>();
            Item.shootSpeed = 25;



        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Seedler, 1);
            recipe.AddIngredient(ItemID.Starfury, 1);
            recipe.AddIngredient(ItemID.RazorbladeTyphoon, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();


        }
    }
}
