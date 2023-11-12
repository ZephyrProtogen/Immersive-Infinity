using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;


namespace immersiveinfinity.Projectiles
{
    internal class Unholy_Might_Projectile : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unholy Might Projectile");
        }
        public override void SetDefaults()
        {
            Projectile.netImportant = true;
            Projectile.width = 22;
            Projectile.height = 5;
            Projectile.friendly = true;
            Projectile.damage = 15;
            Projectile.penetrate = 10;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.localNPCHitCooldown = 10;
            Projectile.stepSpeed = 1f;


            Projectile.aiStyle = ProjAIStyleID.Flail;
            AIType = ProjectileID.BlackBolt;

            DrawOffsetX = -6;
            DrawOriginOffsetY = -6;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Poisoned, 10 * 60);

        }


        public override void AI()
        {


            if (Main.myPlayer == Projectile.owner && Projectile.ai[0] == 3f && Projectile.ai[1] == 3f)
            {

                Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center, Projectile.velocity, ProjectileID.BlackBolt, Projectile.damage, Projectile.knockBack, Main.myPlayer);
                Projectile.ai[1]++;


            }
         
                Projectile.rotation = Projectile.rotation + 0.5235f;
            
      
            
            {

                int dust = Dust.NewDust(Projectile.Center, 8, 8, DustID.GemRuby, 0.9f, 0.9f, 0, default, 2);
                Main.dust[dust].noGravity = true;
                Main.dust[dust].velocity *= 2f;
                Main.dust[dust].scale = 1f;
            }
        }
    }
}