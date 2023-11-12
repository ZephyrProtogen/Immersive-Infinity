using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using immersiveinfinity.Projectiles;
using immersiveinfinity.Content.Items.Weapons.Staffs;
using Terraria.DataStructures;
using Terraria.Audio;
using Terraria.ModLoader.Utilities;
using IL.Terraria.Audio;
using ReLogic.Utilities;
using static Terraria.ModLoader.PlayerDrawLayer;
using Microsoft.Xna.Framework.Graphics;
using IL.Terraria.Chat.Commands;
using Terraria.Chat.Commands;
using IL.Terraria.UI.Chat;
using immersiveinfinity.Enemies;
using immersiveinfinity;
using System.Reflection;


using ReLogic.Content;



namespace immersiveinfinity.NPCs.Bosses

{

    [AutoloadBossHead]
    public class Test : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Test");
            
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
            float V = 40f;
            Vector2 NPCPos = new Vector2(NPC.position.X + 40, NPC.position.Y + 40);
            int Obr = 80;
            float rot = (float)Math.Atan2(NPCPos.Y - (Main.player[NPC.target].position.Y + (Main.player[NPC.target].height * 0.5f)), NPCPos.X - (Main.player[NPC.target].position.X + (Main.player[NPC.target].width * 0.5f)));


            NPC.TargetClosest(true);
            Vector2 Cel = Main.CurrentPlayer.Center;
            Player player = Main.player[NPC.target];

            float velX = 12f;
            float velY = 12f;
            Vector2 projV = new Vector2(velX, velY);
            Vector2 projV1 = new Vector2(velX, velY).RotatedBy(45);
            Vector2 projV2 = new Vector2(velX, velY).RotatedBy(90);
            Vector2 projV3 = new Vector2(velX, velY).RotatedBy(135);
            Vector2 projV4 = new Vector2(velX, velY).RotatedBy(180);
            Vector2 projV5 = new Vector2(velX, velY).RotatedBy(225);
            Vector2 projV6 = new Vector2(velX, velY).RotatedBy(270);


            float vel = 0.6f;
            float velMax = 12f;

            if (Cel.X - 50 < NPC.position.X && NPC.velocity.X < velMax && !player.dead)
            {
                NPC.velocity.X -= vel;

            }
            else
            {
                NPC.velocity.X += vel;
            }

            if (Cel.Y < NPC.position.Y && !player.dead)
            {
                NPC.velocity.Y -= vel;

            }

            if (Cel.Y > NPC.position.Y && NPC.velocity.Y < velMax && !player.dead)
            {
                NPC.velocity.Y += vel;

            }

            if (Cel.X > NPC.position.X + 500 || Cel.X < NPC.position.X - 500)
            {
                NPC.DirectionTo(Cel);
            }
        }
        public override void OnKill()
        {
            Terraria.Audio.SoundStyle lego = new Terraria.Audio.SoundStyle("immersiveinfinity/Sounds/caca");

            Terraria.Audio.SoundEngine.PlaySound(lego);
        }
    }
}

