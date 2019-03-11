using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;
using System.IO;
using Terraria.DataStructures;
using Terraria.GameInput;

namespace ClamExtraMusic
{
    class ClamExtraMusic : Mod
    {
        public ClamExtraMusic()
        {

        }

        public override void Load()
        {
            Main.tileCut[231] = false;
            if (!Main.dedServ)
            {
                //AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Optime"), ItemType("OptimeMusicBox"), TileType("OptimeMusicBox"));
                //AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/NiceGuy"), ItemType("NGMusicBox"), TileType("NGMusicBox"));
                //AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/CavityMusic"), ItemType("CavityMusicBox"), TileType("CavityMusicBox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/GelatineThrone"), ItemType("KingSlimeInv"), TileType("KingSlimePlaced"));
            }
        }

        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Main.musicVolume != 0)
            {
                if (Main.myPlayer != -1 && !Main.gameMenu && Main.LocalPlayer.active)
                {
                    if (NPC.AnyNPCs(NPCID.QueenBee))
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/StingingOnslaught");
                        priority = MusicPriority.BossHigh;
                    }
                    if (NPC.AnyNPCs(NPCID.DukeFishron))
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/HellOrHighWaters");
                        priority = MusicPriority.BossHigh;
                    }
                    if (NPC.AnyNPCs(NPCID.KingSlime))
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/GelatineThrone");
                        priority = MusicPriority.BossHigh;
                    }
                    if (NPC.AnyNPCs(NPCID.Retinazer) || NPC.AnyNPCs(NPCID.Spazmatism) || NPC.AnyNPCs(NPCID.TheDestroyer) || NPC.AnyNPCs(NPCID.SkeletronPrime))
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/PlayingWithFirepower");
                        priority = MusicPriority.BossHigh;
                    }
                }
            }
        }
    }
}