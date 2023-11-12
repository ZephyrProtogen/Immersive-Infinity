using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using immersiveinfinity.Rarities;
using immersiveinfinity.Content.Items.Placeables;

namespace immersiveinfinity.Content.Items.Weapons.Bows
{
    internal class XenonBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Xenon Bow");
            Tooltip.SetDefault("Made using pure Xenon");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


        }
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 36;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.autoReuse = true;
            Item.useStyle = 5;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 28;
            Item.knockBack = 5f;
            Item.crit = 16;

            Item.value = Item.sellPrice(gold: 0, silver: 40);
            Item.rare = ModContent.RarityType<XenonRarity>();
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Arrow;
            Item.shootSpeed = 18f;

            Item.UseSound = SoundID.Item5;


        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<XenonBar>(), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();


        }
        public override Vector2? HoldoutOffset()
        {
            Vector2 offset = new Vector2(6, 0);
            return offset;
        }
    }
}

