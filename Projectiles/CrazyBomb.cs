using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using ReLogic.Content;
using Terraria.GameContent.Shaders;


namespace immersiveinfinity.Projectiles
{
    public class CrazyBomb : ModProjectile
    {
        private int rippleCount = 3;
        private int rippleSize = 5;
        private int rippleSpeed = 15;
        private float distortStrength = 100f;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crazy Bomb");

        }

        public override void SetDefaults()
        {
            Projectile.width = 50;
            Projectile.height = 50;
            Projectile.friendly = true;
            Projectile.timeLeft = 10;
            Projectile.tileCollide = false;
            Projectile.penetrate = 4;

        }

        public override void Load()
        {
            if (!Main.dedServ)
            {

                Ref<Effect> screenRef = new Ref<Effect>((Effect)Mod.Assets.Request<Effect>("Effects/ShockwaveEffect")); // Be sure to update the effect path and pass name here.
                Filters.Scene["Shockwave"] = new Filter(new ScreenShaderData(screenRef, "Shockwave"), EffectPriority.VeryHigh);
                Filters.Scene["Shockwave"].Load();
            }
        }
        public override void AI()
        {
            // ai[0] = state
            // 0 = unexploded
            // 1 = exploded
   
            if (Projectile.timeLeft <= 10)
            {
                if (Projectile.ai[0] == 0)
                {
                    Projectile.ai[0] = 1; // Set state to exploded
                    Projectile.alpha = 255; // Make the projectile invisible.
                    Projectile.friendly = false; // Stop the bomb from hurting enemies.

                    if (Main.netMode != NetmodeID.Server && !Filters.Scene["Shockwave"].IsActive())
                    {
                        Filters.Scene.Activate("Shockwave", Projectile.Center).GetShader().UseColor(rippleCount, rippleSize, rippleSpeed).UseTargetPosition(Projectile.Center);
                    }
                }

                if (Main.netMode != NetmodeID.Server && Filters.Scene["Shockwave"].IsActive())
                {
                    float progress = (180f - Projectile.timeLeft) / 60f;
                    Filters.Scene["Shockwave"].GetShader().UseProgress(progress).UseOpacity(distortStrength * (1 - progress / 3f));
                }
            }
        }

        public override void Kill(int timeLeft)
        {
            if (Main.netMode != NetmodeID.Server && Filters.Scene["Shockwave"].IsActive())
            {
                Filters.Scene["Shockwave"].Deactivate();
            }
        }

    }


}