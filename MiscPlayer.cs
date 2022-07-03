using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace MiscThings
{
    public class MiscPlayer : ModPlayer
    {	
		public bool HasWoodenFrameEquipped;
		
		public static MiscPlayer ModPlayer(Player Player)
		{
			return Player.GetModPlayer<MiscPlayer>();
		}
		
		//Neko the Cat'nt#7385 mentioned that I should use a bool within PostUpdate to detect the Wooden Frame, and apply its attributes accordingly. I will take note of this, in case I need to perform such in the future.
		public override void PostUpdate()
		{
			if(HasWoodenFrameEquipped)
			{
			Player.statLifeMax2 += Player.statDefense * 5;
			}
		}
    }
}
