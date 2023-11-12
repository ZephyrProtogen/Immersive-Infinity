using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using immersiveinfinity;
using Terraria.ModLoader;
using Terraria;

namespace immersiveinfinity.Content.Items.Accessories.Dyes
{
    public class Dye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dye");
        }
        public override void Load()
        {

            // All of this loading needs to be client-side.

            if (Main.netMode != NetmodeID.Server)
            {
                // First, you load in your shader file.
                // You'll have to do this regardless of what kind of shader it is,
                // and you'll have to do it for every shader file.
                // This example assumes you have both armour and screen shaders.

                Ref<Effect> dyeRef = new Ref<Effect>((Effect)Mod.Assets.Request<Effect>("immersiveinfinity/Effects/Dye"));
                Ref<Effect> specialRef = new Ref<Effect>((Effect)Mod.Assets.Request<Effect>("immersiveinfinity/Effects/Dye"));
                Ref<Effect> filterRef = new Ref<Effect>((Effect)Mod.Assets.Request<Effect>("immersiveinfinity/Effects/Dye"));
                // To add a dye, simply add this for every dye you want to add.
                // "PassName" should correspond to the name of your pass within the *technique*,
                // so if you get an error here, make sure you've spelled it right across your effect file.

                GameShaders.Armor.BindShader(ItemType<Dyes.Dye>(), new ArmorShaderData(dyeRef, "i forgor"));

                // If your dye takes specific parameters such as colour, you can append them after binding the shader.
                // IntelliSense should be able to help you out here.  

                GameShaders.Armor.BindShader(ItemType<Dyes.Dye>(), new ArmorShaderData(dyeRef, "ColourPass")).UseColor(1.5f, 0.15f, 0f);


                // To bind a miscellaneous, non-filter effect, use this.
                // If you're actually using this, you probably already know what you're doing anyway.

               
                // To bind a screen shader, use this.
                // EffectPriority should be set to whatever you think is reasonable.  

            
            }
        }
    }

}
    

