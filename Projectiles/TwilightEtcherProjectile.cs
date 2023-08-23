using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using immersiveinfinity.Dusts;
using Terraria.Audio;


namespace immersiveinfinity.Projectiles
{
    public class TwilightEtcherProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Twilight Etcher Projectile");
        }
        public override void SetDefaults()
        {

            Projectile.width = 30;
            Projectile.height = 40;
            Projectile.aiStyle = 0;
            Projectile.DamageType = DamageClass.Magic;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 3;
            Projectile.timeLeft = 600;
            Projectile.light = 1f;
            Projectile.ignoreWater = false;
            Projectile.tileCollide = false;


        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Main.player[Projectile.owner].statLife += 5;
        }





        public override void AI()
        {
            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2;


            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, ModContent.DustType<TimewornScrollDust>(), Projectile.velocity.X * 0.2f, Projectile.velocity.Y * 0.2f,
                    0, default(Color), 1f);
            }
        }
    }
}
