using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Voltorb
{
    public class Voltorb : ParentPokemon
    {
        public override int EvolveCost => 25;

        public override Type EvolveTo => typeof(Electrode.Electrode);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Electric };

        public virtual ExpGroup ExpGroup => ExpGroup.MediumFast;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}