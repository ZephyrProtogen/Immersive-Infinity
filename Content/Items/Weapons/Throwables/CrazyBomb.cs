using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using immersiveinfinity.Projectiles;
using Steamworks;


namespace immersiveinfinity.Content.Items.Weapons.Throwables
{
    public class CrazyBomb : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crazy Bomb");
        }
        public override void SetDefaults()
        {

            Item.damage = 20;
            Item.noMelee = true;
            Item.DamageType = DamageClass.Throwing;
            Item.width = 26;
            Item.height = 39;
            Item.shoot = ModContent.ProjectileType<Projectiles.CrazyBomb>();
            Item.UseSound = SoundID.Item1;
            Item.shootSpeed = 5;

            Item.scale = 1.4f;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 40;
            Item.useAnimation = 20;
            Item.autoReuse = true;



        }





    }


}
