using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.ID;

namespace Terramon.Tiles.ShelfBlocks
{
    //Pokeball Tile

	public class MasterBallShelf : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileShine[Type] = 1100;
			Main.tileSolid[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
            minPick = 0;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.addTile(Type);

			AddMapEntry(new Color(177, 61, 227), Language.GetText("Master Ball"));
		}

		public override bool Drop(int i, int j)
		{
			Tile t = Main.tile[i, j];
			int style = t.frameX / 18;
			if (style == 0) // It can be useful to share a single tile with multiple styles. This code will let you drop the appropriate bar if you had multiple.
			{
				Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("MasterBall"));
			}
			return base.Drop(i, j);
		}
	}
    
    //Pokeball Item

        public class MasterBallShelf_Held : ModItem
        {
        public override string Texture => mod.Name + "/Tiles/ShelfBlocks/MasterBallShelf";
        public override void SetStaticDefaults()
            {
                DisplayName.SetDefault("Master Ball Prop");
            }

            public override void SetDefaults()
            {
                item.width = 12;
                item.height = 12;
                item.maxStack = 99;
                item.value = 1000;
                item.useTurn = true;
                item.autoReuse = true;
                item.useAnimation = 15;
                item.useTime = 10;
                item.useStyle = 1;
                item.consumable = true;
                item.createTile = mod.TileType("MasterBallShelf");
            }
        }
}