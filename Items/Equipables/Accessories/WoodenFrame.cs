using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MiscThings.Items.Equipables.Accessories
{
	public class WoodenFrame : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Frame");
			Tooltip.SetDefault("Turns the user's Defense into Health.\n" + "This only takes into consideration the Defense added by Armor and Accessories.");
		}
		
		public override void SetDefaults()
		{

			Item.width = 34;
			Item.height = 34;
			Item.value = 500;
			Item.rare = 1;
			//Item.defense = 4;
			Item.accessory = true;
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ItemID.Wood, 20)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			//player.statDefense = (int)(player.statDefense * 1.25f);
			//^ Old method that didn't work.
			
			player.statLifeMax2 += player.statDefense * 5;
			//player.MiscThings().HasWoodenFrameEquipped = true;
			//HasWoodenFrameEquipped;
		}
	}
}
