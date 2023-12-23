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
     
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/Menu");

    public override Asset<Texture2D> Logo
    {
        get
        {
            if (DateTime.Now.Month == 12 && DateTime.Now.Day >= 1)
            {
                return Mod.Assets.Request<Texture2D>("UITextures/MenuChristmas");
            }
            else
            {
                return Mod.Assets.Request<Texture2D>("UITextures/Menu");
            }
                                                                                                                                                                                                                                        
        }
    }
    
    public override bool PreDrawLogo(SpriteBatch spriteBatch, ref Vector2 logoDrawCenter, ref float logoRotation, ref float logoScale, ref Color drawColor)
    {
        spriteBatch.Draw(Mod.Assets.Request<Texture2D>("Backgrounds/Menu", AssetRequestMode.ImmediateLoad).Value, new Vector2(0, 0), Color.White);
        //spriteBatch.Draw(Mod.Assets.Request<Texture2D>("UITextures/Menu", AssetRequestMode.ImmediateLoad).Value, new Vector2(500, 0), Color.White);
        return true;
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
