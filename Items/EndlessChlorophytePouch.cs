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
	public class EndlessChlorophytePouch : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Endless Chlorophyte Pouch");
		}

		public override void SetDefaults()
		{
			item.shootSpeed = 5f;
			item.shoot = 207;
			item.damage = 10;
			item.width = 8;
			item.height = 8;
			item.ammo = AmmoID.Bullet;
			item.knockBack = 4.5f;
			item.value = 50;
			item.ranged = true;
			item.rare = 7;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBullet, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
