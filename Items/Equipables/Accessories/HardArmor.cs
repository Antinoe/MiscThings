using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MiscThings.Items.Equipables.Accessories
{
	public class HardArmor : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 34;
			Item.height = 34;
			Item.value = 9000;
			Item.rare = 1;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hard Armor");
			Tooltip.SetDefault("Doubles Defense at the cost of applying Defense Weight.\n" + "This defect becomes less severe the higher your Max Mana.\n" + "Turns the user's Defense into Health.");
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(null, "HardBulwark", 1)
				.AddIngredient(null, "WoodenFrame", 1)
				//.AddIngredient(ItemID.Shackle, 1)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
		}

		public override void UpdateAccessory(Player Player, bool hideVisual)
		{
			Player.statLifeMax2 += Player.statDefense * 5;
			Player.statDefense = (int)(Player.statDefense * 2f); //x3 Defense.
			if(Player.statManaMax <= 20) //If Max Mana is less than or equal to 20, then subtracted moveSpeed is equal to current Defense multiplied by 0.05.
			{
				Player.moveSpeed -= Player.statDefense * 0.05f;
			}
			else if(Player.statManaMax <= 40)
			{
				Player.moveSpeed -= Player.statDefense * 0.04f;
			}
			else if(Player.statManaMax <= 60)
			{
				Player.moveSpeed -= Player.statDefense * 0.03f;
			}
			else if(Player.statManaMax <= 80)
			{
				Player.moveSpeed -= Player.statDefense * 0.02f;
			}
			else if(Player.statManaMax <= 100)
			{
				Player.moveSpeed -= Player.statDefense * 0.01f;
			}
			else if(Player.statManaMax <= 120)
			{
				Player.moveSpeed -= Player.statDefense * 0.005f;
			}
			else if(Player.statManaMax <= 140)
			{
				Player.moveSpeed -= Player.statDefense * 0.004f;
			}
			else if(Player.statManaMax <= 160)
			{
				Player.moveSpeed -= Player.statDefense * 0.003f;
			}
			else if(Player.statManaMax <= 180)
			{
				Player.moveSpeed -= Player.statDefense * 0.002f;
			}
			else if(Player.statManaMax <= 200)
			{
				Player.moveSpeed -= Player.statDefense * 0.001f;
			}
			if(Player.moveSpeed < 0)
			{
				Player.moveSpeed = 0.05f;
			}
		}
	}
}
