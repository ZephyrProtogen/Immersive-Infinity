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
    public class Fake : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fake Slime God");
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[2];
        }

        public override void SetDefaults()
        {
            NPC.width = 64;
            NPC.height = 30;
            NPC.damage = 110;
            NPC.defense = 32;
            NPC.lifeMax = 15000;
            NPC.value = 50f;
            NPC.aiStyle = 1;
            NPC.HitSound = SoundID.NPCHit57;
            NPC.DeathSound = SoundID.NPCDeath59;
            AIType = NPCID.WanderingEye;
            AnimationType = NPCID.WanderingEye;
           



        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.01f;
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

    }
}