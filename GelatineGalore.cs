using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace GelatineGalore
{
	class GelatineGalore : Mod
	{
		public GelatineGalore()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

        public override void Load()
        {
            //The King Slime stuff
            Main.itemTexture[ItemID.SlimeCrown] = GetTexture("Replacements/Gels/Gel_Crown");
            Main.itemTexture[ItemID.KingSlimeMask] = GetTexture("Replacements/Gels/Slime_Mask");
            Item bossMaskKS = new Item();
            bossMaskKS.SetDefaults(ItemID.KingSlimeMask);
            Main.armorHeadLoaded[bossMaskKS.headSlot] = true;
            Main.armorHeadTexture[bossMaskKS.headSlot] = GetTexture("Replacements/Gels/Slime_Mask_Head");

            //The King Slime
            Main.npcTexture[NPCID.KingSlime] = GetTexture("Replacements/Slimes/Slime_King");
            Main.npcHeadBossTexture[7] = GetTexture("Replacements/Slimes/Slime_King_Head");
            Main.NPCLoaded[NPCID.KingSlime] = true;

            //Normal Slimes
            Main.goreTexture[314] = GetTexture("Replacements/Slimes/Slime_Umbrella_Umbrella"); //Umbrella
            Main.npcTexture[NPCID.SlimeMasked] = GetTexture("Replacements/Slimes/Slime_Bunny");
            Main.npcTexture[NPCID.BlueSlime] = GetTexture("Replacements/Slimes/Slime_Default");
            Main.npcTexture[NPCID.DungeonSlime] = GetTexture("Replacements/Slimes/Slime_Dungeon");
            Main.npcTexture[NPCID.IlluminantSlime] = GetTexture("Replacements/Slimes/Slime_Hallow");
            Main.npcTexture[NPCID.SlimedZombie] = GetTexture("Replacements/Slimes/Slime_Host");
            Main.npcTexture[NPCID.ArmedZombieSlimed] = GetTexture("Replacements/Slimes/Slime_Host_Arm");
            Main.npcTexture[NPCID.MotherSlime] = GetTexture("Replacements/Slimes/Slime_Large");
            Main.npcTexture[NPCID.LavaSlime] = GetTexture("Replacements/Slimes/Slime_Lava");
            Main.npcTexture[NPCID.RainbowSlime] = GetTexture("Replacements/Slimes/Slime_Rainbow");
            Main.npcTexture[NPCID.SlimeRibbonWhite] = GetTexture("Replacements/Slimes/Slime_Ribbon0");
            Main.npcTexture[NPCID.SlimeRibbonYellow] = GetTexture("Replacements/Slimes/Slime_Ribbon1");
            Main.npcTexture[NPCID.SlimeRibbonGreen] = GetTexture("Replacements/Slimes/Slime_Ribbon2");
            Main.npcTexture[NPCID.SlimeRibbonRed] = GetTexture("Replacements/Slimes/Slime_Ribbon3");
            Main.npcTexture[NPCID.SpikedJungleSlime] = GetTexture("Replacements/Slimes/Slime_Rose");
            Main.npcTexture[NPCID.SlimeSpiked] = GetTexture("Replacements/Slimes/Slime_Spiky");
            Main.npcTexture[NPCID.ToxicSludge] = GetTexture("Replacements/Slimes/Slime_Toxic");
            Main.npcTexture[NPCID.UmbrellaSlime] = GetTexture("Replacements/Slimes/Slime_Umbrella");
            Main.goreLoaded[314] = true;
            Main.NPCLoaded[NPCID.SlimeMasked] = true;
            Main.NPCLoaded[NPCID.BlueSlime] = true;
            Main.NPCLoaded[NPCID.DungeonSlime] = true;
            Main.NPCLoaded[NPCID.IlluminantSlime] = true;
            Main.NPCLoaded[NPCID.SlimedZombie] = true;
            Main.NPCLoaded[NPCID.ArmedZombieSlimed] = true;
            Main.NPCLoaded[NPCID.MotherSlime] = true;
            Main.NPCLoaded[NPCID.LavaSlime] = true;
            Main.NPCLoaded[NPCID.RainbowSlime] = true;
            Main.NPCLoaded[NPCID.SlimeRibbonWhite] = true;
            Main.NPCLoaded[NPCID.SlimeRibbonYellow] = true;
            Main.NPCLoaded[NPCID.SlimeRibbonGreen] = true;
            Main.NPCLoaded[NPCID.SlimeRibbonRed] = true;
            Main.NPCLoaded[NPCID.SpikedJungleSlime] = true;
            Main.NPCLoaded[NPCID.SlimeSpiked] = true;
            Main.NPCLoaded[NPCID.ToxicSludge] = true;
            Main.NPCLoaded[NPCID.UmbrellaSlime] = true;


            //Slime Pets and such
            Main.buffTexture[BuffID.BabySlime] = GetTexture("Replacements/Slimes/Slime_Baby_Buff");
            Main.projectileTexture[ProjectileID.BabySlime] = GetTexture("Replacements/Slimes/Slime_Baby");
            Main.projectileLoaded[ProjectileID.BabySlime] = true;
            Main.buffTexture[BuffID.SlimeMount] = GetTexture("Replacements/Slimes/Slime_Mount_Buff");
            Mount.mounts[3].backTexture = GetTexture("Replacements/Slimes/Slime_Mount");

            //Misc Slime stuff
            Main.itemTexture[ItemID.Gel] = GetTexture("Replacements/Gels/Gel_Default");
            Main.itemTexture[ItemID.PinkGel] = GetTexture("Replacements/Gels/Gel_Pink");
        }
    }
}
