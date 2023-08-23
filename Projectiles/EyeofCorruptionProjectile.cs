using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using immersiveinfinity.Dusts;
using Terraria.Audio;
using System;



namespace immersiveinfinity.Projectiles
{
    public class EyeofCorruptionProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eye of Corruption Projectile");
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
            {
                for (int i = 0; i < 200; i++)
                {
                    NPC target = Main.npc[i];
               
                    if (Main.npc[i].CanBeChasedBy(this, false))
                    {
                        
                        float shootToX = target.position.X + (float)target.width * 0.5f - Projectile.Center.X;
                        float shootToY = target.position.Y - Projectile.Center.Y;
                        float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

                        //If the distance between the live targeted npc and the projectile is less than 480 pixels
                        if (distance < 150f && !target.friendly && target.active)
                        {
                 
                            distance = 2f / distance;

                            shootToX *= distance * 3;
                            shootToY *= distance * 3;

                     
                            Projectile.velocity.X = shootToX;
                            Projectile.velocity.Y = shootToY;
                        }
                    }
                }
            }


            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, ModContent.DustType<EyeofCorruptionDust>(), Projectile.velocity.X * 0.1f, Projectile.velocity.Y * 0.1f,
                    0, default(Color), 1f);
            }
        }
    
        }
      


    }
          
    
 

