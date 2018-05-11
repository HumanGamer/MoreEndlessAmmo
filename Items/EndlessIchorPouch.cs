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
	public class EndlessIchorPouch : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Endless Ichor Pouch");
		}

		public override void SetDefaults()
		{
			item.shootSpeed = 5.25f;
			item.shoot = 279;
			item.damage = 13;
			item.width = 26;
			item.height = 34;
			item.ammo = AmmoID.Bullet;
			item.knockBack = 4f;
			item.value = Item.sellPrice(0, 2, 0, 0);
			item.ranged = true;
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IchorBullet, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
