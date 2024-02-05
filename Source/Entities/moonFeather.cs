using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using Monocle;
using MonoMod.Utils;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;

namespace Celeste.Mod.boxohelpeR.Entities {
    [Tracked]
    [CustomEntity("boxohelpeR/moonFeather")]
    public class MoonFeather : FlyFeather {

        public static void Load() {
            
        }


        public MoonFeather(EntityData data, Vector2 offset) : base(data, offset){
            Collider = new Hitbox(20,20,0,0);
            // TODO: read properties from data
            Add(GFX.SpriteBank.Create("moonFeather"));
        }  

        public override void Render()
        {
            base.Render();
        }
        private static void FlyBinary(ILContext il) {
            ILCursor cursor = new ILCursor(il);

            if (cursor.TryGotoNext(instr => instr.MatchLdcR4())) {
                
            }

        }




    }
}
