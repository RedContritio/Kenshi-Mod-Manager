﻿using Core.Models;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GuidelineCore
{
    public static class RuleService
    {
        private static List<Rules> ruleList = new List<Rules>();
        public static List<Rules> GetRules()
        {
            var rules = new List<Rules> {

                new Rules{
                    Order = 0,
                    Name = "Ui, Graphics, Performance,BaseFixes",
                    Mod = new List<string>(){
                        "ShaderSSAO.mod",
                        "Texture_Options_512_world_only.mod",
                        "Removed Weather Effects.mod",
                        "Less_Foliage_and_Rocks_x4.mod",
                        "Nice Map [Tpg + Grid + Zones + Zone names + Roads].mod",
                        "Dark UI.mod",
                        "Player Faction Armor Color.mod",
                        "Shidan's Tweaks & Fixes",
                        "Tweaks & Fixes No Tech Hunter Alliances.mod",
                        "Tweaks & Fixes No Research Artifacts.mod",
                        "Fixing Clipping Issues.mod",
                        "UKP.mod",
                        "EnhancedSurvivalChallenge.mod",
                        "Dark Nights & Reshade.mod",
                        "Less Clutter x0.50.mod",
                        "ReDone_UI.mod",
                        "ReDone_UI_Clean.mod",
                    }
                },
                new Rules{
                    Order = 1,
                    Name = "Animations",
                    Mod = new List<string>(){
                        "More Combat Animation.mod",
                        "AnimationOverhaul.mod",
                        "Military craft.mod"
                    }
                },
                new Rules{
                    Order = 2,
                    Name = "New Races, RaceEdits,StartMods",
                    Mod = new List<string>(){
                        "Playable Races And Sub-Races.mod",
                        "Skeleton SL-M.mod",
                        "Skeleton ILA-M MKI.mod",
                        "NoArmorPenalty.mod",
                        "MW_Fu2 Hairstyles.mod",
                        "CCO.mod",
                        "CCO_RACES.mod",
                        "CCO_PACK_01.mod",
                        "CCO_RACES_PACK_01.mod",
                        "CCO_HIRES_01.mod",
                        "CCO_HIRES_02.mod",
                        "CCO_RACES_GLOW.mod",
                        "DEAD_HIVE_GLOW.mod",
                        "Faces+.mod",
                        "FacesAdd01.mod",
                        "CannibalHeads.mod",
                        "FishSticks.mod",
                        "HiveHeads.mod",
                        "Hive Prosthetics.mod",
                        "Grievewraiths.mod",
                        "Iron Skimmer.mod",

                        "Foulhounds.mod",
                        "Mist Ghouls.mod",
                        "ScarierSpiders.mod",
                        "Throes of Obedience.mod",
                        "Ancient Terrors.mod",
                        "Vagrant Dealers.mod",
                        "Cannibal_Expansion.mod",
                        "Cannibal Hunters.mod",
                        "Skeletons.mod",
                        "ShriekingBandit_Expansion.mod",
                        "Starving Bandits new type.mod",
                        "Nomad Changes.mod",
                        "Faction Caravans.mod",
                        "Slaver Caravan.mod",
                        "Remove Outpost Slaver Raids.mod",
                        "Slave Camp Slots Balance.mod",
                        "Hiver_Expansion.mod",
                        "Fix Relation(Healing)EN.mod",
                        "AllRacesSameRoute.mod",
                        "Everyone Has a Name, Janet.mod",
                        "wvr_MoreNamedPeoples.mod",
                        "More Names.mod",
                        "Expanded Name Set.mod",
                        "hippity hoppity you're now my property.mod",
                        "Talk to everyone.mod",
                        "DialoguePlus.mod",
                        "Dialogue Expanded.mod",
                        "Random Furniture.mod",
                        "Moisture Farming.mod",
                        "Metal Fencing.mod",
                        "Interior Design.mod",
                        "Forgotten Buildings.mod",
                        "Work_Bench_Variations.mod",
                        "HiveBuildings.mod",
                        "Hang Paintings.mod",
                        "Manufacturers Expanded.mod",
                        "Manufacturers Expanded - Craftable.mod",
                        "Ancient Technology Trader.mod",
                        "Luxury_Goods.mod",
                        "TexturedT5Walls.mod",
                        "blot slaverope.mod",
                        "Iron_Cuffs.mod",
                        "Parchment Crafting.mod",
                        "Expanded Lighting.mod",
                        "Clutter.mod",
                        "Crucifixion.mod",
                        "Burned alive.mod",
                        "Citadel.mod",
                        "CombatBoots.mod",
                        "SquareTopper.mod",
                        "Mediocre Black Armor.mod",
                        "Better Crop Fences.mod",

                        "Wooden Dexterity Training Dummy.mod",
                        "Sparring - Melee Defense Training.mod",
                        "Remove Training Bar.mod",
                        "Remove Training Bar - Mod Patches.mod",
                        "Build Category Fix.mod",
                        "Slopeless.mod",
                        "repeatable techs.mod",
                        "Security Plus.mod",
                        "WorkBench variation Patch01.mod",
                        "moreBluePrints.mod",
                        "Prisoner_Food.mod",

                        "Quiver.mod",
                        "BoltsMoreCharges.mod",
                        "NewRecruits.mod",
                        "More Bountys.mod",
                        "Recruitable Bounties.mod",
                        "Clown.mod",
                        "Idle Stands.mod",
                        "Idle Stands Patch.mod",
                        "Move Mod.mod",
                        "ShekSub.mod",
                        "VOICEROID Hairstyles.mod",
                        "Faces+AddOn2.mod",
                        "HiveHuntersNoFog.mod",
                        "Hard labor uses strength.mod",
                        "WANTED poster map.mod",
                        "FacesAdd03.mod",
                        "Animal Eats Plus.mod",
                        "Players AI.mod",
                        "Let's Talk.mod",
                        "HN Ascended.mod",
                        "UC Heightened.mod",
                        "Shek Kingdom Expansion.mod",
                        "Hive_South_stats.mod",


                    }
                },
                new Rules{
                    Order = 3,
                    Name = "GameStart Minor Additions (New Npc's and animals)",
                    Mod = new List<string>(){
                         "Cheat Start.mod",
                        "SC Competition Start.mod",
                        "CCO_STARTS_01.mod",
                        "CCO_STARTS_02.mod",
                        "The Chosen One.mod",
                        "Lazarus.mod",
                        "New Recruits.mod",
                        "kotorstuff.mod",
                        "HK-47 Recruit Addon.mod",
                        "GreatDirewolf.mod",
                        "Animal Traders.mod",
                        "Animal Backpacks.mod",
                        "Aminals.mod",
                        "TameBeasties.mod",
                        "TIHYD_Zoo.mod",
                        "Wildlife_Diversity.mod",
                        "Wildlife_Tame.mod",
                        "End Exotic Pet Neglect.mod",
                    }
                },
                new Rules{
                    Order = 4,
                    Name = "FactionEdits, simple additions",
                    Mod = new List<string>(){
                        "Islanders Race.mod",
                        "Unique Phoenix Armor.mod",
                        "The Dust King.mod",
                        "Black Dragon Ninjas.mod",
                        "Community Part Map.mod",
                        "thigh_high.mod",
                        "highheels.mod",
                        "Mercenary Full Plate.mod",
                        "Diffuser Helm.mod",
                        "back_scorpion_gears.mod",
                        "2PN8HiveSoldiers.mod",
                        "Regenerates in Towns.mod",
                        "More Bountys.mod",
                        "Tech Hunters Relations.mod",
                        "Taxman Relations plus.mod",
                        "The Dark Tech Society.mod",
                        "Reprogrammable skeletons.mod",
                        "Hive_Queen_start.mod",
                        "CCO_RACES_ACO.mod",
                        "CCO_STARTS_03.mod",
                        "CCO_HIRES_03.mod",
                        "CCO_STARTS_04.mod",
                        "CCO_UNLOCK.mod",
                        "Escort Mission.mod",
                        "NPC Town Guard Mission.mod",

                    }

                },
                new Rules{
                    Order = 5,
                    Name = "Buildings",
                    Mod = new List<string>(){
                        "skeletonlimbstorage.mod",
                        "MedicalBeds.mod",
                        "Work_Bench_Variations.mod",
                        "Expanded Lighting.mod",
                        "Moisture Farming.mod",
                        "Wooden Watchtower.mod",
                        "Training Dummies by.Adys.mod",
                        "more building.mod",
                        "Forgotten Buildings.mod",
                        "defensivegates.mod",
                        "Slopeless.mod",
                        "oil.mod",
                        "IdleTraining.mod",
                        "Interactive World.mod",
                        "training_swords_gariba.mod",
                        "Advanced Training.mod",

                        "cubic cubes.mod",
                        "small_is_small.mod"
                    }
                },
                  new Rules{
                    Order = 6,
                    Name = "Armor/Weapons",
                    Mod = new List<string>(){
                        "CombatBoots.mod",
                        "MorePlate.mod",
                        "GusokuArmorV1.0.mod",
                        "Nomad Pants.mod",
                        "Wolf_Headgear.mod",
                        "revansrobes.mod",
                        "nomad cape.mod",
                        "ImpalerArmor.mod",
                        "Plank Shield.mod",
                        "Crossbow_expansion.mod",
                        "BoltsMoreCharges.mod",
                        "Legendary Weapons.mod",
                        "Patchwork Armour.mod",
                        "Luxury Backpack Mod.mod",
                        "Umbra Backpacks.mod",
                        "Fox's Weapons Mod Set.mod",
                        "Expanded Craftable Weapons.mod",
                        "Jewy's Limbs Overhaul.mod"

                    }
                },new Rules{
                    Order = 7,
                    Name = "Overhauls & Big additions/world changes",
                    Mod = new List<string>(){
                        "ABSOLVER.mod",
                        "Shidan's Tweaks & Fixes.mod",
                        "RecruitPrisoners.mod",
                        "Adventurers Guild - Lore Friendly Recruitment.mod",
                        "Minor Factions Expansion.mod",
                        "Minor Faction Pacifiers.mod",
                        "Swish Mods East Coast Expansion.mod",
                        "Swish Mod.mod",
                        "ShriekingBandit_Expansion.mod",
                        "Cannibal_Expansion.mod",
                        "Hiver_Expansion.mod",
                        "take over the world.mod",
                        "Reactive world.mod",
                        "Realpolitik.mod",
                        "Genesis.Mod",
                        "GenMod.mod"
                    }
                },
                  new Rules{
                    Order = 8,
                    Name = "Patches",
                    Mod = new List<string>(){
                        "GenMod_Cr_add01.mod",
                        "GenMod DR_DLC1.mod",
                        "GenMod_More_starts.mod",
                        "GenMod_CCO_Hive_Starts.mod",
                        "GenMod_unlocker_01.mod",
                        "GenMod_Modul_01.mod",
                        "GenMod_unlocker_02.mod",
                        "GenMod_easy_01.mod",
                        "GenMod_Paper.mod",
                        "GenMod_PER_01.mod",
                        "Better Crop Fences GenMod Patch.mod",
                        "GenMod_LessGreen.mod",
                        "GenMod_LessBlue.mod",
                        "GenMod_Modul_03.mod",
                        "GenMod_Modul_02.mod",
                        "GenMod_MoreAlphas.mod",
                        "GenMod_HiveEX_comp.mod",
                        "CCO_COMP_MCA.mod",
                        "CCO_AOC_COMP_MOD.mod",
                        "Resource specific storage 1000.mod",
                        "No Cut Efficiency.mod",
                        "DrugsExpandedPatch.mod",
                        "CCO_AOC_COMP_MOD.mod",
                        "CCO_COMP_MCA.mod",
                        "Forgotten Buildings + Work Bench Variations Compatibility.mod",
                        "BCF-DrugsExpandedPatch-Compat.mod",
                        "GenMod_HiveEX_comp.mod",
                        "Warmaidens Reactive World Patch.mod",
                        "Remove Training Bar.mod",
                        "Remove Training Bar - Mod Patches.mod",
                        "KAoBS - Hair Patches.mod",
                        "KAoBS - Animation Patches.mod",
                        "KAoBS - Animation Patches 2.mod",
                        "KAoBS - Misc Patches.mod",
                        "KAoBS - Collection Tweaks.mod",
                        "GenMod_TamBea_comp.mod",
                        "ShekSub_comp02.mod",
                        "GenMod_InterWor_comp.mod",
                        "CCO_HAIR_COMP_01.mod",
                        "CCO_HAIR_COMP_02.mod",
                        "CCO_HAIR_COMP_04.mod",
                        "GenMod_Animal_starts.mod",
                        "GenMod_Zoo_comp.mod",
                        "CCO_RACES_CLEAN_COMP.mod",
                        "CCO_CLEAN_COMP.mod",
                        "GenMod_Clean_comp.mod",
                        "GenMod_Griev_comp.mod",
                        "GenMod_Foulhou_comp.mod",
                        "GenMod_Ceature_Co_Co.mod",
                        "CCO_HAIR_COLL_COMP.mod",
                        "CCO_MC_COMP_MOD.mod",
                        "GenMod_AddAnims_comp.mod",
                        "ShekSub_comp01.mod",
                        "CCO_RACES_COMP_MCA.mod",
                        "CCO_RACES_HiveEX.mod",
                        "GenMod_UC_Heightened.mod",
                        "GenMod_HN_Ascended.mod",
                        "Clean Queen.mod",
                        "Shek_KE_Anim_fix.mod",
                        "GenMod_Parchment.mod",
                        "Plant Trees.mod",
                        "Hive_Queen_No_Robo.mod",
                        "CCO_PRAET.mod",
                        "yundao_hair_conversion.mod",
                        "aniceoaktrees_hairstyles.mod",
                        "MW_Fu2 Hairstyles - JRPG Patch.mod",
                        "FacesAdd04.mod",
                        "HIVE_TO_DEADHIVE.mod",
                        "Imprisonment Plus.mod",
                        "LonghouseAdjustment.mod",
                        "ShriekingBandit_Expansion_NCE.mod",
                        "Hiver_Expansion_NCE.mod",
                        "Cannibal_Expansion_NCE.mod",
                        "NCE for Mediocre Black Armor.mod",
                        "NCE Patch Pack 2.mod",
                        "GenMod_CCO_all_anim_comp.mod",
                    }
                },
                new Rules{
                    Order = 9,
                    Name = "Economy",
                    Mod = new List<string>(){
                        "TradeRework.mod",
                        "tariffs.mod",
                        "NPC enjoys more shopping.mod",
                        "citizens.mod",
                        "shoppi/con.mod",
                        "shops have more money.mod",
                        "Trade Prices.mod",
                        "Your sold items will disappear.mod",
                        "shoppingecon.mod",
                        "shoppingecon.mod",
                        "NPC enjoys more shopping.mod",
                        "shopkeeper.mod",

                    }
                },
                new Rules{
                    Order = 10,
                    Name = "Priority (Custom)",
                    Mod = new List<string>(){
                        "Realistic Combat.mod",
                        "More Meitous.mod",
                        "No Cut Efficiency.mod",
                        "Pocket Change.mod",
                        "Sabre Class Realistic.mod",
                        "Blunt Class Realistic.mod",
                        "Hacker Class Realistic.mod",
                        "Realistic Goggles.mod",
                        "Undershirts Realistic.mod",
                        "Armoured Rags Realistic .mod",
                        "Rag Shirt Realistic.mod",
                        "Mercenary Leather Armor Realistic.mod",
                        "Mercenary Plate Armor Realistic.mod",
                        "Samurai Armor Realistic.mod",
                        "Plate Armor Realistic.mod",
                        "Armored Rag Skirt Realistic.mod",
                        "Samurai Legplates Realistic.mod",
                        "Samurai Boots Realistic.mod",
                        "Bandana Realistic.mod",
                        "Rag Lioncloth Realistic.mod",
                        "Trader's Leathers Realistic.mod",
                        "Holy Armor Realistic.mod",
                        "Martial Artist Bindings Realistic.mod",
                        "Heart Protector Realistic.mod",
                        "Faceplates Realistic.mod",
                        "Wooden Sandals Realistic.mod",
                        "Hat Realism.mod",
                        "Shirts Realistic.mod",
                        "Head Armour Realistic.mod",
                        "Hackstopper Realistic.mod",
                        "Crab Armour Realistic.mod",
                        "Katana Class Realistic.mod",
                        "Ninja Gi.mod",
                        "Ragged Pants.mod",
                        "Assassin's Rags Fix.mod",
                        "Defensive Gates 10x HP & 50% quicker repair.mod",
                        "MaxStats.mod",
                        "Nice Map [Tpg + Grid + Zones + Zone names].mod",
                        "More Fog.mod",
                        "Longer Night - Sunset At 7pm.mod",
                        "Lights for Dark Nights.mod",
                        "detail textures.mod",
                        "Compressed Textures Project.mod",
                        "Forgotten Buildings - Reduced Texture Size.mod",
                        "Reduced Particle Effects.mod",
                        "JoshLmoa's_DarkVanillaUI.mod",
                        "Transparent UI.mod",
                        "Font Redux.mod",
                        "Reactive World.mod",
                        "Take Over the World.mod",
                        "Ruin Restoration.mod",
                        "FallenGraceTownRemoval.mod",
                        "SlowHealing.mod",
                        "BlleedOut.mod",
                        "Pocket Change 2.0.mod",
                        "Toon's NPC mod.mod",
                        "Outpostlife.mod",
                        "BuildingEditsThatIDontWantToInclude.mod",
                        "1Slaves Changes Mind.mod",
                        "Longer Mercenary Contracts.mod",
                        "Mercenary Reworked.mod",
                        "Attack Slots x2.mod",
                        "Attack Slots x3.mod",
                        "Attack Slots x5.mod",
                        "256 Squad Limit.mod",
                        "Don't Burst My Ear Drums.mod",
                        "Dangerous Hazards.mod",
                        "10x Longer Prison Sentences.mod",
                        "UICorrections.mod",
                        "Kenshi Community Loading Screens.mod",
                        "No Loading Screens Tips.mod",
                        "FactionArmorColorSettings.mod",
                        "Darker Nights ++.mod",
                        "BCW no blue.mod",
                        "Minor Mesh Fixes.mod",
                        "Minor Mesh Fixes - Alt.mod",
                        "Bigger Backpacks.mod",
                        "Random Enemy Squads' numbers.mod",
                        "Crossbow Training Station.mod",
                        "10XLessRaids.mod",
                        "GreedyMerchants.mod",
                        "AidKitsMoreCharges.mod",
                        "CarryWeight10XExp.mod",
                        "WeakEnemiesSquads.mod",
                        "LessFastHealingBeds.mod",
                        "Martial Arts No Matrix Dodge.mod",
                        "Martial Arts Fast Dodger.mod",
                        "Weaklings Always Give XP.mod",
                        "2HNotMartialArtistDiv3.mod",
                        "MartialArtsAlwaysAttack.mod",
                        "RobotNoWearDamage.mod",
                        "Travellers_Medicrate.mod",
                        "Stone_is_Stone.mod",
                    }
                }
            };

            return rules;
        }

        public static IEnumerable<Mod> OrderMods(IEnumerable<Mod> mods)
        {


            if (ruleList.Count == 0)
                ruleList = GetRules();

            foreach (var rule in ruleList)
            {
                foreach (var orderedMod in rule.Mod)
                {
                    var mod = mods.FirstOrDefault(c => Path.GetFileName(c.Name).Contains(orderedMod));
                    if (mod == null) continue;
                    if (Path.GetFileName(mod.Name).Contains(orderedMod))
                    {
                        mod.OrderedAutomatically = true;

                        removeModFromOtherList(mod, rule.Order);

                        if (!rule.ModsOrdered.Any(q => q.UniqueIdentifier == mod.UniqueIdentifier))
                            rule.ModsOrdered.Add(mod);
                        continue;
                    }
                }

            }

            foreach (var item in mods.Where(c => !c.OrderedAutomatically))
            {
                ruleList.FirstOrDefault(c => c.Order == 10).ModsOrdered.Add(item);
                Console.WriteLine(Path.GetFileName(item.Name));
            }

            var ordered = new List<Mod>();



            foreach (var rule in ruleList)
            {
                var index = rule.InitialRange;

                foreach (var mod in rule.ModsOrdered)
                {

                    mod.Order = index;
                    index++;
                }
                ordered.AddRange(rule.ModsOrdered.OrderBy(o => o.Order));
            }

            var i = 0;
            foreach (var item in ordered.OrderBy(o => o.Order))
            {
                item.Order = i;
                i++;
            }

            foreach (var rule in ruleList)
            {
                rule.ModsOrdered.Clear();
            }
            return ordered.OrderBy(o => ordered);

            void removeModFromOtherList(Mod mod, int order)
            {
                foreach (var rule in ruleList.Where(c => c.Order < order))
                    rule.ModsOrdered.Remove(mod);
            }
        }
    }
}
