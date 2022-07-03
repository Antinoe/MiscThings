using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MiscThings.Items.Equipables.Accessories
{
	public class HealthMultiplier : ModItem
	{

		public override void SetDefaults()
		{

			Item.width = 34;
			Item.height = 34;
			Item.value = 40000;
			Item.rare = 1;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blood Amulet");
			Tooltip.SetDefault("Triples Max HP.");
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ItemID.LunarBar, 10)
				.AddIngredient(ItemID.LifeFruit, 20)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statLifeMax2 *= 3;
		}
		
	}
}
