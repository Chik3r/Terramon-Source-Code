using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Ekans
{
    public class Ekans : ParentPokemon
    {
        public override int EvolveCost => 17;

        public override Type EvolveTo => typeof(Arbok.Arbok);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Poison };

        public virtual ExpGroup ExpGroup => ExpGroup.MediumFast;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}