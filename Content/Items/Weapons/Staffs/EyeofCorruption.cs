using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using immersiveinfinity.Projectiles;
using Terraria.Audio;

namespace immersiveinfinity.Content.Items.Weapons.Staffs
{
    internal class EyeofCorruption : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eye of Corruption");
            Tooltip.SetDefault("It was created for typical use and is seen as a cursed weapon.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            Item.staff[Item.type] = true;

        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.mana = 10;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 29;
            Item.useAnimation = 29;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Magic;
            Item.damage = 30;
            Item.knockBack = 10f;
            Item.crit = 20;

            Item.value = Item.buyPrice(silver: 80, copper: 50);
            Item.rare = ItemRarityID.Yellow;

            Item.UseSound = SoundID.Item8;
            Item.shoot = ModContent.ProjectileType<EyeofCorruptionProjectile>();
            Item.shootSpeed = 5f;
            Item.noMelee = true;
            

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Lens, 10);
            recipe.AddIngredient(ItemID.DemoniteBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();


        }
    }
}