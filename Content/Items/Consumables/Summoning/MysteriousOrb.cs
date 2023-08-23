using immersiveinfinity.Content.Items.Consumables.Summoning;
using immersiveinfinity.NPCs.Bosses;
using immersiveinfinity.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;


namespace immersiveinfinity.Content.Items.Consumables.Summoning
{
    internal class MysteriousOrb : ModItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mysterious Orb");
            Tooltip.SetDefault("Summons The Celestial God");
        }

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 40;
            Item.maxStack = 1;
            Item.rare = ItemRarityID.Pink;
            Item.useAnimation = 45;
            Item.useTime = 45;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.UseSound = SoundID.Item44;
            Item.consumable = true;



        }

        public override bool CanUseItem(Player player) => !Main.dayTime && NPC.CountNPCS(ModContent.NPCType<CelestialGod>()) < 1 && NPC.downedMoonlord;

        public override bool? UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<NPCs.Bosses.CelestialGod>());
            return true; 
        }
     
        
        

            


        }

    }
