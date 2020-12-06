using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Magikarp
{
    public class Magikarp : ParentPokemon
    {
        public override int EvolveCost => 15;

        public override Type EvolveTo => typeof(Gyarados.Gyarados);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Water };

        public virtual ExpGroup ExpGroup => ExpGroup.Slow;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}