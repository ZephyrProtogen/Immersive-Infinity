using immersiveinfinity.Content.Items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Drawing;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace immersiveinfinity.Projectiles
{
    internal class SatanBreathProjectilePost : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Satan's Breath Projectile Post");
            Main.projFrames[Projectile.type] = 3;
        }

        public override void SetDefaults()
        {   

            Projectile.width = 32;
            Projectile.height = 16;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.tileCollide = false;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 120;



        }

        public override void AI()
        {
          float posX = Projectile.position.X;
          float posY = Projectile.position.Y;

           float rot = Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2;
            Lighting.AddLight(Projectile.Center, 1, 0, 2);

            int wybor = Main.rand.Next(2);
            {
                if (wybor == 0)
                {
                    wybor = 20;
                }

                if (wybor == 1)
                {
                    wybor = 16;
                }
            }
            Dust.NewDust(Projectile.Center, 16, 16, wybor, 1, 1);

            int klatki = 8;
            Projectile.frameCounter++;
            if (Projectile.frameCounter >= klatki)
            {
                Projectile.frameCounter = 0;
                Projectile.frame++;
                if (Projectile.frame >= Main.projFrames[Projectile.type])
                {
                    Projectile.frame = 0;
                }
            }


        }

  
    }
}

