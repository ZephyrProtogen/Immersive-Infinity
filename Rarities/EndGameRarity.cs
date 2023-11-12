using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace immersiveinfinity.Rarities
{
    public class EndGameRarity : ModRarity
    {
        public override Color RarityColor
        {
            get
            {
                var colors = new List<Color> {Color.Khaki, Color.DarkRed};
                int num = (int)(Main.GlobalTimeWrappedHourly / 2f % colors.Count);
                Color blue = colors[num];
                Color red = colors[(num + 1) % colors.Count];
                return Color.Lerp(blue, red,
                    Main.GlobalTimeWrappedHourly % 2f > 1f ? 1f : Main.GlobalTimeWrappedHourly % 1f);
            }
        }

    }
}