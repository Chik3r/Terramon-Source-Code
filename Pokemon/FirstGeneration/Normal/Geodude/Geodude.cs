using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Geodude
{
    public class Geodude : ParentPokemon
    {
        public override int EvolveCost => 20;

        public override Type EvolveTo => typeof(Graveler.Graveler);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Rock, PokemonType.Ground };

        public virtual ExpGroup ExpGroup => ExpGroup.MediumSlow;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}