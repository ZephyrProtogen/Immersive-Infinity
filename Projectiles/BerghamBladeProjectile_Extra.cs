using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using immersiveinfinity.Dusts;
using Terraria.Audio;
using System;
using SteelSeries.GameSense;
using Steamworks;

namespace immersiveinfinity.Projectiles
{
    public class BerghamBladeProjectile_Extra : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("BerghamBladeProjectile_Extra");
        }
        public override void SetDefaults()
        {
            Projectile.width = 8;
            Projectile.height = 8;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.tileCollide = false;
            Projectile.penetrate = 1;

        }



        public override void AI()
        {
            Player owner = Main.player[Projectile.owner];
            Projectile.light = 0.9f;
            int DustID = Dust.NewDust(new Vector2(Projectile.position.X, Projectile.position.Y + 2f), Projectile.width + 4, Projectile.height + 4, 36, Projectile.velocity.X * 0.2f, Projectile.velocity.Y * 0.2f, 120, default(Color), 0.75f);
            Main.dust[DustID].noGravity = true;

            {
                Projectile.ai[0]++;
                if (Projectile.ai[0] > 60 * 1)
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
                                    if (distance < 500f && !target.friendly && target.active)
                                    {

                                        distance = 2f / distance;

                                        shootToX *= distance * 3;
                                        shootToY *= distance * 3;


                                        Projectile.velocity.X = shootToX;
                                        Projectile.velocity.Y = shootToY;
                                        Projectile.light = 0.9f; //Lights up the whole room
                                        Projectile.alpha = 50; //Semi Transparent

                                        Main.dust[DustID].noGravity = true; //Makes dust not fall


                                    }
                                }
                            }
                        }



                    }

                }
            }
        }
    








