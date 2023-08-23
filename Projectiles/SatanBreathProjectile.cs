using immersiveinfinity.Content.Items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace immersiveinfinity.Projectiles
{
    internal class SatanBreathProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Satan's Breath Projectile");
           Main.projFrames[Projectile.type] = 3;

        }

        public override void SetDefaults()
        {
            Projectile.width = 32;
            Projectile.height = 16;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.tileCollide = true;
            Projectile.penetrate = 4;
            Projectile.timeLeft = 65;
            
            

        }

       

        public override void AI()
        {
            float velX = Projectile.velocity.X;
            float velY = Projectile.velocity.Y;
            int type = ModContent.ProjectileType<SatanBreathProjectilePost>(); 
            int damage = 50; 
            float knockBack = 2f;
            float rotation = MathHelper.ToRadians(45);
            Vector2 projVelocity = new Vector2(velX, velY);
            Vector2 projVelocityUp = new Vector2(velX, velY).RotatedBy(rotation);
            Vector2 projVelocityDown = new Vector2(velX, velY).RotatedBy(-rotation);

            





            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2;
            float dir = Projectile.direction;

            Lighting.AddLight(Projectile.Center,1,0,0);

            int wybor = Main.rand.Next(2);
            {
                if (wybor == 0)
                {
                    wybor = 6;
                }

                if (wybor == 1)
                {
                    wybor = 35;
                }
            }
            Dust.NewDust(Projectile.Center, 16, 16, wybor, 1, 1);


            Projectile.ai[0]++;
                 
            if (Projectile.ai[0] > 60)
            {
                
                Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center, projVelocity, type,damage,knockBack, Main.myPlayer);
                Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center, projVelocityUp, type, damage, knockBack, Main.myPlayer);
                Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center, projVelocityDown, type, damage, knockBack, Main.myPlayer);

                Projectile.ai[0] = 0;
                
            }

            int klatki = 8;
            Projectile.frameCounter++;
            if(Projectile.frameCounter >= klatki)
            {
                Projectile.frameCounter = 0;
                Projectile.frame++;
                if(Projectile.frame >= Main.projFrames[Projectile.type])
                {
                    Projectile.frame = 0;
                }
            }




        }

        


    }
}

