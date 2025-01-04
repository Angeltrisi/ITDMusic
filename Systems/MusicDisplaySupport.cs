using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace ITDMusic.Systems
{
    public class MusicDisplaySupport : ModSystem
    {
        public override void PostSetupContent()
        {
            Mod musicDisplay = ITDMusic.Instance.musicDisplay;
            if (musicDisplay is null) return;

            void AddMusic(string songKey, string authorKey)
            {
                short slot = (short)MusicLoader.GetMusicSlot(Mod, "Music/" + songKey);
                musicDisplay.Call("AddMusic", slot, Mod.GetLocalization("SongNames." + songKey), Mod.GetLocalization("AuthorNames." + authorKey), Mod.DisplayName);
            }

            AddMusic("BlueshroomGroves", "qAngel");
            AddMusic("WanderingTheBlueshrooms", "Bluestarr");
            AddMusic("DuneBearer", "Microengine");
            AddMusic("DeepDesert", "Microengine");
            AddMusic("CosmicJellyfish", "Microengine");
            AddMusic("Gravekeeper", "Microengine");
            AddMusic("WOMR", "Bluestarr");
            AddMusic("Maw", "Microengine");
            AddMusic("AlphaMenu", "Microengine"); // "errmmmm, but q, nobody's gonna see this 🤓" but what if we decide to pull a calamity and add music boxes?!?!?
        }
    }
}
