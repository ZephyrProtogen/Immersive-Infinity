using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace immersiveinfinity.Rarities;

public class BasicRarity : ModRarity
{
    public override Color RarityColor
    {
        get
        {
            var colors = new List<Color> { new(50, 25, 25), new(250, 5, 60) };
            int num = (int)(Main.GlobalTimeWrappedHourly / 2f % colors.Count);
            Color blue = colors[num];
            Color red = colors[(num + 1) % colors.Count];
            return Color.Lerp(blue, red,
                Main.GlobalTimeWrappedHourly % 2f > 1f ? 1f : Main.GlobalTimeWrappedHourly % 1f);
        }
    }

    
    public override int GetPrefixedRarity(int offset, float valueMult) => Type;
}
