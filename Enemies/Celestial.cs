using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.Utilities;
using System;


using Terraria.GameContent.Events;

using Terraria.Localization;

using immersiveinfinity;

namespace immersiveinfinity.Enemies
{
    public class Celestial : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Celestial");
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[2];
        }

        public override void SetDefaults()
        {
            NPC.width = 32;
            NPC.height = 32;
            NPC.damage = 8;
            NPC.defense = 2;
            NPC.lifeMax = 50;
            NPC.value = 50f;
            NPC.aiStyle = 2;
            NPC.HitSound = SoundID.NPCHit54;
            NPC.DeathSound = SoundID.NPCDeath3;
            




        }
   

        public override void FindFrame(int frameHeight)
        {
            NPC.frameCounter++;
            if (NPC.frameCounter >= 20)
            {
                NPC.frameCounter = 0;
            }
            NPC.frame.Y = (int)NPC.frameCounter / 10 * frameHeight;
        }

        public override void OnKill()
        {

            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.Bone, Main.rand.Next(5, 10));
        }

        public override void AI()
        {
            float V = 40f;
            Vector2 NPCPos = new Vector2(NPC.position.X + 40, NPC.position.Y + 40);
            int Obr = 80;
            float rot = (float)Math.Atan2(NPCPos.Y - (Main.player[NPC.target].position.Y + (Main.player[NPC.target].height * 0.5f)), NPCPos.X - (Main.player[NPC.target].position.X + (Main.player[NPC.target].width * 0.5f)));
            NPC.ai[0]++;
            if (NPC.ai[0] >= Main.rand.Next(30, 60))
            {
                Projectile.NewProjectile(NPC.GetSource_FromAI(), NPCPos.X, NPCPos.Y, (float)((Math.Cos(rot) * V) * -1), (float)((Math.Sin(rot) * V) * -1), ProjectileID.FrostBeam, Obr, 0f, Main.myPlayer);
                NPC.ai[0] = 0;
            }

            
        }
    }
}