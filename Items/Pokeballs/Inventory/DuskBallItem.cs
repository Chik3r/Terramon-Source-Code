using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terramon.Items.Pokeballs.Thrown;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terramon.Items.Pokeballs.Inventory
{
    public class DuskBallItem : BaseThrowablePokeballItem<DuskBallProjectile>
    {
        public DuskBallItem() : base(Constants.Pokeballs.UnlocalizedNames.DUSK_BALL,
            new Dictionary<GameCulture, string>()
            {
                { GameCulture.English, "Dusk Ball" },
                { GameCulture.French, "Sombre Ball" }
            }, 
            new Dictionary<GameCulture, string>()
            {
                { GameCulture.English, "A somewhat different Poké Ball.\nIt makes it easier to catch wild Pokémon at night." },
                { GameCulture.French, "Un Poké Ball quelque peu différent.\nIl est plus facile d'attraper les Pokémon pendant la nuit." }
            }, 
            Item.sellPrice(gold: 2, silver: 20), ItemRarityID.White, Constants.Pokeballs.CatchRates.DUSK_BALL, new Color(130, 224, 99))
        {
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DuskBallCap"));
            recipe.AddIngredient(mod.ItemType("Button"));
            recipe.AddIngredient(mod.ItemType("PokeballBase"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void SetDefaults()
        {
            base.SetDefaults();

            item.value = 60000;
        }
    }
}
