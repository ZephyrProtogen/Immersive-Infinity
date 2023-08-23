using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using immersiveinfinity.Dusts;
using Terraria.Audio;


namespace immersiveinfinity.Projectiles
{
    public class TimewornScrollProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Timeworn Scroll Projectile");
        }
        public override void SetDefaults()
        {

            Projectile.width = 19;
            Projectile.height = 19;
            Projectile.aiStyle = 0;
            Projectile.DamageType = DamageClass.Magic;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 600;
            Projectile.light = 1f;                                              
            Projectile.ignoreWater = false;
            Projectile.tileCollide = true;
           

        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Main.player[Projectile.owner].statLife += 5;
        }
   




        public override void AI()
        {
            float rotateSpeed = 0.35f * (float)Projectile.direction;
            Projectile.rotation += rotateSpeed;


            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, ModContent.DustType<TimewornScrollDust>(), Projectile.velocity.X * 0.2f, Projectile.velocity.Y * 0.2f,
                    0, default(Color), 1f);
            }
        }

    }



}




