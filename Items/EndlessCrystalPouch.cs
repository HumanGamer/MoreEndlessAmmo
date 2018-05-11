using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreEndlessAmmo.Items
{
	public class EndlessCrystalPouch : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Endless Crystal Pouch");
		}

		public override void SetDefaults()
		{
			item.shootSpeed = 5f;
			item.shoot = 89;
			item.damage = 9;
			item.width = 8;
			item.height = 8;
			item.ammo = AmmoID.Bullet;
			item.knockBack = 1f;
			item.value = Item.sellPrice(0, 2, 0, 0);
			item.ranged = true;
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalBullet, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
