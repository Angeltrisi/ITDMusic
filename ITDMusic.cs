using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace ITDMusic
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class ITDMusic : Mod
	{
        public static ITDMusic Instance;
        public ITDMusic() => Instance = this;
        internal Mod musicDisplay = null;
        internal Mod ITD = null;
        public override void Load()
        {
            musicDisplay = null;
            ModLoader.TryGetMod("MusicDisplay", out musicDisplay);
            ModLoader.TryGetMod("ITD", out ITD);
        }
        public override void Unload()
        {
            Instance = null;
            musicDisplay = null;
            ITD = null;
        }
    }
}
