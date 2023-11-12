using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;

namespace immersiveinfinity.Content.Items.Weapons.Bows
{
    internal class IronbarkPiercer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ironbark Piercer");
            Tooltip.SetDefault("Just a regular Iron Bow");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.autoReuse = true;
            Item.useStyle = 5;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 14;
            Item.knockBack = 5f;
            Item.crit = 16;

            Item.value = Item.buyPrice(gold: 10, silver: 80, copper: 50);
            Item.value = Item.sellPrice(gold: 0, silver: 40);
            Item.rare = ItemRarityID.Green;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Arrow;
            Item.shootSpeed = 7f;

            Item.UseSound = SoundID.Item5;


        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup("IronBar", 10);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();


        }
        public override Vector2? HoldoutOffset()
        {
            Vector2 offset = new Vector2(6, 0);
            return offset;
        }
    }
}

