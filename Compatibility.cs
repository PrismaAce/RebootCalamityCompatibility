using CalamityMod.NPCs.DesertScourge;
using CalamityMod.NPCs.Crabulon;
using CalamityMod.NPCs.HiveMind;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.SlimeGod;
using CalamityMod.NPCs.Cryogen;
using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityMod.NPCs.CalClone;
using CalamityMod.NPCs.Leviathan;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.Providence;
using CalamityMod.NPCs.StormWeaver;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Signus;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.OldDuke;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.Yharon;
using CalamityMod.NPCs.ExoMechs;
using CalamityMod.NPCs.SupremeCalamitas;
using CalamityMod.NPCs.PrimordialWyrm;

using Microsoft.Xna.Framework;
using System.IO;
using System.Threading;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;
using CalamityMod.NPCs.NormalNPCs;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.ExoMechs.Artemis;
using CalamityMod.NPCs.ExoMechs.Thanatos;

namespace RebootVan.Content
{
    public class CompatibilitySystem : ModSystem
    {
        public static bool desertScourge = false;
        public static bool crabulon = false;
        public static bool evil2 = false;
        public static bool slimegod = false;
        public static bool cryo = false;
        public static bool aqua = false;
        public static bool brimmy = false;
        public static bool calclone = false;
        public static bool levi = false;
        public static bool aureus = false;
        public static bool pbg = false;
        public static bool rav = false;
        public static bool deus = false;
        public static bool guards = false;
        public static bool folly = false;
        public static bool prov = false;
        public static bool weaver = false;
        public static bool cvoid = false;
        public static bool sigma = false;
        public static bool polter = false;
        public static bool old = false;
        public static bool dog = false;
        public static bool dragon = false;
        public static bool exos = false;
        public static bool scal = false;
        public static bool wyrm = false;

        public override void ClearWorld()
        {
            desertScourge = false;
            crabulon = false;
            evil2 = false;
            slimegod = false;
            cryo = false;
            aqua = false;
            brimmy = false;
            calclone = false;
            levi = false;
            aureus = false;
            pbg = false;
            rav = false;
            deus = false;
            guards = false;
            folly = false;
            prov = false;
            weaver = false;
            cvoid = false;
            sigma = false;
            polter = false;
            old = false;
            dog = false;
            dragon = false;
            exos = false;
            scal = false;
            wyrm = false;
        }

        public override void SaveWorldData(TagCompound tag)
        {
            if (desertScourge) tag["desertScourge"] = true;
            if (crabulon) tag["crabulon"] = true;
            if (evil2) tag["evil2"] = true;
            if (slimegod) tag["slimegod"] = true;

            if (cryo) tag["cryo"] = true;
            if (aqua) tag["aqua"] = true;
            if (brimmy) tag["brimmy"] = true;
            if (calclone) tag["calclone"] = true;
            if (levi) tag["levi"] = true; 
            if (aureus) tag["aureus"] = true;
            if (pbg) tag["pbg"] = true;
            if (rav) tag["rav"] = true;
            if (deus) tag["deus"] = true;

            if (guards) tag["guards"] = true;
            if (folly) tag["folly"] = true;
            if (prov) tag["prov"] = true;
            if (weaver) tag["weaver"] = true;
            if (cvoid) tag["cvoid"] = true;
            if (sigma) tag["sigma"] = true;
            if (polter) tag["polter"] = true;
            if (old) tag["old"] = true;
            if (dog) tag["dog"] = true;
            if (dragon) tag["dragon"] = true;
            if (exos) tag["exos"] = true;
            if (scal) tag["scal"] = true;
            if (wyrm) tag["wyrm"] = true;

        }

        public override void LoadWorldData(TagCompound tag)
        {
            desertScourge = tag.ContainsKey("desertScourge");
            crabulon = tag.ContainsKey("crabulon");
            evil2 = tag.ContainsKey("evil2");
            slimegod = tag.ContainsKey("slimegod");

            cryo = tag.ContainsKey("cryo");
            aqua = tag.ContainsKey("aqua");
            brimmy = tag.ContainsKey("brimmy");
            calclone = tag.ContainsKey("calclone");
            levi = tag.ContainsKey("levi");
            aureus = tag.ContainsKey("aureus");
            pbg = tag.ContainsKey("pbg");
            rav = tag.ContainsKey("rav");
            deus = tag.ContainsKey("deus");

            guards = tag.ContainsKey("guards");
            folly = tag.ContainsKey("folly");
            prov = tag.ContainsKey("prov");
            weaver = tag.ContainsKey("weaver");
            cvoid = tag.ContainsKey("cvoid");
            sigma = tag.ContainsKey("sigma");
            polter = tag.ContainsKey("polter");
            old = tag.ContainsKey("old");
            dog = tag.ContainsKey("dog");
            dragon = tag.ContainsKey("dragon");
            exos = tag.ContainsKey("exos");
            scal = tag.ContainsKey("scal");
            wyrm = tag.ContainsKey("wyrm");
        }

        public override void NetSend(BinaryWriter writer)
        {
            var flags1 = new BitsByte();
            flags1[0] = desertScourge;
            flags1[1] = crabulon;
            flags1[2] = evil2;
            flags1[3] = slimegod;
            flags1[4] = cryo;
            flags1[5] = aqua;
            flags1[6] = brimmy;
            flags1[7] = calclone;
            writer.Write(flags1);

            var flags2 = new BitsByte();
            flags2[0] = levi;
            flags2[1] = aureus;
            flags2[2] = pbg;
            flags2[3] = rav;
            flags2[4] = deus;
            flags2[5] = guards;
            flags2[6] = folly;
            flags2[7] = prov;
            writer.Write(flags2);

            var flags3 = new BitsByte();
            flags3[0] = weaver;
            flags3[1] = cvoid;
            flags3[2] = sigma;
            flags3[3] = polter;
            flags3[4] = old;
            flags3[5] = dog;
            flags3[6] = dragon;
            flags3[7] = exos;
            writer.Write(flags3);

            var flags4 = new BitsByte();
            flags4[0] = scal;
            flags4[1] = wyrm;
            writer.Write(flags4);
        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags1 = reader.ReadByte();
            desertScourge = flags1[0];
            crabulon = flags1[1];
            evil2 = flags1[2];
            slimegod = flags1[3];
            cryo = flags1[4];
            aqua = flags1[5];
            brimmy = flags1[6];
            calclone = flags1[7];

            BitsByte flags2 = reader.ReadByte();
            levi = flags2[0];
            aureus = flags2[1];
            pbg = flags2[2];
            rav = flags2[3];
            deus = flags2[4];
            guards = flags2[5];
            folly = flags2[6];
            prov = flags2[7];

            BitsByte flags3 = reader.ReadByte();
            weaver = flags3[0];
            cvoid = flags3[1];
            sigma = flags3[2];
            polter = flags3[3];
            old = flags3[4];
            dog = flags3[5];
            dragon = flags3[6];
            exos = flags3[7];

            BitsByte flags4 = reader.ReadByte();
            scal = flags4[0];
            wyrm = flags4[1];
        }
    }
    public class CompatibilityGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public static void Refill()
        {
            if (ModLoader.TryGetMod("RebootVan", out Mod reboot))
            {
                reboot.Call("RefillVan");
            }
        }
        public override void OnKill(NPC npc)
        {
            bool lastAnaLevi = false;
            if (npc.type == NPCType<Anahita>())
                lastAnaLevi = !NPC.AnyNPCs(NPCType<Leviathan>());
            else if (npc.type == NPCType<Leviathan>())
                lastAnaLevi = !NPC.AnyNPCs(NPCType<Anahita>());

            bool lastExo = false;
            if (npc.type == NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresBody>())
            {
                lastExo = 
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Apollo.Apollo>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Artemis.Artemis>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosHead>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosBody1>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosBody2>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosTail>())
                    ;
            }
            else if (npc.type == NPCType<CalamityMod.NPCs.ExoMechs.Apollo.Apollo>())
            {
                lastExo =
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresBody>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresGaussNuke>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresLaserCannon>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresPlasmaFlamethrower>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresTeslaCannon>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Artemis.Artemis>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosHead>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosBody1>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosBody2>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosTail>())
                    ;
            }
            else if (npc.type == NPCType<CalamityMod.NPCs.ExoMechs.Artemis.Artemis>())
            {
                lastExo =
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresBody>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresGaussNuke>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresLaserCannon>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresPlasmaFlamethrower>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresTeslaCannon>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Apollo.Apollo>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosHead>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosBody1>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosBody2>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosTail>())
                    ;
            }
            else if (npc.type == NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosHead>()
                || npc.type == NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosBody1>()
                || npc.type == NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosBody2>()
                || npc.type == NPCType<CalamityMod.NPCs.ExoMechs.Thanatos.ThanatosTail>()
                )
            {
                lastExo =
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresBody>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresGaussNuke>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresLaserCannon>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresPlasmaFlamethrower>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Ares.AresTeslaCannon>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Artemis.Artemis>()) &&
                    !NPC.AnyNPCs(NPCType<CalamityMod.NPCs.ExoMechs.Apollo.Apollo>())
                    ;
            }
            
            if (npc.type == NPCType<DesertScourgeHead>()
                || npc.type == NPCType<DesertScourgeBody>()
                || npc.type == NPCType<DesertScourgeTail>()
                )
            {
                if(!CompatibilitySystem.desertScourge)
                {
                    CompatibilitySystem.desertScourge = true;
                    Refill();
                }

            }
            else if (npc.type == NPCType<Crabulon>()
                && !CompatibilitySystem.crabulon)
            {
                CompatibilitySystem.crabulon = true;
                Refill();
            }
            else if (npc.type == NPCType<PerforatorHive>()
                || npc.type == NPCType<HiveMind>()
                )
            {
                if (!CompatibilitySystem.evil2)
                {
                    CompatibilitySystem.evil2 = true;
                    Refill();
                }

            }
            else if (npc.type == NPCType<SlimeGodCore>()
                && !CompatibilitySystem.slimegod)
            {
                CompatibilitySystem.slimegod = true;
                Refill();
            }
            else if (npc.type == NPCType<Cryogen>()
                && !CompatibilitySystem.cryo)
            {
                CompatibilitySystem.cryo = true;
                Refill();
            }
            else if (npc.type == NPCType<AquaticScourgeHead>()
                || npc.type == NPCType<AquaticScourgeBody>()
                || npc.type == NPCType<AquaticScourgeBodyAlt>()
                || npc.type == NPCType<AquaticScourgeTail>()
                )
            {
                if (!CompatibilitySystem.aqua)
                {

                    CompatibilitySystem.aqua = true;
                    Refill();
                }
            }
            else if (npc.type == NPCType<BrimstoneElemental>()
                && !CompatibilitySystem.brimmy)
            {
                CompatibilitySystem.brimmy = true;
                Refill();
            }
            else if (npc.type == NPCType<CalamitasClone>()
                && !CompatibilitySystem.calclone)
            {
                CompatibilitySystem.calclone = true;
                Refill();
            }
            else if (npc.type == NPCType<Leviathan>()
                || npc.type == NPCType<Anahita>()
                )
            {
                if (!CompatibilitySystem.levi)
                {
                    if (lastAnaLevi)
                    {
                        CompatibilitySystem.levi = true;
                        Refill();
                    }
                }

            }
            else if (npc.type == NPCType<AstrumAureus>()
                && !CompatibilitySystem.aureus)
            {
                CompatibilitySystem.aureus = true;
                Refill();
            }
            else if (npc.type == NPCType<PlaguebringerGoliath>()
                && !CompatibilitySystem.pbg)
            {
                CompatibilitySystem.pbg = true;
                Refill();
            }
            else if (npc.type == NPCType<RavagerBody>()
                && !CompatibilitySystem.rav)
            {
                CompatibilitySystem.rav = true;
                Refill();
            }
            else if (npc.type == NPCType<AstrumDeusHead>()
                || npc.type == NPCType<AstrumDeusBody>()
                || npc.type == NPCType<AstrumDeusTail>()
                )
            {
                if (!CompatibilitySystem.deus)
                {
                    CompatibilitySystem.deus = true;
                    Refill();
                }    

            }
            else if (npc.type == NPCType<ProfanedGuardianCommander>()
                && !CompatibilitySystem.guards)
            {
                CompatibilitySystem.guards = true;
                Refill();
            }
            else if (npc.type == NPCType<Bumblefuck>()
                && !CompatibilitySystem.folly)
            {
                CompatibilitySystem.folly = true;
                Refill();
            }
            else if (npc.type == NPCType<Providence>()
                && !CompatibilitySystem.prov)
            {
                CompatibilitySystem.prov = true;
                Refill();
            }
            else if (npc.type == NPCType<StormWeaverHead>()
                || npc.type == NPCType<StormWeaverBody>()
                || npc.type == NPCType<StormWeaverTail>()
                )
            {
                if (!CompatibilitySystem.weaver)
                {
                    CompatibilitySystem.weaver = true;
                    Refill();
                }

            }
            else if (npc.type == NPCType<CeaselessVoid>()
                && !CompatibilitySystem.cvoid)
            {
                CompatibilitySystem.cvoid = true;
                Refill();
            }
            else if (npc.type == NPCType<Signus>()
                && !CompatibilitySystem.sigma)
            {
                CompatibilitySystem.sigma = true;
                Refill();
            }
            else if (npc.type == NPCType<Polterghast>()
                && !CompatibilitySystem.polter)
            {
                CompatibilitySystem.polter = true;
                Refill();
            }
            else if (npc.type == NPCType<OldDuke>()
                && !CompatibilitySystem.old)
            {
                CompatibilitySystem.old = true;
                Refill();
            }
            else if (npc.type == NPCType<DevourerofGodsHead>()
                || npc.type == NPCType<DevourerofGodsBody>()
                || npc.type == NPCType<DevourerofGodsTail>()
                )
            {
                if(!CompatibilitySystem.dog)
                {
                    CompatibilitySystem.dog = true;
                    Refill();
                }

            }
            else if (npc.type == NPCType<Yharon>()
                && !CompatibilitySystem.dragon)
            {
                CompatibilitySystem.dragon = true;
                Refill();
            }
            else if (npc.type == NPCType<SupremeCalamitas>()
                && !CompatibilitySystem.scal)
            {
                CompatibilitySystem.scal = true;
                Refill();
            }
            else if (npc.type == NPCType<PrimordialWyrmHead>()
                && !CompatibilitySystem.wyrm)
            {
                CompatibilitySystem.wyrm = true;
                Refill();
            }
            else if (npc.type == NPCType<AresBody>()
                || npc.type == NPCType<Apollo>()
                || npc.type == NPCType<Artemis>()
                || npc.type == NPCType<ThanatosHead>()
                || npc.type == NPCType<ThanatosBody1>()
                || npc.type == NPCType<ThanatosBody2>()
                || npc.type == NPCType<ThanatosTail>()
                )
            {
                if (lastExo && !CompatibilitySystem.exos)
                {
                    CompatibilitySystem.exos = true;
                    Refill();
                }
                
            }
        }
    }
}