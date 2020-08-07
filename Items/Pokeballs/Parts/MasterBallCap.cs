using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Terramon.Items.Pokeballs.Parts
{
    public class MasterBallCap : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Master Ball Cap");
            Tooltip.SetDefault("Forged from Luminite, as well as Red, Blue and Pink Apricorns."
                               + "\nCombine it with a button and a base to create the fabled [c/f553da:Master Ball.]");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.maxStack = 999;
            item.value = 50000;
            item.rare = 0;
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 7);
            recipe.AddIngredient(mod.ItemType("RedApricorn"), 4);
            recipe.AddIngredient(mod.ItemType("BlueApricorn"), 4);
            recipe.AddIngredient(mod.ItemType("BlueApricorn"), 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine nameLine = tooltips.FirstOrDefault(t => t.Name == "ItemName" && t.mod == "Terraria");

            foreach (TooltipLine line2 in tooltips)
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                    line2.overrideColor = new Color(192, 192, 192);
        }
    }
}
 
 