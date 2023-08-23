using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using immersiveinfinity.Projectiles;

namespace immersiveinfinity.Content.Items.Weapons.Melee
{
    internal class Fate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fate");
            Tooltip.SetDefault("Sword");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


        }
        public override void SetDefaults()
        {
            Item.width = 58;
            Item.height = 58;
            Item.scale = 1.4f;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 40;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 28;
            Item.knockBack = 5f;
            Item.crit = 20;

            Item.value = Item.buyPrice(gold: 30, silver: 80, copper: 50);
            Item.value = Item.sellPrice(gold: 1, silver: 80);
            Item.rare = ItemRarityID.Blue;
            

            Item.UseSound = SoundID.Item1;
            Item.shoot = ModContent.ProjectileType<FateProjectile>();
            Item.shootSpeed = 25;
            


        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.PlatinumBar, 20);
            recipe.AddIngredient(ItemID.FallenStar, 12);
            recipe.AddIngredient(ItemID.Ruby, 10);
            recipe.AddIngredient(ModContent.ItemType<ImpSoul>(), 25);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GoldBar, 20);
            recipe.AddIngredient(ItemID.FallenStar, 12);
            recipe.AddIngredient(ModContent.ItemType<ImpSoul>(), 25);
            recipe.AddIngredient(ItemID.Ruby, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
