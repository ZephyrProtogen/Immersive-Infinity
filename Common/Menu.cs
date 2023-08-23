using System;
using System.Reflection;
using IL.Terraria.GameContent;
using immersiveinfinity;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;


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

    //int WhatMusic = MusicID.MenuMusic;

    //int[] MusicChoices =
    //{
    //    MusicID.MenuMusic,
    //    MusicID.ConsoleMenu,
    //    MusicID.Title
    //};
    //public override void OnSelected()
    //{
    //    WhatMusic = MusicChoices[Main.rand.Next(3)];
    //    if (DateTime.Now.Month == 4 && DateTime.Now.Day == 1)
    //    {
    //        WhatMusic = MusicID.Hell;
    //    }
    //}
    //public override int Music => WhatMusic;
    public override void Load()
    {
        base.Load();

        const string lastSelectedModMenuFieldName = "LastSelectedModMenu";
        FieldInfo? lastSelectedModMenuFieldInfo =
            typeof(MenuLoader).GetField(lastSelectedModMenuFieldName, BindingFlags.NonPublic | BindingFlags.Static);

        if (lastSelectedModMenuFieldInfo != null)
        {
           
            lastSelectedModMenuFieldInfo.SetValue(null, FullName);
        }
    }
}
