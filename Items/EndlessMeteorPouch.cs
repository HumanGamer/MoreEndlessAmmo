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
	public class EndlessMeteorPouch : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Endless Meteor Pouch");
		}

		public override void SetDefaults()
		{
			item.shootSpeed = 3f;
			item.shoot = 36;
			item.damage = 9;
			item.width = 26;
			item.height = 34;
			item.ammo = AmmoID.Bullet;
			item.knockBack = 1f;
			item.value = Item.sellPrice(0, 2, 0, 0);
			item.rare = 1;
			item.ranged = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteorShot, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
