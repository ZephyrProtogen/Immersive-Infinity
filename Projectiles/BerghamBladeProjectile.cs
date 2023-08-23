    
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using immersiveinfinity.Dusts;
using Terraria.Audio;
using System;
using immersiveinfinity.Content.Items.Weapons.Staffs;
using SteelSeries.GameSense;
using System.Threading;

namespace immersiveinfinity.Projectiles
{
    public class BerghamBladeProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("BerghamBladeProjectile");
        }
        public override void SetDefaults()
        {

            Projectile.width = 9;
            Projectile.height = 9;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.tileCollide = false;
            Projectile.penetrate = 4;



        }
        public override void AI()
        {
            Player owner = Main.player[Projectile.owner]; //Makes a player variable of owner set as the player using the projectile
            Projectile.light = 0.9f; //Lights up the whole room
            Projectile.alpha = 50; //Semi Transparent
            Projectile.rotation += (float)Projectile.direction * 0.2f; //Spins in a good speed
            int DustID = Dust.NewDust(new Vector2(Projectile.position.X, Projectile.position.Y + 2f), Projectile.width + 4, Projectile.height + 4, 36, Projectile.velocity.X * 0.2f, Projectile.velocity.Y * 0.2f, 120, default(Color), 0.75f); //Spawns dust
            Main.dust[DustID].noGravity = true; //Makes dust not fall
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            float positionY = (float)Projectile.position.X;
            float positionX = (float)Projectile.position.Y;
            int velocityX = 0;
            int velocityY = -2;
            float direction = (float)Projectile.direction;



            Projectile.NewProjectile(Projectile.GetSource_FromThis(), positionY + 30, positionX - 50, velocityX + 2f, velocityY, ModContent.ProjectileType<BerghamBladeProjectile_Extra>(), 2, 2, Main.myPlayer);
            Projectile.NewProjectile(Projectile.GetSource_FromThis(), positionY, positionX - 50, velocityX, velocityY, ModContent.ProjectileType<BerghamBladeProjectile_Extra>(), 2, 2, Main.myPlayer);


            int random = Main.rand.Next(10);

            if (random < 9)
            {
                Projectile.NewProjectile(Projectile.GetSource_FromThis(), positionY - 30, positionX - 50, velocityX - 2f, velocityY, ModContent.ProjectileType<BerghamBladeProjectile_Extra>(), 2, 2, Main.myPlayer);
            }
            else if (random == 9)
            {
                Projectile.NewProjectile(Projectile.GetSource_FromThis(), positionY, positionX - 50, velocityX - 2f, velocityY, ModContent.ProjectileType<BerghamBladeProjectile_Extra>(), 2, 2, Main.myPlayer);
                Projectile.NewProjectile(Projectile.GetSource_FromThis(), positionY, positionX - 50, velocityX + 1f, velocityY, ModContent.ProjectileType<BerghamBladeProjectile_Extra>(), 2, 2, Main.myPlayer);
                Projectile.NewProjectile(Projectile.GetSource_FromThis(), positionY, positionX - 50, velocityX - 1f, velocityY, ModContent.ProjectileType<BerghamBladeProjectile_Extra>(), 2, 2, Main.myPlayer);
            }
        }
    }
}
      

        
    




