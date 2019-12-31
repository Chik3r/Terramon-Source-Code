using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Terramon.Pokemon.FirstGeneration.Normal.Gastly
{
    public class GastlyNPC : ParentPokemonNPC_Gastly
    {
        public override Type HomeClass() => typeof(Gastly);

        public override void SetDefaults()
        {
            base.SetDefaults();
            npc.width = 20;
            npc.height = 20;
            npc.alpha = 75;
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color drawColor)
        {
            npc.gfxOffY = -4;
            return true;
        }
    }
}