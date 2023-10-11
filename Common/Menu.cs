using System.Reflection;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.ID;
using Terraria.ModLoader;
using immersiveinfinity;
using System;
using Microsoft.Xna.Framework;

using ReLogic.Utilities;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;


namespace immersiveinfinity.Common;

public class immersiveinfinity : ModMenu
{
    public override Asset<Texture2D> Logo
    {
        get
        {
            return Mod.Assets.Request<Texture2D>("UITextures/Menu");
        }
    }


 //public override ModSurfaceBackgroundStyle MenuBackgroundStyle => (ModSurfaceBackgroundStyle)ModContent.Request<ModSurfaceBackgroundStyle>("immersiveinfinity/UITextures/MenuB");   

    static int Music2 = MusicLoader.GetMusicSlot("immersiveinfinity/Sounds/Music/Menu");

    int[] MusicChoices = 
    {
        MusicID.MenuMusic,
       MusicID.ConsoleMenu,
        MusicID.Title
    };

    public override int Music => Music2;
    public override void Load()
    {
        base.Load();

        const string lastSelectedModMenuFieldName = "LastSelectedModMenu";
        FieldInfo lastSelectedModMenuFieldInfo =
            typeof(MenuLoader).GetField(lastSelectedModMenuFieldName, BindingFlags.NonPublic | BindingFlags.Static);

        if (lastSelectedModMenuFieldInfo != null)
        {
           
            lastSelectedModMenuFieldInfo.SetValue(null, FullName);
        }
    }
}
