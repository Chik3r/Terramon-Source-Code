using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Krabby
{
    public class Krabby : ParentPokemon
    {
        public override int EvolveCost => 23;

        public override Type EvolveTo => typeof(Kingler.Kingler);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Water };

        public virtual ExpGroup ExpGroup => ExpGroup.MediumFast;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}