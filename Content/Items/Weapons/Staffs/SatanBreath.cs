using immersiveinfinity.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;


namespace immersiveinfinity.Content.Items.Weapons.Staffs
{
    internal class SatanBreath : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Satan's Brath");
            Tooltip.SetDefault("Be aware of huge power of satan.");
        }
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 32;
            Item.mana = 25;

            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.useTime = 60;
            Item.useAnimation = 60;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Magic;
            Item.damage = 78;
            Item.knockBack = 2f;
            Item.crit = 35;

            Item.value = Item.buyPrice(silver: 80, copper: 50);
            Item.value = Item.sellPrice(gold: 1, silver: 80, copper: 50);
            Item.rare = ItemRarityID.Pink;

            Item.UseSound = SoundID.Item8;
            Item.shoot = ModContent.ProjectileType<SatanBreathProjectile>();
            Item.shootSpeed = 8f;
            Item.noMelee = true;

        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SpellTome);
            recipe.AddIngredient(ItemID.Book, 25);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddIngredient(ModContent.ItemType<ImpSoul>(), 25); ;
            recipe.AddTile(TileID.Bookcases);
            recipe.Register();
        }

    }

}