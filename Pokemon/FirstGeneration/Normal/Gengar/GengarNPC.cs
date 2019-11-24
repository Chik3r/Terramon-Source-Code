using System;

namespace Terramon.Pokemon.FirstGeneration.Normal.Gengar
{
    public class GengarNPC : ParentPokemonNPCNight
    {
        public override Type HomeClass() => typeof(Gengar);

        public override void SetDefaults()
        {
            base.SetDefaults();
            npc.width = 20;
            npc.height = 20;
        }

        public override void NPCLoot()
        {
            
        }
    }
}