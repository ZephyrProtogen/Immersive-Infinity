using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;

namespace immersiveinfinity.Global
{
    internal class ModGlobalNPC : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {

            if (npc.type == NPCID.FireImp)
            {

                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.ImpSoul>(), 8, 8, 16));
                
            }

            

        }

    }

}
