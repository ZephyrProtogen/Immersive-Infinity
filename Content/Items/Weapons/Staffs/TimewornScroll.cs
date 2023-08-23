using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using immersiveinfinity.Projectiles;
using Terraria.Audio;

namespace immersiveinfinity.Content.Items.Weapons.Staffs
{
    internal class TimewornScroll : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Timeworn Scroll");
            Tooltip.SetDefault("It was created for practical use, is very old, but appears new and was taken from its rightful owner.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            Item.staff[Item.type] = true;

        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.mana = 15;
            Item.scale = 0.2f;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 29;
            Item.useAnimation = 29;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Magic;
            Item.damage = 55;
            Item.knockBack = 6f;
            Item.crit = 35;

            Item.value = Item.buyPrice(silver: 80, copper: 50);
            Item.value = Item.sellPrice(gold: 1, silver: 80, copper: 50);
            Item.rare = ItemRarityID.Orange;

            Item.UseSound = SoundID.Item8;
            Item.shoot = ModContent.ProjectileType<TimewornScrollProjectile>();
            Item.shootSpeed = 5f;
            Item.noMelee = true;


        }
    }
}