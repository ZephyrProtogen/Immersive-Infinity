using Terraria;
using Terraria.ModLoader;
using immersiveinfinity;
using immersiveinfinity.Buffs;

namespace immersiveinfinity.Buffs;

public class BijeZoneEfekt : ModBuff
{
    public override void Update(Player player, ref int buffIndex)
    {
        player.statDefense += 60;
        player.statLifeMax += 100;
        player.GetDamage(DamageClass.Melee) += 10f;
    }

}