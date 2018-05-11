using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace MoreEndlessAmmo
{
    public class MoreEndlessAmmo : Mod
    {
	    internal static MoreEndlessAmmo Instance;

		public MoreEndlessAmmo()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadBackgrounds = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

	    public override void Load()
	    {
		    Instance = this;
	    }
    }
}
