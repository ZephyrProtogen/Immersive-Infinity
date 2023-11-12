using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace immersiveinfinity.Rarities;

public class BlackRarity : ModRarity
{
    public override Color RarityColor
    {
        get
        {

            return Color.DarkGray;
        }
    }

    /// <inheritdoc />
    // no 'lower' tier to go to, so return the type of this rarity.
    public override int GetPrefixedRarity(int offset, float valueMult) => Type;
}
