using IL.Terraria.DataStructures;
using Microsoft.Xna.Framework;
using On.Terraria.DataStructures;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace immersiveinfinity.Projectiles
{
    public class FateProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fate Projectile");
        }

        public override void SetDefaults()
        {
            Projectile.width = 12;
            Projectile.height = 12;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.tileCollide = true;
            Projectile.penetrate = 4;
            
            
        }
        public override void AI()
        {
            Projectile.aiStyle = 27;
            int dust1 = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, 72, Projectile.velocity.X * 0.2f, Projectile.velocity.Y * 0.2f, 150, default(Color), 1f);
            Lighting.AddLight(Projectile.Center, 2f, 0.1f, 0.3f);
            
            
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Player owner = Main.player[Projectile.owner];
            int random1 = Main.rand.Next(25);
            if (random1 < 24)
            {
                target.AddBuff(BuffID.OnFire, 60 * 8);
            }

            else if (random1 == 24)
            {
                owner.AddBuff(BuffID.OnFire, 60 * 8);
            }

            float posX = Projectile.position.X;
            float posY = Projectile.position.Y;
      

            int random2 = Main.rand.Next(2);
            if (random2 == 0)
            {
                posX = posX + 200;
                posY = posY - 200;
                ModContent.ProjectileType<PostFate>();
            }

            if (random2 == 1)
            {
                posX = posX - 200;
                posY = posY - 200;
            }


            Projectile.NewProjectile(Projectile.GetSource_FromThis(),posX, posY, 15,15, ModContent.ProjectileType<PostFate>(), 8, 2, Main.myPlayer, ProjectileID.TerraBeam);
        }

        

    }
}
