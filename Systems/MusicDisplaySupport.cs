using System;
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
            // thank you gabe for making this real :garf:
            void AddMusicWithCondition(string songKey, string authorKey, Func<bool> condition)
            {
                short slot = (short)MusicLoader.GetMusicSlot(Mod, "Music/" + songKey);
                musicDisplay.Call("AddMusic", slot, Mod.GetLocalization("SongNames." + songKey), Mod.GetLocalization("AuthorNames." + authorKey), Mod.DisplayName, condition);
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
            //i'll make itdmusic eventually dependant on ITD, so we don't have to use this horrid modcall
            //AddMusicWithCondition("Mudkarp", "Microengine", () => ITDMusic.Instance.ITD != null && !(bool)ITDMusic.Instance.ITD.Call("TalkingTo", Main.LocalPlayer, "Mudkarp"));
            AddMusic("Mudkarp", "Microengine");
            AddMusic("LavaRain", "Microengine");
            AddMusic("BlueshroomNight", "Microengine");
        }
    }
}
