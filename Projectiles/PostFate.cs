using IL.Terraria.DataStructures;
using Microsoft.Xna.Framework;
using On.Terraria.DataStructures;
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
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {



            if (Projectile.owner == Main.myPlayer)
            {

                Player owner = Main.player[Projectile.owner];
                float posX = Projectile.position.X;
                float posY = Projectile.position.Y;
                float targX = target.position.X;
                float targY = target.position.Y;

                int random1 = Main.rand.Next(25);
                if (random1 < 24)
                {
                    target.AddBuff(BuffID.OnFire, 60 * 8);
                }

                else if (random1 == 24)
                {
                    owner.AddBuff(BuffID.OnFire, 60 * 8);
                }

                bool random2 = Main.rand.NextBool(2);

                if (random2 == true)
                {
                    posX = posX + 500;
                    posY = posY - 500;

                    Projectile.NewProjectile(Projectile.GetSource_FromThis(), posX, posY, -16, 40, ModContent.ProjectileType<FateProjectile>(), 8, 2, Main.myPlayer, ProjectileID.TerraBeam);


                }

                if (random2 == false)
                {

                    posX = posX - 500;
                    posY = posY - 500;
                    Projectile.NewProjectile(Projectile.GetSource_FromThis(), posX, posY, 16, 40, ModContent.ProjectileType<FateProjectile>(), 8, 2, Main.myPlayer, ProjectileID.TerraBeam);
                }
            }
        }
    }
}
