using IL.Terraria.DataStructures;
using Microsoft.Xna.Framework;
using On.Terraria.DataStructures;
using System.ComponentModel;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace immersiveinfinity.Projectiles
{
    public class PostFate : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fate Projectile Post");
        }

        public override void SetDefaults()
        {
            Projectile.width = 8;
            Projectile.height = 8;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.tileCollide = false;
            Projectile.penetrate = 4;

        }
        public override void AI()
        {
            Projectile.aiStyle = 27;
            int dust1 = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, 72, Projectile.velocity.X * 0.2f, Projectile.velocity.Y * 0.2f, 150, default(Color), 1f);
            Lighting.AddLight(Projectile.Center, 2f, 0.1f, 0.3f);
          

        }
    }
}
