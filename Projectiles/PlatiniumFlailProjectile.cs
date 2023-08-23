using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;


namespace immersiveinfinity.Projectiles
{
    internal class PlatiniumFlailProjectile : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("GoldenFlailProjectile");
        }
        public override void SetDefaults()
        {
            Projectile.netImportant = true;
            Projectile.width = 22;
            Projectile.height = 5;
            Projectile.friendly = true;
            Projectile.damage = 15;
            Projectile.penetrate = 3;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.localNPCHitCooldown = 10;
            Projectile.stepSpeed = 5f;


            Projectile.aiStyle = ProjAIStyleID.Flail;
            AIType = ProjectileID.BlueMoon;

            DrawOffsetX = -6;
            DrawOriginOffsetY = -6;
        }



        public override void AI()
        {


            if (Main.myPlayer == Projectile.owner && Projectile.ai[0] == 2f && Projectile.ai[1] == 3f)
            {

                Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center, Projectile.velocity, ProjectileID.BlueMoon, Projectile.damage, Projectile.knockBack, Main.myPlayer);
                Projectile.ai[1]++;
            }


            {

                int dust = Dust.NewDust(Projectile.Center, 8, 8, DustID.PlatinumCoin, 0.9f, 0.9f, 0, default, 2);
                Main.dust[dust].noGravity = true;
                Main.dust[dust].velocity *= 4f;
                Main.dust[dust].scale = 2f;
            }
        }
    }
}
