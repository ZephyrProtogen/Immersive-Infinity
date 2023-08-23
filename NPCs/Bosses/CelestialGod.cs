using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using immersiveinfinity.Projectiles;
using immersiveinfinity.Content.Items.Weapons.Staffs;
using Terraria.DataStructures;



using Terraria.ModLoader.Utilities;
using IL.Terraria.Audio;
using ReLogic.Utilities;
using static Terraria.ModLoader.PlayerDrawLayer;

namespace immersiveinfinity.NPCs.Bosses

{

    [AutoloadBossHead]
	public class CelestialGod : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestial God");
		}
		public override void SetDefaults()
		{
			
			NPC.lifeMax = 40000;
			NPC.damage = 10000;
			NPC.defense = 55;
			NPC.knockBackResist = 0f;
			NPC.width = 100;
			NPC.height = 100;
			NPC.value = Item.buyPrice(0, 20, 0, 0);
			NPC.npcSlots = 15f;
			NPC.boss = true;
			NPC.lavaImmune = true;
			NPC.noGravity = true;
			NPC.noTileCollide = true;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.buffImmune[24] = true;
			Music = MusicID.Boss3;
		}

		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			NPC.lifeMax = (int)(NPC.lifeMax * 0.625f * bossLifeScale);
			NPC.damage = (int)(NPC.damage * 0.6f);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.0001f;
		}



        public override void AI()
        { 


            NPC.TargetClosest(true);

            Vector2 Cel = Main.player[NPC.target].position;


            int vel = 4;

            if (Cel.X < NPC.position.X)
            {
                NPC.velocity.X = -vel;

            }
            else
            {
                NPC.velocity.X = vel;
            }

            if (Cel.Y < NPC.position.Y)
            {
                NPC.velocity.Y = -vel;

            }
            else
            {
                NPC.velocity.Y = vel;
            }
            if (Cel.X == NPC.position.X && Cel.Y == NPC.position.Y)
            {
                NPC.velocity.X = 0;
                NPC.velocity.Y = 0;

            }

            NPC.ai[0]++;

            if (NPC.ai[0] >= 50)
            {
                float V = 12f;
                Vector2 Wekt_poc = new Vector2(NPC.position.X, NPC.position.Y);
                int Obr = 30;
                float rot = (float)Math.Atan2(Wekt_poc.Y - (Main.player[NPC.target].position.Y + (Main.player[NPC.target].height * 0.5f)), Wekt_poc.X - (Main.player[NPC.target].position.X + (Main.player[NPC.target].width * 0.5f)));
                Projectile.NewProjectile(NPC.GetSource_FromAI(), Wekt_poc.X, Wekt_poc.Y, (float)((Math.Cos(rot) * V) * -1), (float)((Math.Sin(rot) * V) * -1), ProjectileID.EyeBeam, Obr, 0f, Main.myPlayer);
                NPC.ai[0] = 0;
            }

            if (NPC.ai[1] >= 25)
            {

            }

        }













        public override void OnKill()
        {

			Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ModContent.ItemType<Content.Items.Placeables.CelestialGodRelic>());
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ModContent.ItemType<Content.Items.Placeables.DoblinusBar>(), Main.rand.Next(5, 10));
        }

    }
}
