using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mass_Effect_Andromeda_Damage_Calculator
{
    struct gun
    {
        public gun(string iweaponName, float iBWD, float iImpactPercent, float imeleeBuiltInBonus, bool icanWeakspot, float iWeaponWeakspotBonus, int iburstSize, int inrPellets, int iequivalentROF, float irampUpDelay, bool ifireDuringRampUP, int irampedUpROf, int imagazineSize, byte iweaponClass, float ihipfirePenalty, float ivsShield, float ivsArmor, bool iinfiniteAmmo, float ireloadDuration, 
            float irechargeFrom1BulletInClip, bool ilowMag, float ilowMagMul, bool imagazineDamageBonus, bool ifullyChargedVenom, int inrExtraChargedVenomProjectiles, float ichargedVenomProjectileMultiplier, bool bleedI)
        {
            weaponName = iweaponName;
            BWD = iBWD; // base weapon damage
            ImpactPercent = iImpactPercent; // default *1 ; *0.4 for naladen (changed in patch) 0.7 for kishock 
            meleeBuiltInBonus = imeleeBuiltInBonus; // 0.1 ruzad  0 all others
            canWeakspot = icanWeakspot; // most explosive weapons cannot
            WeaponWeakspotBonus = iWeaponWeakspotBonus; // 0 ; 0.25 ; 0.7 
            burstSize = iburstSize; // 1 or 2 or 3
            nrPellets = inrPellets; // 1 or pellet shotguns
            equivalentROF = iequivalentROF;
            rampUpDelay = irampUpDelay; // default 0 , Cyclone & Soned & Rozerad
            fireDuringRampUP = ifireDuringRampUP; // snoned cyclone false ; Rozerad true
            rampedUpROf = irampedUpROf; // rozerad
            magazineSize = imagazineSize;
            weaponClass = iweaponClass; // 1 pistols , 2 SR , 3 Shotguns, 4 Assault 
            hipfirePenalty = ihipfirePenalty; // default 1
            vsShield = ivsShield;
            vsArmor = ivsArmor; //default 1
            infiniteAmmo = iinfiniteAmmo;
            reloadDuration = ireloadDuration; // for infinite clip overheat duration; needed for sustained DPS
            rechargeFrom1BulletInClip = irechargeFrom1BulletInClip;
            lowMag = ilowMag; // default false cyclone
            lowMagMul = ilowMagMul; // default 1 ; *1.5 multiplier
            magazineDamageBonus = imagazineDamageBonus; // default false , enables additive damage bonus for shadow
            fullyChargedVenom = ifullyChargedVenom; //  default false                    // charge up
            nrExtraChargedVenomProjectiles = inrExtraChargedVenomProjectiles; //
            chargedVenomProjectileMultiplier = ichargedVenomProjectileMultiplier; // 0.667  
            bleed = bleedI;
        }

        public string weaponName { get; } // weapon's name
        public float BWD { get; } // base weapon damage
        public float ImpactPercent { get; } // default *1 ; *0.4 for naladen
        public float meleeBuiltInBonus { get; } // 0.1 ruzad  0 all others
        public bool canWeakspot { get; } // most explosive weapons cannot
        public float WeaponWeakspotBonus { get; } // 0 ; 0.25 ; 0.7 
        public int burstSize { get; } // 1 or 2 or 3
        public int nrPellets { get; } // 1 or pellet shotguns
        public int equivalentROF { get; }
        public float rampUpDelay { get; } // default 0 , Cyclone & Soned & Rozerad
        public bool fireDuringRampUP { get; } // snoned cyclone false ; Rozerad true
        public int rampedUpROf { get; } // rozerad
        public int magazineSize { get; }
        public byte weaponClass { get; } // 1 pistols , 2 SR , 3 Shotguns, 4 Assault 
        public float hipfirePenalty { get; } // default 1
        public float vsShield { get; } //default 1
        public float vsArmor { get; }
        public bool infiniteAmmo { get; }
        public float reloadDuration { get; } // for infinite clip overheat duration;  needed for sustained DPS
        public float rechargeFrom1BulletInClip { get; }
        public bool lowMag { get; } // default false cyclone
        public float lowMagMul { get; } // default 1 ; *1.5 multiplier
        public bool magazineDamageBonus { get; } // default false , enables additive damage bonus for shadow
        public bool fullyChargedVenom { get; } //  default false                    // charge up
        public int nrExtraChargedVenomProjectiles { get; } //
        public float chargedVenomProjectileMultiplier { get; } // 0.667  
        public bool bleed; // default false  kishock true
    }

   
        
  struct playingCharacter
    {
         public playingCharacter(string CharacterNameI, float BaseCharacterHealthI, float BaseCharacterShieldsI, float BaseCharacterMeleeDamageI , float CharacterMeleeBonusVsShieldsI, float CharacterMeleeBonusVsArmorI , float HiddenMeleeDamageBonusI, string SpecialMeleePrimeComboI,
            string Skill1NameI, string Skill1TextI, bool Skill1ToggleableI, string Skill1CooldownMaxDurationPassiveTempEtcI, string Skill1evo1I, string Skill1evo2I, string Skill1evo3I, string Skill1evo4aI, string Skill1evo4bI, string Skill1evo5aI, string Skill1evo5bI, string Skill1evo6aI, string Skill1evo6bI,
            string Skill2NameI, string Skill2TextI, bool Skill2ToggleableI, string Skill2CooldownMaxDurationPassiveTempEtcI, string Skill2evo1I, string Skill2evo2I, string Skill2evo3I, string Skill2evo4aI, string Skill2evo4bI, string Skill2evo5aI, string Skill2evo5bI, string Skill2evo6aI, string Skill2evo6bI,
            string Skill3NameI, string Skill3TextI, bool Skill3ToggleableI, string Skill3CooldownMaxDurationPassiveTempEtcI, string Skill3evo1I, string Skill3evo2I, string Skill3evo3I, string Skill3evo4aI, string Skill3evo4bI, string Skill3evo5aI, string Skill3evo5bI, string Skill3evo6aI, string Skill3evo6bI,
            string Skill4NameI, string Skill4TextI, bool Skill4ToggleableI, string Skill4CooldownMaxDurationPassiveTempEtcI, string Skill4evo1I, string Skill4evo2I, string Skill4evo3I, string Skill4evo4aI, string Skill4evo4bI, string Skill4evo5aI, string Skill4evo5bI, string Skill4evo6aI, string Skill4evo6bI,
            string Skill5NameI, string Skill5TextI, bool Skill5ToggleableI, string Skill5CooldownMaxDurationPassiveTempEtcI, string Skill5evo1I, string Skill5evo2I, string Skill5evo3I, string Skill5evo4aI, string Skill5evo4bI, string Skill5evo5aI, string Skill5evo5bI, string Skill5evo6aI, string Skill5evo6bI)
        {
            CharacterName = CharacterNameI;
            BaseCharacterHealth = BaseCharacterHealthI;
            BaseCharacterShields = BaseCharacterShieldsI;
            BaseCharacterMeleeDamage = BaseCharacterMeleeDamageI;
            CharacterMeleeBonusVsShields = CharacterMeleeBonusVsShieldsI;
            CharacterMeleeBonusVsArmor = CharacterMeleeBonusVsArmorI;
            HiddenMeleeDamageBonus = HiddenMeleeDamageBonusI;
            SpecialMeleePrimeCombo = SpecialMeleePrimeComboI;

            Skill1Name = Skill1NameI;
            Skill1Text = Skill1TextI;
            Skill1Toggleable = Skill1ToggleableI;
            Skill1CooldownMaxDurationPassiveTempEtc = Skill1CooldownMaxDurationPassiveTempEtcI;
            Skill1evo1 = Skill1evo1I;
            Skill1evo2 = Skill1evo2I;
            Skill1evo3 = Skill1evo3I;
            Skill1evo4a = Skill1evo4aI;
            Skill1evo4b = Skill1evo4bI;
            Skill1evo5a = Skill1evo5aI;
            Skill1evo5b = Skill1evo5bI;
            Skill1evo6a = Skill1evo6aI;
            Skill1evo6b = Skill1evo6bI;

            Skill2Name = Skill2NameI;
            Skill2Text = Skill2TextI;
            Skill2Toggleable = Skill2ToggleableI;
            Skill2CooldownMaxDurationPassiveTempEtc = Skill2CooldownMaxDurationPassiveTempEtcI;
            Skill2evo1 = Skill2evo1I;
            Skill2evo2 = Skill2evo2I;
            Skill2evo3 = Skill2evo3I;
            Skill2evo4a = Skill2evo4aI;
            Skill2evo4b = Skill2evo4bI;
            Skill2evo5a = Skill2evo5aI;
            Skill2evo5b = Skill2evo5bI;
            Skill2evo6a = Skill2evo6aI;
            Skill2evo6b = Skill2evo6bI;

            Skill3Name = Skill3NameI;
            Skill3Text = Skill3TextI;
            Skill3Toggleable = Skill3ToggleableI;
            Skill3CooldownMaxDurationPassiveTempEtc = Skill3CooldownMaxDurationPassiveTempEtcI;
            Skill3evo1 = Skill3evo1I;
            Skill3evo2 = Skill3evo2I;
            Skill3evo3 = Skill3evo3I;
            Skill3evo4a = Skill3evo4aI;
            Skill3evo4b = Skill3evo4bI;
            Skill3evo5a = Skill3evo5aI;
            Skill3evo5b = Skill3evo5bI;
            Skill3evo6a = Skill3evo6aI;
            Skill3evo6b = Skill3evo6bI;
            
            Skill4Name = Skill4NameI;
            Skill4Text = Skill4TextI;
            Skill4Toggleable = Skill4ToggleableI;
            Skill4CooldownMaxDurationPassiveTempEtc = Skill4CooldownMaxDurationPassiveTempEtcI;
            Skill4evo1 = Skill4evo1I;
            Skill4evo2 = Skill4evo2I;
            Skill4evo3 = Skill4evo3I;
            Skill4evo4a = Skill4evo4aI;
            Skill4evo4b = Skill4evo4bI;
            Skill4evo5a = Skill4evo5aI;
            Skill4evo5b = Skill4evo5bI;
            Skill4evo6a = Skill4evo6aI;
            Skill4evo6b = Skill4evo6bI;


            Skill5Name = Skill5NameI;
            Skill5Text = Skill5TextI;
            Skill5Toggleable = Skill5ToggleableI;
            Skill5CooldownMaxDurationPassiveTempEtc = Skill5CooldownMaxDurationPassiveTempEtcI;
            Skill5evo1 = Skill5evo1I;
            Skill5evo2 = Skill5evo2I;
            Skill5evo3 = Skill5evo3I;
            Skill5evo4a = Skill5evo4aI;
            Skill5evo4b = Skill5evo4bI;
            Skill5evo5a = Skill5evo5aI;
            Skill5evo5b = Skill5evo5bI;
            Skill5evo6a = Skill5evo6aI;
            Skill5evo6b = Skill5evo6bI;


        } // end MEGA CONSTRUCTOR

        public string CharacterName { get; }
        public float BaseCharacterHealth { get; }
        public float BaseCharacterShields { get; }
        public float BaseCharacterMeleeDamage { get; }
        public float CharacterMeleeBonusVsShields { get; }  // default 1
        public float CharacterMeleeBonusVsArmor { get; }    // default 1
        public float HiddenMeleeDamageBonus { get; } // default 0 , Mercenary 0.5f , Gladiator 0.25f 
        public string SpecialMeleePrimeCombo  { get; } 
 
       // Skill 1
       //common info to all evos
        public string Skill1Name { get; }
        public string Skill1Text { get; }
        public bool Skill1Toggleable { get; }
        public string Skill1CooldownMaxDurationPassiveTempEtc{ get; }
        public string Skill1evo1{ get; }
        public string Skill1evo2{ get; }
        public string Skill1evo3{ get; }
        public string Skill1evo4a{ get; }
        public string Skill1evo4b{ get; }
        public string Skill1evo5a{ get; }
        public string Skill1evo5b{ get; }
        public string Skill1evo6a{ get; }
        public string Skill1evo6b{ get; }

        // Skill 2
        public string Skill2Name{ get; }
        public string Skill2Text{ get; }
        public bool Skill2Toggleable { get; }
        public string Skill2CooldownMaxDurationPassiveTempEtc{ get; }
        public string Skill2evo1{ get; }
        public string Skill2evo2{ get; }
        public string Skill2evo3{ get; }
        public string Skill2evo4a{ get; }
        public string Skill2evo4b{ get; }
        public string Skill2evo5a{ get; }
        public string Skill2evo5b{ get; }
        public string Skill2evo6a{ get; }
        public string Skill2evo6b{ get; }

        // Skill 3
        public string Skill3Name{ get; }
        public string Skill3Text{ get; }
        public bool Skill3Toggleable { get; }
        public string Skill3CooldownMaxDurationPassiveTempEtc{ get; }
        public string Skill3evo1{ get; }
        public string Skill3evo2{ get; }
        public string Skill3evo3{ get; }
        public string Skill3evo4a{ get; }
        public string Skill3evo4b{ get; }
        public string Skill3evo5a{ get; }
        public string Skill3evo5b{ get; }
        public string Skill3evo6a{ get; }
        public string Skill3evo6b{ get; }

        // Skill 4 passive
        public string Skill4Name{ get; }
        public string Skill4Text{ get; }
        public bool Skill4Toggleable { get; }
        public string Skill4CooldownMaxDurationPassiveTempEtc{ get; }
        public string Skill4evo1{ get; }
        public string Skill4evo2{ get; }
        public string Skill4evo3{ get; }
        public string Skill4evo4a{ get; }
        public string Skill4evo4b{ get; }
        public string Skill4evo5a{ get; }
        public string Skill4evo5b{ get; }
        public string Skill4evo6a{ get; }
        public string Skill4evo6b{ get; }

        // Skill 5 fitness
        public string Skill5Name{ get; }
        public string Skill5Text{ get; }
        public bool Skill5Toggleable { get; }
        public string Skill5CooldownMaxDurationPassiveTempEtc{ get; }
        public string Skill5evo1{ get; }
        public string Skill5evo2{ get; }
        public string Skill5evo3{ get; }
        public string Skill5evo4a{ get; }
        public string Skill5evo4b{ get; }
        public string Skill5evo5a{ get; }
        public string Skill5evo5b{ get; }
        public string Skill5evo6a{ get; }
        public string Skill5evo6b{ get; }

    }

    struct GearPiece
    {
        public GearPiece(string gearNameI, string gearEffectsI)
        {
            gearName = gearNameI;
            gearEffects = gearEffectsI;
        }

        public string gearName { get; }
        public string gearEffects { get; }
    }

    struct WeaponAddon
    {
        public WeaponAddon(string AddOnNameI, string AddOnEffectsI, int AddOnWeaponClassI, int AddOnGroupI)
        {
            AddOnName = AddOnNameI;
            AddOnEffects = AddOnEffectsI;
            AddOnWeaponClass = AddOnWeaponClassI;
            AddOnGroup = AddOnGroupI;
        }

        public string AddOnName { get; }
        public string AddOnEffects { get; }
        public int AddOnWeaponClass { get; } // 1 Pistol/2 SR/ 3 SG/ 4 AR
        public int AddOnGroup { get; } //  1 Barrels, 2 Magazine, 3 stocks, 4 receivers, 5, scopes,  6 melee mods, 7 chokes, 8 spare ammo, 9 materials
    }

    struct Booster
    {
        public Booster(string BoosterNameI, string BoosterEffectsI, int BoosterGroupI)
        {
            BoosterName = BoosterNameI;
            BoosterEffects = BoosterEffectsI;
            BoosterGroup = BoosterGroupI;
        }

        public string BoosterName { get; }
        public string BoosterEffects { get; }
        public int BoosterGroup{ get; }  // 1 ammo, 2 weapon, 3 offensive, 4 defensive; 5 power
    }

    struct APEXModifiers
    {
        public APEXModifiers(string APEXModNameI, string APEXModEffectsI)
        {
            APEXModName = APEXModNameI;
            APEXModEffects = APEXModEffectsI;
        }

        public string APEXModName { get; }
        public string APEXModEffects { get; }
    }

    /// <summary>
    /// /Enemy database
    /// </summary>
    struct EnemyStats
    {
        public EnemyStats(string enemyNameI,float maxHealthI, float maxShieldsI, float maxArmorI, float baseWeak1I, float baseWeak2I, int difficultyI, int factionI, bool isSynthI)
        {
            enemyName = enemyNameI; 
            maxHealth = maxHealthI;
            maxShields = maxShieldsI;
            maxArmor = maxArmorI;
            baseWeak1 = baseWeak1I;
            baseWeak2 = baseWeak2I;
            difficulty = difficultyI;
            faction = factionI;
            isSynth = isSynthI;
            }

       public string enemyName { get; }
       public float maxHealth { get; }
       public float maxShields { get; }
       public float maxArmor { get; }
       public float baseWeak1 { get; }
       public float baseWeak2 { get; }
       public int difficulty { get; }  // 1 bronze; 2 silver ; 3 gold ; 4 platinum
       public int faction { get; } // 1 outlaw 2 kett 3 remnant
       bool isSynth { get; }

    }


    public partial class Form1 : Form
    {
        // my init crap here ?

        // init guns struct array
        const int constNrGuns = 10;
        private gun[] myGunArray = new gun[constNrGuns]
             {                      //  1 pistols , 2 SR , 3 Shotguns, 4 Assault 
                   new gun("Avenger I", 39, 1, 0, true, 0, 1, 1, 525, 0, true, 525, 30, 4, 1, 1, 1, false, 1.5f, 0, false, 1, false, false, 0, 0, false),
                   new gun("Avenger X", 52, 1, 0, true, 0, 1, 1, 525, 0, true, 525, 30, 4, 1, 1, 1, false, 1.5f, 0, false, 1, false, false, 0, 0, false),
                   new gun("Predator I", 54 , 1, 0,true, 0.25f, 1, 1, 450, 0, true, 450, 15, 1, 1, 1, 1, false, 1.4f, 0, false, 1, false, false, 0, 0, false),
                   new gun("Predator X", 72 , 1, 0,true, 0.25f, 1, 1, 450, 0, true, 450, 15, 1, 1, 1, 1, false, 1.4f, 0, false, 1, false, false, 0, 0, false),
                   new gun("Viper I", 321 , 1, 0,true, 0.7f, 1, 1, 90, 0, true, 90, 3, 2, 0.5f, 1, 1, false, 2.25f, 0, false, 1, false, false, 0, 0, false),
                   new gun("Viper X", 427 , 1, 0,true, 0.7f, 1, 1, 90, 0, true, 90, 3, 2, 0.5f, 1, 1, false, 2.25f, 0, false, 1, false, false, 0, 0, false),
                   new gun("Katana I", 64, 1, 0, true, 0, 1, 7, 85, 0, true, 85, 5, 3, 1, 1, 1.25f, false, 1.9f, 0, false, 1, false, false, 0, 0, false),
                   new gun("Katana X", 85, 1, 0, true, 0, 1, 7, 85, 0, true, 85, 5, 3, 1, 1, 1.25f, false, 1.9f, 0, false, 1, false, false, 0, 0, false),
                   new gun("Ruzad I", 171, 1,0.1f,true ,0,1,5, 70,0,true,70,3,3,1,1,1.25f,false,2.5f,0,false,1,false,false,0,0,false),
                   new gun("Ruzad X", 171, 1,0.1f,true ,0,1,5, 70,0,true,70,3,3,1,1,1.25f,false,2.5f,0,false,1,false,false,0,0,false)

                };

        // init char struct array
        const int constNumberChars = 25; // number of playable characters
        private playingCharacter[] playingCharactersArray = new playingCharacter[constNumberChars]
             {
                  new playingCharacter("Human Soldier", 500f, 250f, 400f, 0f, 0f, 0f, "" ,
                     "Frag Grenade", "frag grenade description", false, "BaseDam=1000;Cooldown=0;AnimDur=0.9", "1", "2", "Dam=0.3", "4a", "Dam=0.4", "5a", "BaseDOTDam=100;BaseDOTDur=6", "vsArmor=0.8","vsShields=1",
                     "Turbocharge", "turbocharge description", true, "Duration=8;Recharge=0.2", "WD=0.1;ROF=0.2;MAG=0.2", "Recharge=0.1", "WD=0.1", "Recharge=0.2", "Duration=0.5", "WD=0.15", "5b", "ROF=0.2;MAG=0.2","MAG=0.8",
                     "Concussive Shot", "concussive shot description", false, "BaseDam=440;Recharge=10;Detonator=1", "1", "2", "Dam=0.35", "Recharge=0.3", "Repeat", "5a","Dam=0.5", "vsArmor=1.25", "vsShields=1",
                     "Munitions Training", "munitions training description", false, "", "WD=0.05", "PD=0.2", "WD=0.05;MD=0.2", "WD=0.08", "PD=0.2;MD=0.2", "TWD=0.2;TMD=0.3;EnableTCheck", "Reload=0.15;MAG=0.25", "TDebuff=0.24;EnableTCheck", "Weak=0.2",
                     "Combat Fitness", "combat fitness description", false, "", "Shields=0.1;Health=0.1", "MD=0.3", "Shields=0.15;Health=0.15", "Shields=0.25;Health=0.25", "MD=0.5", "TDR=0.5;EnableTCheck", "TDR=1;EnableTCheck", "TDR=2;EnableTCheck","TMD=0.65;EnableTCheck"),
                  new playingCharacter("Human Vanguard", 500f, 250f, 400f, 0f, 0f, 0f , "" ,
                     "Charge", "charge description", false, "BaseDam=275;Recharge=8", "1", "Recharge=0.35", "Dam=0.3", "Dam=0.4", "4b", "TWD=0.15;TMD=0.3;EnableTCheck", "PD=0.25;EnableTCheck", "Recharge=0.75","TDR=0.75;Dam=0.4;EnableTCheck",
                     "Nova", "Nova description", false, "BaseDam=420;Recharge=12", "1", "2", "Dam=0.3", "Dam=0.35", "4b", "vsArmor=1", "vsShields=1", "Dam=0.5;BioticPrimer=HSA","6b",
                     "Shockwave", "shockwave description", false,  "BaseDam=400;Recharge=12;Detonator=0.5", "1", "Recharge=0.2", "Dam=0.3", "Dam=0.5", "4b", "Recharge=0.35", "5b", "vsArmor=0.75","BioticPrimer=H",
                     "Apex Training", "apex description", false, "", "WD=0.05", "PD=0.15", "WD=0.05;MD=0.2", "WD=0.08", "PD=0.2;MD=0.2", "Weak=0.2", "Combo=0.5", "WD=0.1","PD=0.15",
                     "Barrier", "Barrier description", false, "", "Shields=0.25", "2", "MD=0.3", "Shields=0.3", "4b", "5a", "MD=0.5", "6a","6b"),
                   new playingCharacter("Human Engineer", 500f, 250f, 400f, 0f, 0f, 0f , "" ,
                     "Cryo Beam", "cryo beam description", false, "BaseDam=150;Recharge=10;CryoPrimer=HA", "TArmorDebuff=0.5;EnableTCheck", "Recharge=0.1", "Dam=0.3", "Dam=0.5", "Recharge=0.3", "TArmorDebuff=0.65;EnableTCheck", "DamMul=1.25", "6a","6b",
                     "Assault Turret", "assault turret description", false,  "BaseDam=36;Recharge=0.3;DeathDam=400;CastDam=100;BaseHealth=400", "1", "ConHealth=0.5", "Dam=0.4", "ConHealth=0.75", "Recharge=2", "Dam=0.6", "TPRS=0.35;EnableTCheck", "Dam=0.6;TArmorDebuff=0.5;EnableTCheck;CryoPrimer=HA","BaseDam=275;BaseDOTDam=35;FlamevsArmor=0.6;DOTDuration=4;FirePrimer=HA",
                     "Overload", "overload description", false, "BaseDamage=200;BaseChargedDamage=300;BaseChainDamage=300;Chains=2;Recharge=12;Detonator=1;TechPrimer=HSA", "vsShields=1.25;vsSynth=0.3", "Recharge=0.1", "Dam=0.25", "Dam=0.35", "Recharge=0.25", "EChain=1", "vsShields=0.6", "vsShields=0.6;vsSynth=0.15","Dam=0.3;EChain=1",
                     "Offensive Tech", "offensive tech description", false, "", "PD=0.1", "WD=0.08;MD=0.2", "PD=0.15;ConDam=0.2", "PD=0.25;PEffectDur=0.2", "Combo=0.5", "vsShields=0.4", "vsArmor=0.4", "ET=0.35","MD=0.2",
                     "Support Systems", "support systems description", false, "", "1", "Health=0.2;Shields=0.2;ConHealth=0.15", "MD=0.3", "PEffectDur=0.3", "4a", "Health=0.2;Shields=0.2;ConHealth=0.2", "TDR=1.2;EnableTCheck", "6a","6b"),
                   new playingCharacter("Human Adept", 500f, 250f, 400f, 0f, 0f, 0f , "" ,
                     "Pull", "pull description", false, "Duration=5;Recharge=8;BioticPrimer=H", "1", "Recharge=0.3", "Duration=0.4", "Duration=0.5", "4b", "BaseDOTDam=60", "TDebuff=0.3;EnableTCheck", "BaseDamage=600","6b",
                     "Singularity", "singularity description", false, "BaseDOTDamage=35;Duration=8;Recharge=20;BioticPrimer=HSA", "1", "Recharge=0.1", "Dam=1", "Duration=0.4", "4b", "vsShields=1", "Recharge=0.4", "BaseDamage=700","6b",
                     "Shockwave", "shockwave description", false, "BaseDam=400;Recharge=12;Detonator=0.5", "1", "Recharge=0.2", "Dam=0.3", "Dam=0.5", "4b", "Recharge=0.35", "5b", "vsArmor=0.75","BioticPrimer=H",
                     "Offensive Biotics", "offensive biotics description", false, "" , "PD=0.1", "WD=0.05", "PD=0.15", "PD=0.15", "PRS=0.25", "TDebuff=0.2;EnableTCheck", "Combo=0.5", "TBPD=0.4;EnableTCheck", "TWD=0.15;TMD=0.5;EnableTCheck",
                     "Barrier", "barrier description", false, "", "Shields=0.25", "2", "MD=0.3", "Shields=0.3", "4b", "TShields=0.4;EnableTCheck", "MD=0.5", "6a","6b"),
                    new playingCharacter("Human Sentinel", 500f, 250f, 400f, 0f, 0f, 0f , "" ,
                     "Throw", "throw description", false, "BaseDamage=50;BaseEDamage=240,Recharge=8;Detonator=1;BioticPrimer=H", "1", "Recharge=0.25", "Dam=0.35", "Dam=0.45", "4b", "5a", "Recharge=0.3", "6a","Detonator=1.3;Recharge=0.5",
                     "Barricade", "barricade description", false, "Duration=13;Cooldown=1", "1", "2", "Duration=0.25", "Duration=0.35", "4b", "5a", "5b", "6a","BaseDamage=125;vsShields=1;vsSynth=0.15",
                     "Energy Drain", "energy drain description", false, "BaseDamage=175;RShields=0.35;Recharge=12;Detonator=1", "vsShields=1;vsSynth=0.15", "Recharge=0.1", "Dam=0.25;RShields=0.15", "Dam=0.3;RShields=0.2", "Recharge=0.3", "RSHOT=0.06;RSHOTDur=4;TechPrimer=HSA", "5b","Dam=0.35;vsShields=0.75;vsSynth=0.15", "RShields=0.25;AllyRShields=0.5",
                     "Weapon Training", "weapon training description", false, "", "WD=0.05", "PD=0.15", "WD=0.05;MD=0.2", "WD=0.08", "PD=0.2;MD=0.2", "Weak=0.2", "Combo=0.5", "WD=0.1","PD=0.2",
                     "Tech Armor", "tech armor description", false, "", "DR=0.1", "MD=0.3", "DR=0.15", "DR=0.2", "MD=0.35", "DR=0.2", "5b", "6a","TMD=0.6;TSupport=0.3;EnableTCheck"),
                    new playingCharacter("Human Infiltrator", 500f, 250f, 400f, 0f, 0f, 0f , "" ,
                     "Sticky Grenade", "stricky grenade description", false, "BaseDam=1100;Cooldown=0", "1", "2", "Dam=0.2", "Dam=0.3", "4b", "5a", "BaseDOTDam=65;BaseDOTDur=5", "vsArmor=0.65", "vsShields=65",
                     "Tactical Cloak", "tactical cloak description", true, "Duration=6.5;Recharge=12", "WD=0.5;PD=0.5;MD=0.75", "Recharge=0.15", "Duration=0.25", "Recharge=0.3", "WD=0.4;PD=0.5;MD=0.5", "Duration=0.5", "5b", "6a","6b",
                     "Incinerate", "incinerate description", false, "BaseDam=350;BaseDOTDam=45;BaseDOTDur=6;Recharge=12;FirePrimer=HA", "vsArmor=0.6", "Recharge=0.15", "DOTDam=0.35;IDam=0.35", "4a", "DOTDam=0.5;DOTDuration=0.5", "IDam=0.6", "vsArmor=0.65", "Detonator=1","6b",
                     "Munitions Training", "munitions training description", false, "", "WD=0.05", "PD=0.2", "WD=0.05;MD=0.2", "WD=0.08", "PD=0.2;MD=0.2", "TWD=0.2;TMD=0.3;EnableTCheck", "Reload=0.15;MAG=0.25", "TDebuff=0.24;EnableTCheck", "Weak=0.2",
                     "Combat Fitness", "combat fitness description", false, "", "Shields=0.1;Health=0.1", "MD=0.3", "Shields=0.15;Health=0.15", "Shields=0.25;Health=0.25", "MD=0.5", "TDR=0.5;EnableTCheck", "TDR=1;EnableTCheck", "TDR=2;EnableTCheck","TMD=0.65;EnableTCheck"),
                    new playingCharacter("Turian Soldier", 500f, 275f, 400f, 0f, 0f, 0f , "" ,
                     "Fortify", "fortification description", true, "Recharge=5", "DR=0.4", "Recharge=0.3", "DR=0.1", "DR=0.2", "4b", "5a", "MD=0.3", "TDR=0.5;EnableTCheck","BaseDamage=400;vsShields=0.6;Recharge=-0.5",
                     "Turbocharge", "turbocharge description", true,"Duration=8;Recharge=0.2", "WD=0.1;ROF=0.2;MAG=0.2", "Recharge=0.1", "WD=0.1", "Recharge=0.2", "Duration=0.5", "WD=0.15", "5b", "ROF=0.2;MAG=0.2","MAG=0.8",
                     "Frag Grenade", "frag grenade description", false, "BaseDam=1000;Cooldown=0;AnimDur=0.9", "1", "2", "Dam=0.3", "4a", "Dam=0.4", "5a", "BaseDOTDam=100;BaseDOTDur=6", "vsArmor=0.8","vsShields=1",
                     "Munitions Training", "munitions training description", false, "", "WD=0.05", "PD=0.2", "WD=0.05;MD=0.2", "WD=0.08", "MD=0.2", "TWD=0.2;TMD=0.3;EnableTCheck", "Reload=0.15;MAG=0.25", "TDebuff=0.24;EnableTCheck", "Weak=0.2",
                     "Combat Fitness", "combat fitness description", false, "", "Shields=0.1;Health=0.1", "MD=0.3", "Shields=0.15;Health=0.15", "Shields=0.25;Health=0.25", "MD=0.5", "TDR=0.5;EnableTCheck", "TDR=1;EnableTCheck", "TDR=2;EnableTCheck","TMD=0.65;EnableTCheck"),
                    new playingCharacter("Krogan Vanguard", 600f, 150f, 740f, 0f, 0f, 0f , "" ,
                     "Charge", "charge description", false, "BaseDam=275;Recharge=8", "1", "Recharge=0.35", "Dam=0.3", "Dam=0.4", "4b", "TWD=0.15;TMD=0.3;EnableTCheck", "PD=0.25;EnableTCheck", "Recharge=0.75","TDR=0.75;Dam=0.4;EnableTCheck",
                     "Fortify", "fortification description", true, "Recharge=5", "DR=0.4", "Recharge=0.3", "DR=0.1", "DR=0.2", "4b", "5a", "MD=0.3", "TDR=0.5;EnableTCheck","BaseDamage=400;vsShields=0.6;Recharge=-0.5",
                     "Nova", "Nova description", false, "BaseDam=420;Recharge=12", "1", "2", "Dam=0.3", "Dam=0.35", "4b", "vsArmor=1", "vsShields=1", "Dam=0.5;BioticPrimer=HSA","6b",
                     "Apex Training", "apex description", false, "", "WD=0.05", "PD=0.15", "WD=0.05;MD=0.2", "WD=0.08", "PD=0.2;MD=0.2", "Weak=0.2", "Combo=0.5", "WD=0.1","PD=0.15",
                     "Rage", "rage description", true, "Duration=15", "RMD=0.25;RDR=0.15", "MD=0.15", "Shields=0.2;Health=0.2", "Shields=0.2;Health=0.2;RDR=0.15", "MD=0.25;RMD=0.065", "TDR=0.5;EnableTCheck", "TMD=0.65;EnableTCheck", "MD=0.25;RageDuration=0.5" , "AllyDR=0.3;Shields=0.2;Health=0.2"),
                    new playingCharacter("Krogan Engineer", 600f, 250f, 740f, 0f, 0f, 0f , "" ,
                     "Overload", "overload description", false, "BaseDamage=200;BaseChargedDamage=300;BaseChainDamage=300;Chains=2;Recharge=12;Detonator=1;TechPrimer=HSA", "vsShields=1.25;vsSynth=0.3", "Recharge=0.1", "Dam=0.25", "Dam=0.35", "Recharge=0.25", "EChain=1", "vsShields=0.6", "vsShields=0.6;vsSynth=0.15","Dam=0.3;EChain=1",
                     "Assault Turret", "assault turret description", false,  "BaseDam=36;Recharge=0.3;DeathDam=400;CastDam=100;BaseHealth=400", "1", "ConHealth=0.5", "Dam=0.4", "ConHealth=0.75", "Recharge=2", "Dam=0.6", "TPRS=0.35;EnableTCheck", "Dam=0.6;TArmorDebuff=0.5;EnableTCheck;CryoPrimer=HA","BaseDam=275;BaseDOTDam=35;FlamevsArmor=0.6;DOTDuration=4;FirePrimer=HA",
                     "Incinerate", "incinerate description", false, "BaseDam=350;BaseDOTDam=45;BaseDOTDur=6;Recharge=12;FirePrimer=HA", "vsArmor=0.6", "Recharge=0.15", "DOTDam=0.35;IDam=0.35", "4a", "DOTDam=0.5;DOTDuration=0.5", "IDam=0.6", "vsArmor=0.65", "Detonator=1","6b",
                     "Offensive Tech", "offensive tech description", false, "", "PD=0.1", "WD=0.08;MD=0.2", "PD=0.15;ConDam=0.2", "PD=0.25;PEffectDur=0.2", "Combo=0.5", "vsShields=0.4", "vsArmor=0.4", "ET=0.35","MD=0.2",
                     "Rage", "rage description", true, "Duration=15", "RMD=0.25;RDR=0.15", "MD=0.15", "Shields=0.2;Health=0.2", "Shields=0.2;Health=0.2;RDR=0.15", "MD=0.25;RMD=0.065", "TDR=0.5;EnableTCheck", "TMD=0.65;EnableTCheck", "MD=0.25;RageDuration=0.5" , "AllyDR=0.3;Shields=0.2;Health=0.2"),
                    new playingCharacter("Asari Sentinel", 475f, 250f, 400f, 0f, 0f, 0f , "" ,
                     "Backlash", "backlash description", false, "AegisHealth=400;Recharge=20;Returned=2", "TDR=0.75;EnableTCheck", "Recharge=0.25", "AegisHealth=0.35", "AegisHealth=0.5", "Recharge=0.4", "AegisHealth=0.5", "ReturnedMul=1.5", "6a","TWD=0.2;TPD=0.3;TMD=0.3;EnableTCheck",   // 5b *2 * (1 + 1.5) = *5
                     "Throw", "throw description", false, "BaseDamage=50;BaseEDamage=240,Recharge=8;Detonator=1;BioticPrimer=H", "1", "Recharge=0.25", "Dam=0.35", "Dam=0.45", "4b", "5a", "Recharge=0.3", "6a","Detonator=1.3;Recharge=0.5",
                     "Energy Drain", "energy drain description", false, "BaseDamage=175;RShields=0.35;Recharge=12;Detonator=1", "vsShields=1;vsSynth=0.15", "Recharge=0.1", "Dam=0.25;RShields=0.15", "Dam=0.3;RShields=0.2", "Recharge=0.3", "RSHOT=0.06;RSHOTDur=4;TechPrimer=HSA", "5b","Dam=0.35;vsShields=0.75;vsSynth=0.15", "RShields=0.25;AllyRShields=0.5",
                     "Offensive Biotics", "offensive biotics description", false, "" , "PD=0.1", "WD=0.05", "PD=0.15;MD=0.15", "PD=0.25", "PRS=0.25", "TWD=0.1;TMD=0.3;EnableTCheck", "Combo=0.5", "TBPD=0.4;EnableTCheck", "TWD=0.15;TMD=0.5;EnableTCheck",
                     "Tech Armor", "tech armor description", false, "", "DR=0.1", "MD=0.3", "DR=0.15", "DR=0.2", "MD=0.35", "DR=0.2", "5b", "6a","TMD=0.6;TSupport=0.3;EnableTCheck"),
                    new playingCharacter("Salarian Inflitrator", 425f, 270f, 400f, 0f, 0f, 0f , "" ,
                     "Sticky Grenade", "stricky grenade description", false, "BaseDam=1100;Cooldown=0", "1", "2", "Dam=0.2", "Dam=0.3", "4b", "5a", "BaseDOTDam=65;BaseDOTDur=5", "vsArmor=0.65", "vsShields=65",
                     "Tactical Cloak", "tactical cloak description", true, "Duration=6.5;Recharge=12", "WD=0.5;PD=0.5;MD=0.75", "Recharge=0.15", "Duration=0.25", "Recharge=0.3", "WD=0.4;PD=0.5;MD=0.5", "Duration=0.5", "5b", "6a","6b",
                     "Energy Drain", "energy drain description", false, "BaseDamage=175;RShields=0.35;Recharge=12;Detonator=1", "vsShields=1;vsSynth=0.15", "Recharge=0.1", "Dam=0.25;RShields=0.15", "Dam=0.3;RShields=0.2", "Recharge=0.3", "RSHOT=0.06;RSHOTDur=4;TechPrimer=HSA", "5b","Dam=0.35;vsShields=0.75;vsSynth=0.15", "RShields=0.25;AllyRShields=0.5",
                     "Offensive Tech", "offensive Tech description", false, "", "PD=0.1", "WD=0.08;MD=0.2", "PD=0.15", "PD=0.2;PEffectDur=0.2", "Combo=0.5", "vsShields=0.4", "vsArmor=0.4", "TWD=0.3;EnableTCheck","MD=0.2",
                     "Support Systems", "Support Systems description", false, "", "1", "Shields=0.2;Health=0.2", "MD=0.3", "PEffectDur=0.3", "MD=0.4", "Shields=0.2;Health=0.2", "TDR=1.2;EnableTCheck", "6a","6b"),
                    new playingCharacter("Asari Adept", 475f, 200f, 400f, 0f, 0f, 0f , "" ,
                     "Throw", "throw description", false, "BaseDamage=50;BaseEDamage=240,Recharge=8;Detonator=1;BioticPrimer=H", "1", "Recharge=0.25", "Dam=0.35", "Dam=0.45", "4b", "5a", "Recharge=0.3", "6a","Detonator=1.3;Recharge=0.5",
                     "Annihilation", "annihilation description", true, "BaseDOTDam=50;Recharge=8;BioticPrimer=HSA", "PRP=0.75", "PRP=-0.1", "Dam=0.15", "4a", "PRP=-0.3", "TDebuff=0.2;EnableTCheck", "5b", "6a","6b",   // DO POWER RECHARGE SPEED AND  ANNI PENALTY STACK ADDITIVELY ?? Toggle recharge pen
                     "Lance", "Lance description", false, "BaseDam=400;Detonator=1;Recharge=10", "1", "Recharge=0.1", "Dam=0.25", "Dam=0.3", "4b", "LWeak=0.4", "vsShields=0.35","Dam=0.3","Cost=0.45",
                     "Offensive Biotics", "offensive biotics description", false, "" , "PD=0.1", "WD=0.05", "PD=0.15", "PD=0.25", "PRS=0.25", "TDebuff=0.2;EnableTCheck", "Combo=0.5", "TBPD=0.4;EnableTCheck", "TWD=0.15;TMD=0.5;EnableTCheck",
                     "Barrier", "barrier description", false, "", "Shields=0.25", "2", "MD=0.3", "Shields=0.3", "4b", "TShields=0.4;EnableTCheck", "MD=0.5", "6a","6b"),
                    new playingCharacter("Krogan Mercenary", 700f, 300f, 740f, 0f, 0f, 0.5f , "" ,
                     "Flamethrower", "flamerthrow description", false, "BaseSDam=275;BaseDOTDam=200;BaseDOTDur=5;Recharge=12;FirePrimer=HA", "vsArmor=0.25", "Recharge=0.2", "IDam=0.25;DOTDam=0.25", "IDam=0.4;DOTDam=0.4", "Recharge=0.3", "5a", "DOTDam=0.5;DOTDuration=0.5", "vsArmor=0.8","6b",
                     "Fortify", "fortification description", true, "Recharge=5", "DR=0.4", "Recharge=0.3", "DR=0.1", "DR=0.2", "4b", "5a", "MD=0.3", "TDR=0.5;EnableTCheck","BaseDamage=400;vsShields=0.6;Recharge=-0.5",
                     "Flak Cannon", "Flak description", false, "BaseDamage=250;SBase=85;Cooldown=1", "SvsArmor=-0.3", "2", "Dam=0.4", "Dam=0.5", "4b", "vsArmor=0.75", "5b", "NrSrapnel=0.5","BaseDOTDam=100;BaseDOTDur=8",
                     "Munitions Training", "munitions training description", false, "", "WD=0.05", "PD=0.2", "WD=0.05;MD=0.2", "WD=0.08", "PD=0.2;MD=0.2", "TWD=0.2;TMD=0.3;EnableTCheck", "Reload=0.15;MAG=0.25", "TDebuff=0.24;EnableTCheck", "Weak=0.2",
                     "Rage", "rage description", true, "Duration=15", "RMD=0.25;RDR=0.15", "MD=0.15", "Shields=0.2;Health=0.2", "Shields=0.2;Health=0.2;RDR=0.15", "MD=0.25;RMD=0.065", "TDR=0.5;EnableTCheck", "TMD=0.65;EnableTCheck", "MD=0.25;RageDuration=0.5" , "AllyDR=0.3;Shields=0.2;Health=0.2"),
                   new playingCharacter("Turian Havok Trooper", 500f, 350f, 400f, 0f, 0f, 0f , "" ,
                     "Incinerate", "incinerate description", false, "BaseDam=350;BaseDOTDam=45;BaseDOTDur=6;Recharge=12;FirePrimer=HA", "vsArmor=0.6", "Recharge=0.15", "DOTDam=0.35;IDam=0.35", "4a", "DOTDam=0.5;DOTDuration=0.5", "IDam=0.6", "vsArmor=0.65", "Detonator=1","6b",
                     "Turbocharge", "turbocharge description", true, "Duration=8;Recharge=0.2", "WD=0.1;ROF=0.2;MAG=0.2", "Recharge=0.1", "WD=0.1", "Recharge=0.2", "Duration=0.5", "WD=0.15", "5b", "ROF=0.2;MAG=0.2","MAG=0.8",
                     "Flak Cannon", "Flak description", false, "BaseDamage=250;SBase=85;Cooldown=1", "SvsArmor=-0.3", "2", "Dam=0.4", "Dam=0.5", "4b", "vsArmor=0.75", "5b", "NrSrapnel=0.5","BaseDOTDam=100;BaseDOTDur=8",
                     "Munitions Training", "munitions training description", false, "", "WD=0.05", "PD=0.2", "WD=0.05;MD=0.2", "WD=0.08", "PD=0.2;MD=0.2", "TWD=0.2;TMD=0.3;EnableTCheck", "Reload=0.15;MAG=0.25", "TDebuff=0.24;EnableTCheck", "Weak=0.2",
                     "Aerial Assault", "aerial assault description", false, "", "Shields=0.1;Health=0.1", "TDR=1;EnableTCheck", "Shields=0.15;Health=0.15", "4a", "Shields=0.25;Health=0.25", "TDR=1;EnableTCheck", "MD=0.6", "TDR=1;EnableTCheck", "Shields=0.25;Health=0.25;TMD=0.65;EnableTCheck"),
                   new playingCharacter("Asari Huntress", 475f, 250f, 400f, 0f, 0f, 0f , "" ,
                     "Throw", "throw description", false, "BaseDamage=50;BaseEDamage=240,Recharge=8;Detonator=1;BioticPrimer=H", "1", "Recharge=0.25", "Dam=0.35", "Dam=0.45", "4b", "5a", "Recharge=0.3", "6a","Detonator=1.3;Recharge=0.5",
                     "Stealth Grid", "Stealth Grid description", true, "Duration=8;Cooldown=1", "WD=0.3;PD=0.3;MD=0.5", "2", "Duration=0.3", "4a", "4b", "Duration=0.3", "5b", "6a","WD=0.5;PD=0.4;MD=05",
                     "Lance", "Lance description", false, "BaseDam=400;Detonator=1;Recharge=10", "1", "Recharge=0.1", "Dam=0.25", "Dam=0.3", "4b", "LWeak=0.4", "vsShields=0.35","Dam=0.3","Cost=0.45",
                     "Offensive Biotics", "offensive biotics description", false, "" , "PD=0.1", "WD=0.05", "PD=0.15;MD=0.15", "PD=0.25", "PRS=0.25", "TWD=0.1;TMD=0.3;EnableTCheck", "Combo=0.5", "TBPD=0.4;EnableTCheck", "TWD=0.15;TMD=0.5;EnableTCheck",
                     "Barrier", "Barrier description", false, "", "Shields=0.25", "2", "MD=0.3", "Shields=0.3", "4b", "5a", "MD=0.5", "6a","6b"),
                   new playingCharacter("Angara Insurgent", 550f, 250f, 550f, 0f, 1f, 0f , "" ,
                     "Shield Boost", "sb description", false, "BaseHeal=125;BaseHOT=50;BaseHOTDur=3;Recharge=15", "1", "Recharge=0.1", "IHeal=0.2;HOT=0.2", "4a", "HOT=0.35", "Recharge=0.35", "IHeal=0.3", "TShields=1;EnableTCheck","HOTDur=1.5",
                     "Assault Turret", "assault turret description", false,  "BaseDam=36;Recharge=0.3;DeathDam=400;CastDam=100;BaseHealth=400", "1", "ConHealth=0.5", "Dam=0.4", "ConHealth=0.75", "Recharge=2", "Dam=0.6", "TPRS=0.35;EnableTCheck", "Dam=0.6;TArmorDebuff=0.5;EnableTCheck;CryoPrimer=HA","BaseDam=275;BaseDOTDam=35;FlamevsArmor=0.6;DOTDuration=4;FirePrimer=HA",
                     "Trip Mine", "Trip Mine description", false, "BaseDam=1300;Cooldown=1", "1", "2", "Dam=0.15", "4a", "4b", "Dam=0.3", "5b", "Detonator=1.3","TechPrimer=HSA;vsShields=0.35",
                     "Offensive Tech", "offensive tech description", false, "" ,"PD=0.1", "WD=0.08;MD=0.2", "PD=0.15", "PD=0.25;PEffectDur=0.2", "Combo=0.5", "vsShields=0.4", "vsArmor=0.4", "6a","MD=0.2",
                     "Bioelectric Defence", "bioelectric defense description", false, "", "Shields=0.15;Health=0.15", "MD=0.3", "Shields=0.15;Health=0.15", "4a", "4b", "5a", "Support=0.3;ConDam=0.25;ConHealth=0.3", "TDR=0.8;EnableTCheck","TMD=0.65;EnableTCheck"),
                    new playingCharacter("Salarian Architect", 425f, 270f, 400f, 0f, 0f, 0f , "CryoPrimer=HA" ,
                     "Remnant VI", "remanat VI description", false, "BaseDam=15;Recharge=18;BaseHealth=800", "1", "ConHealth=0.5", "Dam=0.5", "4a", "Recharge=0.4", "Dam=0.8", "ConHealth=2", "BaseDamage=450;Detonator=1;MissileROF=6","Dam=0.5;vsShield=0;vsSynth=0.15;TechPrimer=HSA",
                     "Barricade", "barricade description", false, "Duration=13,Cooldown=1", "1", "2", "Duration=0.25", "Duration=0.35", "4b", "5a", "5b", "6a","BaseDamage=125;vsShields=1;vsSynth=0.15",
                     "Incinerate", "incinerate description", false, "BaseDam=350;BaseDOTDam=45;BaseDOTDur=6;Recharge=12;FirePrimer=HA", "vsArmor=0.6", "Recharge=0.15", "DOTDam=0.35;IDam=0.35", "4a", "DOTDam=0.5;DOTDuration=0.5", "IDam=0.6", "vsArmor=0.65", "Detonator=1","6b",
                     "Offensive Tech", "offensive tech description", false, "", "PD=0.1", "WD=0.08;MD=0.2", "PD=0.15;ConDam=0.2", "PD=0.25;PEffectDur=0.2", "Combo=0.5", "vsShields=0.4", "vsArmor=0.4", "ET=0.35", "MD=0.2",
                     "Support Systems", "support systems description", false, "", "1", "Health=0.2;Shields=0.2;ConHealth=0.15", "MD=0.3", "PEffectDur=0.3", "4a", "Health=0.2;Shields=0.2;ConHealth=0.2", "TDR=1.2;EnableTCheck", "6a","6b"),
                    new playingCharacter("Turian Agent", 500f, 250f, 400f, 0f, 0f, 0f , "" ,
                     "Recon Visor", "recon visor description", true, "Duration=12;Recharge=12", "PEN=0.6", "2", "PEN=0.25", "Recharge=0.3", "4b", "5a", "Duration=0.5", "6a","TArmorDebuff=0.25;EnableTCheck",
                     "Tactical Cloak", "tactical cloak description", true, "Duration=6.5;Recharge=12", "WD=0.5;PD=0.5;MD=0.75", "Recharge=0.15", "Duration=0.25", "Recharge=0.3", "WD=0.4;PD=0.5;MD=0.5", "Duration=0.5", "5b", "6a","6b",
                     "Flamethrower", "flamerthrow description", false, "BaseSDam=275;BaseDOTDam=200;BaseDOTDur=5;Recharge=12;FirePrimer=HA", "vsArmor=0.25", "Recharge=0.2", "IDam=0.25;DOTDam=0.25", "IDam=0.4;DOTDam=0.4", "Recharge=0.3", "5a", "DOTDam=0.5;DOTDuration=0.5", "vsArmor=0.8","6b",
                     "Apex Training", "apex description", false, "", "WD=0.05", "PD=0.15", "WD=0.05;MD=0.2", "WD=0.08", "PD=0.2;MD=0.2", "Weak=0.2", "Combo=0.5", "WD=0.1","PD=0.15;SOmethingDUR",
                     "Support Systems", "Support Systems description", false, "", "1", "Shields=0.2;Health=0.2", "MD=0.3", "PEffectDur=0.3", "MD=0.4", "Shields=0.2;Health=0.2", "TDR=1.2;EnableTCheck", "6a","6b"),
                     new playingCharacter("Batarian Scrapper", 585f, 310f, 750f, 0f, 0f, 0f , "Detonator=0.7" ,
                     "Concussive Shot", "concussive shot description", false, "BaseDam=440;Recharge=10;Detonator=1", "1", "2", "Dam=0.35", "Recharge=0.3", "Repeat", "5a","Dam=0.5", "vsArmor=1.25", "vsShields=1",
                     "Snap Freeze", "Snap Freeze description", false, "BaseDamage=250;ColdDur=0.6;Recharge=12;CryoPrimer=HA", "TArmorDebuff=0.5;EnableTCheck", "Recharge=0.2", "Dam=0.3", "Dam=0.5", "4b", "5a", "TDebuff=0.2;EnableTCheck", "TArmorDebuff=0.65;EnableTCheck","6b",
                     "Flak Cannon", "Flak description", false, "BaseDamage=250;SBase=85;Cooldown=1", "SvsArmor=-0.3", "2", "Dam=0.4", "Dam=0.5", "4b", "vsArmor=0.75", "5b", "NrSrapnel=0.5","BaseDOTDam=100;BaseDOTDur=8",
                     "Munitions Training", "munitions training description", false, "", "WD=0.05", "PD=0.2", "WD=0.05;MD=0.2", "WD=0.08", "PD=0.2;MD=0.2", "TWD=0.2;TMD=0.3;EnableTCheck", "Reload=0.15;MAG=0.25", "TDebuff=0.24;EnableTCheck", "Weak=0.2",
                     "Combat Fitness", "combat fitness description", false, "", "Shields=0.1;Health=0.1", "MD=0.3", "Shields=0.15;Health=0.15", "Shields=0.25;Health=0.25", "MD=0.5", "TDR=0.5;EnableTCheck", "TDR=1;EnableTCheck", "TDR=2;EnableTCheck","TMD=0.65;EnableTCheck"),
                     new playingCharacter("Asari Duelist", 475f, 250f, 740f, 0f, 0f, 0f , "" ,
                     "Backlash", "backlash description", false, "AegisHealth=400;Recharge=20;Returned=2", "TDR=0.75;EnableTCheck", "Recharge=0.25", "AegisHealth=0.35", "AegisHealth=0.5", "Recharge=0.4", "AegisHealth=0.5", "ReturnedMul=1.5", "6a","TWD=0.2;TPD=0.3;TMD=0.3;EnableTCheck",   // 5b *2 * (1 + 1.5) = *5
                     "Charge", "charge description", false, "BaseDam=275;Recharge=8", "1", "Recharge=0.35", "Dam=0.3", "Dam=0.4", "4b", "TWD=0.15;TMD=0.3;EnableTCheck", "PD=0.25;EnableTCheck", "Recharge=0.75","TDR=0.75;Dam=0.4;EnableTCheck",
                     "Lance", "Lance description", false, "BaseDam=400;Detonator=1;Recharge=10", "1", "Recharge=0.1", "Dam=0.25", "Dam=0.3", "4b", "LWeak=0.4", "vsShields=0.35","Dam=0.3","Cost=0.45",
                     "Offensive Biotics", "offensive biotics description", false, "" , "PD=0.1", "WD=0.05", "PD=0.15;MD=0.15", "PD=0.25", "PRS=0.25", "TWD=0.1;TMD=0.3;EnableTCheck", "Combo=0.5", "TBPD=0.4;EnableTCheck", "TWD=0.15;TMD=0.5;EnableTCheck",
                     "Barrier", "Barrier description", false, "", "Shields=0.25", "2", "MD=0.3", "Shields=0.3", "4b", "5a", "MD=0.5", "6a","6b"),
                     new playingCharacter("Angara Avenger", 500f, 300f, 550f, 0f, 1f, 0f , "" ,
                     "Sticky Grenade", "stricky grenade description", false, "BaseDam=1100;Cooldown=0", "1", "2", "Dam=0.2", "Dam=0.3", "4b", "5a", "BaseDOTDam=65;BaseDOTDur=5", "vsArmor=0.65", "vsShields=65",
                     "Stealth Grid", "Stealth Grid description", true, "Duration=8;Cooldown=1", "WD=0.3;PD=0.3;MD=0.5", "2", "Duration=0.3", "4a", "4b", "Duration=0.3", "5b", "6a","WD=0.5;PD=0.4;MD=05",
                     "Avenger Strike", "avenger strike description", false, "BaseDamage=500;Recharge=12", "1", "Recharge=0.1", "Dam=0.25", "BaseDOTDam=40;BaseDOTDur=5", "Recharge=0.3", "Dam=0.4", "5b", "vsShields=0.35;vsSynth=0.15;TechPrimer=HSA","6b",
                     "Weapon Training", "weapon training description", false, "", "WD=0.05", "PD=0.15", "WD=0.05;MD=0.2", "WD=0.08", "PD=0.2;MD=0.2", "Weak=0.2", "Combo=0.5", "WD=0.1","PD=0.2",
                     "Bioelectric Defence", "bioelectric defense description", false, "", "Shields=0.15;Health=0.15", "MD=0.3", "Shields=0.15;Health=0.15", "4a", "4b", "5a", "MD=0.5", "TDR=0.8;EnableTCheck","TMD=0.65;EnableTCheck"),
                     new playingCharacter("Salarian Operator", 425f, 250f, 400f, 0f, 0f, 0f , "" ,
                     "Invasion", "Invasion description", false, "BaseDamage=30;Recharge=15;Duration=15", "TDebuff=0.3;EnableTCheck", "Recharge=0.1", "Duration=0.3", "Recharge=0.4", "4b", "Duration=0.4", "TDebuff=0.1;EnableTCheck", "BaseDamage=250;Trigger=0.15","6b",
                     "Shield Boost", "sb description", false, "BaseHeal=125;BaseHOT=50;BaseHOTDur=3;Recharge=15", "1", "Recharge=0.1", "IHeal=0.2;HOT=0.2", "4a", "HOT=0.35", "Recharge=0.35", "IHeal=0.3", "TShields=1;EnableTCheck","HOTDur=1.5",
                     "Overload", "overload description", false, "BaseDamage=200;BaseChargedDamage=300;BaseChainDamage=300;Chains=2;Recharge=12;Detonator=1;TechPrimer=HSA", "vsShields=1.25;vsSynth=0.3", "Recharge=0.1", "Dam=0.25", "Dam=0.35", "Recharge=0.25", "EChain=1", "vsShields=0.6", "vsShields=0.6;vsSynth=0.15","Dam=0.3;EChain=1",
                     "Offensive Tech", "offensive tech description", false, "", "PD=0.1", "WD=0.08;MD=0.2", "PD=0.15", "PD=0.25;PEffectDur=0.2", "Combo=0.5", "vsShields=0.4", "vsArmor=0.4", "ET=0.35", "MD=0.2",
                     "Support Systems", "Support Systems description", false, "", "1", "Shields=0.2;Health=0.2;Support=0.2", "MD=0.3", "PEffectDur=0.3", "4b", "Shields=0.2;Health=0.2;Support=0.3", "TDR=1.2;EnableTCheck", "6a","6b"),
                      new playingCharacter("Human Kineticist", 450f, 250f, 400f, 0f, 0f, 0f , "" ,
                     "Pull", "pull description", false, "Duration=5;Recharge=8;BioticPrimer=H", "1", "Recharge=0.3", "Duration=0.4", "Duration=0.5", "4b", "BaseDOTDam=60", "TDebuff=0.3;EnableTCheck", "BaseDamage=600","6b",
                     "Throw", "throw description", false, "BaseDamage=50;BaseEDamage=240,Recharge=8;Detonator=1;BioticPrimer=H", "1", "Recharge=0.25", "Dam=0.35", "Dam=0.45", "4b", "5a", "Recharge=0.3", "6a","Detonator=1.3;Recharge=0.5",
                     "Lance", "Lance description", false, "BaseDam=400;Detonator=1;Recharge=10", "1", "Recharge=0.1", "Dam=0.25", "Dam=0.3", "4b", "LWeak=0.4", "vsShields=0.35","Dam=0.3","Cost=0.45",
                     "Biotic Ascension", "ascension description", true, "", "ADR=1", "PD=0.2", "3", "PD=0.25", "PEffectDur=0.4", "TDebuff=0.3;EnableTCheck", "Combo=0.5", "APD=0.35","ADR=0.3;Discount=0.4",  // DR EHP
                     "Barrier", "barrier description", false, "", "Shields=0.25", "2", "MD=0.3", "Shields=0.3", "4b", "TShields=0.4;EnableTCheck", "MD=0.5", "6a","6b"),
                      new playingCharacter("Krogan Gladiator", 700f, 325f, 650f, 0f, 0f, 0.25f , "" ,
                     "Pull", "pull description", false, "Duration=5;Recharge=8;BioticPrimer=H", "1", "Recharge=0.3", "Duration=0.4", "Duration=0.5", "4b", "BaseDOTDam=60", "TDebuff=0.3;EnableTCheck", "BaseDamage=600","6b",
                     "Annihilation", "annihilation description", true, "BaseDOTDam=50;Recharge=8;BioticPrimer=HSA", "PRP=0.75", "PRP=-0.1", "Dam=0.15", "4a", "PRP=-0.3", "TDebuff=0.2;EnableTCheck", "5b", "6a","6b",   // DO POWER RECHARGE SPEED AND  ANNI PENALTY STACK ADDITIVELY ?? Toggle recharge pen
                     "Nova", "Nova description", false, "BaseDam=420;Recharge=12", "1", "2", "Dam=0.3", "Dam=0.35", "4b", "vsArmor=1", "vsShields=1", "Dam=0.5;BioticPrimer=HSA","6b",
                     "Offensive Biotics", "offensive biotics description", false, "" , "PD=0.1", "WD=0.05", "PD=0.15", "PD=0.25", "PRS=0.25", "TDebuff=0.2;EnableTCheck", "WD=0.1", "TBPD=0.4;EnableTCheck", "TWD=0.15;TMD=0.5;EnableTCheck",
                     "Rage", "rage description", true, "Duration=15", "RMD=0.25;RDR=0.15", "MD=0.15", "Shields=0.2;Health=0.2", "Shields=0.2;Health=0.2;RDR=0.15", "MD=0.25;RMD=0.065", "TDR=0.5;EnableTCheck", "TMD=0.65;EnableTCheck", "MD=0.25;RageDuration=0.5" , "AllyDR=0.3;Shields=0.2;Health=0.2"),
                     new playingCharacter("Anagara Exemplar", 450f, 250f, 725f, 0f, 0f, 0f , "" ,
                     "Overload", "overload description", false, "BaseDamage=200;BaseChargedDamage=300;BaseChainDamage=300;Chains=2;Recharge=12;Detonator=1;TechPrimer=HSA", "vsShields=1.25;vsSynth=0.3", "Recharge=0.1", "Dam=0.25", "Dam=0.35", "Recharge=0.25", "EChain=1", "vsShields=0.6", "vsShields=0.6;vsSynth=0.15","Dam=0.3;EChain=1",
                     "Barricade", "barricade description", false, "Duration=13;Cooldown=1", "1", "2", "Duration=0.25", "Duration=0.35", "4b", "5a", "5b", "6a","BaseDamage=125;vsShields=1;vsSynth=0.15",
                     "Energy Drain", "energy drain description", false, "BaseDamage=175;RShields=0.35;Recharge=12;Detonator=1", "vsShields=1;vsSynth=0.15", "Recharge=0.1", "Dam=0.25;RShields=0.15", "Dam=0.3;RShields=0.2", "Recharge=0.3", "RSHOT=0.06;RSHOTDur=4;TechPrimer=HSA", "5b","Dam=0.35;vsShields=0.75;vsSynth=0.15", "RShields=0.25;AllyRShields=0.5",
                     "Bioelectric Focus", "bioelectric focus description", false, "", "PD=0.15", "PEffectDur=0.3", "3", "PD=0.35", "PRS=0.25", "PEffectDur=0.5", "vsShields=0.25;Combo=0.5", "BaseDamage=150;RvsShields=100;RvsSynth=0.5;TechPrimer=HSA","TPRTR=0.35;EnableTCheck",  // PRTR mechanics ???
                     "Bioelectric Defence", "bioelectric defense description", false, "", "Shields=0.15;Health=0.15", "MD=0.3", "Shields=0.15;Health=0.15", "4a", "4b", "Reload=0.15", "PRS=0.2;Support=0.3;ConDam=0.25;ConHealth=0.3", "TDR=0.8;EnableTCheck","TMD=0.65;EnableTCheck"),


                     ///(base_cooldown/cooldownreduction) * (1 + Min(0,(currentweight - weightcapacity)) * 2 + encumbrancecooldownincrease)
             };


        const int constNrGear = 18;
        private GearPiece[] myGearArray = new GearPiece[constNrGear]
      {
                   new GearPiece("Commando Package" , "WD=0.1;BPD=0.2"),
                   new GearPiece("Expert Package", "PWD=0.15;PRS=0.15"),
                   new GearPiece("Guerilla Upgrade", "SRWD=0.15;PWD=0.15"),
                   new GearPiece("Juggernaut Shield", "Shields=0.2;MD=0.15"),
                   new GearPiece("Martial Biotic AMP", "BPD=0.2;MD=0.15"),
                   new GearPiece("Shock Trooper Upgrade", "SGWD=0.15"),
                   new GearPiece("Stronghold Package", "Shields=0.2"),
                   new GearPiece("Warfighter Package", "WD=0.1;CPD=0.2"),
                   new GearPiece("Adaptive War AMP", "BPD=0.3"),
                   new GearPiece("Assault Rifle AMP", "ARWD=0.2"),
                   new GearPiece("Engineering Kit", "TPD=0.3"),
                   new GearPiece("Enhanced Munitions", "CPD=0.3"),
                   new GearPiece("Hydraulic Joints", "MD=0.25"),
                   new GearPiece("Mental Focuser", "PD=0.25"),
                   new GearPiece("Pistol / SMG AMP", "PWD=0.2"),
                   new GearPiece("Shield Enhacer", "Shields=0.3"),
                   new GearPiece("Vulnerability VI", "Weak=0.4"),
                   new GearPiece("Densified Ammunition", "WD=0.125")
                };


        const int constNrAddOns = 43;
        private WeaponAddon[] myAddOnArray = new WeaponAddon[constNrAddOns]  // 1 pistols , 2 SR , 3 Shotguns, 4 Assault 
      {   //  1 Barrels, 2 Magazine, 3 stocks, 4 receivers, 5 scopes,  6 melee mods, 7 chokes, 8 spare ammo, 9 materials
                   new WeaponAddon("AR Barrel X", "ARWD=0.21", 4, 1),
                   new WeaponAddon("AR Short Barrel X", "ARWD=0.25", 4, 1),
                   new WeaponAddon("AR Long Barrel X", "ARWD=0.25;MAG=-0.18", 4, 1),
                   new WeaponAddon("AR Magazine X", "MAG=0.5", 4, 2),
                   new WeaponAddon("AR Light Magazine X", "MAG=0.7", 4, 2),
                   new WeaponAddon("AR Heavy Magazine X", "MAG=0.7", 4, 2),
                   new WeaponAddon("AR Light Stock X", "RELOAD=-0.1", 4, 3),
                   new WeaponAddon("AR Receiver X", "PenMul=0.58", 4, 4),
                   new WeaponAddon("AR Quick Receiver X", "PenMul=0.75;Weak=-0.13", 4, 4),
                   new WeaponAddon("AR Calibrated Receiver X", "PenMul=0.75;MAG=-0.18", 4, 4),
                   new WeaponAddon("AR Tactical Scope X", "ROF=-0.1", 4, 5),
                   new WeaponAddon("Pistol Barrel X", "PWD=0.21", 1, 1),
                   new WeaponAddon("Pistol Short Barrel X", "PWD=0.25", 1, 1),
                   new WeaponAddon("Pistol Long Barrel X", "PWD=0.25", 1, 1),
                   new WeaponAddon("Pistol Magazine X", "MAG=0.71", 1 , 2),
                   new WeaponAddon("Pistol Light Magazine X", "MAG=0.101;RELOAD=-0.1", 1 , 2),
                   new WeaponAddon("Pistol Heavy Magazine X", "MAG=0.101", 1 , 2),
                   new WeaponAddon("Pistol Melee X", "MD=0.29", 1, 6),
                   new WeaponAddon("Pistol Light Melee X", "MD=0.35", 1, 6),
                   new WeaponAddon("Pistol Heavy Melee X", "MD=0.35", 1, 6),
                   new WeaponAddon("Pistol Receiver X", "PenMul=0.58", 1, 4),
                   new WeaponAddon("Pistol Quick Receiver X", "PenMul=0.75,Weak=-0.13", 1, 4),
                   new WeaponAddon("Pistol Calibrated Receiver X", "PenMul=0.75;MAG=-0.25", 1, 4),
                   new WeaponAddon("Pistol Tatical Scope X", "ROF=-0.1", 1, 5),
                   new WeaponAddon("Shotgun Barrel X" , "SGWD=0.17" , 3, 1),
                   new WeaponAddon("Shotgun Short Barrel X" , "SGWD=0.2" , 3, 1),
                   new WeaponAddon("Shotgun Long Barrel X" , "SGWD=0.2" , 3, 1),
                   new WeaponAddon("Shotgun Asymmetric Spare Clip X" , "MD=-0.1" , 3, 8),
                   new WeaponAddon("Shotgun Melee X", "MD=0.33", 3, 6),
                   new WeaponAddon("Shotgun Light Melee X", "MD=0.4;MAG=-0.25", 3, 6),
                   new WeaponAddon("Shotgun Heavy Melee X", "MD=0.4", 3, 6),
                   new WeaponAddon("Shotgun Receiver X", "PenMul=0.58", 3, 4),
                   new WeaponAddon("Shotgun Quick Receiver X", "PenMul=0.75;Weak=-0.1", 3, 4),
                   new WeaponAddon("Shotgun Calibrated Receiver X", "PenMul=0.75;MAG=-0.25", 3, 4),
                   new WeaponAddon("Shotgun Light Choke X", "RELOAD=-0.1", 3, 7),
                   new WeaponAddon("Shotgun Heavy Choke X", "ROF=-0.1", 3, 7),
                   new WeaponAddon("SR Barrel X" , "SRWD=0.21", 2, 1),
                   new WeaponAddon("SR Reinforced Barrel X" , "SRWD=0.25", 2, 1),
                   new WeaponAddon("SR Vented Barrel X" , "SRWD=0.25;ROF=-0.1", 2, 1),
                   new WeaponAddon("SR Laticed Materials X" , "MAG=-0.18", 2, 9),
                   new WeaponAddon("SR Receiver X" , "PenMul=0.7", 2, 4),
                   new WeaponAddon("SR Quick Receiver X" , "PenMul=0.9;Weak=-0.13", 2, 4),
                   new WeaponAddon("SR Calibrated Receiver X" , "PenMul=0.9;MAG=-0.18", 2, 4)
                   };

        const int constNrBoosters = 60;
        private Booster[] myBoosterArray = new Booster[constNrBoosters]
      {            //1 ammo
                   new Booster("Cryo Ammo I", "WD=0.025;Primer='Cryo'",1),
                   new Booster("Disruptor Ammo I", "WD=0.025;Primer='Tech';DisruptorvsShieldsandSynth=1.25",1),
                   new Booster("Incendiary Ammo I", "WD=0.025;Primer='Fire'",1),
                   new Booster("Cryo Ammo II", "WD=0.05;Primer='Cryo'",1),
                   new Booster("Disruptor Ammo II", "WD=0.05;Primer='Tech';DisruptorvsShieldsandSynth=1.25",1),
                   new Booster("Incendiary Ammo II", "WD=0.05;Primer='Fire'",1),
                   new Booster("Cryo Ammo III", "WD=0.075;Primer='Cryo'",1),
                   new Booster("Disruptor Ammo III", "WD=0.075;Primer='Tech';DisruptorvsShieldsandSynth=1.25",1),
                   new Booster("Incendiary Ammo III", "WD=0.075;Primer='Fire'",1),
                   new Booster("Cryo Ammo IV", "WD=0.1;Primer='Cryo'",1),
                   new Booster("Disruptor Ammo IV", "WD=0.1;Primer='Tech';DisruptorvsShieldsandSynth=1.25",1),
                   new Booster("Incendiary Ammo IV", "WD=0.1;Primer='Fire'",1),
                    // Weapon Damage Rail
                   new Booster("AR Rail AMP I", "ARWD=0.1",2),
                   new Booster("Pistol Rail AMP I", "PWD=0.1",2),
                   new Booster("Shotgun Rail AMP I", "SGWD=0.1",2),
                   new Booster("SR Rail AMP I", "SRWD=0.1",2),
                   new Booster("AR Rail AMP II", "ARWD=0.2",2),
                   new Booster("Pistol Rail AMP II", "PWD=0.2",2),
                   new Booster("Shotgun Rail AMP II", "SGWD=0.2",2),
                   new Booster("SR Rail AMP II", "SRWD=0.2",2),
                   new Booster("AR Rail AMP III", "ARWD=0.3",2),
                   new Booster("Pistol Rail AMP III", "PWD=0.3",2),
                   new Booster("Shotgun Rail AMP III", "SGWD=0.3",2),
                   new Booster("SR Rail AMP III", "SRWD=0.3",2),
                   new Booster("AR Rail AMP IV", "ARWD=0.4",2),
                   new Booster("Pistol Rail AMP IV", "PWD=0.4",2),
                   new Booster("Shotgun Rail AMP IV", "SGWD=0.4",2),
                   new Booster("SR Rail AMP IV", "SRWD=0.4",2),
                   // Offensive
                   new Booster("Strenght Enhancer I", "MD=0.15",3),
                   new Booster("Targeting VI I", "Weak=0.15",3),
                   new Booster("Strenght Enhancer II", "MD=0.3",3),
                   new Booster("Targeting VI II", "Weak=0.3",3),
                   new Booster("Strenght Enhancer III", "MD=0.45",3),
                   new Booster("Targeting VI III", "Weak=0.45",3),
                   new Booster("Strenght Enhancer IV", "MD=0.6",3),
                   new Booster("Targeting VI IV", "Weak=0.6",3),
                   // Defensive
                   new Booster("Cyclonic Mod I", "Shields=0.1",4),
                   new Booster("Cyclonic Mod II", "Shields=0.2",4),
                   new Booster("Cyclonic Mod III", "Shields=0.3",4),
                   new Booster("Cyclonic Mod IV", "Shields=0.4",4),
                   // Power
                   new Booster("Biotic Power AMP I", "BPD=0.1",5),
                   new Booster("Combat Power AMP I", "CPD=0.1",5),
                   new Booster("Tech Power AMP I", "TPD=0.1",5),
                   new Booster("Universal Power AMP I", "PD=0.05;WD=0.05;MD=0.05",5),
                   new Booster("Power Efficency MOD I", "PRS=0.15",5),
                   new Booster("Biotic Power AMP II", "BPD=0.2",5),
                   new Booster("Combat Power AMP II", "CPD=0.2",5),
                   new Booster("Tech Power AMP II", "TPD=0.2",5),
                   new Booster("Universal Power AMP II", "PD=0.1;WD=0.1;MD=0.1",5),
                   new Booster("Power Efficency MOD II", "PRS=0.3",5),
                   new Booster("Biotic Power AMP III", "BPD=0.3",5),
                   new Booster("Combat Power AMP III", "CPD=0.3",5),
                   new Booster("Tech Power AMP III", "TPD=0.3",5),
                   new Booster("Universal Power AMP III", "PD=0.15;WD=0.15;MD=0.15",5),
                   new Booster("Power Efficency MOD III", "PRS=0.45",5),
                   new Booster("Biotic Power AMP IV", "BPD=0.4",5),
                   new Booster("Combat Power AMP IV", "CPD=0.4",5),
                   new Booster("Tech Power AMP IV", "TPD=0.4",5),
                   new Booster("Universal Power AMP IV", "PD=0.2;WD=0.2;MD=0.2",5),
                   new Booster("Power Efficency MOD IV", "PRS=0.6",5)


         };

        const int constNrAPEXMods = 15;
        private APEXModifiers[] myAPEXModsArray = new APEXModifiers[constNrAPEXMods]
      {
                   new APEXModifiers("Pistol Skirmish" , "PDWD=0.5;SRWD=-0.5;SGWD=-0.5;ARWD=-0.5"),
                   new APEXModifiers("Sniper Rifle Skirmish", "PDWD=-0.5;SRWD=0.5;SGWD=-0.5;ARWD=-0.5"),
                   new APEXModifiers("Shotgun Skirmish", "PDWD=-0.5;SRWD=-0.5;SGWD=0.5;ARWD=-0.5"),
                   new APEXModifiers("Assault Rifle Skirmish", "PDWD=-0.5;SRWD=-0.5;SGWD=-0.5;ARWD=0.5"),
                   new APEXModifiers("Biotic Skirmish", "BPD=0.5;TPD=-0.5;CPD=-0.5"),
                   new APEXModifiers("Tech Skirmish", "BPD=-0.5;TPD=0.5;CPD=-0.5"),
                   new APEXModifiers("Combat Skirmish", "BPD=-0.5;TPD=-0.5;CPD=0.5"),
                   new APEXModifiers("Weakened Assault Team" , "Shields=-0.25;Health=-0.25"),
                   new APEXModifiers("Weakened Assault Team II" , "Shields=-0.5;Health=-0.5"),
                   new APEXModifiers("Hyper Shields" , "Shields=1;Health=-0.75"),
                   new APEXModifiers("Hand-to-Hand", "MD=1;PDWD=-0.25;SRWD=-0.25;SGWD=-0.25;ARWD=-0.25;BPD=-0.25;TPD=-0.25;CPD=-0.25"),
                   new APEXModifiers("Dampened Powers", "BPD=-0.25;TPD=-0.25;CPD=-0.25"),
                   new APEXModifiers("Dampened Weapons", "PDWD=-0.25;SRWD=-0.25;SGWD=-0.25;ARWD=-0.25;MAG=-0.25"),
                   new APEXModifiers("Go for the eyes", "PDWD=-0.5;SRWD=-0.5;SGWD=-0.5;ARWD=-0.5;Weak=6;WeakL=6"),
                   new APEXModifiers("Combotastic", "Combo=1")
               //    new APEXModifiers("Glass Jaw", "??")
          // 
         };

         // 1 bronze; 2 silver ; 3 gold ; 4 platinum
        // 1 outlaw 2 kett 3 remnant
        const int constNrEnemies = 124;
        private EnemyStats[] myEnemyStatsArray = new EnemyStats[constNrEnemies]
            {
                //kett
                new EnemyStats("Chosen",783.75f,0,0,1.4f,0,1,2,false),
                new EnemyStats("Chosen",1520f,0,0,1.4f,0,2,2,false),
                new EnemyStats("Chosen",2256.25f,0,0,1.4f,0,3,2,false),
                new EnemyStats("Chosen",3206.25f,0,0,1.4f,0,4,2,false),
                new EnemyStats("Wraith",825,0,0,1,0,1,2,false),
                new EnemyStats("Wraith",1600,0,0,1,0,2,2,false),
                new EnemyStats("Wraith",2375,0,0,1,0,3,2,false),
                new EnemyStats("Wraith",3375,0,0,1,0,4,2,false),
                new EnemyStats("Hat-less Wraith",825,0,0,1.15f,0,1,2,false),
                new EnemyStats("Hat-less Wraith",1600,0,0,1.15f,0,2,2,false),
                new EnemyStats("Hat-less Wraith",2375,0,0,1.15f,0,3,2,false),
                new EnemyStats("Hat-less Wraith",3375,0,0,1.15f,0,4,2,false),
                new EnemyStats("Destined",825,412.5f,0,1.4f,0,1,2,false),
                new EnemyStats("Destined",1600,800,0,1.4f,0,2,2,false),
                new EnemyStats("Destined",2375,1187.5f,0,1.4f,0,3,2,false),
                new EnemyStats("Destined",3375,1687.5f,0,1.4f,0,4,2,false),
                new EnemyStats("Destined Boss",3796.875f,1898.4375f,0,1.4f,0,4,2,false),
                new EnemyStats("Anoited",825,660,0,1.4f,0,1,2,false),
                new EnemyStats("Anoited",1600,1280,0,1.4f,0,2,2,false),
                new EnemyStats("Anoited",2375,1900,0,1.4f,0,3,2,false),
                new EnemyStats("Anoited",3375,2700,0,1.4f,0,4,2,false),
                new EnemyStats("Anoited Boss",3796.875f,3037.5f,0,1.4f,0,4,2,false),
                new EnemyStats("Ascendant",4950,0,0,1.4f,0,1,2,false),
                new EnemyStats("Ascendant",9600,0,0,1.4f,0,2,2,false),
                new EnemyStats("Ascendant",14150,0,0,1.4f,0,3,2,false),
                new EnemyStats("Ascendant",20250,0,0,1.4f,0,4,2,false),
                new EnemyStats("Ascendant Orb",5362.5f,0,0,4.6f,0,1,2,false),
                new EnemyStats("Ascendant Orb",10400,0,0,4.6f,0,2,2,false),
                new EnemyStats("Ascendant Orb",15437.5f,0,0,4.6f,0,3,2,false),
                new EnemyStats("Ascendant Orb",21937.5f,0,0,4.6f,0,4,2,false),
                new EnemyStats("Ascendant Boss",25312.5f,0,0,1.4f,0,4,2,false),
                new EnemyStats("Ascendant Boss Orb",27421.875f,0,0,4.6f,0,4,2,false),
                new EnemyStats("Fiend",0,0,12375,1.6f,1.15f,1,2,false),
                new EnemyStats("Fiend",0,0,24000,1.6f,1.15f,2,2,false),
                new EnemyStats("Fiend",0,0,35625,1.6f,1.15f,3,2,false),
                new EnemyStats("Fiend",0,0,50625,1.6f,1.15f,4,2,false),
                new EnemyStats("Fiend Boss",0,0,63281.25f,1.6f,1.15f,4,2,false),
                new EnemyStats("Behemoth",0,0,67500,1.6f,1.15f,4,2,false),
                //outlaws
                new EnemyStats("Adhi",660,0,0,1.15f, 0,1,1,false),
                new EnemyStats("Adhi",1280,0,0,1.15f,0,2,1,false),
                new EnemyStats("Adhi",1900,0,0,1.15f,0,3,1,false),
                new EnemyStats("Adhi",2700,0,0,1.15f,0,4,1,false),
                new EnemyStats("Raider",783.75f,0,0,1.4f, 0,1,1,false),
                new EnemyStats("Raider",1520,0,0,1.4f,0,2,1,false),
                new EnemyStats("Raider",2256.25f,0,0,1.4f,0,3,1,false),
                new EnemyStats("Raider",3206.25f,0,0,1.4f,0,4,1,false),
                new EnemyStats("Agent Clone",0,0,288.75f,1.4f, 0,1,1,false),
                new EnemyStats("Agent Clone",0,0,560,1.4f,0,2,1,false),
                new EnemyStats("Agent Clone",0,0,831.25f,1.4f,0,3,1,false),
                new EnemyStats("Agent Clone",0,0,1181.25f,1.4f,0,4,1,false),
                new EnemyStats("Agent",0,0,1650,1.4f, 0,1,1,false),
                new EnemyStats("Agent",0,0,3200,1.4f,0,2,1,false),
                new EnemyStats("Agent",0,0,4750,1.4f,0,3,1,false),
                new EnemyStats("Agent",0,0,6750,1.4f,0,4,1,false),
                new EnemyStats("Agent Boss",0,0,8437.5f,1.4f,0,4,1,false),
                new EnemyStats("Anarchist",0,0,1650,1.4f, 0,1,1,false),
                new EnemyStats("Anarchist",0,0,3200,1.4f,0,2,1,false),
                new EnemyStats("Anarchist",0,0,4750,1.4f,0,3,1,false),
                new EnemyStats("Anarchist",0,0,6750,1.4f,0,4,1,false),
                new EnemyStats("Anarchist Boss",0,0,8437.5f,1.4f,0,4,1,false),
                new EnemyStats("Pariah",825,825,0,1.4f, 0,1,1,false),
                new EnemyStats("Pariah",1600,1600,0,1.4f,0,2,1,false),
                new EnemyStats("Pariah",2375,2375,0,1.4f,0,3,1,false),
                new EnemyStats("Pariah",3375,3375,0,1.4f,0,4,1,false),
                new EnemyStats("Pariah Boss",3796.875f,3796.875f,0,1.4f,0,4,1,false),
                new EnemyStats("Saboteur",0,412.5f,1650,1.4f, 0,1,1,false),
                new EnemyStats("Saboteur",0,800,3200,1.4f,0,2,1,false),
                new EnemyStats("Saboteur",0,1187.5f,4750,1.4f,0,3,1,false),
                new EnemyStats("Saboteur",0,1687.5f,6750,1.4f,0,4,1,false),
                new EnemyStats("Saboteur Boss",0,2109.375f,8437.5f,1.4f,0,4,1,false),
                new EnemyStats("Sharpshooter",825,660,0,1.4f, 0,1,1,false),
                new EnemyStats("Sharpshooter",1600,1280,0,1.4f,0,2,1,false),
                new EnemyStats("Sharpshooter",2375,1900,0,1.4f,0,3,1,false),
                new EnemyStats("Sharpshooter",3375,2700,0,1.4f,0,4,1,false),
                new EnemyStats("Berserker",0,0,4950,1.6f, 0,1,1,false),
                new EnemyStats("Berserker",0,0,9600,1.6f,0,2,1,false),
                new EnemyStats("Berserker",0,0,14250,1.6f,0,3,1,false),
                new EnemyStats("Berserker",0,0,20250,1.6f,0,4,1,false),
                new EnemyStats("Berserker Boss",0,0,25312.5f,1.6f,0,4,1,false),
                new EnemyStats("Hydra",0,0,13200,1.6f, 1.15f,1,1,true),
                new EnemyStats("Hydra",0,0,25600,1.6f,1.15f,2,1,true),
                new EnemyStats("Hydra",0,0,38000,1.6f,1.15f,3,1,true),
                new EnemyStats("Hydra",0,0,54000,1.6f,1.15f,4,1,true),
                new EnemyStats("Hydra Boss",0,0,67500,1.6f,1.15f,4,1,true),
                new EnemyStats("Blaze Hydra",0,0,14437.5f,1.6f, 1.15f,1,1,true),
                new EnemyStats("Blaze Hydra",0,0,28000,1.6f,1.15f,2,1,true),
                new EnemyStats("Blaze Hydra",0,0,41562.5f,1.6f,1.15f,3,1,true),
                new EnemyStats("Blaze Hydra",0,0,59062.5f,1.6f,1.15f,4,1,true),
                //remnant
                new EnemyStats("Breacher",412.5f,0,0,0,0,1,3,false),
                new EnemyStats("Breacher",800,0,0,0,0,2,3,false),
                new EnemyStats("Breacher",1187.5f,0,0,0,0,3,3,false),
                new EnemyStats("Breacher",1687.5f,0,0,0,0,4,3,false),
                new EnemyStats("Assembler",825,0,0,1.15f, 0,1,3,false),
                new EnemyStats("Assembler",1600,0,0,1.15f,0,2,3,true),
                new EnemyStats("Assembler",2375,0,0,1.15f,0,3,3,true),
                new EnemyStats("Assembler",3375,0,0,1.15f,0,4,3,true),
                new EnemyStats("Observer",495,825,0,1.15f, 0,1,3,true),
                new EnemyStats("Observer",960,1600,0,1.15f,0,2,3,true),
                new EnemyStats("Observer",1425,2375,0,1.15f,0,3,3,true),
                new EnemyStats("Observer",2025,3375,0,1.15f,0,4,3,true),
                new EnemyStats("Observer Boss",2278.125f,3754.6875f,0,1.15f,0,4,3,true),
                new EnemyStats("Nulifier",0,0,2640,1.15f,0,1,3,true),
                new EnemyStats("Nulifier",0,0,5120,1.15f,0,2,3,true),
                new EnemyStats("Nulifier",0,0,7600,1.15f,0,3,3,true),
                new EnemyStats("Nulifier",0,0,10800,1.15f,0,4,3,true),
                new EnemyStats("Nulifier Boss",0,0,13500,1.15f,0,4,3,true),
                new EnemyStats("Destroyer Turrets",0,3712.5f,1031.25f,1,0,1,3,true),
                new EnemyStats("Destroyer Turrets",0,7200,2000,1,0,2,3,true),
                new EnemyStats("Destroyer Turrets",0,10687.5f,2968.75f,1,0,3,3,true),
                new EnemyStats("Destroyer Turrets",0,15187.5f,4218.75f,1,0,4,3,true),
                new EnemyStats("Destroyer",0,33000,7920,8,0,1,3,true),
                new EnemyStats("Destroyer",0,64000,15360,8,0,2,3,true),
                new EnemyStats("Destroyer",0,95000,22800,8,0,3,3,true),
                new EnemyStats("Destroyer",0,135000,32400,8,0,4,3,true),
                new EnemyStats("Destroyer Boss Turrets",0,17085.9375f,4746.09375f,1,0,4,3,true),
                new EnemyStats("Destroyer Boss",0,151875,36450,8,0,4,3,true),
                new EnemyStats("Progenitor Turrets",0,4937.625f,1340.625f,1,0,1,3,true),
                new EnemyStats("Progenitor Turrets",0,9576,2600,1,0,2,3,true),
                new EnemyStats("Progenitor Turrets",0,14214.375f,3859.375f,1,0,3,3,true),
                new EnemyStats("Progenitor Turrets",0,20199.375f,5484.375f,1,0,4,3,true),
                new EnemyStats("Progenitor",0,49500,11220,8,0,1,3,true),
                new EnemyStats("Progenitor",0,96000,21760,8,0,2,3,true),
                new EnemyStats("Progenitor",0,142500,32300,8,0,3,3,true),
                new EnemyStats("Progenitor",0,202500,45900,8,0,4,3,true)

            };

       


        // initialize an array of chars ...

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // WE FOUND THE INTIALIZER AREA

              initializeCombos();
        }

        public void initializeCombos()
        {
            comboBoxSelectWeapon.Items.Clear();
            for (int i = 0; i < constNrGuns; i++)
            {
                comboBoxSelectWeapon.Items.Add(myGunArray[i].weaponName);
            }
            comboBoxSelectWeapon.SelectedIndex = 0;

            comboBoxSelectChars.Items.Clear();
            for (int i = 0; i < constNumberChars; i++)
            {
                comboBoxSelectChars.Items.Add(playingCharactersArray[i].CharacterName);
            }
            comboBoxSelectChars.SelectedIndex = 0;

            comboBoxSelectGear.Items.Clear(); comboBoxSelectGear.Items.Add("none");
            for (int i = 0; i < constNrGear; i++)
            {
                comboBoxSelectGear.Items.Add(myGearArray[i].gearName + "* " + myGearArray[i].gearEffects);
            }
            comboBoxSelectGear.SelectedIndex = 0;

            comboBoxSelectBooster1.Items.Clear(); comboBoxSelectBooster1.Items.Add("none");
             comboBoxSelectBooster2.Items.Clear(); comboBoxSelectBooster2.Items.Add("none");
            for (int i = 0; i < constNrBoosters; i++)
            {

                comboBoxSelectBooster1.Items.Add(myBoosterArray[i].BoosterName + "* " + myBoosterArray[i].BoosterEffects);
                comboBoxSelectBooster2.Items.Add(myBoosterArray[i].BoosterName + "* " + myBoosterArray[i].BoosterEffects);

            }
            comboBoxSelectBooster1.SelectedIndex = 0;
            comboBoxSelectBooster2.SelectedIndex = 0;

            comboBoxSelectApex1.Items.Clear(); comboBoxSelectApex2.Items.Clear();
            comboBoxSelectApex1.Items.Add("none"); comboBoxSelectApex2.Items.Add("none");
            for (int i = 0; i < constNrAPEXMods; i++)
            {

                comboBoxSelectApex1.Items.Add(myAPEXModsArray[i].APEXModName + "* " + myAPEXModsArray[i].APEXModEffects);
                comboBoxSelectApex2.Items.Add(myAPEXModsArray[i].APEXModName + "* " + myAPEXModsArray[i].APEXModEffects);

            }
            comboBoxSelectApex1.SelectedIndex = 0;
            comboBoxSelectApex2.SelectedIndex = 0;



            comboBoxSelectVeteranLevel.SelectedIndex = 0;
            comboBoxSelectDifficulty.SelectedIndex = 2;


            comboBoxBonusHealth.SelectedIndex = 0;
            comboBoxBonusShields.SelectedIndex = 0;
            comboBoxBonusPRS.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxOnOffSkill1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Skill1_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Skill1_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSelectAddOn1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when you change (if not none and other not nore) set the other to none if same add-on group

            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (!selected.Equals("none") && (!comboBoxSelectAddOn2.Text.Equals("none")))
            {
                int AddonIndex1; AddonIndex1 = 0;
                do
                {
                    if (myAddOnArray[AddonIndex1].AddOnName.Equals(comboBoxSelectAddOn2.Text.Split('*')[0])) break;
                    AddonIndex1++;
                } while (AddonIndex1 < constNrAddOns);

                int AddonIndex2; AddonIndex2 = 0;
                do
                {
                    if (myAddOnArray[AddonIndex2].AddOnName.Equals(selected.Split('*')[0])) break;
                    AddonIndex2++;
                } while (AddonIndex2 < constNrAddOns);

                if (myAddOnArray[AddonIndex1].AddOnGroup == myAddOnArray[AddonIndex2].AddOnGroup) comboBoxSelectAddOn2.SelectedIndex = 0;
            }
        }

        private void labelEnemyShields_Click(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Skill1_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Skill1_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Skill1_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Skill1_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSelectVeteranLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSelectChars_SelectedIndexChanged(object sender, EventArgs e)
        { if (playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1Toggleable) checkBoxOnOffSkill1.Enabled = true; else { checkBoxOnOffSkill1.Enabled = false; checkBoxOnOffSkill1.Checked = true; }
            labelSkill1Name.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1Name;
            comboBoxSkill1_1.Items.Clear(); comboBoxSkill1_2.Items.Clear(); comboBoxSkill1_3.Items.Clear(); comboBoxSkill1_4.Items.Clear(); comboBoxSkill1_5.Items.Clear(); comboBoxSkill1_6.Items.Clear();
            comboBoxSkill1_1.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo1); comboBoxSkill1_1.SelectedIndex = 0;
            comboBoxSkill1_2.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo2);
            comboBoxSkill1_2.Items.Add("none"); comboBoxSkill1_2.SelectedIndex = 0;
            comboBoxSkill1_3.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo3);
            comboBoxSkill1_3.Items.Add("none"); comboBoxSkill1_3.SelectedIndex = 0;
            comboBoxSkill1_4.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo4a);
            comboBoxSkill1_4.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo4b);
            comboBoxSkill1_4.Items.Add("none"); comboBoxSkill1_4.SelectedIndex = 0;
            comboBoxSkill1_5.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo5a);
            comboBoxSkill1_5.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo5b);
            comboBoxSkill1_5.Items.Add("none"); comboBoxSkill1_5.SelectedIndex = 0;
            comboBoxSkill1_6.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo6a);
            comboBoxSkill1_6.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo6b);
            comboBoxSkill1_6.Items.Add("none"); comboBoxSkill1_6.SelectedIndex = 0;

            if (playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2Toggleable) checkBoxOnOffSkill2.Enabled = true; else { checkBoxOnOffSkill2.Enabled = false; checkBoxOnOffSkill2.Checked = true; }
            labelSkill2Name.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2Name;
            comboBoxSkill2_1.Items.Clear(); comboBoxSkill2_2.Items.Clear(); comboBoxSkill2_3.Items.Clear(); comboBoxSkill2_4.Items.Clear(); comboBoxSkill2_5.Items.Clear(); comboBoxSkill2_6.Items.Clear();
            comboBoxSkill2_1.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo1); comboBoxSkill2_1.SelectedIndex = 0;
            comboBoxSkill2_2.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo2);
            comboBoxSkill2_2.Items.Add("none"); comboBoxSkill2_2.SelectedIndex = 0;
            comboBoxSkill2_3.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo3);
            comboBoxSkill2_3.Items.Add("none"); comboBoxSkill2_3.SelectedIndex = 0;
            comboBoxSkill2_4.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo4a);
            comboBoxSkill2_4.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo4b);
            comboBoxSkill2_4.Items.Add("none"); comboBoxSkill2_4.SelectedIndex = 0;
            comboBoxSkill2_5.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo5a);
            comboBoxSkill2_5.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo5b);
            comboBoxSkill2_5.Items.Add("none"); comboBoxSkill2_5.SelectedIndex = 0;
            comboBoxSkill2_6.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo6a);
            comboBoxSkill2_6.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo6b);
            comboBoxSkill2_6.Items.Add("none"); comboBoxSkill2_6.SelectedIndex = 0;

            if (playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3Toggleable) checkBoxOnOffSkill3.Enabled = true; else { checkBoxOnOffSkill3.Enabled = false; checkBoxOnOffSkill3.Checked = true; }
            labelSkill3Name.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3Name;
            comboBoxSkill3_1.Items.Clear(); comboBoxSkill3_2.Items.Clear(); comboBoxSkill3_3.Items.Clear(); comboBoxSkill3_4.Items.Clear(); comboBoxSkill3_5.Items.Clear(); comboBoxSkill3_6.Items.Clear();
            comboBoxSkill3_1.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo1); comboBoxSkill3_1.SelectedIndex = 0;
            comboBoxSkill3_2.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo2);
            comboBoxSkill3_2.Items.Add("none"); comboBoxSkill3_2.SelectedIndex = 0;
            comboBoxSkill3_3.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo3);
            comboBoxSkill3_3.Items.Add("none"); comboBoxSkill3_3.SelectedIndex = 0;
            comboBoxSkill3_4.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo4a);
            comboBoxSkill3_4.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo4b);
            comboBoxSkill3_4.Items.Add("none"); comboBoxSkill3_4.SelectedIndex = 0;
            comboBoxSkill3_5.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo5a);
            comboBoxSkill3_5.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo5b);
            comboBoxSkill3_5.Items.Add("none"); comboBoxSkill3_5.SelectedIndex = 0;
            comboBoxSkill3_6.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo6a);
            comboBoxSkill3_6.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo6b);
            comboBoxSkill3_6.Items.Add("none"); comboBoxSkill3_6.SelectedIndex = 0;

            if (playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4Toggleable) checkBoxOnOffSkill4.Enabled = true; else { checkBoxOnOffSkill4.Enabled = false; checkBoxOnOffSkill4.Checked = true; }
            labelSkill4Name.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4Name;
            comboBoxSkill4_1.Items.Clear(); comboBoxSkill4_2.Items.Clear(); comboBoxSkill4_3.Items.Clear(); comboBoxSkill4_4.Items.Clear(); comboBoxSkill4_5.Items.Clear(); comboBoxSkill4_6.Items.Clear();
            comboBoxSkill4_1.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo1);
            comboBoxSkill4_1.Items.Add("none"); comboBoxSkill4_1.SelectedIndex = 0;
            comboBoxSkill4_2.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo2);
            comboBoxSkill4_2.Items.Add("none"); comboBoxSkill4_2.SelectedIndex = 0;
            comboBoxSkill4_3.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo3);
            comboBoxSkill4_3.Items.Add("none"); comboBoxSkill4_3.SelectedIndex = 0;
            comboBoxSkill4_4.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo4a);
            comboBoxSkill4_4.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo4b);
            comboBoxSkill4_4.Items.Add("none"); comboBoxSkill4_4.SelectedIndex = 0;
            comboBoxSkill4_5.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo5a);
            comboBoxSkill4_5.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo5b);
            comboBoxSkill4_5.Items.Add("none"); comboBoxSkill4_5.SelectedIndex = 0;
            comboBoxSkill4_6.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo6a);
            comboBoxSkill4_6.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo6b);
            comboBoxSkill4_6.Items.Add("none"); comboBoxSkill4_6.SelectedIndex = 0;

            if (playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5Toggleable) checkBoxOnOffSkill5.Enabled = true; else { checkBoxOnOffSkill5.Enabled = false; checkBoxOnOffSkill5.Checked = true; }
            labelSkill5Name.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5Name;
            comboBoxSkill5_1.Items.Clear(); comboBoxSkill5_2.Items.Clear(); comboBoxSkill5_3.Items.Clear(); comboBoxSkill5_4.Items.Clear(); comboBoxSkill5_5.Items.Clear(); comboBoxSkill5_6.Items.Clear();
            comboBoxSkill5_1.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo1);
            comboBoxSkill5_1.Items.Add("none"); comboBoxSkill5_1.SelectedIndex = 0;
            comboBoxSkill5_2.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo2);
            comboBoxSkill5_2.Items.Add("none"); comboBoxSkill5_2.SelectedIndex = 0;
            comboBoxSkill5_3.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo3);
            comboBoxSkill5_3.Items.Add("none"); comboBoxSkill5_3.SelectedIndex = 0;
            comboBoxSkill5_4.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo4a);
            comboBoxSkill5_4.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo4b);
            comboBoxSkill5_4.Items.Add("none"); comboBoxSkill5_4.SelectedIndex = 0;
            comboBoxSkill5_5.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo5a);
            comboBoxSkill5_5.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo5b);
            comboBoxSkill5_5.Items.Add("none"); comboBoxSkill5_5.SelectedIndex = 0;
            comboBoxSkill5_6.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo6a);
            comboBoxSkill5_6.Items.Add(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo6b);
            comboBoxSkill5_6.Items.Add("none"); comboBoxSkill5_6.SelectedIndex = 0;
        }

        private void comboBoxSkill1_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill1_3.SelectedIndex = comboBoxSkill1_3.Items.Count - 1; }

          if (selected.Contains("EnableTCheck"))checkBoxSkill1_2.Enabled = true; else { checkBoxSkill1_2.Enabled = false; checkBoxSkill1_2.Checked = false; }

        }

        private void comboBoxSkill1_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill1_4.SelectedIndex = comboBoxSkill1_4.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill1_2.Text.Equals("none")) comboBoxSkill1_2.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill1_3.Enabled = true; else { checkBoxSkill1_3.Enabled = false; checkBoxSkill1_3.Checked = false; }

        }

        private void comboBoxSkill1_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill1_5.SelectedIndex = comboBoxSkill1_5.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill1_3.Text.Equals("none")) comboBoxSkill1_3.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill1_4.Enabled = true; else { checkBoxSkill1_4.Enabled = false; checkBoxSkill1_4.Checked = false; }

        }

        private void comboBoxSkill1_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill1_6.SelectedIndex = comboBoxSkill1_6.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill1_4.Text.Equals("none")) comboBoxSkill1_4.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill1_5.Enabled = true; else { checkBoxSkill1_5.Enabled = false; checkBoxSkill1_5.Checked = false; }

        }

        private void comboBoxSkill2_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill2_3.SelectedIndex = comboBoxSkill2_3.Items.Count - 1; }

          if (selected.Contains("EnableTCheck"))checkBoxSkill2_2.Enabled = true; else { checkBoxSkill2_2.Enabled = false; checkBoxSkill2_2.Checked = false; }

        }

        private void comboBoxSkill2_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill2_4.SelectedIndex = comboBoxSkill2_4.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill2_2.Text.Equals("none")) comboBoxSkill2_2.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill2_3.Enabled = true; else { checkBoxSkill2_3.Enabled = false; checkBoxSkill2_3.Checked = false; }

        }

        private void comboBoxSkill2_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill2_5.SelectedIndex = comboBoxSkill2_5.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill2_3.Text.Equals("none")) comboBoxSkill2_3.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill2_4.Enabled = true; else { checkBoxSkill2_4.Enabled = false; checkBoxSkill2_4.Checked = false; }

        }

        private void comboBoxSkill2_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill2_6.SelectedIndex = comboBoxSkill2_6.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill2_4.Text.Equals("none")) comboBoxSkill2_4.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill2_5.Enabled = true; else { checkBoxSkill2_5.Enabled = false; checkBoxSkill2_5.Checked = false; }
        }

        private void comboBoxSkill3_2_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill3_3.SelectedIndex = comboBoxSkill3_3.Items.Count - 1; }

          if (selected.Contains("EnableTCheck"))checkBoxSkill3_2.Enabled = true; else { checkBoxSkill3_2.Enabled = false; checkBoxSkill3_2.Checked = false; }

        }

        private void comboBoxSkill3_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill3_4.SelectedIndex = comboBoxSkill3_4.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill3_2.Text.Equals("none")) comboBoxSkill3_2.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill3_3.Enabled = true; else { checkBoxSkill3_3.Enabled = false; checkBoxSkill3_3.Checked = false; }

        }

        private void comboBoxSkill3_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill3_5.SelectedIndex = comboBoxSkill3_5.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill3_3.Text.Equals("none")) comboBoxSkill3_3.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill3_4.Enabled = true; else { checkBoxSkill3_4.Enabled = false; checkBoxSkill3_4.Checked = false; }

        }

        private void comboBoxSkill3_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill3_6.SelectedIndex = comboBoxSkill3_6.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill3_4.Text.Equals("none")) comboBoxSkill3_4.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill3_5.Enabled = true; else { checkBoxSkill3_5.Enabled = false; checkBoxSkill3_5.Checked = false; }

        }

        private void comboBoxSkill4_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill4_2.SelectedIndex = comboBoxSkill4_2.Items.Count - 1; }

          if (selected.Contains("EnableTCheck"))checkBoxSkill4_1.Enabled = true; else { checkBoxSkill4_1.Enabled = false; checkBoxSkill4_1.Checked = false; }

        }

        private void comboBoxSkill4_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill4_3.SelectedIndex = comboBoxSkill4_3.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill4_1.Text.Equals("none")) comboBoxSkill4_1.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill4_2.Enabled = true; else { checkBoxSkill4_2.Enabled = false; checkBoxSkill4_2.Checked = false; }

        }

        private void comboBoxSkill4_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill4_4.SelectedIndex = comboBoxSkill4_4.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill4_2.Text.Equals("none")) comboBoxSkill4_2.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill4_3.Enabled = true; else { checkBoxSkill4_3.Enabled = false; checkBoxSkill4_3.Checked = false; }

        }

        private void comboBoxSkill4_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill4_5.SelectedIndex = comboBoxSkill4_5.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill4_3.Text.Equals("none")) comboBoxSkill4_3.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill4_4.Enabled = true; else { checkBoxSkill4_4.Enabled = false; checkBoxSkill4_4.Checked = false; }

        }

        private void comboBoxSkill4_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill4_6.SelectedIndex = comboBoxSkill4_6.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill4_4.Text.Equals("none")) comboBoxSkill4_4.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill4_5.Enabled = true; else { checkBoxSkill4_5.Enabled = false; checkBoxSkill4_5.Checked = false; }

        }

        private void comboBoxSkill5_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill5_2.SelectedIndex = comboBoxSkill5_2.Items.Count - 1; }

          if (selected.Contains("EnableTCheck"))checkBoxSkill5_1.Enabled = true; else { checkBoxSkill5_1.Enabled = false; checkBoxSkill5_1.Checked = false; }
        }

        private void comboBoxSkill5_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill5_3.SelectedIndex = comboBoxSkill5_3.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill5_1.Text.Equals("none")) comboBoxSkill5_1.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill5_2.Enabled = true; else { checkBoxSkill5_2.Enabled = false; checkBoxSkill5_2.Checked = false; }
        }

        private void comboBoxSkill5_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill5_4.SelectedIndex = comboBoxSkill5_4.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill5_2.Text.Equals("none")) comboBoxSkill5_2.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill5_3.Enabled = true; else { checkBoxSkill5_3.Enabled = false; checkBoxSkill5_3.Checked = false; }
        }

        private void comboBoxSkill5_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill5_5.SelectedIndex = comboBoxSkill5_5.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill5_3.Text.Equals("none")) comboBoxSkill5_3.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill5_4.Enabled = true; else { checkBoxSkill5_4.Enabled = false; checkBoxSkill5_4.Checked = false; }
        }

        private void comboBoxSkill5_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (selected.Equals("none")) { comboBoxSkill5_6.SelectedIndex = comboBoxSkill5_6.Items.Count - 1; }
            if (!selected.Equals("none")) if (comboBoxSkill5_4.Text.Equals("none")) comboBoxSkill5_4.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill5_5.Enabled = true; else { checkBoxSkill5_5.Enabled = false; checkBoxSkill5_5.Checked = false; }
        }

        private void comboBoxSkill1_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (!selected.Equals("none")) if (comboBoxSkill1_5.Text.Equals("none")) comboBoxSkill1_5.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill1_6.Enabled = true; else { checkBoxSkill1_6.Enabled = false; checkBoxSkill1_6.Checked = false; }

        }

        private void comboBoxSkill2_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (!selected.Equals("none")) if (comboBoxSkill2_5.Text.Equals("none")) comboBoxSkill2_5.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill2_6.Enabled = true; else { checkBoxSkill2_6.Enabled = false; checkBoxSkill2_6.Checked = false; }

        }

        private void comboBoxSkill3_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (!selected.Equals("none")) if (comboBoxSkill3_5.Text.Equals("none")) comboBoxSkill3_5.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill3_6.Enabled = true; else { checkBoxSkill3_6.Enabled = false; checkBoxSkill3_6.Checked = false; }

        }

        private void comboBoxSkill4_6_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (!selected.Equals("none")) if (comboBoxSkill4_5.Text.Equals("none")) comboBoxSkill4_5.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill4_6.Enabled = true; else { checkBoxSkill4_6.Enabled = false; checkBoxSkill4_6.Checked = false; }
        }

        private void comboBoxSkill5_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (!selected.Equals("none")) if (comboBoxSkill5_5.Text.Equals("none")) comboBoxSkill5_5.SelectedIndex = 0;

          if (selected.Contains("EnableTCheck"))checkBoxSkill5_6.Enabled = true; else { checkBoxSkill5_6.Enabled = false; checkBoxSkill5_6.Checked = false;  }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSelectAddOn2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when you change (if not none and other not nore) set the other to none if same add-on group

            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (!selected.Equals("none") && (!comboBoxSelectAddOn1.Text.Equals("none")))
            {
                int AddonIndex1; AddonIndex1 = 0;
                do
                {
                    if (myAddOnArray[AddonIndex1].AddOnName.Equals(comboBoxSelectAddOn1.Text.Split('*')[0])) break;
                    AddonIndex1++;
                } while (AddonIndex1 < constNrAddOns);

                int AddonIndex2; AddonIndex2 = 0;
                do
                {
                    if (myAddOnArray[AddonIndex2].AddOnName.Equals(selected.Split('*')[0])) break;
                    AddonIndex2++;
                } while (AddonIndex2 < constNrAddOns);

                if (myAddOnArray[AddonIndex1].AddOnGroup == myAddOnArray[AddonIndex2].AddOnGroup) comboBoxSelectAddOn1.SelectedIndex = 0;
            }
        }

        private void buttonReCalculate_Click(object sender, EventArgs e)
        {
            // this is going to be a huge one unless I move some shit into separate functions
            //// INIT GLOBAL VARIABLES WITH DEFAULT VALUES (mostly 0s and 1s)
            ///parse ONCE GEAR, ADD-ons, Boosters, APEX and ALL SKILLS for generic bonuses (fortification has semi=perma MD bonus on) and update global variables
            /// 
            /// calculate CHAR stats ? (enough data?)
            ///  calculate skill 1 (switch(skill1name)  re=parse skill 1 if needed)
            ///  calculate skill 2 (switch(skill1name)  re=parse skill 2 if needed)
            ///  calculate skill 3 (switch(skill1name)  re=parse skill 3 if needed)
            ///  combo combinations
            ///  GUN STUFF (single shot/ clip/ DPS )
            ///  no weakspot gun simulation
            /// weakspot gun simulation
            /// 


            //// INIT GLOBAL VARIABLES WITH DEFAULT VALUES (mostly 0s and 1s) [keep them separated not accumulated = so we can show expanded formulas with ALL TERMS]
            //////////////
            //////////// BASED ON THIS SECTION YOU WILL WRITE ALL FORMULAS
            /////////////
            // gear variables
            float gearSRWD, gearSGWD, gearPWD, gearARWD, gearBPD, gearTPD, gearCPD, gearPRS, gearShields, gearMD, gearWeak;
            gearSRWD = gearSGWD = gearPWD = gearARWD = gearBPD = gearTPD = gearCPD = gearPRS = gearShields = gearMD = gearWeak = 0;

            //add-on1 variables
            //add-on2 variables
            float addon1ARWD, addon1SRWD, addon1PWD, addon1SGWD, addon1MD, addon1MAG, addon1RELOAD, addon1PenMul, addon1Weak, addon1ROF;
            float addon2ARWD, addon2SRWD, addon2PWD, addon2SGWD, addon2MD, addon2MAG, addon2RELOAD, addon2PenMul, addon2Weak, addon2ROF;
            addon1ARWD = addon1SRWD = addon1PWD = addon1SGWD = addon1MD = addon2ARWD = addon2SRWD = addon2PWD = addon2SGWD = addon2MD = addon1Weak = addon2Weak = addon1ROF = addon2ROF = 0;
            addon1RELOAD = addon2RELOAD = addon1PenMul = addon2PenMul = addon1MAG = addon2MAG = 0;  // or 1 ??

            //booster1 variables
            //booster2 variables

            float booster1ARWD, booster1SRWD, booster1PWD, booster1SGWD, booster1MD, booster1Weak, booster1Shields, booster1PRS, booster1BPD, booster1TPD, booster1CPD;
            booster1ARWD = booster1SRWD = booster1PWD = booster1SGWD = booster1MD = booster1Weak = booster1Shields = booster1PRS = booster1BPD = booster1TPD = booster1CPD = 0;

            float booster2ARWD, booster2SRWD, booster2PWD, booster2SGWD, booster2MD, booster2Weak, booster2Shields, booster2PRS, booster2BPD, booster2TPD, booster2CPD;
            booster2ARWD = booster2SRWD = booster2PWD = booster2SGWD = booster2MD = booster2Weak = booster2Shields = booster2PRS = booster2BPD = booster2TPD = booster2CPD = 0;

            string boosterAmmoType; boosterAmmoType = "none"; float boosterDisruptorVsShields; boosterDisruptorVsShields = 1;


            //APEX1 variables
            //APEX2 variables

            float apex1ARWD, apex1SRWD, apex1PWD, apex1SGWD, apex1MD, apex1Weak, apex1WeakL, apex1BPD, apex1CPD, apex1TPD, apex1Shields, apex1Health, apex1Combo, apex1MAG;
            float apex2ARWD, apex2SRWD, apex2PWD, apex2SGWD, apex2MD, apex2Weak, apex2WeakL, apex2BPD, apex2CPD, apex2TPD, apex2Shields, apex2Health, apex2Combo, apex2MAG;

            apex1ARWD = apex1SRWD = apex1PWD = apex1SGWD = apex1MD = apex1Weak = apex1WeakL = apex1BPD = apex1CPD = apex1TPD = apex1Shields = apex1Health = apex1Combo = apex2ARWD =
                apex2SRWD = apex2PWD = apex2SGWD = apex2MD = apex2Weak = apex2WeakL = apex2BPD = apex2CPD = apex2TPD = apex2Shields = apex2Health = apex2Combo = apex1MAG = apex2MAG = 0;

            //Skill variables (gazzilons :( )  
            //skill1 
            float skill1WDSum, skill1ROFSum, skill1MAGSum, skill1PDSum, skill1MDSum, skill1ShieldsSum, skill1DRSum, skill1DebuffSum, skill1ArmorDebuffSum, skill1PRS, skill1ConHealth, skill1PRPSum, skill1PenMulSum;

            skill1WDSum = skill1ROFSum = skill1MAGSum = skill1PDSum = skill1MDSum = skill1ShieldsSum = skill1DRSum = skill1DebuffSum = skill1ArmorDebuffSum = skill1PRS = skill1ConHealth = skill1PRPSum = skill1PenMulSum = 0;

            //skill2
            float skill2WDSum, skill2ROFSum, skill2MAGSum, skill2PDSum, skill2MDSum, skill2ShieldsSum, skill2DRSum, skill2DebuffSum, skill2ArmorDebuffSum, skill2PRS, skill2ConHealth, skill2PRPSum, skill2PenMulSum;

            skill2WDSum = skill2ROFSum = skill2MAGSum = skill2PDSum = skill2MDSum = skill2ShieldsSum = skill2DRSum = skill2DebuffSum = skill2ArmorDebuffSum = skill2PRS = skill2ConHealth = skill2PRPSum = skill2PenMulSum = 0;

            //skill3
            float skill3WDSum, skill3ROFSum, skill3MAGSum, skill3PDSum, skill3MDSum, skill3ShieldsSum, skill3DRSum, skill3DebuffSum, skill3ArmorDebuffSum, skill3PRS, skill3ConHealth, skill3PRPSum, skill3PenMulSum;

            skill3WDSum = skill3ROFSum = skill3MAGSum = skill3PDSum = skill3MDSum = skill3ShieldsSum = skill3DRSum = skill3DebuffSum = skill3ArmorDebuffSum = skill3PRS = skill3ConHealth = skill3PRPSum = skill3PenMulSum = 0;

            //skill4 "passive"
            float skill4WDSum, skill4MAGSum, skill4PDSum, skill4BPD, skill4MDSum, skill4Reload, skill4Weak, skill4DRSum, skill4DebuffSum, skill4Combo, skill4PRS, skill4ConHealth, skill4ConDam, skill4PEffectDur, skill4vsShields, skill4vsArmor, skill4PRTR;

            skill4WDSum = skill4MAGSum = skill4PDSum = skill4BPD = skill4MDSum = skill4Reload = skill4Weak = skill4DRSum = skill4DebuffSum = skill4Combo = skill4PRS = skill4ConHealth = skill4ConDam = skill4PEffectDur = skill4vsShields = skill4vsArmor = skill4PRTR = 0;

            //skill5 "fitness, "
            float skill5WDSum, skill5MDSum, skill5ShieldsSum, skill5HealthSum, skill5DRSum, skill5ConHealth, skill5ConDam, skill5PEffectDur, skill5SupportSum, skill5Reload, skill5PRS;

            skill5WDSum = skill5MDSum = skill5ShieldsSum = skill5HealthSum = skill5DRSum = skill5ConHealth = skill5ConDam = skill5PEffectDur = skill5SupportSum = skill5Reload = skill5PRS = 0;

            // "No need to PARSE GEAR" - use switch instead ignoring the string data

            if (comboBoxSelectGear.SelectedIndex > 0)  // missaligned indexes between MygearArray and gear Combobox because of the "none" option
                switch (myGearArray[comboBoxSelectGear.SelectedIndex - 1].gearName)
                {
                    case "none":
                        break;
                    case "Commando Package":
                        gearSRWD = gearSGWD = gearPWD = gearARWD = 0.1f; gearBPD = 0.2f;
                        break;
                    case "Expert Package":
                        gearPWD = 0.15f; gearPRS = 0.15f;
                        break;
                    case "Guerilla Upgrade":
                        gearSRWD = gearPWD = 0.15f;
                        break;
                    case "Juggernaut Shield":
                        gearShields = 0.2f; gearMD = 0.15f;
                        break;
                    case "Martial Biotic AMP":
                        gearBPD = 0.2f; gearMD = 0.15f;
                        break;
                    case "Shock Trooper Upgrade":
                        gearSGWD = 0.15f;
                        break;
                    case "Stronghold Package":
                        gearShields = 0.2f;
                        break;
                    case "Warfighter Package":
                        gearSRWD = gearSGWD = gearPWD = gearARWD = 0.1f; gearCPD = 0.2f;
                        break;
                    case "Adaptive War AMP":
                        gearBPD = 0.3f;
                        break;
                    case "Assault Rifle AMP":
                        gearARWD = 0.2f;
                        break;
                    case "Engineering Kit":
                        gearTPD = 0.3f;
                        break;
                    case "Enhanced Munitions":
                        gearCPD = 0.3f;
                        break;
                    case "Hydraulic Joints":
                        gearMD = 0.25f;
                        break;
                    case "Mental Focuser":
                        gearBPD = gearTPD = gearCPD = 0.25f;
                        break;
                    case "Pistol / SMG AMP":
                        gearPWD = 0.2f;
                        break;
                    case "Shield Enhacer":
                        gearShields = 0.3f;
                        break;
                    case "Vulnerability VI":
                        gearWeak = 0.4f;
                        break;
                    case "Densified Ammunition": // "WD=0.125"
                        gearSRWD = gearSGWD = gearPWD = gearARWD = 0.125f;
                        break;

                }


            // temp PRint all gear variable somewhere to VERIFY
            textBoxDebug.Text = "Debug: ";
            if (gearSRWD != 0) textBoxDebug.Text += "gearSRWD = " + gearSRWD.ToString() + " ";
            if (gearSGWD != 0) textBoxDebug.Text += "gearSGWD = " + gearSGWD.ToString() + " ";
            if (gearPWD != 0) textBoxDebug.Text += "gearPWD = " + gearPWD.ToString() + " ";
            if (gearARWD != 0) textBoxDebug.Text += "gearARWD = " + gearARWD.ToString() + " ";
            if (gearBPD != 0) textBoxDebug.Text += "gearBPD = " + gearBPD.ToString() + " ";
            if (gearTPD != 0) textBoxDebug.Text += "gearTPD = " + gearTPD.ToString() + " ";
            if (gearCPD != 0) textBoxDebug.Text += "gearCPD = " + gearCPD.ToString() + " ";
            if (gearPRS != 0) textBoxDebug.Text += "gearPRS = " + gearPRS.ToString() + " ";
            if (gearShields != 0) textBoxDebug.Text += "gearShields = " + gearShields.ToString() + " ";
            if (gearMD != 0) textBoxDebug.Text += "gearMD = " + gearMD.ToString() + " ";
            if (gearWeak != 0) textBoxDebug.Text += "gearWeak = " + gearWeak.ToString() + " ";



            //textBoxDebug.Text += comboBoxSelectAddOn1.Text.Split('*')[0];

            int AddonIndex; AddonIndex = 0;
            do
            {
                if (myAddOnArray[AddonIndex].AddOnName.Equals(comboBoxSelectAddOn1.Text.Split('*')[0])) break;
                AddonIndex++;
            } while (AddonIndex < constNrAddOns);



            if (AddonIndex < constNrAddOns) switch (myAddOnArray[AddonIndex].AddOnName)
                {
                    case "AR Barrel X":
                        addon1ARWD = 0.21f;
                        break;
                    case "AR Short Barrel X":
                        addon1ARWD = 0.25f;
                        break;
                    case "AR Long Barrel X":
                        addon1ARWD = 0.25f; addon1MAG = -0.18f;
                        break;
                    case "AR Magazine X":
                        addon1MAG = 0.5f;
                        break;
                    case "AR Light Magazine X":
                        addon1MAG = 0.7f;
                        break;
                    case "AR Heavy Magazine X":
                        addon1MAG = 0.7f;
                        break;
                    case "AR Light Stock X":
                        addon1RELOAD = -0.1f;
                        break;
                    case "AR Receiver X":
                        addon1PenMul = 0.58f;
                        break;
                    case "AR Quick Receiver X":
                        addon1PenMul = 0.75f; addon1Weak = -0.13f;
                        break;
                    case "AR Calibrated Receiver X":
                        addon1PenMul = 0.75f; addon1MAG = -0.18f;
                        break;
                    case "AR Tactical Scope X":
                        addon1ROF = -0.1f;
                        break;
                    case "Pistol Barrel X":
                        addon1PWD = 0.21f;
                        break;
                    case "Pistol Short Barrel X":
                        addon1PWD = 0.25f;
                        break;
                    case "Pistol Long Barrel X":
                        addon1PWD = 0.25f;
                        break;
                    case "Pistol Magazine X":
                        addon1MAG = 0.71f;
                        break;
                    case "Pistol Light Magazine X":
                        addon1MAG = 0.101f; addon1RELOAD = -0.1f;
                        break;
                    case "Pistol Heavy Magazine X":
                        addon1MAG = 0.101f;
                        break;
                    case "Pistol Melee X":
                        addon1MD = 0.29f;
                        break;
                    case "Pistol Light Melee X":
                        addon1MD = 0.35f;
                        break;
                    case "Pistol Heavy Melee X":
                        addon1MD = 0.35f;
                        break;
                    case "Pistol Receiver X":
                        addon1PenMul = 0.58f;
                        break;
                    case "Pistol Quick Receiver X":
                        addon1PenMul = 0.75f; addon1Weak = -0.13f;
                        break;
                    case "Pistol Calibrated Receiver X":
                        addon1PenMul = 0.75f; addon1MAG = -0.25f;
                        break;
                    case "Pistol Tatical Scope X":
                        addon1ROF = -0.1f;
                        break;
                    case "Shotgun Barrel X":
                        addon1SGWD = 0.17f;
                        break;
                    case "Shotgun Short Barrel X":
                        addon1SGWD = 0.2f;
                        break;
                    case "Shotgun Long Barrel X":
                        addon1SGWD = 0.2f;
                        break;
                    case "Shotgun Asymmetric Spare Clip X":
                        addon1MD = -0.1f;
                        break;
                    case "Shotgun Melee X":
                        addon1MD = 0.33f;
                        break;
                    case "Shotgun Light Melee X":
                        addon1MD = 0.4f; addon1MAG = -0.25f;
                        break;
                    case "Shotgun Heavy Melee X":
                        addon1MD = 0.4f;
                        break;
                    case "Shotgun Receiver X":
                        addon1PenMul = 0.58f;
                        break;
                    case "Shotgun Quick Receiver X":
                        addon1PenMul = 0.75f; addon1Weak = -0.1f;
                        break;
                    case "Shotgun Calibrated Receiver X":
                        addon1PenMul = 0.75f; addon1MAG = -0.25f;
                        break;
                    case "Shotgun Light Choke X":
                        addon1RELOAD = -0.1f;
                        break;
                    case "Shotgun Heavy Choke X":
                        addon1ROF = -0.1f;
                        break;
                    case "SR Barrel X":
                        addon1SRWD = 0.21f;
                        break;
                    case "SR Reinforced Barrel X":
                        addon1SRWD = 0.25f;
                        break;
                    case "SR Vented Barrel X":
                        addon1SRWD = 0.25f; addon1ROF = -0.1f;
                        break;
                    case "SR Laticed Materials X":
                        addon1MAG = -0.18f;
                        break;
                    case "SR Receiver X":
                        addon1PenMul = 0.7f;
                        break;
                    case "SR Quick Receiver X":
                        addon1PenMul = 0.9f; addon1Weak = -0.13f;
                        break;
                    case "SR Calibrated Receiver X":
                        addon1PenMul = 0.9f; addon1MAG = -0.18f;
                        break;

                }



            AddonIndex = 0;
            do
            {
                if (myAddOnArray[AddonIndex].AddOnName.Equals(comboBoxSelectAddOn2.Text.Split('*')[0])) break;
                AddonIndex++;
            } while (AddonIndex < constNrAddOns);



            if (AddonIndex < constNrAddOns) switch (myAddOnArray[AddonIndex].AddOnName)
                {
                    case "AR Barrel X":
                        addon2ARWD = 0.21f;
                        break;
                    case "AR Short Barrel X":
                        addon2ARWD = 0.25f;
                        break;
                    case "AR Long Barrel X":
                        addon2ARWD = 0.25f; addon2MAG = -0.18f;
                        break;
                    case "AR Magazine X":
                        addon2MAG = 0.5f;
                        break;
                    case "AR Light Magazine X":
                        addon2MAG = 0.7f;
                        break;
                    case "AR Heavy Magazine X":
                        addon2MAG = 0.7f;
                        break;
                    case "AR Light Stock X":
                        addon2RELOAD = -0.1f;
                        break;
                    case "AR Receiver X":
                        addon2PenMul = 0.58f;
                        break;
                    case "AR Quick Receiver X":
                        addon2PenMul = 0.75f; addon2Weak = -0.13f;
                        break;
                    case "AR Calibrated Receiver X":
                        addon2PenMul = 0.75f; addon2MAG = -0.18f;
                        break;
                    case "AR Tactical Scope X":
                        addon2ROF = -0.1f;
                        break;
                    case "Pistol Barrel X":
                        addon2PWD = 0.21f;
                        break;
                    case "Pistol Short Barrel X":
                        addon2PWD = 0.25f;
                        break;
                    case "Pistol Long Barrel X":
                        addon2PWD = 0.25f;
                        break;
                    case "Pistol Magazine X":
                        addon2MAG = 0.71f;
                        break;
                    case "Pistol Light Magazine X":
                        addon2MAG = 0.101f; addon2RELOAD = -0.1f;
                        break;
                    case "Pistol Heavy Magazine X":
                        addon2MAG = 0.101f;
                        break;
                    case "Pistol Melee X":
                        addon2MD = 0.29f;
                        break;
                    case "Pistol Light Melee X":
                        addon2MD = 0.35f;
                        break;
                    case "Pistol Heavy Melee X":
                        addon2MD = 0.35f;
                        break;
                    case "Pistol Receiver X":
                        addon2PenMul = 0.58f;
                        break;
                    case "Pistol Quick Receiver X":
                        addon2PenMul = 0.75f; addon2Weak = -0.13f;
                        break;
                    case "Pistol Calibrated Receiver X":
                        addon2PenMul = 0.75f; addon2MAG = -0.25f;
                        break;
                    case "Pistol Tatical Scope X":
                        addon2ROF = -0.1f;
                        break;
                    case "Shotgun Barrel X":
                        addon2SGWD = 0.17f;
                        break;
                    case "Shotgun Short Barrel X":
                        addon2SGWD = 0.2f;
                        break;
                    case "Shotgun Long Barrel X":
                        addon2SGWD = 0.2f;
                        break;
                    case "Shotgun Asymmetric Spare Clip X":
                        addon2MD = -0.1f;
                        break;
                    case "Shotgun Melee X":
                        addon2MD = 0.33f;
                        break;
                    case "Shotgun Light Melee X":
                        addon2MD = 0.4f; addon2MAG = -0.25f;
                        break;
                    case "Shotgun Heavy Melee X":
                        addon2MD = 0.4f;
                        break;
                    case "Shotgun Receiver X":
                        addon2PenMul = 0.58f;
                        break;
                    case "Shotgun Quick Receiver X":
                        addon2PenMul = 0.75f; addon2Weak = -0.1f;
                        break;
                    case "Shotgun Calibrated Receiver X":
                        addon2PenMul = 0.75f; addon2MAG = -0.25f;
                        break;
                    case "Shotgun Light Choke X":
                        addon2RELOAD = -0.1f;
                        break;
                    case "Shotgun Heavy Choke X":
                        addon2ROF = -0.1f;
                        break;
                    case "SR Barrel X":
                        addon2SRWD = 0.21f;
                        break;
                    case "SR Reinforced Barrel X":
                        addon2SRWD = 0.25f;
                        break;
                    case "SR Vented Barrel X":
                        addon2SRWD = 0.25f; addon2ROF = -0.1f;
                        break;
                    case "SR Laticed Materials X":
                        addon2MAG = -0.18f;
                        break;
                    case "SR Receiver X":
                        addon2PenMul = 0.7f;
                        break;
                    case "SR Quick Receiver X":
                        addon2PenMul = 0.9f; addon2Weak = -0.13f;
                        break;
                    case "SR Calibrated Receiver X":
                        addon2PenMul = 0.9f; addon2MAG = -0.18f;
                        break;

                }



            // temp PRint all gear variable somewhere to VERIFY
            if (addon1ARWD != 0) textBoxDebug.Text += "addon1ARWD = " + addon1ARWD.ToString() + " ";
            if (addon1MAG != 0) textBoxDebug.Text += "addon1MAG = " + addon1MAG.ToString() + " ";
            if (addon1PWD != 0) textBoxDebug.Text += "addon1PWD = " + addon1PWD.ToString() + " ";
            if (addon1MD != 0) textBoxDebug.Text += "addon1MD = " + addon1MD.ToString() + " ";
            if (addon1SRWD != 0) textBoxDebug.Text += "addon1SRWD = " + addon1SRWD.ToString() + " ";
            if (addon1SGWD != 0) textBoxDebug.Text += "addon1SGWD = " + addon1SGWD.ToString() + " ";
            if (addon1RELOAD != 0) textBoxDebug.Text += "addon1RELOAD = " + addon1RELOAD.ToString() + " ";
            if (addon1PenMul != 0) textBoxDebug.Text += "addon1PenMul = " + addon1PenMul.ToString() + " ";
            if (addon1Weak != 0) textBoxDebug.Text += "addon1Weak = " + addon1Weak.ToString() + " ";
            if (addon1ROF != 0) textBoxDebug.Text += "addon1ROF = " + addon1ROF.ToString() + " ";

            if (addon2ARWD != 0) textBoxDebug.Text += "addon2ARWD = " + addon2ARWD.ToString() + " ";
            if (addon2MAG != 0) textBoxDebug.Text += "addon2MAG = " + addon2MAG.ToString() + " ";
            if (addon2PWD != 0) textBoxDebug.Text += "addon2PWD = " + addon2PWD.ToString() + " ";
            if (addon2MD != 0) textBoxDebug.Text += "addon2MD = " + addon2MD.ToString() + " ";
            if (addon2SRWD != 0) textBoxDebug.Text += "addon2SRWD = " + addon2SRWD.ToString() + " ";
            if (addon2SGWD != 0) textBoxDebug.Text += "addon2SGWD = " + addon2SGWD.ToString() + " ";
            if (addon2RELOAD != 0) textBoxDebug.Text += "addon2RELOAD = " + addon2RELOAD.ToString() + " ";
            if (addon2PenMul != 0) textBoxDebug.Text += "addon2PenMul = " + addon2PenMul.ToString() + " ";
            if (addon2Weak != 0) textBoxDebug.Text += "addon2Weak = " + addon2Weak.ToString() + " ";
            if (addon2ROF != 0) textBoxDebug.Text += "addon2ROF = " + addon2ROF.ToString() + " ";


            int BoosterIndex; BoosterIndex = 0;
            do
            {
                if (myBoosterArray[BoosterIndex].BoosterName.Equals(comboBoxSelectBooster1.Text.Split('*')[0])) break;
                BoosterIndex++;
            } while (BoosterIndex < constNrBoosters);



            if (BoosterIndex < constNrBoosters) switch (myBoosterArray[BoosterIndex].BoosterName)
                {
                    case "Cryo Ammo I":
                        booster1ARWD = 0.025f; booster1SRWD = 0.025f; booster1PWD = 0.025f; booster1SGWD = 0.025f; boosterAmmoType = "cryo";
                        break;
                    case "Disruptor Ammo I":
                        booster1ARWD = 0.025f; booster1SRWD = 0.025f; booster1PWD = 0.025f; booster1SGWD = 0.025f; boosterAmmoType = "disruptor"; boosterDisruptorVsShields = 1.25f;
                        break;
                    case "Incendiary Ammo I":
                        booster1ARWD = 0.025f; booster1SRWD = 0.025f; booster1PWD = 0.025f; booster1SGWD = 0.025f; boosterAmmoType = "incendiary";
                        break;
                    case "Cryo Ammo II":
                        booster1ARWD = 0.05f; booster1SRWD = 0.05f; booster1PWD = 0.05f; booster1SGWD = 0.05f; boosterAmmoType = "cryo";
                        break;
                    case "Disruptor Ammo II":
                        booster1ARWD = 0.05f; booster1SRWD = 0.05f; booster1PWD = 0.05f; booster1SGWD = 0.05f; boosterAmmoType = "disruptor"; boosterDisruptorVsShields = 1.25f;
                        break;
                    case "Incendiary Ammo II":
                        booster1ARWD = 0.05f; booster1SRWD = 0.05f; booster1PWD = 0.05f; booster1SGWD = 0.05f; boosterAmmoType = "incendiary";
                        break;
                    case "Cryo Ammo III":
                        booster1ARWD = 0.075f; booster1SRWD = 0.075f; booster1PWD = 0.075f; booster1SGWD = 0.075f; boosterAmmoType = "cryo";
                        break;
                    case "Disruptor Ammo III":
                        booster1ARWD = 0.075f; booster1SRWD = 0.075f; booster1PWD = 0.075f; booster1SGWD = 0.075f; boosterAmmoType = "disruptor"; boosterDisruptorVsShields = 1.25f;
                        break;
                    case "Incendiary Ammo III":
                        booster1ARWD = 0.075f; booster1SRWD = 0.075f; booster1PWD = 0.075f; booster1SGWD = 0.075f; boosterAmmoType = "incendiary";
                        break;
                    case "Cryo Ammo IV":
                        booster1ARWD = 0.1f; booster1SRWD = 0.1f; booster1PWD = 0.1f; booster1SGWD = 0.1f; boosterAmmoType = "cryo";
                        break;
                    case "Disruptor Ammo IV":
                        booster1ARWD = 0.1f; booster1SRWD = 0.1f; booster1PWD = 0.1f; booster1SGWD = 0.1f; boosterAmmoType = "disruptor"; boosterDisruptorVsShields = 1.25f;
                        break;
                    case "Incendiary Ammo IV":
                        booster1ARWD = 0.1f; booster1SRWD = 0.1f; booster1PWD = 0.1f; booster1SGWD = 0.1f; boosterAmmoType = "incendiary";
                        break;
                    case "AR Rail AMP I":
                        booster1ARWD = 0.1f;
                        break;
                    case "Pistol Rail AMP I":
                        booster1PWD = 0.1f;
                        break;
                    case "Shotgun Rail AMP I":
                        booster1SGWD = 0.1f;
                        break;
                    case "SR Rail AMP I":
                        booster1SRWD = 0.1f;
                        break;
                    case "AR Rail AMP II":
                        booster1ARWD = 0.2f;
                        break;
                    case "Pistol Rail AMP II":
                        booster1PWD = 0.2f;
                        break;
                    case "Shotgun Rail AMP II":
                        booster1SGWD = 0.2f;
                        break;
                    case "SR Rail AMP II":
                        booster1SRWD = 0.2f;
                        break;
                    case "AR Rail AMP III":
                        booster1ARWD = 0.3f;
                        break;
                    case "Pistol Rail AMP III":
                        booster1PWD = 0.3f;
                        break;
                    case "Shotgun Rail AMP III":
                        booster1SGWD = 0.3f;
                        break;
                    case "SR Rail AMP III":
                        booster1SRWD = 0.3f;
                        break;
                    case "AR Rail AMP IV":
                        booster1ARWD = 0.4f;
                        break;
                    case "Pistol Rail AMP IV":
                        booster1PWD = 0.4f;
                        break;
                    case "Shotgun Rail AMP IV":
                        booster1SGWD = 0.4f;
                        break;
                    case "SR Rail AMP IV":
                        booster1SRWD = 0.4f;
                        break;
                    case "Strenght Enhancer I":
                        booster1MD = 0.15f;
                        break;
                    case "Targeting VI I":
                        booster1Weak = 0.15f;
                        break;
                    case "Strenght Enhancer II":
                        booster1MD = 0.3f;
                        break;
                    case "Targeting VI II":
                        booster1Weak = 0.3f;
                        break;
                    case "Strenght Enhancer III":
                        booster1MD = 0.45f;
                        break;
                    case "Targeting VI III":
                        booster1Weak = 0.45f;
                        break;
                    case "Strenght Enhancer IV":
                        booster1MD = 0.6f;
                        break;
                    case "Targeting VI IV":
                        booster1Weak = 0.6f;
                        break;
                    case "Cyclonic Mod I":
                        booster1Shields = 0.1f;
                        break;
                    case "Cyclonic Mod II":
                        booster1Shields = 0.2f;
                        break;
                    case "Cyclonic Mod III":
                        booster1Shields = 0.3f;
                        break;
                    case "Cyclonic Mod IV":
                        booster1Shields = 0.4f;
                        break;
                    case "Biotic Power AMP I":
                        booster1BPD = 0.1f;
                        break;
                    case "Combat Power AMP I":
                        booster1CPD = 0.1f;
                        break;
                    case "Tech Power AMP I":
                        booster1TPD = 0.1f;
                        break;
                    case "Universal Power AMP I":
                        booster1ARWD = 0.05f; booster1SRWD = 0.05f; booster1PWD = 0.05f; booster1SGWD = 0.05f; booster1BPD = 0.05f; booster1TPD = 0.05f; booster1CPD = 0.05f; booster1MD = 0.05f;
                        break;
                    case "Power Efficency MOD I":
                        booster1PRS = 0.15f;
                        break;
                    case "Biotic Power AMP II":
                        booster1BPD = 0.2f;
                        break;
                    case "Combat Power AMP II":
                        booster1CPD = 0.2f;
                        break;
                    case "Tech Power AMP II":
                        booster1TPD = 0.2f;
                        break;
                    case "Universal Power AMP II":
                        booster1ARWD = 0.1f; booster1SRWD = 0.1f; booster1PWD = 0.1f; booster1SGWD = 0.1f; booster1BPD = 0.1f; booster1TPD = 0.1f; booster1CPD = 0.1f; booster1MD = 0.1f;
                        break;
                    case "Power Efficency MOD II":
                        booster1PRS = 0.3f;
                        break;
                    case "Biotic Power AMP III":
                        booster1BPD = 0.3f;
                        break;
                    case "Combat Power AMP III":
                        booster1CPD = 0.3f;
                        break;
                    case "Tech Power AMP III":
                        booster1TPD = 0.3f;
                        break;
                    case "Universal Power AMP III":
                        booster1ARWD = 0.15f; booster1SRWD = 0.15f; booster1PWD = 0.15f; booster1SGWD = 0.15f; booster1BPD = 0.15f; booster1TPD = 0.15f; booster1CPD = 0.15f; booster1MD = 0.15f;
                        break;
                    case "Power Efficency MOD III":
                        booster1PRS = 0.45f;
                        break;
                    case "Biotic Power AMP IV":
                        booster1BPD = 0.4f;
                        break;
                    case "Combat Power AMP IV":
                        booster1CPD = 0.4f;
                        break;
                    case "Tech Power AMP IV":
                        booster1TPD = 0.4f;
                        break;
                    case "Universal Power AMP IV":
                        booster1ARWD = 0.2f; booster1SRWD = 0.2f; booster1PWD = 0.2f; booster1SGWD = 0.2f; booster1BPD = 0.2f; booster1TPD = 0.2f; booster1CPD = 0.2f; booster1MD = 0.2f;
                        break;
                    case "Power Efficency MOD IV":
                        booster1PRS = 0.6f;
                        break;
                }

            BoosterIndex = 0;
            do
            {
                if (myBoosterArray[BoosterIndex].BoosterName.Equals(comboBoxSelectBooster2.Text.Split('*')[0])) break;
                BoosterIndex++;
            } while (BoosterIndex < constNrBoosters);



            if (BoosterIndex < constNrBoosters) switch (myBoosterArray[BoosterIndex].BoosterName)
                {
                    case "Cryo Ammo I":
                        booster2ARWD = 0.025f; booster2SRWD = 0.025f; booster2PWD = 0.025f; booster2SGWD = 0.025f; boosterAmmoType = "cryo";
                        break;
                    case "Disruptor Ammo I":
                        booster2ARWD = 0.025f; booster2SRWD = 0.025f; booster2PWD = 0.025f; booster2SGWD = 0.025f; boosterAmmoType = "disruptor"; boosterDisruptorVsShields = 1.25f;
                        break;
                    case "Incendiary Ammo I":
                        booster2ARWD = 0.025f; booster2SRWD = 0.025f; booster2PWD = 0.025f; booster2SGWD = 0.025f; boosterAmmoType = "incendiary";
                        break;
                    case "Cryo Ammo II":
                        booster2ARWD = 0.05f; booster2SRWD = 0.05f; booster2PWD = 0.05f; booster2SGWD = 0.05f; boosterAmmoType = "cryo";
                        break;
                    case "Disruptor Ammo II":
                        booster2ARWD = 0.05f; booster2SRWD = 0.05f; booster2PWD = 0.05f; booster2SGWD = 0.05f; boosterAmmoType = "disruptor"; boosterDisruptorVsShields = 1.25f;
                        break;
                    case "Incendiary Ammo II":
                        booster2ARWD = 0.05f; booster2SRWD = 0.05f; booster2PWD = 0.05f; booster2SGWD = 0.05f; boosterAmmoType = "incendiary";
                        break;
                    case "Cryo Ammo III":
                        booster2ARWD = 0.075f; booster2SRWD = 0.075f; booster2PWD = 0.075f; booster2SGWD = 0.075f; boosterAmmoType = "cryo";
                        break;
                    case "Disruptor Ammo III":
                        booster2ARWD = 0.075f; booster2SRWD = 0.075f; booster2PWD = 0.075f; booster2SGWD = 0.075f; boosterAmmoType = "disruptor"; boosterDisruptorVsShields = 1.25f;
                        break;
                    case "Incendiary Ammo III":
                        booster2ARWD = 0.075f; booster2SRWD = 0.075f; booster2PWD = 0.075f; booster2SGWD = 0.075f; boosterAmmoType = "incendiary";
                        break;
                    case "Cryo Ammo IV":
                        booster2ARWD = 0.1f; booster2SRWD = 0.1f; booster2PWD = 0.1f; booster2SGWD = 0.1f; boosterAmmoType = "cryo";
                        break;
                    case "Disruptor Ammo IV":
                        booster2ARWD = 0.1f; booster2SRWD = 0.1f; booster2PWD = 0.1f; booster2SGWD = 0.1f; boosterAmmoType = "disruptor"; boosterDisruptorVsShields = 1.25f;
                        break;
                    case "Incendiary Ammo IV":
                        booster2ARWD = 0.1f; booster2SRWD = 0.1f; booster2PWD = 0.1f; booster2SGWD = 0.1f; boosterAmmoType = "incendiary";
                        break;
                    case "AR Rail AMP I":
                        booster2ARWD = 0.1f;
                        break;
                    case "Pistol Rail AMP I":
                        booster2PWD = 0.1f;
                        break;
                    case "Shotgun Rail AMP I":
                        booster2SGWD = 0.1f;
                        break;
                    case "SR Rail AMP I":
                        booster2SRWD = 0.1f;
                        break;
                    case "AR Rail AMP II":
                        booster2ARWD = 0.2f;
                        break;
                    case "Pistol Rail AMP II":
                        booster2PWD = 0.2f;
                        break;
                    case "Shotgun Rail AMP II":
                        booster2SGWD = 0.2f;
                        break;
                    case "SR Rail AMP II":
                        booster2SRWD = 0.2f;
                        break;
                    case "AR Rail AMP III":
                        booster2ARWD = 0.3f;
                        break;
                    case "Pistol Rail AMP III":
                        booster2PWD = 0.3f;
                        break;
                    case "Shotgun Rail AMP III":
                        booster2SGWD = 0.3f;
                        break;
                    case "SR Rail AMP III":
                        booster2SRWD = 0.3f;
                        break;
                    case "AR Rail AMP IV":
                        booster2ARWD = 0.4f;
                        break;
                    case "Pistol Rail AMP IV":
                        booster2PWD = 0.4f;
                        break;
                    case "Shotgun Rail AMP IV":
                        booster2SGWD = 0.4f;
                        break;
                    case "SR Rail AMP IV":
                        booster2SRWD = 0.4f;
                        break;
                    case "Strenght Enhancer I":
                        booster2MD = 0.15f;
                        break;
                    case "Targeting VI I":
                        booster2Weak = 0.15f;
                        break;
                    case "Strenght Enhancer II":
                        booster2MD = 0.3f;
                        break;
                    case "Targeting VI II":
                        booster2Weak = 0.3f;
                        break;
                    case "Strenght Enhancer III":
                        booster2MD = 0.45f;
                        break;
                    case "Targeting VI III":
                        booster2Weak = 0.45f;
                        break;
                    case "Strenght Enhancer IV":
                        booster2MD = 0.6f;
                        break;
                    case "Targeting VI IV":
                        booster2Weak = 0.6f;
                        break;
                    case "Cyclonic Mod I":
                        booster2Shields = 0.1f;
                        break;
                    case "Cyclonic Mod II":
                        booster2Shields = 0.2f;
                        break;
                    case "Cyclonic Mod III":
                        booster2Shields = 0.3f;
                        break;
                    case "Biotic Power AMP I":
                        booster2BPD = 0.1f;
                        break;
                    case "Combat Power AMP I":
                        booster2CPD = 0.1f;
                        break;
                    case "Tech Power AMP I":
                        booster2TPD = 0.1f;
                        break;
                    case "Universal Power AMP I":
                        booster2ARWD = 0.05f; booster2SRWD = 0.05f; booster2PWD = 0.05f; booster2SGWD = 0.05f; booster2BPD = 0.05f; booster2TPD = 0.05f; booster2CPD = 0.05f; booster2MD = 0.05f;
                        break;
                    case "Power Efficency MOD I":
                        booster2PRS = 0.15f;
                        break;
                    case "Biotic Power AMP II":
                        booster2BPD = 0.2f;
                        break;
                    case "Combat Power AMP II":
                        booster2CPD = 0.2f;
                        break;
                    case "Tech Power AMP II":
                        booster2TPD = 0.2f;
                        break;
                    case "Universal Power AMP II":
                        booster2ARWD = 0.1f; booster2SRWD = 0.1f; booster2PWD = 0.1f; booster2SGWD = 0.1f; booster2BPD = 0.1f; booster2TPD = 0.1f; booster2CPD = 0.1f; booster2MD = 0.1f;
                        break;
                    case "Power Efficency MOD II":
                        booster2PRS = 0.3f;
                        break;
                    case "Biotic Power AMP III":
                        booster2BPD = 0.3f;
                        break;
                    case "Combat Power AMP III":
                        booster2CPD = 0.3f;
                        break;
                    case "Tech Power AMP III":
                        booster2TPD = 0.3f;
                        break;
                    case "Universal Power AMP III":
                        booster2ARWD = 0.15f; booster2SRWD = 0.15f; booster2PWD = 0.15f; booster2SGWD = 0.15f; booster2BPD = 0.15f; booster2TPD = 0.15f; booster2CPD = 0.15f; booster2MD = 0.15f;
                        break;
                    case "Power Efficency MOD III":
                        booster2PRS = 0.45f;
                        break;
                    case "Biotic Power AMP IV":
                        booster2BPD = 0.4f;
                        break;
                    case "Combat Power AMP IV":
                        booster2CPD = 0.4f;
                        break;
                    case "Tech Power AMP IV":
                        booster2TPD = 0.4f;
                        break;
                    case "Universal Power AMP IV":
                        booster2ARWD = 0.2f; booster2SRWD = 0.2f; booster2PWD = 0.2f; booster2SGWD = 0.2f; booster2BPD = 0.2f; booster2TPD = 0.2f; booster2CPD = 0.2f; booster2MD = 0.2f;
                        break;
                    case "Power Efficency MOD IV":
                        booster2PRS = 0.6f;
                        break;
                }


            // temp print them to debug
            if (booster1ARWD != 0) textBoxDebug.Text += "booster1ARWD = " + booster1ARWD.ToString() + " ";
            if (booster1SRWD != 0) textBoxDebug.Text += "booster1SRWD = " + booster1SRWD.ToString() + " ";
            if (booster1PWD != 0) textBoxDebug.Text += "booster1PWD = " + booster1PWD.ToString() + " ";
            if (booster1SGWD != 0) textBoxDebug.Text += "booster1SGWD = " + booster1SGWD.ToString() + " ";
            if (booster1MD != 0) textBoxDebug.Text += "booster1MD = " + booster1MD.ToString() + " ";
            if (booster1Weak != 0) textBoxDebug.Text += "booster1Weak = " + booster1Weak.ToString() + " ";
            if (booster1Shields != 0) textBoxDebug.Text += "booster1Shields = " + booster1Shields.ToString() + " ";
            if (booster1PRS != 0) textBoxDebug.Text += "booster1PRS = " + booster1PRS.ToString() + " ";
            if (booster1BPD != 0) textBoxDebug.Text += "booster1BPD = " + booster1BPD.ToString() + " ";
            if (booster1TPD != 0) textBoxDebug.Text += "booster1TPD = " + booster1TPD.ToString() + " ";
            if (booster1CPD != 0) textBoxDebug.Text += "booster1CPD = " + booster1CPD.ToString() + " ";

            if (booster2ARWD != 0) textBoxDebug.Text += "booster2ARWD = " + booster2ARWD.ToString() + " ";
            if (booster2SRWD != 0) textBoxDebug.Text += "booster2SRWD = " + booster2SRWD.ToString() + " ";
            if (booster2PWD != 0) textBoxDebug.Text += "booster2PWD = " + booster2PWD.ToString() + " ";
            if (booster2SGWD != 0) textBoxDebug.Text += "booster2SGWD = " + booster2SGWD.ToString() + " ";
            if (booster2MD != 0) textBoxDebug.Text += "booster2MD = " + booster2MD.ToString() + " ";
            if (booster2Weak != 0) textBoxDebug.Text += "booster2Weak = " + booster2Weak.ToString() + " ";
            if (booster2Shields != 0) textBoxDebug.Text += "booster2Shields = " + booster2Shields.ToString() + " ";
            if (booster2PRS != 0) textBoxDebug.Text += "booster2PRS = " + booster2PRS.ToString() + " ";
            if (booster2BPD != 0) textBoxDebug.Text += "booster2BPD = " + booster2BPD.ToString() + " ";
            if (booster2TPD != 0) textBoxDebug.Text += "booster2TPD = " + booster2TPD.ToString() + " ";
            if (booster2CPD != 0) textBoxDebug.Text += "booster2CPD = " + booster2CPD.ToString() + " ";

            if (boosterDisruptorVsShields != 1) textBoxDebug.Text += "boosterDisruptorVsShields = " + boosterDisruptorVsShields.ToString() + " ";

            if (!boosterAmmoType.Equals("none")) textBoxDebug.Text += "boosterAmmoType = " + boosterAmmoType + " ";




            int ApexIndex; ApexIndex = 0;
            do
            {
                if (myAPEXModsArray[ApexIndex].APEXModName.Equals(comboBoxSelectApex1.Text.Split('*')[0])) break;
                ApexIndex++;
            } while (ApexIndex < constNrAPEXMods);



            if (ApexIndex < constNrAPEXMods) switch (myAPEXModsArray[ApexIndex].APEXModName)
                {
                    case "Pistol Skirmish":
                        apex1ARWD = -0.5f; apex1SRWD = -0.5f; apex1PWD = 0.5f; apex1SGWD = -0.5f;
                        break;
                    case "Sniper Rifle Skirmish":
                        apex1ARWD = -0.5f; apex1SRWD = 0.5f; apex1PWD = -0.5f; apex1SGWD = -0.5f;
                        break;
                    case "Shotgun Skirmish":
                        apex1ARWD = -0.5f; apex1SRWD = -0.5f; apex1PWD = -0.5f; apex1SGWD = 0.5f;
                        break;
                    case "Assault Rifle Skirmish":
                        apex1ARWD = 0.5f; apex1SRWD = -0.5f; apex1PWD = -0.5f; apex1SGWD = -0.5f;
                        break;
                    case "Weakened Assault Team":
                        apex1Health = -0.25f; apex1Shields = -0.25f;
                        break;
                    case "Hand-to-Hand":
                        apex1MD = 1; apex1ARWD = -0.25f; apex1SRWD = -0.25f; apex1PWD = -0.25f; apex1SGWD = -0.25f; apex1BPD = -0.25f; apex1TPD = -0.25f; apex1CPD = -0.25f;
                        break;
                    case "Dampened Powers":
                        apex1BPD = -0.25f; apex1TPD = -0.25f; apex1CPD = -0.25f;
                        break;
                    case "Dampened Weapons":
                        apex1ARWD = -0.25f; apex1SRWD = -0.25f; apex1PWD = -0.25f; apex1SGWD = -0.25f; apex1MAG = -0.25f;
                        break;
                    case "Go for the eyes":
                        apex1ARWD = -0.5f; apex1SRWD = -0.5f; apex1PWD = -0.5f; apex1SGWD = -0.5f; apex1Weak = 6; apex1WeakL = 6;
                        break;
                    case "Combotastic":
                        apex1Combo = 1;
                        break;
                    case "Glass Jaw":
                        break;
                    case "Biotic Skirmish":
                        apex1BPD = 0.5f; apex1TPD = -0.5f; apex1CPD = -0.5f;
                        break;
                    case "Tech Skirmish":
                        apex1BPD = -0.5f; apex1TPD = 0.5f; apex1CPD = -0.5f;
                        break;
                    case "Combat Skirmish":
                        apex1BPD = -0.5f; apex1TPD = -0.5f; apex1CPD = 0.5f;
                        break;
                    case "Weakened Assault Team II":
                        apex1Health = -0.5f; apex1Shields = -0.5f;
                        break;
                    case "Hyper Shields":
                        apex1Health = -0.75f; apex1Shields = 1f;
                        break;
                }


            ApexIndex = 0;
            do
            {
                if (myAPEXModsArray[ApexIndex].APEXModName.Equals(comboBoxSelectApex2.Text.Split('*')[0])) break;
                ApexIndex++;
            } while (ApexIndex < constNrAPEXMods);



            if (ApexIndex < constNrAPEXMods) switch (myAPEXModsArray[ApexIndex].APEXModName)
                {
                    case "Pistol Skirmish":
                        apex2ARWD = -0.5f; apex2SRWD = -0.5f; apex2PWD = 0.5f; apex2SGWD = -0.5f;
                        break;
                    case "Sniper Rifle Skirmish":
                        apex2ARWD = -0.5f; apex2SRWD = 0.5f; apex2PWD = -0.5f; apex2SGWD = -0.5f;
                        break;
                    case "Shotgun Skirmish":
                        apex2ARWD = -0.5f; apex2SRWD = -0.5f; apex2PWD = -0.5f; apex2SGWD = 0.5f;
                        break;
                    case "Assault Rifle Skirmish":
                        apex2ARWD = 0.5f; apex2SRWD = -0.5f; apex2PWD = -0.5f; apex2SGWD = -0.5f;
                        break;
                    case "Weakened Assault Team":
                        apex2Health = -0.25f; apex2Shields = -0.25f;
                        break;
                    case "Hand-to-Hand":
                        apex2MD = 1; apex2ARWD = -0.25f; apex2SRWD = -0.25f; apex2PWD = -0.25f; apex2SGWD = -0.25f; apex2BPD = -0.25f; apex2TPD = -0.25f; apex2CPD = -0.25f;
                        break;
                    case "Dampened Powers":
                        apex2BPD = -0.25f; apex2TPD = -0.25f; apex2CPD = -0.25f;
                        break;
                    case "Dampened Weapons":
                        apex2ARWD = -0.25f; apex2SRWD = -0.25f; apex2PWD = -0.25f; apex2SGWD = -0.25f; apex2MAG = -0.25f;
                        break;
                    case "Go for the eyes":
                        apex2ARWD = -0.5f; apex2SRWD = -0.5f; apex2PWD = -0.5f; apex2SGWD = -0.5f; apex2Weak = 6; apex2WeakL = 6;
                        break;
                    case "Combotastic":
                        apex2Combo = 1;
                        break;
                    case "Glass Jaw":
                        break;
                    case "Biotic Skirmish":
                        apex2BPD = 0.5f; apex2TPD = -0.5f; apex2CPD = -0.5f;
                        break;
                    case "Tech Skirmish":
                        apex2BPD = -0.5f; apex2TPD = 0.5f; apex2CPD = -0.5f;
                        break;
                    case "Combat Skirmish":
                        apex2BPD = -0.5f; apex2TPD = -0.5f; apex2CPD = 0.5f;
                        break;
                    case "Weakened Assault Team II":
                        apex2Health = -0.5f; apex2Shields = -0.5f;
                        break;
                    case "Hyper Shields":
                        apex2Health = -0.75f; apex2Shields = 1f;
                        break;
                }


            // temp print them to debug
            if (apex1ARWD != 0) textBoxDebug.Text += "apex1ARWD = " + apex1ARWD.ToString() + " ";
            if (apex1SRWD != 0) textBoxDebug.Text += "apex1SRWD = " + apex1SRWD.ToString() + " ";
            if (apex1PWD != 0) textBoxDebug.Text += "apex1PWD = " + apex1PWD.ToString() + " ";
            if (apex1SGWD != 0) textBoxDebug.Text += "apex1SGWD = " + apex1SGWD.ToString() + " ";
            if (apex1MAG != 0) textBoxDebug.Text += "apex1MAG = " + apex1MAG.ToString() + " ";
            if (apex1MD != 0) textBoxDebug.Text += "apex1MD = " + apex1MD.ToString() + " ";
            if (apex1Weak != 0) textBoxDebug.Text += "apex1Weak = " + apex1Weak.ToString() + " ";
            if (apex1WeakL != 0) textBoxDebug.Text += "apex1WeakL = " + apex1WeakL.ToString() + " ";
            if (apex1Shields != 0) textBoxDebug.Text += "apex1Shields = " + apex1Shields.ToString() + " ";
            if (apex1Health != 0) textBoxDebug.Text += "apexHealth = " + apex1Health.ToString() + " ";
            //    if (apex1PRS != 0) textBoxDebug.Text += "apex1PRS = " + apex1PRS.ToString() + " ";
            if (apex1BPD != 0) textBoxDebug.Text += "apex1BPD = " + apex1BPD.ToString() + " ";
            if (apex1TPD != 0) textBoxDebug.Text += "apex1TPD = " + apex1TPD.ToString() + " ";
            if (apex1CPD != 0) textBoxDebug.Text += "apex1CPD = " + apex1CPD.ToString() + " ";
            if (apex1Combo != 0) textBoxDebug.Text += "apex1Combo = " + apex1Combo.ToString() + " ";

            if (apex2ARWD != 0) textBoxDebug.Text += "apex2ARWD = " + apex2ARWD.ToString() + " ";
            if (apex2SRWD != 0) textBoxDebug.Text += "apex2SRWD = " + apex2SRWD.ToString() + " ";
            if (apex2PWD != 0) textBoxDebug.Text += "apex2PWD = " + apex2PWD.ToString() + " ";
            if (apex2SGWD != 0) textBoxDebug.Text += "apex2SGWD = " + apex2SGWD.ToString() + " ";
            if (apex2MAG != 0) textBoxDebug.Text += "apex2MAG = " + apex2MAG.ToString() + " ";
            if (apex2MD != 0) textBoxDebug.Text += "apex2MD = " + apex2MD.ToString() + " ";
            if (apex2Weak != 0) textBoxDebug.Text += "apex2Weak = " + apex2Weak.ToString() + " ";
            if (apex2WeakL != 0) textBoxDebug.Text += "apex2WeakL = " + apex2WeakL.ToString() + " ";
            if (apex2Shields != 0) textBoxDebug.Text += "apex2Shields = " + apex2Shields.ToString() + " ";
            if (apex2Health != 0) textBoxDebug.Text += "apexHealth = " + apex2Health.ToString() + " ";
            //    if (apex2PRS != 0) textBoxDebug.Text += "apex2PRS = " + apex2PRS.ToString() + " ";
            if (apex2BPD != 0) textBoxDebug.Text += "apex2BPD = " + apex2BPD.ToString() + " ";
            if (apex2TPD != 0) textBoxDebug.Text += "apex2TPD = " + apex2TPD.ToString() + " ";
            if (apex2CPD != 0) textBoxDebug.Text += "apex2CPD = " + apex2CPD.ToString() + " ";
            if (apex2Combo != 0) textBoxDebug.Text += "apex2Combo = " + apex2Combo.ToString() + " ";


            string[] PassiveActiveSkillList = { "Rage", "Biotic Ascension" };
            //skill1 

            if ((checkBoxOnOffSkill1.Checked) || (PassiveActiveSkillList.Contains(labelSkill1Name.Text)))
            {
                //  textBoxDebug.Text += " Processing skill 1";

                // REPEAT FOR comboBoxSkill1_1.Text to comboBoxSkill1_6.Text

                foreach (string s in comboBoxSkill1_1.Text.Split(';'))
                {
                    //   if (s.Contains("fluff")) textBoxDebug.Text += "found FLUFFY";


                    if (s.StartsWith("WD=")) skill1WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill1_1.Checked)) skill1WDSum += float.Parse(s.Substring(4, s.Length - 4));

                    if (s.StartsWith("ROF=")) skill1ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill1MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill1PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill1_1.Checked)) skill1PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill1MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill1_1.Checked)) skill1MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //   if ((s.StartsWith("TShields=")) && (checkBoxSkill1_1.Checked)) skill1ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));
                    if (s.StartsWith("DR=")) skill1DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill1_1.Checked)) skill1DRSum += float.Parse(s.Substring(4, s.Length - 4));

                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill1_1.Checked)) skill1DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill1_1.Checked)) skill1ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill1_1.Checked)) skill1PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill1ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill1PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill1PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    // if (s.StartsWith("ArmorDebuff=")) skill1ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));
                }


                foreach (string s in comboBoxSkill1_2.Text.Split(';'))
                {

                    if (s.StartsWith("WD=")) skill1WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill1_2.Checked)) skill1WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill1ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill1MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill1PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill1_2.Checked)) skill1PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill1MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill1_2.Checked)) skill1MDSum += float.Parse(s.Substring(4, s.Length - 4));

                    //    if ((s.StartsWith("TShields=")) && (checkBoxSkill1_2.Checked)) skill1ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill1DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill1_2.Checked)) skill1DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill1_2.Checked)) skill1DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill1_2.Checked)) skill1ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill1_2.Checked)) skill1PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill1ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill1PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill1PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    //   if (s.StartsWith("ArmorDebuff=")) skill1ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }


                foreach (string s in comboBoxSkill1_3.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill1WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill1_3.Checked)) skill1WDSum += float.Parse(s.Substring(4, s.Length - 4));

                    if (s.StartsWith("ROF=")) skill1ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill1MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill1PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill1_3.Checked)) skill1PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill1MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill1_3.Checked)) skill1MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //    if ((s.StartsWith("TShields=")) && (checkBoxSkill1_3.Checked)) skill1ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill1DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill1_3.Checked)) skill1DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill1_3.Checked)) skill1DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill1_3.Checked)) skill1ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill1_3.Checked)) skill1PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill1ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill1PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill1PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    // if (s.StartsWith("ArmorDebuff=")) skill1ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }


                foreach (string s in comboBoxSkill1_4.Text.Split(';'))
                {

                    if (s.StartsWith("WD=")) skill1WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill1_4.Checked)) skill1WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill1ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill1MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill1PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill1_4.Checked)) skill1PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill1MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill1_4.Checked)) skill1MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //     if ((s.StartsWith("TShields=")) && (checkBoxSkill1_4.Checked)) skill1ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill1DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill1_4.Checked)) skill1DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill1_4.Checked)) skill1DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill1_4.Checked)) skill1ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill1_4.Checked)) skill1PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill1ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill1PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill1PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    // if (s.StartsWith("ArmorDebuff=")) skill1ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }


                foreach (string s in comboBoxSkill1_5.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill1WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill1_5.Checked)) skill1WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill1ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill1MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill1PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill1_5.Checked)) skill1PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill1MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill1_5.Checked)) skill1MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //    if ((s.StartsWith("TShields=")) && (checkBoxSkill1_5.Checked)) skill1ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill1DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill1_5.Checked)) skill1DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill1_5.Checked)) skill1DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill1_5.Checked)) skill1ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    if ((s.StartsWith("TPRS=")) && (checkBoxSkill1_5.Checked)) skill1PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill1ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill1PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill1PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    //   if (s.StartsWith("ArmorDebuff=")) skill1ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }


                foreach (string s in comboBoxSkill1_6.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill1WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill1_6.Checked)) skill1WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill1ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill1MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill1PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill1_6.Checked)) skill1PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill1MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill1_6.Checked)) skill1MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TShields=")) && (checkBoxSkill1_6.Checked)) skill1ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill1DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill1_6.Checked)) skill1DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill1_6.Checked)) skill1DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill1_6.Checked)) skill1ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill1_6.Checked)) skill1PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill1ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill1PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill1PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ArmorDebuff=")) skill1ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }



            }
            //skill2 
            if ((checkBoxOnOffSkill2.Checked) || (PassiveActiveSkillList.Contains(labelSkill2Name.Text)))
            {
                // textBoxDebug.Text += " Processing skill 2";

                foreach (string s in comboBoxSkill2_1.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill2WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill2_1.Checked)) skill2WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill2ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill2MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill2PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill2_1.Checked)) skill2PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill2MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill2_1.Checked)) skill2MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //      if ((s.StartsWith("TShields=")) && (checkBoxSkill2_1.Checked)) skill2ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill2DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill2_1.Checked)) skill2DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill2_1.Checked)) skill2DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill2_1.Checked)) skill2ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill2_1.Checked)) skill2PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill2ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill2PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill2PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    //    if (s.StartsWith("ArmorDebuff=")) skill2ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }

                foreach (string s in comboBoxSkill2_2.Text.Split(';'))
                {

                    if (s.StartsWith("WD=")) skill2WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill2_2.Checked)) skill2WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill1ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill2MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill2PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill2_2.Checked)) skill2PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill2MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill2_2.Checked)) skill2MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //     if ((s.StartsWith("TShields=")) && (checkBoxSkill2_2.Checked)) skill2ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill2DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill2_2.Checked)) skill2DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill2_2.Checked)) skill2DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill2_2.Checked)) skill2ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill2_2.Checked)) skill2PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill2ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill2PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill2PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    //  if (s.StartsWith("ArmorDebuff=")) skill2ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }


                foreach (string s in comboBoxSkill2_3.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill2WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill2_3.Checked)) skill2WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill1ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill2MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill2PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill2_3.Checked)) skill2PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill2MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill2_3.Checked)) skill2MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //    if ((s.StartsWith("TShields=")) && (checkBoxSkill2_3.Checked)) skill2ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill2DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill2_3.Checked)) skill2DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill2_3.Checked)) skill2DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill2_3.Checked)) skill2ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill2_3.Checked)) skill2PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill2ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill2PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill2PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    //  if (s.StartsWith("ArmorDebuff=")) skill2ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }


                foreach (string s in comboBoxSkill2_4.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill2WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill2_4.Checked)) skill2WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill1ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill2MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill2PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill2_4.Checked)) skill2PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill2MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill2_4.Checked)) skill2MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //    if ((s.StartsWith("TShields=")) && (checkBoxSkill2_4.Checked)) skill2ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill2DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill2_4.Checked)) skill2DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill2_4.Checked)) skill2DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill2_4.Checked)) skill2ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill2_4.Checked)) skill2PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill2ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill2PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill2PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    //    if (s.StartsWith("ArmorDebuff=")) skill2ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }


                foreach (string s in comboBoxSkill2_5.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill2WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill2_5.Checked)) skill2WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill2ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill2MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill2PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill2_5.Checked)) skill2PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill2MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill2_5.Checked)) skill2MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //  if ((s.StartsWith("TShields=")) && (checkBoxSkill2_5.Checked)) skill2ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill2DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill2_5.Checked)) skill2DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill2_5.Checked)) skill2DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill2_5.Checked)) skill2ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    if ((s.StartsWith("TPRS=")) && (checkBoxSkill2_5.Checked)) skill2PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill2ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill2PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill2PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    // if (s.StartsWith("ArmorDebuff=")) skill2ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }


                foreach (string s in comboBoxSkill2_6.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill2WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill2_6.Checked)) skill2WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill2ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill2MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill2PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill2_6.Checked)) skill2PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill2MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill2_6.Checked)) skill2MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TShields=")) && (checkBoxSkill2_6.Checked)) skill2ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill2DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill2_6.Checked)) skill2DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill2_6.Checked)) skill2DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill2_6.Checked)) skill2ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill2_6.Checked)) skill2PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill2ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill2PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill2PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ArmorDebuff=")) skill2ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }
            }

            //skill3
            if ((checkBoxOnOffSkill3.Checked) || (PassiveActiveSkillList.Contains(labelSkill3Name.Text)))
            {
                // textBoxDebug.Text += " Processing skill 3";

                foreach (string s in comboBoxSkill3_1.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill3WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill3_1.Checked)) skill3WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill3ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill3MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill3PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill3_1.Checked)) skill3PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill3MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill3_1.Checked)) skill3MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //   if ((s.StartsWith("TShields=")) && (checkBoxSkill3_1.Checked)) skill3ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill3DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill3_1.Checked)) skill3DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill3_1.Checked)) skill3DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill3_1.Checked)) skill3ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill3_1.Checked)) skill3PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill3ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill3PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill3PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    // if (s.StartsWith("ArmorDebuff=")) skill3ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));
                }

                foreach (string s in comboBoxSkill3_2.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill3WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill3_2.Checked)) skill3WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill3ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill3MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill3PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill3_2.Checked)) skill3PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill3MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill3_2.Checked)) skill3MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //   if ((s.StartsWith("TShields=")) && (checkBoxSkill3_2.Checked)) skill3ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill3DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill3_2.Checked)) skill3DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill3_2.Checked)) skill3DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill3_2.Checked)) skill3ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill3_2.Checked)) skill3PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill3ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill3PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill3PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    // if (s.StartsWith("ArmorDebuff=")) skill3ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }


                foreach (string s in comboBoxSkill3_3.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill3WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill3_3.Checked)) skill3WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill3ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill3MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill3PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill3_3.Checked)) skill3PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill3MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill3_3.Checked)) skill3MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //   if ((s.StartsWith("TShields=")) && (checkBoxSkill3_3.Checked)) skill3ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill3DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill3_3.Checked)) skill3DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill3_3.Checked)) skill3DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill3_3.Checked)) skill3ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill3_3.Checked)) skill3PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill3ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill3PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill3PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    // if (s.StartsWith("ArmorDebuff=")) skill3ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }


                foreach (string s in comboBoxSkill3_4.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill3WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill3_4.Checked)) skill3WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill3ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill3MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill3PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill3_4.Checked)) skill3PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill3MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill3_4.Checked)) skill3MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //   if ((s.StartsWith("TShields=")) && (checkBoxSkill3_4.Checked)) skill3ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill3DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill3_4.Checked)) skill3DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill3_4.Checked)) skill3DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill3_4.Checked)) skill3ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill3_4.Checked)) skill3PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill3ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill3PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill3PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    // if (s.StartsWith("ArmorDebuff=")) skill3ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }


                foreach (string s in comboBoxSkill3_5.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill3WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill3_5.Checked)) skill3WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill3ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill3MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill3PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill3_5.Checked)) skill3PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill3MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill3_5.Checked)) skill3MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    //   if ((s.StartsWith("TShields=")) && (checkBoxSkill3_5.Checked)) skill3ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill3DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill3_5.Checked)) skill3DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill3_5.Checked)) skill3DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill3_5.Checked)) skill3ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    if ((s.StartsWith("TPRS=")) && (checkBoxSkill3_5.Checked)) skill3PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill3ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill3PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill3PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    // if (s.StartsWith("ArmorDebuff=")) skill3ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }


                foreach (string s in comboBoxSkill3_6.Text.Split(';'))
                {
                    if (s.StartsWith("WD=")) skill3WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill3_6.Checked)) skill3WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ROF=")) skill3ROFSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill3MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill3PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill3_6.Checked)) skill3PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill3MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill3_6.Checked)) skill3MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TShields=")) && (checkBoxSkill3_6.Checked)) skill3ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill3DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill3_6.Checked)) skill3DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill3_6.Checked)) skill3DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TArmorDebuff=")) && (checkBoxSkill3_6.Checked)) skill3ArmorDebuffSum += float.Parse(s.Substring(13, s.Length - 13));
                    //if ((s.StartsWith("TPRS=")) && (checkBoxSkill3_6.Checked)) skill3PRS += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("ConHealth=")) skill3ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("PRP=")) skill3PRPSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PEN=")) skill3PenMulSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ArmorDebuff=")) skill3ArmorDebuffSum += float.Parse(s.Substring(12, s.Length - 12));

                }

            }

            //skill4 "passive"
            if ((checkBoxOnOffSkill4.Checked) || (PassiveActiveSkillList.Contains(labelSkill4Name.Text)))
            {
                //   textBoxDebug.Text += " Processing skill 4";

                foreach (string s in comboBoxSkill4_1.Text.Split(';'))
                {

                    if (s.StartsWith("WD=")) skill4WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill4_1.Checked)) skill4WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill4MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill4PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill4_1.Checked)) skill4PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill4MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill4_1.Checked)) skill4MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("Reload=")) skill4Reload += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("Weak=")) skill4Weak += float.Parse(s.Substring(5, s.Length - 5));
                    //   if (s.StartsWith("Combo=")) skill4Combo += float.Parse(s.Substring(6, s.Length - 6));

                    if (s.StartsWith("DR=")) skill4DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill4_1.Checked)) skill4DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    //    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill4_1.Checked)) skill4DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    // if (s.StartsWith("PRS="))  skill4PRS += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ConHealth=")) skill4ConHealth += float.Parse(s.Substring(10, s.Length - 10));

                    if (s.StartsWith("ConDam=")) skill4ConDam += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PEffectDur=")) skill4PEffectDur += float.Parse(s.Substring(11, s.Length - 11));
                    //       if (s.StartsWith("vsShields=")) skill4vsShields += float.Parse(s.Substring(10, s.Length - 10));
                    //      if (s.StartsWith("vsArmor=")) skill4vsArmor += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("ADR=")) && (checkBoxOnOffSkill4.Checked)) skill4DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("APD=")) && (checkBoxOnOffSkill4.Checked)) skill4PDSum += float.Parse(s.Substring(4, s.Length - 4));

                }

                foreach (string s in comboBoxSkill4_2.Text.Split(';'))
                {

                    if (s.StartsWith("WD=")) skill4WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill4_2.Checked)) skill4WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill4MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill4PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill4_2.Checked)) skill4PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill4MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill4_2.Checked)) skill4MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("Reload=")) skill4Reload += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("Weak=")) skill4Weak += float.Parse(s.Substring(5, s.Length - 5));
                    //    if (s.StartsWith("Combo=")) skill4Combo += float.Parse(s.Substring(6, s.Length - 6));

                    if (s.StartsWith("DR=")) skill4DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill4_2.Checked)) skill4DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    //   if ((s.StartsWith("TDebuff=")) && (checkBoxSkill4_2.Checked)) skill4DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    // if (s.StartsWith("PRS="))  skill4PRS += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ConHealth=")) skill4ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("ConDam=")) skill4ConDam += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PEffectDur=")) skill4PEffectDur += float.Parse(s.Substring(11, s.Length - 11));
                    //      if (s.StartsWith("vsShields=")) skill4vsShields += float.Parse(s.Substring(10, s.Length - 10));
                    //      if (s.StartsWith("vsArmor=")) skill4vsArmor += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("ADR=")) && (checkBoxOnOffSkill4.Checked)) skill4DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("APD=")) && (checkBoxOnOffSkill4.Checked)) skill4PDSum += float.Parse(s.Substring(4, s.Length - 4));
                }

                foreach (string s in comboBoxSkill4_3.Text.Split(';'))
                {

                    if (s.StartsWith("WD=")) skill4WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill4_3.Checked)) skill4WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill4MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill4PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill4_3.Checked)) skill4PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill4MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill4_3.Checked)) skill4MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("Reload=")) skill4Reload += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("Weak=")) skill4Weak += float.Parse(s.Substring(5, s.Length - 5));
                    // if (s.StartsWith("Combo=")) skill4Combo += float.Parse(s.Substring(6, s.Length - 6));

                    if (s.StartsWith("DR=")) skill4DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill4_3.Checked)) skill4DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    //  if ((s.StartsWith("TDebuff=")) && (checkBoxSkill4_3.Checked)) skill4DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    // if (s.StartsWith("PRS="))  skill4PRS += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ConHealth=")) skill4ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("ConDam=")) skill4ConDam += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PEffectDur=")) skill4PEffectDur += float.Parse(s.Substring(11, s.Length - 11));
                    //       if (s.StartsWith("vsShields=")) skill4vsShields += float.Parse(s.Substring(10, s.Length - 10));
                    //      if (s.StartsWith("vsArmor=")) skill4vsArmor += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("ADR=")) && (checkBoxOnOffSkill4.Checked)) skill4DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("APD=")) && (checkBoxOnOffSkill4.Checked)) skill4PDSum += float.Parse(s.Substring(4, s.Length - 4));
                }

                foreach (string s in comboBoxSkill4_4.Text.Split(';'))
                {


                    if (s.StartsWith("WD=")) skill4WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill4_4.Checked)) skill4WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill4MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill4PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill4_4.Checked)) skill4PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill4MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill4_4.Checked)) skill4MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("Reload=")) skill4Reload += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("Weak=")) skill4Weak += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("Combo=")) skill4Combo += float.Parse(s.Substring(6, s.Length - 6));
                    if (s.StartsWith("DR=")) skill4DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill4_4.Checked)) skill4DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill4_4.Checked)) skill4DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if (s.StartsWith("PRS=")) skill4PRS += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ConHealth=")) skill4ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("ConDam=")) skill4ConDam += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PEffectDur=")) skill4PEffectDur += float.Parse(s.Substring(11, s.Length - 11));
                    if (s.StartsWith("vsShields=")) skill4vsShields += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("vsArmor=")) skill4vsArmor += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("ADR=")) && (checkBoxOnOffSkill4.Checked)) skill4DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("APD=")) && (checkBoxOnOffSkill4.Checked)) skill4PDSum += float.Parse(s.Substring(4, s.Length - 4));
                }

                foreach (string s in comboBoxSkill4_5.Text.Split(';'))
                {

                    if (s.StartsWith("WD=")) skill4WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill4_5.Checked)) skill4WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill4MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("PD=")) skill4PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill4_5.Checked)) skill4PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill4MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill4_5.Checked)) skill4MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("Reload=")) skill4Reload += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("Weak=")) skill4Weak += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("Combo=")) skill4Combo += float.Parse(s.Substring(6, s.Length - 6));
                    if (s.StartsWith("DR=")) skill4DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill4_5.Checked)) skill4DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill4_5.Checked)) skill4DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    if (s.StartsWith("PRS=")) skill4PRS += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ConHealth=")) skill4ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("ConDam=")) skill4ConDam += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PEffectDur=")) skill4PEffectDur += float.Parse(s.Substring(11, s.Length - 11));
                    if (s.StartsWith("vsShields=")) skill4vsShields += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("vsArmor=")) skill4vsArmor += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("ADR=")) && (checkBoxOnOffSkill4.Checked)) skill4DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("APD=")) && (checkBoxOnOffSkill4.Checked)) skill4PDSum += float.Parse(s.Substring(4, s.Length - 4));
                }

                foreach (string s in comboBoxSkill4_6.Text.Split(';'))
                {


                    if (s.StartsWith("WD=")) skill4WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill4_6.Checked)) skill4WDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MAG=")) skill4MAGSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TBPD=")) && (checkBoxSkill4_6.Checked)) skill4BPD += float.Parse(s.Substring(5, s.Length - 5));
                    if (s.StartsWith("PD=")) skill4PDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TPD=")) && (checkBoxSkill4_6.Checked)) skill4PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("MD=")) skill4MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill4_6.Checked)) skill4MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("Reload=")) skill4Reload += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("Weak=")) skill4Weak += float.Parse(s.Substring(5, s.Length - 5));
                    //   if (s.StartsWith("Combo=")) skill4Combo += float.Parse(s.Substring(6, s.Length - 6));
                    if (s.StartsWith("DR=")) skill4DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill4_6.Checked)) skill4DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TDebuff=")) && (checkBoxSkill4_6.Checked)) skill4DebuffSum += float.Parse(s.Substring(8, s.Length - 8));
                    //if (s.StartsWith("PRS="))  skill4PRS += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ConHealth=")) skill4ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("ConDam=")) skill4ConDam += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PEffectDur=")) skill4PEffectDur += float.Parse(s.Substring(11, s.Length - 11));
                    //      if (s.StartsWith("vsShields=")) skill4vsShields += float.Parse(s.Substring(10, s.Length - 10));
                    //    if (s.StartsWith("vsArmor=")) skill4vsArmor += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("ADR=")) && (checkBoxOnOffSkill4.Checked)) skill4DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("APD=")) && (checkBoxOnOffSkill4.Checked)) skill4PDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("TPRTR=")) && (checkBoxSkill4_6.Checked)) skill4PRTR += float.Parse(s.Substring(6, s.Length - 6));

                }
            }

            //skill5 "fitness"
            if ((checkBoxOnOffSkill5.Checked) || (PassiveActiveSkillList.Contains(labelSkill5Name.Text)))
            {
                // textBoxDebug.Text += " Processing skill 5";

                foreach (string s in comboBoxSkill5_1.Text.Split(';'))
                {


                    if (s.StartsWith("WD=")) skill5WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill5_1.Checked)) skill5WDSum += float.Parse(s.Substring(4, s.Length - 4));

                    if (s.StartsWith("MD=")) skill5MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill5_1.Checked)) skill5MDSum += float.Parse(s.Substring(4, s.Length - 4));

                    if (s.StartsWith("Health=")) skill5HealthSum += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("Shields=")) skill5ShieldsSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TShields=")) && (checkBoxSkill5_1.Checked)) skill5ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill5DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill5_1.Checked)) skill5DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ConHealth=")) skill5ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("ConDam=")) skill5ConDam += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PEffectDur=")) skill5PEffectDur += float.Parse(s.Substring(11, s.Length - 11));

                    if (s.StartsWith("Support=")) skill5SupportSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TSupport=")) && (checkBoxSkill5_1.Checked)) skill5SupportSum += float.Parse(s.Substring(9, s.Length - 9));
                    if (s.StartsWith("Reload=")) skill5Reload += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PRS=")) skill5PRS += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("RDR=")) && (checkBoxOnOffSkill5.Checked)) skill5DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("RMD=")) && (checkBoxOnOffSkill5.Checked)) skill5MDSum += float.Parse(s.Substring(4, s.Length - 4));

                }

                foreach (string s in comboBoxSkill5_2.Text.Split(';'))
                {


                    if (s.StartsWith("WD=")) skill5WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill5_2.Checked)) skill5WDSum += float.Parse(s.Substring(4, s.Length - 4));

                    if (s.StartsWith("MD=")) skill5MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill5_2.Checked)) skill5MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("Health=")) skill5HealthSum += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("Shields=")) skill5ShieldsSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TShields=")) && (checkBoxSkill5_2.Checked)) skill5ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));
                    //TDebuff =
                    if (s.StartsWith("DR=")) skill5DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill5_2.Checked)) skill5DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ConHealth=")) skill5ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("ConDam=")) skill5ConDam += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PEffectDur=")) skill5PEffectDur += float.Parse(s.Substring(11, s.Length - 11));
                    if (s.StartsWith("Support=")) skill5SupportSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TSupport=")) && (checkBoxSkill5_2.Checked)) skill5SupportSum += float.Parse(s.Substring(9, s.Length - 9));
                    if (s.StartsWith("Reload=")) skill5Reload += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PRS=")) skill5PRS += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("RDR=")) && (checkBoxOnOffSkill5.Checked)) skill5DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("RMD=")) && (checkBoxOnOffSkill5.Checked)) skill5MDSum += float.Parse(s.Substring(4, s.Length - 4));
                }


                foreach (string s in comboBoxSkill5_3.Text.Split(';'))
                {


                    if (s.StartsWith("WD=")) skill5WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill5_3.Checked)) skill5WDSum += float.Parse(s.Substring(4, s.Length - 4));

                    if (s.StartsWith("MD=")) skill5MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill5_3.Checked)) skill5MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("Health=")) skill5HealthSum += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("Shields=")) skill5ShieldsSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TShields=")) && (checkBoxSkill5_3.Checked)) skill5ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));
                    //TDebuff =
                    if (s.StartsWith("DR=")) skill5DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill5_3.Checked)) skill5DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ConHealth=")) skill5ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("ConDam=")) skill5ConDam += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PEffectDur=")) skill5PEffectDur += float.Parse(s.Substring(11, s.Length - 11));
                    if (s.StartsWith("Support=")) skill5SupportSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TSupport=")) && (checkBoxSkill5_3.Checked)) skill5SupportSum += float.Parse(s.Substring(9, s.Length - 9));
                    if (s.StartsWith("Reload=")) skill5Reload += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PRS=")) skill5PRS += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("RDR=")) && (checkBoxOnOffSkill5.Checked)) skill5DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("RMD=")) && (checkBoxOnOffSkill5.Checked)) skill5MDSum += float.Parse(s.Substring(4, s.Length - 4));
                }


                foreach (string s in comboBoxSkill5_4.Text.Split(';'))
                {

                    if (s.StartsWith("WD=")) skill5WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill5_4.Checked)) skill5WDSum += float.Parse(s.Substring(4, s.Length - 4));

                    if (s.StartsWith("MD=")) skill5MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill5_4.Checked)) skill5MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("Health=")) skill5HealthSum += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("Shields=")) skill5ShieldsSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TShields=")) && (checkBoxSkill5_4.Checked)) skill5ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));

                    if (s.StartsWith("DR=")) skill5DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill5_4.Checked)) skill5DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ConHealth=")) skill5ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("ConDam=")) skill5ConDam += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PEffectDur=")) skill5PEffectDur += float.Parse(s.Substring(11, s.Length - 11));
                    if (s.StartsWith("Support=")) skill5SupportSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TSupport=")) && (checkBoxSkill5_4.Checked)) skill5SupportSum += float.Parse(s.Substring(9, s.Length - 9));
                    if (s.StartsWith("Reload=")) skill5Reload += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PRS=")) skill5PRS += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("RDR=")) && (checkBoxOnOffSkill5.Checked)) skill5DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("RMD=")) && (checkBoxOnOffSkill5.Checked)) skill5MDSum += float.Parse(s.Substring(4, s.Length - 4));
                }


                foreach (string s in comboBoxSkill5_5.Text.Split(';'))
                {

                    if (s.StartsWith("WD=")) skill5WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill5_5.Checked)) skill5WDSum += float.Parse(s.Substring(4, s.Length - 4));

                    if (s.StartsWith("MD=")) skill5MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill5_5.Checked)) skill5MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("Health=")) skill5HealthSum += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("Shields=")) skill5ShieldsSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TShields=")) && (checkBoxSkill5_5.Checked)) skill5ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));
                    //TDebuff =
                    if (s.StartsWith("DR=")) skill5DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill5_5.Checked)) skill5DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ConHealth=")) skill5ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("ConDam=")) skill5ConDam += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PEffectDur=")) skill5PEffectDur += float.Parse(s.Substring(11, s.Length - 11));
                    if (s.StartsWith("Support=")) skill5SupportSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TSupport=")) && (checkBoxSkill5_5.Checked)) skill5SupportSum += float.Parse(s.Substring(9, s.Length - 9));
                    if (s.StartsWith("Reload=")) skill5Reload += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PRS=")) skill5PRS += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("RDR=")) && (checkBoxOnOffSkill5.Checked)) skill5DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("RMD=")) && (checkBoxOnOffSkill5.Checked)) skill5MDSum += float.Parse(s.Substring(4, s.Length - 4));
                }


                foreach (string s in comboBoxSkill5_6.Text.Split(';'))
                {

                    if (s.StartsWith("WD=")) skill5WDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TWD=")) && (checkBoxSkill5_6.Checked)) skill5WDSum += float.Parse(s.Substring(4, s.Length - 4));

                    if (s.StartsWith("MD=")) skill5MDSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TMD=")) && (checkBoxSkill5_6.Checked)) skill5MDSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("Health=")) skill5HealthSum += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("Shields=")) skill5ShieldsSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TShields=")) && (checkBoxSkill5_6.Checked)) skill5ShieldsSum += float.Parse(s.Substring(9, s.Length - 9));
                    //TDebuff =
                    if (s.StartsWith("DR=")) skill5DRSum += float.Parse(s.Substring(3, s.Length - 3));
                    if ((s.StartsWith("TDR=")) && (checkBoxSkill5_6.Checked)) skill5DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if (s.StartsWith("ConHealth=")) skill5ConHealth += float.Parse(s.Substring(10, s.Length - 10));
                    if (s.StartsWith("ConDam=")) skill5ConDam += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PEffectDur=")) skill5PEffectDur += float.Parse(s.Substring(11, s.Length - 11));
                    if (s.StartsWith("Support=")) skill5SupportSum += float.Parse(s.Substring(8, s.Length - 8));
                    if ((s.StartsWith("TSupport=")) && (checkBoxSkill5_6.Checked)) skill5SupportSum += float.Parse(s.Substring(9, s.Length - 9));
                    if (s.StartsWith("Reload=")) skill5Reload += float.Parse(s.Substring(7, s.Length - 7));
                    if (s.StartsWith("PRS=")) skill5PRS += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("RDR=")) && (checkBoxOnOffSkill5.Checked)) skill5DRSum += float.Parse(s.Substring(4, s.Length - 4));
                    if ((s.StartsWith("RMD=")) && (checkBoxOnOffSkill5.Checked)) skill5MDSum += float.Parse(s.Substring(4, s.Length - 4));

                }
            }

            // temp changed values for debug
            if (skill1WDSum != 0) textBoxDebug.Text += "skill1WDSum = " + skill1WDSum.ToString() + " ";
            if (skill1ROFSum != 0) textBoxDebug.Text += "skill1ROFSum = " + skill1ROFSum.ToString() + " ";
            if (skill1MAGSum != 0) textBoxDebug.Text += "skill1MAGSum = " + skill1MAGSum.ToString() + " ";
            if (skill1PDSum != 0) textBoxDebug.Text += "skill1PDSum  = " + skill1PDSum.ToString() + " ";
            if (skill1MDSum != 0) textBoxDebug.Text += "skill1MDSum  = " + skill1MDSum.ToString() + " ";
            if (skill1ShieldsSum != 0) textBoxDebug.Text += "skill1ShieldsSum  = " + skill1ShieldsSum.ToString() + " ";
            if (skill1DRSum != 0) textBoxDebug.Text += "skill1DRSum = " + skill1DRSum.ToString() + " ";
            if (skill1DebuffSum != 0) textBoxDebug.Text += "skill1DebuffSum = " + skill1DebuffSum.ToString() + " ";
            if (skill1ArmorDebuffSum != 0) textBoxDebug.Text += "skill1ArmorDebuffSum = " + skill1ArmorDebuffSum.ToString() + " ";
            if (skill1PRS != 0) textBoxDebug.Text += "skill1PRS  = " + skill1PRS.ToString() + " ";
            if (skill1ConHealth != 0) textBoxDebug.Text += "skill1ConHealth  = " + skill1ConHealth.ToString() + " ";
            if (skill1PRPSum != 0) textBoxDebug.Text += "skill1PRPSum  = " + skill1PRPSum.ToString() + " ";
            if (skill1PenMulSum != 0) textBoxDebug.Text += "skill1PenMulSum  = " + skill1PenMulSum.ToString() + " ";


            if (skill2WDSum != 0) textBoxDebug.Text += "skill2WDSum = " + skill2WDSum.ToString() + " ";
            if (skill2ROFSum != 0) textBoxDebug.Text += "skill2ROFSum = " + skill2ROFSum.ToString() + " ";
            if (skill2MAGSum != 0) textBoxDebug.Text += "skill2MAGSum = " + skill2MAGSum.ToString() + " ";
            if (skill2PDSum != 0) textBoxDebug.Text += "skill2PDSum  = " + skill2PDSum.ToString() + " ";
            if (skill2MDSum != 0) textBoxDebug.Text += "skill2MDSum  = " + skill2MDSum.ToString() + " ";
            if (skill2ShieldsSum != 0) textBoxDebug.Text += "skill2ShieldsSum  = " + skill2ShieldsSum.ToString() + " ";
            if (skill2DRSum != 0) textBoxDebug.Text += "skill2DRSum = " + skill2DRSum.ToString() + " ";
            if (skill2DebuffSum != 0) textBoxDebug.Text += "skill2DebuffSum = " + skill2DebuffSum.ToString() + " ";
            if (skill2ArmorDebuffSum != 0) textBoxDebug.Text += "skill2ArmorDebuffSum = " + skill2ArmorDebuffSum.ToString() + " ";
            if (skill2PRS != 0) textBoxDebug.Text += "skill2PRS  = " + skill2PRS.ToString() + " ";
            if (skill2ConHealth != 0) textBoxDebug.Text += "skill2ConHealth  = " + skill2ConHealth.ToString() + " ";
            if (skill2PRPSum != 0) textBoxDebug.Text += "skill2PRPSum  = " + skill2PRPSum.ToString() + " ";
            if (skill2PenMulSum != 0) textBoxDebug.Text += "skill2PenMulSum  = " + skill2PenMulSum.ToString() + " ";


            if (skill3WDSum != 0) textBoxDebug.Text += "skill3WDSum = " + skill3WDSum.ToString() + " ";
            if (skill3ROFSum != 0) textBoxDebug.Text += "skill3ROFSum = " + skill3ROFSum.ToString() + " ";
            if (skill3MAGSum != 0) textBoxDebug.Text += "skill3MAGSum = " + skill3MAGSum.ToString() + " ";
            if (skill3PDSum != 0) textBoxDebug.Text += "skill3PDSum  = " + skill3PDSum.ToString() + " ";
            if (skill3MDSum != 0) textBoxDebug.Text += "skill3MDSum  = " + skill3MDSum.ToString() + " ";
            if (skill3ShieldsSum != 0) textBoxDebug.Text += "skill3ShieldsSum  = " + skill3ShieldsSum.ToString() + " ";
            if (skill3DRSum != 0) textBoxDebug.Text += "skill3DRSum = " + skill3DRSum.ToString() + " ";
            if (skill3DebuffSum != 0) textBoxDebug.Text += "skill3DebuffSum = " + skill3DebuffSum.ToString() + " ";
            if (skill3ArmorDebuffSum != 0) textBoxDebug.Text += "skill3ArmorDebuffSum = " + skill3ArmorDebuffSum.ToString() + " ";
            if (skill3PRS != 0) textBoxDebug.Text += "skill3PRS  = " + skill3PRS.ToString() + " ";
            if (skill3ConHealth != 0) textBoxDebug.Text += "skill3ConHealth  = " + skill3ConHealth.ToString() + " ";
            if (skill3PRPSum != 0) textBoxDebug.Text += "skill3PRPSum  = " + skill3PRPSum.ToString() + " ";
            if (skill3PenMulSum != 0) textBoxDebug.Text += "skill3PenMulSum  = " + skill3PenMulSum.ToString() + " ";


            if (skill4WDSum != 0) textBoxDebug.Text += "skill4WDSum = " + skill4WDSum.ToString() + " ";
            if (skill4MAGSum != 0) textBoxDebug.Text += "skill4MAGSum = " + skill4MAGSum.ToString() + " ";
            if (skill4PDSum != 0) textBoxDebug.Text += "skill4PDSum  = " + skill4PDSum.ToString() + " ";
            if (skill4BPD != 0) textBoxDebug.Text += "skill4BPD  = " + skill4BPD.ToString() + " ";
            if (skill4MDSum != 0) textBoxDebug.Text += "skill4MDSum  = " + skill4MDSum.ToString() + " ";
            if (skill4Reload != 0) textBoxDebug.Text += "skill4Reload  = " + skill4Reload.ToString() + " ";
            if (skill4Weak != 0) textBoxDebug.Text += "skill4Weak  = " + skill4Weak.ToString() + " ";
            if (skill4DRSum != 0) textBoxDebug.Text += "skill4DRSum = " + skill4DRSum.ToString() + " ";
            if (skill4DebuffSum != 0) textBoxDebug.Text += "skill4DebuffSum = " + skill4DebuffSum.ToString() + " ";
            if (skill4Combo != 0) textBoxDebug.Text += "skill4Combo = " + skill4Combo.ToString() + " ";
            if (skill4PRS != 0) textBoxDebug.Text += "skill4PRS  = " + skill4PRS.ToString() + " ";
            if (skill4ConHealth != 0) textBoxDebug.Text += "skill4ConHealth  = " + skill4ConHealth.ToString() + " ";
            if (skill4ConDam != 0) textBoxDebug.Text += "skill4ConDam  = " + skill4ConDam.ToString() + " ";
            if (skill4PEffectDur != 0) textBoxDebug.Text += "skill4PEffectDur = " + skill4PEffectDur.ToString() + " ";
            if (skill4vsShields != 0) textBoxDebug.Text += "skill4vsShields  = " + skill4vsShields.ToString() + " ";
            if (skill4vsArmor != 0) textBoxDebug.Text += "skill4vsArmor = " + skill4vsArmor.ToString() + " ";
            if (skill4PRTR != 0) textBoxDebug.Text += "skill4PRTR = " + skill4PRTR.ToString() + " ";

            if (skill5WDSum != 0) textBoxDebug.Text += "skill5WDSum = " + skill5WDSum.ToString() + " ";
            if (skill5MDSum != 0) textBoxDebug.Text += "skill5MDSum  = " + skill5MDSum.ToString() + " ";
            if (skill5HealthSum != 0) textBoxDebug.Text += "skill5HealthSum  = " + skill5HealthSum.ToString() + " ";
            if (skill5ShieldsSum != 0) textBoxDebug.Text += "skill5ShieldsSum  = " + skill5ShieldsSum.ToString() + " ";
            if (skill5DRSum != 0) textBoxDebug.Text += "skill5DRSum = " + skill5DRSum.ToString() + " ";
            if (skill5ConHealth != 0) textBoxDebug.Text += "skill5ConHealth  = " + skill5ConHealth.ToString() + " ";
            if (skill5ConDam != 0) textBoxDebug.Text += "skill5ConDam  = " + skill5ConDam.ToString() + " ";
            if (skill5PEffectDur != 0) textBoxDebug.Text += "skill5PEffectDur  = " + skill5PEffectDur.ToString() + " ";
            if (skill5SupportSum != 0) textBoxDebug.Text += "skill5SupportSum  = " + skill5SupportSum.ToString() + " ";
            if (skill5Reload != 0) textBoxDebug.Text += "skill5Reload  = " + skill5Reload.ToString() + " ";
            if (skill5PRS != 0) textBoxDebug.Text += "skill5PRS  = " + skill5PRS.ToString() + " ";


            //////////
            /////////////  END OF POPULATING PARAMETER VARIABLES; CALCULATIONS BELLOW
            ///////////

            //////// Char Stats: MaxShields, MaxHealth, Melee and Jump Melee damage ..
            ////////

            textBoxCharacterStats.Text = "";

            // find Selected character Index 
            int SelectedCharIndex;

            //  SelectedCharIndex=0;
            //   do
            //    {
            //        if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals(comboBoxSelectChars.Text)) break;
            //        SelectedCharIndex ++;
            //   } while (SelectedCharIndex < constNumberChars);

            SelectedCharIndex = comboBoxSelectChars.SelectedIndex;


            //CURRENT DR
            textBoxCharacterStats.Text += "Sum of Damage Reduction Active on character ";
            float SumAdditives; SumAdditives = 0;
            if (skill1DRSum != 0) { SumAdditives += skill1DRSum; textBoxCharacterStats.Text += " '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill " + skill1DRSum.ToString(); }
            if (skill2DRSum != 0) { SumAdditives += skill2DRSum; textBoxCharacterStats.Text += " '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill " + skill2DRSum.ToString(); }
            if (skill3DRSum != 0) { SumAdditives += skill3DRSum; textBoxCharacterStats.Text += " '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill " + skill3DRSum.ToString(); }
            if (skill4DRSum != 0) { SumAdditives += skill4DRSum; textBoxCharacterStats.Text += " '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill " + skill4DRSum.ToString(); }
            if (skill5DRSum != 0) { SumAdditives += skill5DRSum; textBoxCharacterStats.Text += " '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill " + skill5DRSum.ToString(); }

            textBoxCharacterStats.Text += " = " + SumAdditives.ToString() + " \r\n\r\n"; float ActiveCharDR; ActiveCharDR = SumAdditives;

            // MAX HEALTH

            // Need to Calculate the result but also display the terms ..
            textBoxCharacterStats.Text += "MaxHealth = Base Health " + playingCharactersArray[SelectedCharIndex].BaseCharacterHealth.ToString() + " * (1 ";
            SumAdditives = 1;    //Simple formula = base * (1 + sum additives);

            // A list of "suspects" health suspects: Bonus, Apex1Health, Apex2Health Skill5HealthSum

            if (float.Parse(comboBoxBonusHealth.Text) != 0) { SumAdditives += float.Parse(comboBoxBonusHealth.Text) / 100; textBoxCharacterStats.Text += " + Bonus 'Max Health' Stat" + float.Parse(comboBoxBonusHealth.Text) / 100; }
            if (apex1Health != 0) { SumAdditives += apex1Health; textBoxCharacterStats.Text += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1Health.ToString(); }
            if (apex2Health != 0) { SumAdditives += apex2Health; textBoxCharacterStats.Text += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2Health.ToString(); }
            if (skill5HealthSum != 0) { SumAdditives += skill5HealthSum; textBoxCharacterStats.Text += " + Health from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5HealthSum.ToString(); }

            textBoxCharacterStats.Text += " ) = " + (playingCharactersArray[SelectedCharIndex].BaseCharacterHealth * SumAdditives).ToString() + " EffectiveHealth = " + (playingCharactersArray[SelectedCharIndex].BaseCharacterHealth * SumAdditives * (1 + ActiveCharDR)).ToString() + " \r\n";

            // MAX Shields

            // Need to Calculate the result but also display the terms ..
            textBoxCharacterStats.Text += "MaxShields = Base Shields " + playingCharactersArray[SelectedCharIndex].BaseCharacterShields.ToString() + " * (1 ";
            SumAdditives = 1;    //Simple formula = base * (1 + sum additives);

            // 
            if (float.Parse(comboBoxBonusShields.Text) != 0) { SumAdditives += float.Parse(comboBoxBonusShields.Text) / 100; textBoxCharacterStats.Text += " + Bonus 'Max Shields' Stat" + float.Parse(comboBoxBonusShields.Text) / 100; }
            if (gearShields != 0) { SumAdditives += gearShields; textBoxCharacterStats.Text += " + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearShields.ToString(); }
            if (booster1Shields != 0) { SumAdditives += booster1Shields; textBoxCharacterStats.Text += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1Shields.ToString(); }
            if (booster2Shields != 0) { SumAdditives += booster2Shields; textBoxCharacterStats.Text += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2Shields.ToString(); }
            if (apex1Shields != 0) { SumAdditives += apex1Shields; textBoxCharacterStats.Text += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1Shields.ToString(); }
            if (apex2Shields != 0) { SumAdditives += apex2Shields; textBoxCharacterStats.Text += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2Shields.ToString(); }
            if (skill1ShieldsSum != 0) { SumAdditives += skill1ShieldsSum; textBoxCharacterStats.Text += " + Shields from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1ShieldsSum.ToString(); }
            if (skill2ShieldsSum != 0) { SumAdditives += skill2ShieldsSum; textBoxCharacterStats.Text += " + Shields from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2ShieldsSum.ToString(); }
            if (skill3ShieldsSum != 0) { SumAdditives += skill3ShieldsSum; textBoxCharacterStats.Text += " + Shields from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3ShieldsSum.ToString(); }
            if (skill5ShieldsSum != 0) { SumAdditives += skill5ShieldsSum; textBoxCharacterStats.Text += " + Shields from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5ShieldsSum.ToString(); }

            textBoxCharacterStats.Text += " ) = " + (playingCharactersArray[SelectedCharIndex].BaseCharacterShields * SumAdditives).ToString() + " EffectiveShields = " + (playingCharactersArray[SelectedCharIndex].BaseCharacterShields * SumAdditives * (1 + ActiveCharDR)).ToString() + " \r\n\r\n";

            // Melee Damage is a bit more involved 
            // BMD * VsDefence * (1 + SumMD) * (1 + SumDebuff)
            const float BaseJumpMeleeDamage = 385;
            const float JumpMeleeImpactPercent = 0.333f;
            const float JumpMeleeAOEPercent = 0.667f;
            const float BasePullHammer = 1200;


            textBoxCharacterStats.Text += "formula: BaseMD * (1 + SumMD) * (1 + (SumDebuff + SumArmorDebuff) * (1 + SupportSum) + SquadDebuff) * (1 + CharacterMeleeBonusVsDefence) \r\n\r\n";
            textBoxCharacterStats.Text += " some debuffs, ex Pull's expose cannot be activated vs Armor or Shields - I don't account for that here - but you can tick that debuff off in UI if you want numbers without it and RE-Calculate) \r\n";
            textBoxCharacterStats.Text += "vsArmorDebuff from different skills on same char don't stack - CryoBeam and CryoTurret on HEngineer \r\n";
                               
            string tempString1, tempString2, tempString3, tempString4, tempString5, tempString6, tempString7, tempString8, tempString9, tempString10, tempString11, tempString12;
            tempString1 = tempString2 = tempString3 = tempString4 = tempString5 = tempString6 = tempString7 = tempString8 = tempString9 = tempString10 = tempString11 = tempString12 = "";

                 

            tempString1 += "Melee Damage vs Health = Base Melee Damage " + playingCharactersArray[SelectedCharIndex].BaseCharacterMeleeDamage.ToString() + " * ( 1";
            tempString2 += "Melee Damage vs Shields = Base Melee Damage " + playingCharactersArray[SelectedCharIndex].BaseCharacterMeleeDamage.ToString() + " * ( 1";
            tempString3 += "Melee Damage vs Armor = Base Melee Damage " + playingCharactersArray[SelectedCharIndex].BaseCharacterMeleeDamage.ToString() + " * ( 1";

            tempString4 += "Jump Melee Impact Damage vs Health = Base Jump Melee Impact Damage " + (BaseJumpMeleeDamage * JumpMeleeImpactPercent).ToString() + " * ( 1";
            tempString5 += "Jump Melee Impact Damage vs Shields = Base Jump Melee Impact Damage " + (BaseJumpMeleeDamage * JumpMeleeImpactPercent).ToString() + " * ( 1";
            tempString6 += "Jump Melee Impact Damage vs Armor = Base Jump Melee Impact Damage " + (BaseJumpMeleeDamage * JumpMeleeImpactPercent).ToString() + " * ( 1";

            tempString7 += "Jump Melee AOE Damage vs Health = Base Jump Melee AOE Damage " + (BaseJumpMeleeDamage * JumpMeleeAOEPercent).ToString() + " * ( 1";
            tempString8 += "Jump Melee AOE Damage vs Shields = Base Jump Melee AOE Damage " + (BaseJumpMeleeDamage * JumpMeleeAOEPercent).ToString() + " * ( 1";
            tempString9 += "Jump Melee AOE Damage vs Armor = Base Jump Melee AOE Damage " + (BaseJumpMeleeDamage * JumpMeleeAOEPercent).ToString() + " * ( 1";

            if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator")) {
                tempString10 += "Pull + Hammer AOE Damage vs Health = Base Pull + Hammer AOE Damage " + BasePullHammer.ToString() + " * ( 1";
                tempString11 += "Pull + Hammer AOE Damage vs Shields = Base Pull + Hammer AOE Damage " + BasePullHammer.ToString() + " * ( 1";
                tempString12 += "Pull + Hammer AOE Damage vs Armor = Base Pull + Hammer AOE Damage " + BasePullHammer.ToString() + " * ( 1";
            }

            SumAdditives = 0;

            if (playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus != 0) { SumAdditives += playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus;
                tempString1 += "  + Hidden Class Melee" + playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus.ToString(); tempString2 += "  + Hidden Class Melee" + playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus.ToString(); tempString3 += "  + Hidden Class Melee" + playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus.ToString();
                tempString4 += "  + Hidden Class Melee" + playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus.ToString(); tempString5 += "  + Hidden Class Melee" + playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus.ToString(); tempString6 += "  + Hidden Class Melee" + playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus.ToString();
                tempString7 += "  + Hidden Class Melee" + playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus.ToString(); tempString8 += "  + Hidden Class Melee" + playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus.ToString(); tempString9 += "  + Hidden Class Melee" + playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus.ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                        {
                    tempString10 += "  + Hidden Class Melee" + playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus.ToString(); tempString11 += "  + Hidden Class Melee" + playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus.ToString(); tempString12 += "  + Hidden Class Melee" + playingCharactersArray[SelectedCharIndex].HiddenMeleeDamageBonus.ToString();
                        }
            }
            if (myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus != 0) { SumAdditives += myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus;
                tempString1 += "  + '" + myGunArray[comboBoxSelectWeapon.SelectedIndex].weaponName + "' built in Melee" + myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus.ToString() ; tempString2 += "  + '" + myGunArray[comboBoxSelectWeapon.SelectedIndex].weaponName + "' built in Melee" + myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus.ToString(); tempString3 += "  + '" + myGunArray[comboBoxSelectWeapon.SelectedIndex].weaponName + "' built in Melee" + myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus.ToString() ;
                tempString4 += "  + '" + myGunArray[comboBoxSelectWeapon.SelectedIndex].weaponName + "' built in Melee" + myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus.ToString() ; tempString5 += "  + '" + myGunArray[comboBoxSelectWeapon.SelectedIndex].weaponName + "' built in Melee" + myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus.ToString(); tempString6 += "  + '" + myGunArray[comboBoxSelectWeapon.SelectedIndex].weaponName + "' built in Melee" + myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus.ToString() ;
                tempString7 += "  + '" + myGunArray[comboBoxSelectWeapon.SelectedIndex].weaponName + "' built in Melee" + myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus.ToString() ; tempString8 += "  + '" + myGunArray[comboBoxSelectWeapon.SelectedIndex].weaponName + "' built in Melee" + myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus.ToString() ; tempString9 += "  + '" + myGunArray[comboBoxSelectWeapon.SelectedIndex].weaponName + "' built in Melee" + myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus.ToString() ;
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += "  + '" + myGunArray[comboBoxSelectWeapon.SelectedIndex].weaponName + "' built in Melee" + myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus.ToString() ; tempString11 += "  + '" + myGunArray[comboBoxSelectWeapon.SelectedIndex].weaponName + "' built in Melee" + myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus.ToString() ; tempString12 += "  + '" + myGunArray[comboBoxSelectWeapon.SelectedIndex].weaponName + "' built in Melee" + myGunArray[comboBoxSelectWeapon.SelectedIndex].meleeBuiltInBonus.ToString() ;
                }

            }
            if (gearMD != 0) { SumAdditives += gearMD;
                tempString1 +=" + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearMD.ToString(); tempString2 +=" + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearMD.ToString(); tempString3 +=" + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearMD.ToString();
                tempString4 +=" + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearMD.ToString(); tempString5 +=" + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearMD.ToString(); tempString6 +=" + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearMD.ToString();
                tempString7 +=" + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearMD.ToString(); tempString8 +=" + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearMD.ToString(); tempString9 +=" + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearMD.ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 +=" + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearMD.ToString(); tempString11 +=" + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearMD.ToString(); tempString12 +=" + gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearMD.ToString();
                }
            }

            if (booster1MD != 0) { SumAdditives += booster1MD;
                tempString1 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1MD.ToString(); tempString2 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1MD.ToString(); tempString3 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1MD.ToString();
                tempString4 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1MD.ToString(); tempString5 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1MD.ToString(); tempString6 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1MD.ToString();
                tempString7 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1MD.ToString(); tempString8 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1MD.ToString(); tempString9 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1MD.ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1MD.ToString(); tempString11 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1MD.ToString(); tempString12 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1MD.ToString();
                }
            }

               if (booster2MD != 0) { SumAdditives += booster2MD;
                tempString1 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2MD.ToString(); tempString2 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2MD.ToString(); tempString3 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2MD.ToString();
                tempString4 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2MD.ToString(); tempString5 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2MD.ToString(); tempString6 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2MD.ToString();
                tempString7 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2MD.ToString(); tempString8 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2MD.ToString(); tempString9 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2MD.ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2MD.ToString(); tempString11 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2MD.ToString(); tempString12 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2MD.ToString();
                }
            }

                 if (apex1MD != 0) { SumAdditives += apex1MD;
                tempString1 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1MD.ToString(); tempString2 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1MD.ToString(); tempString3 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1MD.ToString();
                tempString4 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1MD.ToString(); tempString5 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1MD.ToString(); tempString6 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1MD.ToString();
                tempString7 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1MD.ToString(); tempString8 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1MD.ToString(); tempString9 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1MD.ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1MD.ToString(); tempString11 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1MD.ToString(); tempString12 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1MD.ToString();
                }
            }

            if (apex2MD != 0) { SumAdditives += apex2MD;
                tempString1 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2MD.ToString(); tempString2 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2MD.ToString(); tempString3 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2MD.ToString();
                tempString4 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2MD.ToString(); tempString5 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2MD.ToString(); tempString6 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2MD.ToString();
                tempString7 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2MD.ToString(); tempString8 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2MD.ToString(); tempString9 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2MD.ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2MD.ToString(); tempString11 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2MD.ToString(); tempString12 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2MD.ToString();
                }
            }
           
             if (float.Parse(comboBoxSelectVeteranLevel.Text) != 0) { SumAdditives += float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f;
                tempString1 += "  + Veteran MD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString(); tempString2 += "  + Veteran MD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString(); tempString3 += "  + Veteran MD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                tempString4 += "  + Veteran MD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString(); tempString5 += "  + Veteran MD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString(); tempString6 += "  + Veteran MD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                tempString7 += "  + Veteran MD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString(); tempString8 += "  + Veteran MD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString(); tempString9 += "  + Veteran MD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += "  + Veteran MD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString(); tempString11 += "  + Veteran MD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString(); tempString12 += "  + Veteran MD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                }
            }

            if (skill1MDSum != 0) { SumAdditives += skill1MDSum;
                tempString1 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1MDSum.ToString(); tempString2 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1MDSum.ToString(); tempString3 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1MDSum.ToString();
                tempString4 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1MDSum.ToString(); tempString5 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1MDSum.ToString(); tempString6 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1MDSum.ToString();
                tempString7 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1MDSum.ToString(); tempString8 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1MDSum.ToString(); tempString9 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1MDSum.ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1MDSum.ToString(); tempString11 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1MDSum.ToString(); tempString12 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1MDSum.ToString();
                }
            }
            if (skill2MDSum != 0)
            {
                SumAdditives += skill2MDSum;
                tempString1 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2MDSum.ToString(); tempString2 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2MDSum.ToString(); tempString3 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2MDSum.ToString();
                tempString4 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2MDSum.ToString(); tempString5 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2MDSum.ToString(); tempString6 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2MDSum.ToString();
                tempString7 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2MDSum.ToString(); tempString8 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2MDSum.ToString(); tempString9 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2MDSum.ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2MDSum.ToString(); tempString11 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2MDSum.ToString(); tempString12 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2MDSum.ToString();
                }
            }
            if (skill3MDSum != 0)
            {
                SumAdditives += skill3MDSum;
                tempString1 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3MDSum.ToString(); tempString2 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3MDSum.ToString(); tempString3 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3MDSum.ToString();
                tempString4 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3MDSum.ToString(); tempString5 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3MDSum.ToString(); tempString6 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3MDSum.ToString();
                tempString7 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3MDSum.ToString(); tempString8 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3MDSum.ToString(); tempString9 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3MDSum.ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3MDSum.ToString(); tempString11 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3MDSum.ToString(); tempString12 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3MDSum.ToString();
                }
            }
            if (skill4MDSum != 0)
            {
                SumAdditives += skill4MDSum;
                tempString1 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4MDSum.ToString(); tempString2 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4MDSum.ToString(); tempString3 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4MDSum.ToString();
                tempString4 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4MDSum.ToString(); tempString5 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4MDSum.ToString(); tempString6 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4MDSum.ToString();
                tempString7 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4MDSum.ToString(); tempString8 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4MDSum.ToString(); tempString9 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4MDSum.ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4MDSum.ToString(); tempString11 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4MDSum.ToString(); tempString12 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4MDSum.ToString();
                }
            }
            if (skill5MDSum != 0)
            {
                SumAdditives += skill5MDSum;
                tempString1 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5MDSum.ToString(); tempString2 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5MDSum.ToString(); tempString3 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5MDSum.ToString();
                tempString4 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5MDSum.ToString(); tempString5 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5MDSum.ToString(); tempString6 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5MDSum.ToString();
                tempString7 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5MDSum.ToString(); tempString8 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5MDSum.ToString(); tempString9 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5MDSum.ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5MDSum.ToString(); tempString11 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5MDSum.ToString(); tempString12 += " + MD from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5MDSum.ToString();
                }
            }

            tempString1 +=  " ) * ( 1 "; tempString2 += " ) * ( 1 "; tempString3 += " ) * ( 1 "; tempString4 += " ) * ( 1 "; tempString5 += " ) * ( 1 "; tempString6 += " ) * ( 1 "; tempString7 += " ) * ( 1 "; tempString8 += " ) * ( 1 "; tempString9 += " ) * ( 1 ";
            if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator")) { tempString10 += " ) * ( 1 "; tempString11 += " ) * ( 1 "; tempString12 += " ) * ( 1 "; }

            // Will need to accumulate the strings and print at the end since I want to print 9 at once .. 
            // need sum of debuffs and MAX(skill ArmorDebuff - cryo beam and turret don't stack) first 
            float sumMeleeAdditives;  sumMeleeAdditives = SumAdditives; 

            float SumArmorDebuff;
            textBoxCharacterStats.Text += "MUST CALCULATE sumARMOR DEBUFF before since it doesn't stack from cryo beam and cryo turret ";
            if (skill1ArmorDebuffSum != 0) { textBoxCharacterStats.Text += " + debuffvsArmor from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1ArmorDebuffSum.ToString(); }
            if (skill2ArmorDebuffSum != 0) { textBoxCharacterStats.Text += " + debuffvsArmor from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2ArmorDebuffSum.ToString(); }
            if (skill3ArmorDebuffSum != 0) { textBoxCharacterStats.Text += " + debuffvsArmor from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3ArmorDebuffSum.ToString(); }
            SumArmorDebuff = Math.Max(skill1ArmorDebuffSum, Math.Max(skill2ArmorDebuffSum, skill3ArmorDebuffSum)); SumArmorDebuff *= 1 + skill5SupportSum ;
            textBoxCharacterStats.Text += " Sum debuffs on target vsArmor  = " + SumArmorDebuff.ToString() + " \r\n\r\n"; SumAdditives = 0;


            if (skill1DebuffSum != 0) {
                SumAdditives += skill1DebuffSum * (1 + skill5SupportSum);
                tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString7 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString7 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString8 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString8 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString9 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString9 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString10 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                    tempString11 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString11 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                    tempString12 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString12 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                }
            }

            if (skill2DebuffSum != 0)
            {
                SumAdditives += skill2DebuffSum * (1 + skill5SupportSum);
                tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString7 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString7 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString8 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString8 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString9 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString9 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString10 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                    tempString11 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString11 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                    tempString12 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString12 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                }
            }


            if (skill3DebuffSum != 0)
            {
                SumAdditives += skill3DebuffSum * (1 + skill5SupportSum);
                tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString7 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString7 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString8 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString8 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString9 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString9 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString10 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                    tempString11 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString11 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                    tempString12 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString12 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                }
            }

            if (skill4DebuffSum != 0)
            {
                SumAdditives += skill4DebuffSum * (1 + skill5SupportSum);
                tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString7 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString7 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString8 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString8 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                tempString9 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString9 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString10 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                    tempString11 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString11 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                    tempString12 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString12 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                }
            }

            if (float.Parse(textBoxSumSquadDebuffsOnTarget.Text) != 0)
            {
                SumAdditives += float.Parse(textBoxSumSquadDebuffsOnTarget.Text);
                tempString1 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString2 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString3 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                tempString4 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString5 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString6 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                tempString7 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString8 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString9 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
                {
                    tempString10 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString11 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString12 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                }
            }

            if (SumArmorDebuff != 0) { tempString3 += " + debuffvsArmor" + SumArmorDebuff.ToString(); tempString6 += " + debuffvsArmor" + SumArmorDebuff.ToString(); tempString9 += " + debuffvsArmor" + SumArmorDebuff.ToString(); if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator")) tempString12 += " + debuffvsArmor" + SumArmorDebuff.ToString(); }



            float SumDebuff; SumDebuff = SumAdditives;
            tempString1 +=  " ) * ( 1 "; tempString2 +=  " ) * ( 1 "; tempString3 +=  " ) * ( 1 "; tempString4 +=  " ) * ( 1 "; tempString5 +=  " ) * ( 1 "; tempString6 +=  " ) * ( 1 "; tempString7 +=  " ) * ( 1 "; tempString8 +=  " ) * ( 1 "; tempString9 +=  " ) * ( 1 ";
            if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator")) { tempString10 +=  " ) * ( 1 "; tempString11 +=  " ) * ( 1 ";  tempString12 +=  " ) * ( 1 "; }

            tempString1 += " ) = " + (playingCharactersArray[SelectedCharIndex].BaseCharacterMeleeDamage * (1 + sumMeleeAdditives) * (1 + SumDebuff)).ToString();
            if (playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsShields !=0)  tempString2 += " + " + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsShields.ToString(); tempString2 +=  " ) = " + (playingCharactersArray[SelectedCharIndex].BaseCharacterMeleeDamage * (1 + sumMeleeAdditives) * (1 + SumDebuff) * (1 + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsShields)).ToString();
            if (playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsArmor != 0) tempString3 += " + " + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsArmor.ToString(); tempString3 += " ) = " + (playingCharactersArray[SelectedCharIndex].BaseCharacterMeleeDamage * (1 + sumMeleeAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsArmor)).ToString();

            tempString4 += " ) = " + (BaseJumpMeleeDamage * JumpMeleeImpactPercent * (1 + sumMeleeAdditives) * (1 + SumDebuff)).ToString();
            if (playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsShields != 0) tempString5 += " + " + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsShields.ToString(); tempString5 += " ) = " + (BaseJumpMeleeDamage * JumpMeleeImpactPercent * (1 + sumMeleeAdditives) * (1 + SumDebuff) * (1 + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsShields)).ToString();
            if (playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsArmor != 0) tempString6 += " + " + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsArmor.ToString(); tempString6 += " ) = " + (BaseJumpMeleeDamage * JumpMeleeImpactPercent * (1 + sumMeleeAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsArmor)).ToString();

            tempString7 += " ) = " + (BaseJumpMeleeDamage * JumpMeleeAOEPercent * (1 + sumMeleeAdditives) * (1 + SumDebuff)).ToString();
            if (playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsShields != 0) tempString8 += " + " + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsShields.ToString(); tempString8 += " ) = " + (BaseJumpMeleeDamage * JumpMeleeAOEPercent * (1 + sumMeleeAdditives) * (1 + SumDebuff) * (1 + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsShields)).ToString();
            if (playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsArmor != 0) tempString9 += " + " + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsArmor.ToString(); tempString9 += " ) = " + (BaseJumpMeleeDamage * JumpMeleeAOEPercent * (1 + sumMeleeAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsArmor)).ToString();

            if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator"))
            {
                tempString10 += " ) = " + (BasePullHammer* (1 + sumMeleeAdditives) * (1 + SumDebuff)).ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsShields != 0) tempString11 += " + " + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsShields.ToString(); tempString11 += " ) = " + (BasePullHammer* (1 + sumMeleeAdditives) * (1 + SumDebuff) * (1 + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsShields)).ToString();
                if (playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsArmor != 0) tempString12 += " + " + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsArmor.ToString(); tempString12 += " ) = " + (BasePullHammer* (1 + sumMeleeAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + playingCharactersArray[SelectedCharIndex].CharacterMeleeBonusVsArmor)).ToString();

            }
            textBoxCharacterStats.Text += tempString1 + "\r\n"; textBoxCharacterStats.Text += tempString2 + "\r\n"; textBoxCharacterStats.Text += tempString3 + "\r\n\r\n";
            textBoxCharacterStats.Text += tempString4 + "\r\n"; textBoxCharacterStats.Text += tempString5 + "\r\n"; textBoxCharacterStats.Text += tempString6 + "\r\n\r\n";
            textBoxCharacterStats.Text += tempString7 + "\r\n"; textBoxCharacterStats.Text += tempString8 + "\r\n"; textBoxCharacterStats.Text += tempString9 + "\r\n\r\n";
            if (playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Krogan Gladiator")) { textBoxCharacterStats.Text += tempString10 + "\r\n"; textBoxCharacterStats.Text += tempString11 + "\r\n"; textBoxCharacterStats.Text += tempString12 + "\r\n\r\n"; }
            
           
            // gun STATS?  Magazine damage, DPS, single shot damage ..
            //


            ///Active skills section

            string[] ActiveSkillList = { "", "","" };
            ActiveSkillList[0] = labelSkill1Name.Text;
            ActiveSkillList[1] = labelSkill2Name.Text;
            ActiveSkillList[2] = labelSkill3Name.Text;
            for (int ASkillIndex = 0; ASkillIndex < 3; ASkillIndex++)
            {
                // find correct Textbox by name
                Control[] controls = this.Controls.Find("textBoxASkill" + (ASkillIndex + 1).ToString(), true);
                TextBox txtBox = controls[0] as TextBox;
                txtBox.Text = ActiveSkillList[ASkillIndex] + ":\r\n\r\n";



                switch (ActiveSkillList[ASkillIndex])
                {
                    case "Frag Grenade":
                        //txtBox.Text += "long live the frag";
                        // "BaseDam=1000;Cooldown=0;AnimDur=0.9", "1", "2", "Dam=0.3", "4a", "Dam=0.4", "5a", "BaseDOTDam=100;BaseDOTDur=6", "vsArmor=0.8","vsShields=1",
                        // combo boxes HAVE PLAYER CHOICES 
                        // Also need to get the right playingCharactersArray[SelectedCharIndex].Skill X CooldownMaxDurationPassiveTempEtc
                        string TCooldownMaxDurationPassiveTempEtc; TCooldownMaxDurationPassiveTempEtc = "";
                        if (playingCharactersArray[SelectedCharIndex].Skill1Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill1CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill2Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill2CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill3Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill3CooldownMaxDurationPassiveTempEtc;

                        //  txtBox.Text += TCooldownMaxDurationPassiveTempEtc;

                        // cooldown 0 ; animdur = 0.9 
                        txtBox.Text += "Cooldown = 0 (grenade based - nothing related to cooldown recharge can touch it BUT Animation Duration is ~ 0.9 seconds (can't spam 10 grendades per milisecond ..)\r\n";
                        // duration don't care - Actually THERE IS THE POSIBILITY FOR DOT
                        txtBox.Text += "Duration irrelevant ..no sustained effect \r\n\r\n";



                        float FragGrenadeBaseDam; FragGrenadeBaseDam = 0;
                        foreach (string s in TCooldownMaxDurationPassiveTempEtc.Split(';'))
                        {
                            //  "BaseDam="
                            if (s.StartsWith("BaseDam=")) FragGrenadeBaseDam = float.Parse(s.Substring(8, s.Length - 8));
                            //  txtBox.Text += FragGrenadeBaseDam.ToString() + "\r\n";
                        }

                        ComboBox comboBox;
                        //we will need to Find the right comboboxes by name .. 
                        //  controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_1", true);
                        //  comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        // controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_2", true);
                        // comboBox = controls[0] as ComboBox;
                        // txtBox.Text += comboBox.Text + "\r\n";


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_3", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float FragGrenadeDam1; FragGrenadeDam1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) FragGrenadeDam1 += float.Parse(s.Substring(4, s.Length - 4));

                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_4", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float FragGrenadeDam2; FragGrenadeDam2 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) FragGrenadeDam2 += float.Parse(s.Substring(4, s.Length - 4));

                        }

                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_5", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float FragGrenadeBaseDOTDam, FragGrenadeBaseDOTDur; FragGrenadeBaseDOTDam = FragGrenadeBaseDOTDur = 0;

                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            //   "BaseDOTDam=100;BaseDOTDur=6"
                            if (s.StartsWith("BaseDOTDam=")) FragGrenadeBaseDOTDam += float.Parse(s.Substring(11, s.Length - 11));
                            if (s.StartsWith("BaseDOTDur=")) FragGrenadeBaseDOTDur += float.Parse(s.Substring(11, s.Length - 11));
                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_6", true);
                        comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        float FragGrenadevsArmor, FragGrenadevsShields; FragGrenadevsArmor = FragGrenadevsShields = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            if (s.StartsWith("vsArmor=")) FragGrenadevsArmor += float.Parse(s.Substring(8, s.Length - 8));
                            if (s.StartsWith("vsShields=")) FragGrenadevsShields += float.Parse(s.Substring(10, s.Length - 10));

                        }

                        ///////////////
                        /////////////// let the splittage begin


                        txtBox.Text += "Impact formula: BaseImpactDamage * (1 + SumAdditives) * (1 + (SumDebuff + SumArmorDebuff) * (1 + SupportSum) + SquadDebuff ) * (1 + SumvsDefense)  \r\n";
                        txtBox.Text += "DOT damage per tick formula: (BaseDOTDPS/2) * (1 + SumAdditives) * (1 + SumDebuff) * (1 + SumvsDefense)  \r\n\r\n";
                        txtBox.Text += " some debuffs, ex Pull's expose cannot be activated vs Armor or Shields - I don't account for that here - but you can tick that debuff off in UI if you want numbers without it and RE-Calculate) \r\n\r\n";



                        tempString1 = "Impact Damage vs Health = Base Impact Damage " + FragGrenadeBaseDam.ToString() + " * ( 1 ";
                        tempString2 = "Impact Damage vs Shields = Base Impact Damage " + FragGrenadeBaseDam.ToString() + " * ( 1 ";
                        tempString3 = "Impact Damage vs Armor = Base Impact Damage " + FragGrenadeBaseDam.ToString() + " * ( 1 ";

                        if (FragGrenadeBaseDOTDam != 0) {
                            tempString4 = "DOT damage tick vs Health = (Base DOT DPS Damage/2) " + (FragGrenadeBaseDOTDam / 2).ToString() + " * ( 1 ";
                            tempString5 = "DOT damage tick vs Shields = (Base DOT DPS Damage/2) " + (FragGrenadeBaseDOTDam / 2).ToString() + " * ( 1 ";
                            tempString6 = "DOT damage tick vs Armor = (Base DOT DPS Damage/2) " + (FragGrenadeBaseDOTDam / 2).ToString() + " * ( 1 ";
                        }


                        // Will need to accumulate the strings and print at the end since I want to print 9 at once .. 
                        // need sum of debuffs and MAX(skill ArmorDebuff - cryo beam and turret don't stack) first 

                        //ADDITIVEs
                        //                    SumAdditives = 0;

                        if (FragGrenadeDam1 != 0) { SumAdditives += FragGrenadeDam1;
                            tempString1 += " + 'Damage Evo 3' " + FragGrenadeDam1.ToString();
                            tempString2 += " + 'Damage Evo 3' " + FragGrenadeDam1.ToString();
                            tempString3 += " + 'Damage Evo 3' " + FragGrenadeDam1.ToString();
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + 'Damage Evo 3' " + FragGrenadeDam1.ToString();
                                tempString5 += " + 'Damage Evo 3' " + FragGrenadeDam1.ToString();
                                tempString6 += " + 'Damage Evo 3' " + FragGrenadeDam1.ToString();
                            }
                        }

                        if (FragGrenadeDam2 != 0) { SumAdditives += FragGrenadeDam2;
                            tempString1 += " + 'Damage Evo 4a' " + FragGrenadeDam2.ToString();
                            tempString2 += " + 'Damage Evo 4a' " + FragGrenadeDam2.ToString();
                            tempString3 += " + 'Damage Evo 4a' " + FragGrenadeDam2.ToString();
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + 'Damage Evo 4a' " + FragGrenadeDam2.ToString();
                                tempString5 += " + 'Damage Evo 4a' " + FragGrenadeDam2.ToString();
                                tempString6 += " + 'Damage Evo 4a' " + FragGrenadeDam2.ToString();
                            }
                        }

                        if (gearCPD != 0) { SumAdditives += gearCPD;
                            tempString1 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            tempString2 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            tempString3 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                                tempString5 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                                tempString6 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            }
                        }
                        if (booster1CPD != 0) { SumAdditives += booster1CPD;
                            tempString1 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            tempString2 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            tempString3 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                                tempString5 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                                tempString6 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            }
                        }
                        if (booster2CPD != 0)
                        {
                            SumAdditives += booster2CPD;
                            tempString1 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            tempString2 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            tempString3 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                                tempString5 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                                tempString6 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            }
                        }
                        if (apex1CPD != 0) { SumAdditives += apex1CPD;
                            tempString1 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            tempString2 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            tempString3 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                                tempString5 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                                tempString6 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            }
                        }
                        if (apex2CPD != 0)
                        {
                            SumAdditives += apex2CPD;
                            tempString1 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            tempString2 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            tempString3 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                                tempString5 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                                tempString6 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            }
                        }

                        if (float.Parse(comboBoxSelectVeteranLevel.Text) != 0) { SumAdditives += float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f;
                            tempString1 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString2 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString3 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                tempString5 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                tempString6 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            }
                        }

                        if (skill1PDSum != 0) { SumAdditives += skill1PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            }
                        }
                        if (skill2PDSum != 0)
                        {
                            SumAdditives += skill2PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            }
                        }
                        if (skill3PDSum != 0)
                        {
                            SumAdditives += skill3PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            }
                        }
                        if (skill4PDSum != 0)
                        {
                            SumAdditives += skill4PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            }
                        }
                        if (checkBoxBarricadePD.Checked) { SumAdditives += 0.2f;
                            tempString1 += " + PD from squad Barricade 0.2 ";
                            tempString2 += " + PD from squad Barricade 0.2 ";
                            tempString3 += " + PD from squad Barricade 0.2 ";
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + PD from squad Barricade 0.2 ";
                                tempString5 += " + PD from squad Barricade 0.2 ";
                                tempString6 += " + PD from squad Barricade 0.2 ";
                            }
                        }
                        float SumFragAdditives; SumFragAdditives = SumAdditives;

                        //DEBUFFS
                        SumAdditives = 0;
                        tempString1 += " ) * ( 1 "; tempString2 += " ) * ( 1 "; tempString3 += " ) * ( 1 ";
                        if (FragGrenadeBaseDOTDam != 0) { tempString4 += " ) * ( 1 "; tempString5 += " ) * ( 1 "; tempString6 += " ) * ( 1 "; }

                        if (skill1DebuffSum != 0)
                        {
                            SumAdditives += skill1DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            }
                        }


                        if (skill2DebuffSum != 0)
                        {
                            SumAdditives += skill2DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            }
                        }

                        if (skill3DebuffSum != 0)
                        {
                            SumAdditives += skill3DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            }
                        }


                        if (skill4DebuffSum != 0)
                        {
                            SumAdditives += skill4DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            }
                        }

                        if (float.Parse(textBoxSumSquadDebuffsOnTarget.Text) != 0)
                        {
                            SumAdditives += float.Parse(textBoxSumSquadDebuffsOnTarget.Text);
                            tempString1 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString2 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString3 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            if (FragGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString5 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString6 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            }
                        }

                        if (SumArmorDebuff != 0) { tempString3 += " + debuffvsArmor" + SumArmorDebuff.ToString(); if (FragGrenadeBaseDOTDam != 0) tempString6 += " + debuffvsArmor" + SumArmorDebuff.ToString(); }

                        SumDebuff = SumAdditives;
                        tempString1 += " ) * ( 1 "; tempString2 += " ) * ( 1 "; tempString3 += " ) * ( 1 ";
                        if (FragGrenadeBaseDOTDam != 0) { tempString4 += " ) * ( 1 ) "; tempString5 += " ) * ( 1 "; tempString6 += " ) * ( 1 "; }


                        // vsDEFENSE
                        //
                        //HSoldier and TSoldier can't get vsArmor/vsShields in passive so I'll skip that code 
                        tempString1 += " ) = " + (FragGrenadeBaseDam * (1 + SumFragAdditives) * (1 + SumDebuff)).ToString();
                        if (FragGrenadevsShields != 0) tempString2 += " + vsShields " + FragGrenadevsShields.ToString(); tempString2 += " ) = " + (FragGrenadeBaseDam * (1 + SumFragAdditives) * (1 + SumDebuff) * (1 + FragGrenadevsShields)).ToString();
                        if (FragGrenadevsArmor != 0) tempString3 += " + vsArmor " + FragGrenadevsArmor.ToString(); tempString3 += " ) = " + (FragGrenadeBaseDam * (1 + SumFragAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + FragGrenadevsArmor)).ToString();

                        if (FragGrenadeBaseDOTDam != 0)
                        {
                            tempString4 += " = " + ((FragGrenadeBaseDOTDam / 2) * (1 + SumFragAdditives) * (1 + SumDebuff)).ToString();
                            if (FragGrenadevsShields != 0) tempString5 += " + vsShields " + FragGrenadevsShields.ToString(); tempString5 += " ) = " + ((FragGrenadeBaseDOTDam / 2) * (1 + SumFragAdditives) * (1 + SumDebuff) * (1 + FragGrenadevsShields)).ToString();
                            if (FragGrenadevsArmor != 0) tempString6 += " + vsArmor " + FragGrenadevsArmor.ToString(); tempString6 += " ) = " + ((FragGrenadeBaseDOTDam / 2) * (1 + SumFragAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + FragGrenadevsArmor)).ToString();
                        }



                        txtBox.Text += tempString1 + "\r\n";
                        txtBox.Text += tempString2 + "\r\n";
                        txtBox.Text += tempString3 + "\r\n";

                        if (FragGrenadeBaseDOTDam != 0)
                        {
                            txtBox.Text += "\r\n";
                            txtBox.Text += tempString4 + "\r\n";
                            txtBox.Text += tempString5 + "\r\n";
                            txtBox.Text += tempString6 + "\r\n";

                            txtBox.Text += "Neither HSol or TSol have access to DOT duration extension in passive so frag DOT will run for at most : " + FragGrenadeBaseDOTDur + " seconds \r\n";
                            txtBox.Text += "Maximum Total frag DOT vs Health = " + (FragGrenadeBaseDOTDam * (1 + SumFragAdditives) * (1 + SumDebuff) * FragGrenadeBaseDOTDur).ToString() + "\r\n";
                            txtBox.Text += "Maximum Total frag DOT vs Shields = " + (FragGrenadeBaseDOTDam * (1 + SumFragAdditives) * (1 + SumDebuff) * (1 + FragGrenadevsShields) * FragGrenadeBaseDOTDur).ToString() + "\r\n";
                            txtBox.Text += "Maximum Total frag DOT vs Armor = " + (FragGrenadeBaseDOTDam * (1 + SumFragAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + FragGrenadevsArmor) * FragGrenadeBaseDOTDur).ToString() + "\r\n";

                        }


                        break;

                    case "Sticky Grenade":

                        // "BaseDam=1000;Cooldown=0;AnimDur=0.9", "1", "2", "Dam=0.3", "4a", "Dam=0.4", "5a", "BaseDOTDam=100;BaseDOTDur=6", "vsArmor=0.8","vsShields=1",
                        // "BaseDam=1100;Cooldown=0",             "1", "2", "Dam=0.2", "Dam=0.3", "4b", "5a", "BaseDOTDam=65;BaseDOTDur=5", "vsArmor=0.65", "vsShields=65",

                        // combo boxes HAVE PLAYER CHOICES 
                        // Also need to get the right playingCharactersArray[SelectedCharIndex].Skill X CooldownMaxDurationPassiveTempEtc
                        ; TCooldownMaxDurationPassiveTempEtc = "";
                        if (playingCharactersArray[SelectedCharIndex].Skill1Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill1CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill2Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill2CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill3Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill3CooldownMaxDurationPassiveTempEtc;

                        //  txtBox.Text += TCooldownMaxDurationPassiveTempEtc;

                        // cooldown 0 ; animdur = 0.9 
                        txtBox.Text += "Cooldown = 0 (grenade based - nothing related to cooldown recharge can touch it BUT Animation Duration is ~ 0.9 seconds (can't spam 10 grendades per milisecond ..)\r\n";
                        // duration don't care - Actually THERE IS THE POSIBILITY FOR DOT
                        txtBox.Text += "Duration irrelevant ..no sustained effect \r\n\r\n";



                        float StickyGrenadeBaseDam; StickyGrenadeBaseDam = 0;
                        foreach (string s in TCooldownMaxDurationPassiveTempEtc.Split(';'))
                        {
                            //  "BaseDam="
                            if (s.StartsWith("BaseDam=")) StickyGrenadeBaseDam = float.Parse(s.Substring(8, s.Length - 8));
                            //  txtBox.Text += StickyGrenadeBaseDam.ToString() + "\r\n";
                        }

                        //we will need to Find the right comboboxes by name .. 
                        //  controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_1", true);
                        //  comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        // controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_2", true);
                        // comboBox = controls[0] as ComboBox;
                        // txtBox.Text += comboBox.Text + "\r\n";


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_3", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float StickyGrenadeDam1; StickyGrenadeDam1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) StickyGrenadeDam1 += float.Parse(s.Substring(4, s.Length - 4));

                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_4", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float StickyGrenadeDam2; StickyGrenadeDam2 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) StickyGrenadeDam2 += float.Parse(s.Substring(4, s.Length - 4));

                        }

                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_5", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float StickyGrenadeBaseDOTDam, StickyGrenadeBaseDOTDur; StickyGrenadeBaseDOTDam = StickyGrenadeBaseDOTDur = 0;

                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            //   "BaseDOTDam=100;BaseDOTDur=6"
                            if (s.StartsWith("BaseDOTDam=")) StickyGrenadeBaseDOTDam += float.Parse(s.Substring(11, s.Length - 11));
                            if (s.StartsWith("BaseDOTDur=")) StickyGrenadeBaseDOTDur += float.Parse(s.Substring(11, s.Length - 11));
                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_6", true);
                        comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        float StickyGrenadevsArmor, StickyGrenadevsShields; StickyGrenadevsArmor = StickyGrenadevsShields = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            if (s.StartsWith("vsArmor=")) StickyGrenadevsArmor += float.Parse(s.Substring(8, s.Length - 8));
                            if (s.StartsWith("vsShields=")) StickyGrenadevsShields += float.Parse(s.Substring(10, s.Length - 10));

                        }

                        ///////////////
                        /////////////// let the splittage begin


                        txtBox.Text += "Impact formula: BaseImpactDamage * (1 + SumAdditives) * (1 + (SumDebuff + SumArmorDebuff) * (1 + SupportSum) + SquadDebuff ) * (1 + SumvsDefense)  \r\n";
                        txtBox.Text += "DOT damage per tick formula: (BaseDOTDPS/2) * (1 + SumAdditives) * (1 + SumDebuff) * (1 + SumvsDefense)  \r\n\r\n";
                        txtBox.Text += "some debuffs, ex Pull's expose cannot be activated vs Armor or Shields - I don't account for that here - but you can tick that debuff off in UI if you want numbers without it and RE-Calculate) \r\n";
                        txtBox.Text += "Sticky Grenades CANNOT EVER GET Power Damage bonus from Stealth Grid or Tactical cloak unless 6b combat cloak \r\n\r\n";


                        tempString1 = "Impact Damage vs Health = Base Impact Damage " + StickyGrenadeBaseDam.ToString() + " * ( 1 ";
                        tempString2 = "Impact Damage vs Shields = Base Impact Damage " + StickyGrenadeBaseDam.ToString() + " * ( 1 ";
                        tempString3 = "Impact Damage vs Armor = Base Impact Damage " + StickyGrenadeBaseDam.ToString() + " * ( 1 ";

                        if (StickyGrenadeBaseDOTDam != 0)
                        {
                            tempString4 = "DOT damage tick vs Health = (Base DOT DPS Damage/2) " + (StickyGrenadeBaseDOTDam / 2).ToString() + " * ( 1 ";
                            tempString5 = "DOT damage tick vs Shields = (Base DOT DPS Damage/2) " + (StickyGrenadeBaseDOTDam / 2).ToString() + " * ( 1 ";
                            tempString6 = "DOT damage tick vs Armor = (Base DOT DPS Damage/2) " + (StickyGrenadeBaseDOTDam / 2).ToString() + " * ( 1 ";
                        }


                        // Will need to accumulate the strings and print at the end since I want to print 9 at once .. 
                        // need sum of debuffs and MAX(skill ArmorDebuff - cryo beam and turret don't stack) first 

                        //ADDITIVEs
                        //                    SumAdditives = 0;

                        if (StickyGrenadeDam1 != 0)
                        {
                            SumAdditives += StickyGrenadeDam1;
                            tempString1 += " + 'Damage Evo 3' " + StickyGrenadeDam1.ToString();
                            tempString2 += " + 'Damage Evo 3' " + StickyGrenadeDam1.ToString();
                            tempString3 += " + 'Damage Evo 3' " + StickyGrenadeDam1.ToString();
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + 'Damage Evo 3' " + StickyGrenadeDam1.ToString();
                                tempString5 += " + 'Damage Evo 3' " + StickyGrenadeDam1.ToString();
                                tempString6 += " + 'Damage Evo 3' " + StickyGrenadeDam1.ToString();
                            }
                        }

                        if (StickyGrenadeDam2 != 0)
                        {
                            SumAdditives += StickyGrenadeDam2;
                            tempString1 += " + 'Damage Evo 4a' " + StickyGrenadeDam2.ToString();
                            tempString2 += " + 'Damage Evo 4a' " + StickyGrenadeDam2.ToString();
                            tempString3 += " + 'Damage Evo 4a' " + StickyGrenadeDam2.ToString();
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + 'Damage Evo 4a' " + StickyGrenadeDam2.ToString();
                                tempString5 += " + 'Damage Evo 4a' " + StickyGrenadeDam2.ToString();
                                tempString6 += " + 'Damage Evo 4a' " + StickyGrenadeDam2.ToString();
                            }
                        }

                        if (gearCPD != 0)
                        {
                            SumAdditives += gearCPD;
                            tempString1 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            tempString2 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            tempString3 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                                tempString5 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                                tempString6 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            }
                        }
                        if (booster1CPD != 0)
                        {
                            SumAdditives += booster1CPD;
                            tempString1 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            tempString2 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            tempString3 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                                tempString5 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                                tempString6 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            }
                        }
                        if (booster2CPD != 0)
                        {
                            SumAdditives += booster2CPD;
                            tempString1 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            tempString2 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            tempString3 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                                tempString5 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                                tempString6 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            }
                        }
                        if (apex1CPD != 0)
                        {
                            SumAdditives += apex1CPD;
                            tempString1 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            tempString2 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            tempString3 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                                tempString5 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                                tempString6 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            }
                        }
                        if (apex2CPD != 0)
                        {
                            SumAdditives += apex2CPD;
                            tempString1 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            tempString2 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            tempString3 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                                tempString5 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                                tempString6 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            }
                        }

                        if (float.Parse(comboBoxSelectVeteranLevel.Text) != 0)
                        {
                            SumAdditives += float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f;
                            tempString1 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString2 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString3 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                tempString5 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                tempString6 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            }
                        }

                        // verify skill is not stealth or TC without 6b
                        if ((skill1PDSum != 0) && (!playingCharactersArray[SelectedCharIndex].Skill1Name.Equals("Stealth Grid"))) 
                      
                           if (!playingCharactersArray[SelectedCharIndex].Skill1Name.Equals("Tactical Cloak") || (comboBoxSkill1_6.Text.Equals("6b")))
                            { 
                            SumAdditives += skill1PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            }
                        }
                        if ((skill2PDSum != 0) && (!playingCharactersArray[SelectedCharIndex].Skill2Name.Equals("Stealth Grid")))

                            if (!playingCharactersArray[SelectedCharIndex].Skill2Name.Equals("Tactical Cloak") || (comboBoxSkill2_6.Text.Equals("6b")))
                            {
                                SumAdditives += skill2PDSum;
                                tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                if (StickyGrenadeBaseDOTDam != 0)
                                {
                                    tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                    tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                    tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                }
                            }

                        if ((skill3PDSum != 0) && (!playingCharactersArray[SelectedCharIndex].Skill3Name.Equals("Stealth Grid")))

                            if (!playingCharactersArray[SelectedCharIndex].Skill3Name.Equals("Tactical Cloak") || (comboBoxSkill3_6.Text.Equals("6b")))
                            {
                                SumAdditives += skill3PDSum;
                                tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                if (StickyGrenadeBaseDOTDam != 0)
                                {
                                    tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                    tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                    tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                }
                            }


                        if (skill4PDSum != 0)
                        {
                            SumAdditives += skill4PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            }
                        }
                        if (checkBoxBarricadePD.Checked)
                        {
                            SumAdditives += 0.2f;
                            tempString1 += " + PD from squad Barricade 0.2 ";
                            tempString2 += " + PD from squad Barricade 0.2 ";
                            tempString3 += " + PD from squad Barricade 0.2 ";
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + PD from squad Barricade 0.2 ";
                                tempString5 += " + PD from squad Barricade 0.2 ";
                                tempString6 += " + PD from squad Barricade 0.2 ";
                            }
                        }
                        float SumStickyAdditives; SumStickyAdditives = SumAdditives;

                        //DEBUFFS
                        SumAdditives = 0;
                        tempString1 += " ) * ( 1 "; tempString2 += " ) * ( 1 "; tempString3 += " ) * ( 1 ";
                        if (StickyGrenadeBaseDOTDam != 0) { tempString4 += " ) * ( 1 "; tempString5 += " ) * ( 1 "; tempString6 += " ) * ( 1 "; }

                        if (skill1DebuffSum != 0)
                        {
                            SumAdditives += skill1DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            }
                        }


                        if (skill2DebuffSum != 0)
                        {
                            SumAdditives += skill2DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            }
                        }

                        if (skill3DebuffSum != 0)
                        {
                            SumAdditives += skill3DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            }
                        }


                        if (skill4DebuffSum != 0)
                        {
                            SumAdditives += skill4DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            }
                        }

                        if (float.Parse(textBoxSumSquadDebuffsOnTarget.Text) != 0)
                        {
                            SumAdditives += float.Parse(textBoxSumSquadDebuffsOnTarget.Text);
                            tempString1 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString2 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString3 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            if (StickyGrenadeBaseDOTDam != 0)
                            {
                                tempString4 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString5 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString6 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            }
                        }

                        if (SumArmorDebuff != 0) { tempString3 += " + debuffvsArmor" + SumArmorDebuff.ToString(); if (StickyGrenadeBaseDOTDam != 0) tempString6 += " + debuffvsArmor" + SumArmorDebuff.ToString(); }

                        SumDebuff = SumAdditives;
                        tempString1 += " ) * ( 1 "; tempString2 += " ) * ( 1 "; tempString3 += " ) * ( 1 ";
                        if (StickyGrenadeBaseDOTDam != 0) { tempString4 += " ) * ( 1 )  "; tempString5 += " ) * ( 1 "; tempString6 += " ) * ( 1 "; }


                        // vsDEFENSE 
                        //
                        //SAL INF HAS  vsArmor/vsShields in passive ; ALSO has TEFFEctDUR in in 4 and 5


                        tempString1 += " ) = " + (StickyGrenadeBaseDam * (1 + SumStickyAdditives) * (1 + SumDebuff)).ToString();
                        if (StickyGrenadeBaseDOTDam != 0)
                        {
                            tempString4 += " = " + ((StickyGrenadeBaseDOTDam / 2) * (1 + SumStickyAdditives) * (1 + SumDebuff)).ToString();

                        }

                        SumAdditives = 0;
                        if (StickyGrenadevsShields != 0) { tempString2 += " + 6a vsShields " + StickyGrenadevsShields.ToString(); SumAdditives += StickyGrenadevsShields; }
                        if (skill4vsShields != 0) { tempString2 += " + passive vsShields " + skill4vsShields.ToString(); SumAdditives += skill4vsShields; }
                        tempString2 += " ) = " + (StickyGrenadeBaseDam * (1 + SumStickyAdditives) * (1 + SumDebuff) * (1 + SumAdditives)).ToString();
                        float StickyGrenadevsShieldsSum; StickyGrenadevsShieldsSum = SumAdditives;

                        SumAdditives = 0;
                        if (StickyGrenadevsArmor != 0) { tempString3 += " + 6b vsArmor " + StickyGrenadevsArmor.ToString(); SumAdditives += StickyGrenadevsArmor; }
                        if (skill4vsArmor != 0) { tempString3 += " + passive vsArmor " + skill4vsArmor.ToString(); SumAdditives += skill4vsArmor; }
                        tempString3 += " ) = " + (StickyGrenadeBaseDam * (1 + SumStickyAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + SumAdditives)).ToString();
                        float StickyGrenadevsArmorSum; StickyGrenadevsArmorSum = SumAdditives;

                        if (StickyGrenadeBaseDOTDam != 0)
                        {

                            if (StickyGrenadevsShields != 0) tempString5 += " + 6a vsShields " + StickyGrenadevsShields.ToString();
                            if (skill4vsShields != 0) tempString5 += " + passive vsShields " + skill4vsShields.ToString();
                            tempString5 += " ) = " + ((StickyGrenadeBaseDOTDam / 2) * (1 + SumStickyAdditives) * (1 + SumDebuff) * (1 + StickyGrenadevsShieldsSum)).ToString();


                            if (StickyGrenadevsArmor != 0) tempString6 += " + 6b vsArmor " + StickyGrenadevsArmor.ToString();
                            if (skill4vsArmor != 0) tempString6 += " + passive vsArmor " + skill4vsArmor.ToString();
                            tempString6 += " ) = " + ((StickyGrenadeBaseDOTDam / 2) * (1 + SumStickyAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + StickyGrenadevsArmorSum)).ToString();
                        }


                        txtBox.Text += tempString1 + "\r\n";
                        txtBox.Text += tempString2 + "\r\n";
                        txtBox.Text += tempString3 + "\r\n";

                        if (StickyGrenadeBaseDOTDam != 0)
                        {
                            txtBox.Text += "\r\n";
                            txtBox.Text += tempString4 + "\r\n";
                            txtBox.Text += tempString5 + "\r\n";
                            txtBox.Text += tempString6 + "\r\n";


                            txtBox.Text += "DOT duration : " + StickyGrenadeBaseDOTDur.ToString() + " * ( 1";
                            if (skill4PEffectDur != 0) txtBox.Text += " + EffectDuration from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PEffectDur.ToString();
                            if (skill5PEffectDur != 0) txtBox.Text += " + EffectDuration from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5PEffectDur.ToString();
                            txtBox.Text += " ) = " + (StickyGrenadeBaseDOTDur * (1 + skill4PEffectDur + skill5PEffectDur)).ToString() + " seconds \r\n";

                            txtBox.Text += "Maximum Total sticky DOT vs Health = " + (StickyGrenadeBaseDOTDam * (1 + SumStickyAdditives) * (1 + SumDebuff) * StickyGrenadeBaseDOTDur * (1 + skill4PEffectDur + skill5PEffectDur)).ToString() + "\r\n";
                            txtBox.Text += "Maximum Total sticky DOT vs Shields = " + (StickyGrenadeBaseDOTDam * (1 + SumStickyAdditives) * (1 + SumDebuff) * (1 + StickyGrenadevsShieldsSum) * StickyGrenadeBaseDOTDur * (1 + skill4PEffectDur + skill5PEffectDur)).ToString() + "\r\n";
                            txtBox.Text += "Maximum Total sticky DOT vs Armor = " + (StickyGrenadeBaseDOTDam * (1 + SumStickyAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + StickyGrenadevsArmorSum) * StickyGrenadeBaseDOTDur * (1 + skill4PEffectDur + skill5PEffectDur)).ToString() + "\r\n";

                        }


                        break;

                    case "Overload":
                        //        "Overload", "overload description", false, "BaseDamage=200;BaseChargedDamage=300;BaseChainDamage=300;Chains=2;Recharge=12;Detonator=1;TechPrimer=HSA", "vsShields=1.25;vsSynth=0.3", "Recharge=0.1", "Dam=0.25", "Dam=0.35", "Recharge=0.25", "EChain=1", "vsShields=0.6", "vsShields=0.6;vsSynth=0.15","Dam=0.3;EChain=1",


                        // combo boxes HAVE PLAYER CHOICES 
                        // Also need to get the right playingCharactersArray[SelectedCharIndex].Skill X CooldownMaxDurationPassiveTempEtc
                        TCooldownMaxDurationPassiveTempEtc = "";
                        if (playingCharactersArray[SelectedCharIndex].Skill1Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill1CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill2Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill2CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill3Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill3CooldownMaxDurationPassiveTempEtc;

                        //  txtBox.Text += TCooldownMaxDurationPassiveTempEtc;

                        float OverloadBaseDam, OverloadChargedBaseDam, OverloadChainBaseDam, OverloadRecharge; int OverloadBaseNrChains;
                        OverloadBaseDam = OverloadChargedBaseDam = OverloadChainBaseDam = OverloadRecharge = 0; OverloadBaseNrChains = 0;

                        foreach (string s in TCooldownMaxDurationPassiveTempEtc.Split(';'))
                        {
                            //  "BaseDam="
                            if (s.StartsWith("BaseDamage=")) OverloadBaseDam = float.Parse(s.Substring(11, s.Length - 11));
                            if (s.StartsWith("BaseChargedDamage=")) OverloadChargedBaseDam = float.Parse(s.Substring(18, s.Length - 18));
                            if (s.StartsWith("BaseChainDamage=")) OverloadChainBaseDam = float.Parse(s.Substring(16, s.Length - 16));
                            if (s.StartsWith("Chains=")) OverloadBaseNrChains = int.Parse(s.Substring(7, s.Length - 7));
                            if (s.StartsWith("Recharge=")) OverloadRecharge = float.Parse(s.Substring(9, s.Length - 9));

                        }
                        //  txtBox.Text += OverloadBaseDam.ToString() + " " + OverloadChargedBaseDam.ToString() + " " + OverloadChainBaseDam.ToString() + " " + OverloadBaseNrChains.ToString() + " " + OverloadRecharge.ToString() + "\r\n";
                        // duration don't care 
                        txtBox.Text += "Duration irrelevant ..no sustained effect \r\n\r\n";

                        txtBox.Text += "Cooldown FORMULA: (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";
                        txtBox.Text += "In the interest of developement speed this app ignores the WeaponWeight minigame - as long as you don't go over capacity AS YOU SHOULD! - the related term will be Zero \r\n\r\n";
                        txtBox.Text += "Cooldown = ( BaseOverloadCooldown " + OverloadRecharge + " / ( 1 ";

                        //we will need to Find the right comboboxes by name .. 
                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_1", true);
                        comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        float OverloadvsShields1, OverloadvsSynth1; OverloadvsShields1 = OverloadvsSynth1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("vsShields=")) OverloadvsShields1 += float.Parse(s.Substring(10, s.Length - 10));
                            if (s.StartsWith("vsSynth=")) OverloadvsSynth1 += float.Parse(s.Substring(8, s.Length - 8));

                        }

                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_2", true);
                        comboBox = controls[0] as ComboBox;
                        //   txtBox.Text += comboBox.Text + "\r\n";

                        float OverloadRecharge1; OverloadRecharge1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Recharge=")) OverloadRecharge1 += float.Parse(s.Substring(9, s.Length - 9));

                        }



                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_3", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float OverloadDam1; OverloadDam1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) OverloadDam1 += float.Parse(s.Substring(4, s.Length - 4));

                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_4", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float OverloadDam2, OverloadRecharge2; OverloadDam2 = OverloadRecharge2 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) OverloadDam2 += float.Parse(s.Substring(4, s.Length - 4));
                            if (s.StartsWith("Recharge=")) OverloadRecharge2 += float.Parse(s.Substring(9, s.Length - 9));
                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_5", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float OverloadvsShields2; int OverloadEChain1; OverloadEChain1 = 0; OverloadvsShields2 = 0;

                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            if (s.StartsWith("EChain=")) OverloadEChain1 += int.Parse(s.Substring(7, s.Length - 7));
                            if (s.StartsWith("vsShields=")) OverloadvsShields2 += float.Parse(s.Substring(10, s.Length - 10));
                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_6", true);
                        comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        float OverloadvsShields3, OverloadDam3, OverloadvsSynth2; int OverloadEChain2; OverloadvsShields3 = OverloadDam3 = OverloadvsSynth2 = 0; OverloadEChain2 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {

                            if (s.StartsWith("vsShields=")) OverloadvsShields3 += float.Parse(s.Substring(10, s.Length - 10));
                            if (s.StartsWith("EChain=")) OverloadEChain2 += int.Parse(s.Substring(7, s.Length - 7));
                            if (s.StartsWith("Dam=")) OverloadDam3 += float.Parse(s.Substring(4, s.Length - 4));
                            if (s.StartsWith("vsSynth=")) OverloadvsSynth2 += float.Parse(s.Substring(8, s.Length - 8));
                        }


                        /// relevant variables for cooldown
                        /// BONUS STAT PRS, OVerloadRecharge1, OverloadRecharge2 , gearPRS, booster1PRS, booster2PRS, skill1PRS to skill5PRS; + 
                        /// skill4PRTR
                        /// skill1PRPSum to skill3PRPSum
                        /// 

                        /// still at cooldown
                        /// (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";

                        SumAdditives = 0;
                        if (float.Parse(comboBoxBonusPRS.Text) != 0) { SumAdditives += float.Parse(comboBoxBonusPRS.Text) / 100; txtBox.Text += " + Bonus 'Power Recharge' Stat" + float.Parse(comboBoxBonusPRS.Text) / 100; }
                        if (OverloadRecharge1 != 0) { SumAdditives += OverloadRecharge1; txtBox.Text += " + 'Overload Recharge Evo 2' " + OverloadRecharge1.ToString(); }
                        if (OverloadRecharge2 != 0) { SumAdditives += OverloadRecharge2; txtBox.Text += " + 'Overload Recharge Evo 4b' " + OverloadRecharge2.ToString(); }
                        if (gearPRS != 0) { SumAdditives += gearPRS; txtBox.Text += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearPRS.ToString(); }
                        if (booster1PRS != 0) { SumAdditives += booster1PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1PRS.ToString(); }
                        if (booster2PRS != 0) { SumAdditives += booster2PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2PRS.ToString(); }
                        if (skill1PRS != 0) { SumAdditives += skill1PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PRS.ToString(); }
                        if (skill2PRS != 0) { SumAdditives += skill2PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PRS.ToString(); }
                        if (skill3PRS != 0) { SumAdditives += skill3PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PRS.ToString(); }
                        if (skill4PRS != 0) { SumAdditives += skill4PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PRS.ToString(); }
                        if (skill5PRS != 0) { SumAdditives += skill5PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5PRS.ToString(); }
                        txtBox.Text += " ) * ( 1";

                        float PRP; PRP = 0;
                        // NO CHAR CURRENTLY HAS OVERLOAD AND ANNIHILATION
                        if (skill1PRPSum != 0) { PRP = skill1PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill1PRPSum.ToString(); }
                        if (skill2PRPSum != 0) { PRP = skill2PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill2PRPSum.ToString(); }
                        if (skill3PRPSum != 0) { PRP = skill3PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill3PRPSum.ToString(); }

                        txtBox.Text += " ) = " + ((OverloadRecharge / (1 + SumAdditives)) * (1 + PRP)).ToString() + "\r\n";
                        //if (skill4PRTR != 0) { txtBox.Text += " Detonation Feedback" + (1-skill4PRTR).ToString() + " multiplier to remaining cooldown amount \r\n"; }
                        txtBox.Text += "\r\n";


                        /// relevant variables for damage

                        // will need to split  base // charged/ chain damage v*4 (health and synthhealth) 


                        ///////////////
                        /////////////// let the splittage begin


                        txtBox.Text += "Overload Damage formula: BaseDamage * (1 + SumAdditives) * (1 + (SumDebuff + SumArmorDebuff) * (1 + SupportSum) + ETdebuff + SquadDebuff ) * (1 + SumvsDefense)  \r\n\r\n";
                        txtBox.Text += "some debuffs, ex Pull's expose cannot be activated vs Armor or Shields - I don't account for that here - but you can tick that debuff off in UI if you want numbers without it and RE-Calculate) \r\n\r\n";

                        tempString1 = "Uncharged Damage vs NON Synthetic Health = Base Impact Damage " + OverloadBaseDam.ToString() + " * ( 1";
                        tempString2 = "Uncharged Damage vs Synthetic Health = Base Impact Damage " + OverloadBaseDam.ToString() + " * ( 1";
                        tempString3 = "Uncharged Damage vs Shields = Base Impact Damage " + OverloadBaseDam.ToString() + " * ( 1";
                        tempString4 = "Uncharged Damage vs Armor = Base Impact Damage " + OverloadBaseDam.ToString() + " * ( 1";

                        tempString5 = "Charged Damage vs NON Synthetic Health = Base Impact Damage " + OverloadChargedBaseDam.ToString() + " * ( 1";
                        tempString6 = "Charged Damage vs Synthetic Health = Base Impact Damage " + OverloadChargedBaseDam.ToString() + " * ( 1";
                        tempString7 = "Charged Damage vs Shields = Base Impact Damage " + OverloadChargedBaseDam.ToString() + " * ( 1";
                        tempString8 = "Charged Damage vs Armor = Base Impact Damage " + OverloadChargedBaseDam.ToString() + " * ( 1";

                        tempString9 = "Chain Damage vs NON Synthetic Health = Base Impact Damage " + OverloadChainBaseDam.ToString() + " * ( 1";
                        tempString10 = "Chain Damage vs Synthetic Health = Base Impact Damage " + OverloadChainBaseDam.ToString() + " * ( 1";
                        tempString11 = "Chain Damage vs Shields = Base Impact Damage " + OverloadChainBaseDam.ToString() + " * ( 1";
                        tempString12 = "Chain Damage vs Armor = Base Impact Damage " + OverloadChainBaseDam.ToString() + " * ( 1";


                        // Will need to accumulate the strings and print at the end since I want to print 9 at once .. 
                        // need sum of debuffs and MAX(skill ArmorDebuff - cryo beam and turret don't stack) first 

                        //ADDITIVEs
                        SumAdditives = 0;

                        if (OverloadDam1 != 0) { SumAdditives += OverloadDam1;
                            tempString1 += " + 'Damage Evo 3' " + OverloadDam1.ToString();
                            tempString2 += " + 'Damage Evo 3' " + OverloadDam1.ToString();
                            tempString3 += " + 'Damage Evo 3' " + OverloadDam1.ToString();
                            tempString4 += " + 'Damage Evo 3' " + OverloadDam1.ToString();
                            tempString5 += " + 'Damage Evo 3' " + OverloadDam1.ToString();
                            tempString6 += " + 'Damage Evo 3' " + OverloadDam1.ToString();
                            tempString7 += " + 'Damage Evo 3' " + OverloadDam1.ToString();
                            tempString8 += " + 'Damage Evo 3' " + OverloadDam1.ToString();
                            tempString9 += " + 'Damage Evo 3' " + OverloadDam1.ToString();
                            tempString10 += " + 'Damage Evo 3' " + OverloadDam1.ToString();
                            tempString11 += " + 'Damage Evo 3' " + OverloadDam1.ToString();
                            tempString12 += " + 'Damage Evo 3' " + OverloadDam1.ToString();
                        }

                        if (OverloadDam2 != 0)
                        {
                            SumAdditives += OverloadDam2;
                            tempString1 += " + 'Damage Evo 4a' " + OverloadDam2.ToString();
                            tempString2 += " + 'Damage Evo 4a' " + OverloadDam2.ToString();
                            tempString3 += " + 'Damage Evo 4a' " + OverloadDam2.ToString();
                            tempString4 += " + 'Damage Evo 4a' " + OverloadDam2.ToString();
                            tempString5 += " + 'Damage Evo 4a' " + OverloadDam2.ToString();
                            tempString6 += " + 'Damage Evo 4a' " + OverloadDam2.ToString();
                            tempString7 += " + 'Damage Evo 4a' " + OverloadDam2.ToString();
                            tempString8 += " + 'Damage Evo 4a' " + OverloadDam2.ToString();
                            tempString9 += " + 'Damage Evo 4a' " + OverloadDam2.ToString();
                            tempString10 += " + 'Damage Evo 4a' " + OverloadDam2.ToString();
                            tempString11 += " + 'Damage Evo 4a' " + OverloadDam2.ToString();
                            tempString12 += " + 'Damage Evo 4a' " + OverloadDam2.ToString();
                        }

                        if (OverloadDam3 != 0)
                        {
                            SumAdditives += OverloadDam3;
                            tempString1 += " + 'Damage Evo 6b' " + OverloadDam3.ToString();
                            tempString2 += " + 'Damage Evo 6b' " + OverloadDam3.ToString();
                            tempString3 += " + 'Damage Evo 6b' " + OverloadDam3.ToString();
                            tempString4 += " + 'Damage Evo 6b' " + OverloadDam3.ToString();
                            tempString5 += " + 'Damage Evo 6b' " + OverloadDam3.ToString();
                            tempString6 += " + 'Damage Evo 6b' " + OverloadDam3.ToString();
                            tempString7 += " + 'Damage Evo 6b' " + OverloadDam3.ToString();
                            tempString8 += " + 'Damage Evo 6b' " + OverloadDam3.ToString();
                            tempString9 += " + 'Damage Evo 6b' " + OverloadDam3.ToString();
                            tempString10 += " + 'Damage Evo 6b' " + OverloadDam3.ToString();
                            tempString11 += " + 'Damage Evo 6b' " + OverloadDam3.ToString();
                            tempString12 += " + 'Damage Evo 6b' " + OverloadDam3.ToString();
                        }

                        // vsSynth1 vsSynth2 ; 2, 6, 10 
                        float SumAdditivesSynth; SumAdditivesSynth = 0;
                        if (OverloadvsSynth1 != 0)
                        {
                            SumAdditivesSynth += OverloadvsSynth1;
                            tempString2 += " + 'vsSynth Evo 1' " + OverloadvsSynth1.ToString();
                            tempString6 += " + 'vsSynth Evo 1' " + OverloadvsSynth1.ToString();
                            tempString10 += " + 'vsSynth Evo 1' " + OverloadvsSynth1.ToString();
                        }

                        if (OverloadvsSynth2 != 0)
                        {
                            SumAdditivesSynth += OverloadvsSynth2;
                            tempString2 += " + 'vsSynth Evo 6a' " + OverloadvsSynth2.ToString();
                            tempString6 += " + 'vsSynth Evo 6a' " + OverloadvsSynth2.ToString();
                            tempString10 += " + 'vsSynth Evo 6a' " + OverloadvsSynth2.ToString();
                        }

                        if (gearTPD != 0)
                        {
                            SumAdditives += gearTPD;
                            tempString1 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString2 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString3 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString4 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString5 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString6 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString7 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString8 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString9 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString10 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString11 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString12 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                        }


                        if (booster1TPD != 0)
                        {
                            SumAdditives += booster1TPD;
                            tempString1 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString2 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString3 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString4 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString5 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString6 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString7 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString8 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString9 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString10 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString11 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString12 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                        }

                        if (booster2TPD != 0)
                        {
                            SumAdditives += booster2TPD;
                            tempString1 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString2 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString3 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString4 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString5 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString6 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString7 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString8 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString9 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString10 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString11 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString12 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                        }
                        if (apex1TPD != 0)
                        {
                            SumAdditives += apex1TPD;
                            tempString1 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString2 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString3 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString4 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString5 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString6 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString7 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString8 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString9 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString10 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString11 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString12 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                        }

                        if (apex2TPD != 0)
                        {
                            SumAdditives += apex2TPD;
                            tempString1 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString2 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString3 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString4 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString5 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString6 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString7 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString8 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString9 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString10 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString11 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString12 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                        }

                        if (float.Parse(comboBoxSelectVeteranLevel.Text) != 0)
                        {
                            SumAdditives += float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f;
                            tempString1 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString2 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString3 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString4 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString5 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString6 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString7 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString8 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString9 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString10 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString11 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString12 += " + Veteran D Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                        }

                        if (skill1PDSum != 0)
                        {
                            SumAdditives += skill1PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString7 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString8 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString9 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString10 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString11 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString12 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                        }

                        if (skill2PDSum != 0)
                        {
                            SumAdditives += skill2PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString7 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString8 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString9 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString10 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString11 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString12 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                        }
                        if (skill3PDSum != 0)
                        {
                            SumAdditives += skill3PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString7 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString8 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString9 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString10 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString11 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString12 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                        }
                        if (skill4PDSum != 0)
                        {
                            SumAdditives += skill4PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString7 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString8 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString9 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString10 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString11 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString12 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                        }


                        if (checkBoxBarricadePD.Checked)
                        {
                            SumAdditives += 0.2f;
                            tempString1 += " + PD from squad Barricade 0.2 ";
                            tempString2 += " + PD from squad Barricade 0.2 ";
                            tempString3 += " + PD from squad Barricade 0.2 ";
                            tempString4 += " + PD from squad Barricade 0.2 ";
                            tempString5 += " + PD from squad Barricade 0.2 ";
                            tempString6 += " + PD from squad Barricade 0.2 ";
                            tempString7 += " + PD from squad Barricade 0.2 ";
                            tempString8 += " + PD from squad Barricade 0.2 ";
                            tempString9 += " + PD from squad Barricade 0.2 ";
                            tempString10 += " + PD from squad Barricade 0.2 ";
                            tempString11 += " + PD from squad Barricade 0.2 ";
                            tempString12 += " + PD from squad Barricade 0.2 ";
                        }


                        //DEBUFFS
                        float SumOverloadAdditives; SumOverloadAdditives = SumAdditives; SumAdditives = 0;

                        tempString1 += " ) * ( 1"; tempString2 += " ) * ( 1"; tempString3 += " ) * ( 1"; tempString4 += " ) * ( 1";
                        tempString5 += " ) * ( 1"; tempString6 += " ) * ( 1"; tempString7 += " ) * ( 1"; tempString8 += " ) * ( 1";
                        tempString9 += " ) * ( 1"; tempString10 += " ) * ( 1"; tempString11 += " ) * ( 1"; tempString12 += " ) * ( 1";

                        if (skill1DebuffSum != 0)
                        {
                            SumAdditives += skill1DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString7 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString7 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString8 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString8 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString9 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString9 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString10 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString10 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString11 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString11 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString12 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString12 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";

                        }

                        if (skill2DebuffSum != 0)
                        {
                            SumAdditives += skill2DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString7 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString7 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString8 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString8 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString9 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString9 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString10 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString10 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString11 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString11 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString12 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString12 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";

                        }

                        if (skill3DebuffSum != 0)
                        {
                            SumAdditives += skill3DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString7 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString7 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString8 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString8 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString9 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString9 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString10 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString10 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString11 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString11 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString12 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString12 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";

                        }

                        if (skill4DebuffSum != 0)
                        {
                            SumAdditives += skill4DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString7 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString7 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString8 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString8 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString9 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString9 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString10 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString10 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString11 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString11 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString12 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString12 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";

                        }


                        //  if WE HAVE ET skill46a ET AND checkBoxElementalTechOnTarget.checked 
                        // overload doesn't self proc ET
                        if (comboBoxSkill4_6.Text.Equals("ET=0.35") && checkBoxElementalTechOnTarget.Checked)
                        {
                            SumAdditives += 0.35f;
                            tempString1 += " + debuffvsAll from Elemental Tech 0.35";
                            tempString2 += " + debuffvsAll from Elemental Tech 0.35";
                            tempString3 += " + debuffvsAll from Elemental Tech 0.35";
                            tempString4 += " + debuffvsAll from Elemental Tech 0.35";
                            tempString5 += " + debuffvsAll from Elemental Tech 0.35";
                            tempString6 += " + debuffvsAll from Elemental Tech 0.35";
                            tempString7 += " + debuffvsAll from Elemental Tech 0.35";
                            tempString8 += " + debuffvsAll from Elemental Tech 0.35";
                            tempString9 += " + debuffvsAll from Elemental Tech 0.35";
                            tempString10 += " + debuffvsAll from Elemental Tech 0.35";
                            tempString11 += " + debuffvsAll from Elemental Tech 0.35";
                            tempString12 += " + debuffvsAll from Elemental Tech 0.35";
                        }

                        if (float.Parse(textBoxSumSquadDebuffsOnTarget.Text) != 0)
                        {
                            SumAdditives += float.Parse(textBoxSumSquadDebuffsOnTarget.Text);
                            tempString1 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString2 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString3 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString4 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString5 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString6 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString7 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString8 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString9 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString10 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString11 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString12 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;

                        }
                        if (SumArmorDebuff != 0)
                        {
                            tempString4 += " + debuffvsArmor" + SumArmorDebuff.ToString();
                            tempString8 += " + debuffvsArmor" + SumArmorDebuff.ToString();
                            tempString12 += " + debuffvsArmor" + SumArmorDebuff.ToString();
                        }

                        SumDebuff = SumAdditives;

                        tempString1 += " ) * ( 1 "; tempString2 += " ) * ( 1 "; tempString3 += " ) * ( 1 "; tempString4 += " ) * ( 1 ";
                        tempString5 += " ) * ( 1 "; tempString6 += " ) * ( 1 "; tempString7 += " ) * ( 1 "; tempString8 += " ) * ( 1 ";
                        tempString9 += " ) * ( 1 "; tempString10 += " ) * ( 1 "; tempString11 += " ) * ( 1 "; tempString12 += " ) * ( 1 ";

                        /////////////// REMEMBER SumAdditivesSynth

                        tempString1 += " ) = " + (OverloadBaseDam * (1 + SumOverloadAdditives) * (1 + SumDebuff)).ToString();
                        tempString2 += " ) = " + (OverloadBaseDam * (1 + SumOverloadAdditives + SumAdditivesSynth) * (1 + SumDebuff)).ToString();
                        tempString5 += " ) = " + (OverloadChargedBaseDam * (1 + SumOverloadAdditives) * (1 + SumDebuff)).ToString();
                        tempString6 += " ) = " + (OverloadChargedBaseDam * (1 + SumOverloadAdditives + SumAdditivesSynth) * (1 + SumDebuff)).ToString();
                        tempString9 += " ) = " + (OverloadChainBaseDam * (1 + SumOverloadAdditives) * (1 + SumDebuff)).ToString();
                        tempString10 += " ) = " + (OverloadChainBaseDam * (1 + SumOverloadAdditives + SumAdditivesSynth) * (1 + SumDebuff)).ToString();

                        //3/7/11 vs shields
                        SumAdditives = 0;

                        if (OverloadvsShields1 != 0)
                        {
                            SumAdditives += OverloadvsShields1;
                            tempString3 += " + built in vsShields " + OverloadvsShields1.ToString();
                            tempString7 += " + built in vsShields " + OverloadvsShields1.ToString();
                            tempString11 += " + built in vsShields " + OverloadvsShields1.ToString();
                        }


                        if (OverloadvsShields2 != 0)
                        {
                            SumAdditives += OverloadvsShields2;
                            tempString3 += " + evo 5b vsShields " + OverloadvsShields2.ToString();
                            tempString7 += " + evo 5b vsShields " + OverloadvsShields2.ToString();
                            tempString11 += " + evo 5b vsShields " + OverloadvsShields2.ToString();
                        }

                        if (OverloadvsShields3 != 0)
                        {
                            SumAdditives += OverloadvsShields3;
                            tempString3 += " + evo 6a vsShields " + OverloadvsShields3.ToString();
                            tempString7 += " + evo 6a vsShields " + OverloadvsShields3.ToString();
                            tempString11 += " + evo 6a vsShields " + OverloadvsShields3.ToString();
                        }

                        if (skill4vsShields != 0)
                        {
                            SumAdditives += skill4vsShields;
                            tempString3 += " + Passive vsShields " + skill4vsShields.ToString();
                            tempString7 += " + Passive vsShields " + skill4vsShields.ToString();
                            tempString11 += " + Passive vsShields " + skill4vsShields.ToString();
                        }
                        tempString3 += " ) = " + (OverloadBaseDam * (1 + SumOverloadAdditives) * (1 + SumDebuff) * (1 + SumAdditives)).ToString();
                        tempString7 += " ) = " + (OverloadChargedBaseDam * (1 + SumOverloadAdditives) * (1 + SumDebuff) * (1 + SumAdditives)).ToString();
                        tempString11 += " ) = " + (OverloadChainBaseDam * (1 + SumOverloadAdditives) * (1 + SumDebuff) * (1 + SumAdditives)).ToString();


                        //4/8/12 vs armor
                        if (skill4vsArmor != 0)
                        {
                            tempString4 += " + Passive vsArmor " + skill4vsArmor.ToString();
                            tempString8 += " + Passive vsArmor " + skill4vsArmor.ToString();
                            tempString12 += " + Passive vsArmor " + skill4vsArmor.ToString();
                        }
                        tempString4 += " ) = " + (OverloadBaseDam * (1 + SumOverloadAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + skill4vsArmor)).ToString();
                        tempString8 += " ) = " + (OverloadChargedBaseDam * (1 + SumOverloadAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + skill4vsArmor)).ToString();
                        tempString12 += " ) = " + (OverloadChainBaseDam * (1 + SumOverloadAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + skill4vsArmor)).ToString();


                        txtBox.Text += tempString1 + "\r\n";
                        txtBox.Text += tempString2 + "\r\n";
                        txtBox.Text += tempString3 + "\r\n";
                        txtBox.Text += tempString4 + "\r\n\r\n";
                        txtBox.Text += tempString5 + "\r\n";
                        txtBox.Text += tempString6 + "\r\n";
                        txtBox.Text += tempString7 + "\r\n";
                        txtBox.Text += tempString8 + "\r\n\r\n";
                        txtBox.Text += tempString9 + "\r\n";
                        txtBox.Text += tempString10 + "\r\n";
                        txtBox.Text += tempString11 + "\r\n";
                        txtBox.Text += tempString12 + "\r\n\r\n";

                        txtBox.Text += "MAX NUMBER of Charged Chains = " + (OverloadBaseNrChains + OverloadEChain1 + OverloadEChain2).ToString();

                        break;

                    case "Flak Cannon":
                        // "Flak Cannon", "Flak description", false, "BaseDamage=250;SBase=85;Cooldown=1", "SvsArmor=-0.3", "2", "Dam=0.4", "Dam=0.5", "4b", "vsArmor=0.75", "5b", "NrSrapnel=0.5","BaseDOTDam=100",

                        // combo boxes HAVE PLAYER CHOICES 
                        // Also need to get the right playingCharactersArray[SelectedCharIndex].Skill X CooldownMaxDurationPassiveTempEtc
                        TCooldownMaxDurationPassiveTempEtc = "";
                        if (playingCharactersArray[SelectedCharIndex].Skill1Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill1CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill2Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill2CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill3Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill3CooldownMaxDurationPassiveTempEtc;



                        //  txtBox.Text += TCooldownMaxDurationPassiveTempEtc;

                        // cooldown 0 ; animdur = 0.9 
                        txtBox.Text += "Cooldown = 0 (grenade based - nothing related to cooldown recharge can touch it BUT Animation Duration is ~ 0.? seconds (can't spam 10 grendades per milisecond ..)\r\n";
                        // duration don't care - Actually THERE IS THE POSIBILITY FOR DOT
                        txtBox.Text += "Duration irrelevant ..no sustained effect \r\n\r\n";

                        float FlakCannonImpactBaseDam, FlakCannonShrapnelBaseDam; FlakCannonImpactBaseDam = FlakCannonShrapnelBaseDam = 0;
                        // "Flak Cannon", "Flak description", false, "BaseDamage=250;SBase=85;Cooldown=1", "SvsArmor=-0.3", "2", "Dam=0.4", "Dam=0.5", "4b", "vsArmor=0.75", "5b", "NrSrapnel=0.5","BaseDOTDam=100",

                        foreach (string s in TCooldownMaxDurationPassiveTempEtc.Split(';'))
                        {
                            //  "BaseDam="
                            if (s.StartsWith("BaseDamage=")) FlakCannonImpactBaseDam = float.Parse(s.Substring(11, s.Length - 11));
                            if (s.StartsWith("SBase=")) FlakCannonShrapnelBaseDam = float.Parse(s.Substring(6, s.Length - 6));
                        }



                        //we will need to Find the right comboboxes by name .. 
                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_1", true);
                        comboBox = controls[0] as ComboBox;
                        // txtBox.Text += comboBox.Text + "\r\n";

                        float FlakCannonFvsArmor; FlakCannonFvsArmor = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("SvsArmor=")) FlakCannonFvsArmor += float.Parse(s.Substring(9, s.Length - 9));

                        }


                        // controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_2", true);
                        // comboBox = controls[0] as ComboBox;
                        // txtBox.Text += comboBox.Text + "\r\n";


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_3", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float FlakCannonDam1; FlakCannonDam1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) FlakCannonDam1 += float.Parse(s.Substring(4, s.Length - 4));

                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_4", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float FlakCannonDam2; FlakCannonDam2 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) FlakCannonDam2 += float.Parse(s.Substring(4, s.Length - 4));

                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_5", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float FlakCannonvsArmor, FlakCannonvsShields; FlakCannonvsArmor = FlakCannonvsShields = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {

                            if (s.StartsWith("vsArmor=")) FlakCannonvsArmor += float.Parse(s.Substring(8, s.Length - 8));

                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_6", true);
                        comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        float FlakCannonBaseDOTDam, FlakCannonBaseDOTDur, FlakCannonBonusShrapnel; FlakCannonBaseDOTDam = FlakCannonBaseDOTDur = FlakCannonBonusShrapnel = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            if (s.StartsWith("BaseDOTDam=")) FlakCannonBaseDOTDam += float.Parse(s.Substring(11, s.Length - 11));
                            if (s.StartsWith("BaseDOTDur=")) FlakCannonBaseDOTDur += float.Parse(s.Substring(11, s.Length - 11));
                            if (s.StartsWith("NrSrapnel=")) FlakCannonBonusShrapnel += float.Parse(s.Substring(10, s.Length - 10));
                        }

                        ///////////////
                        /////////////// let the splittage begin


                        txtBox.Text += "Impact damage formula: BaseImpactDamage * RangePenalty * (1 + SumAdditives) * (1 + SumDebuff + SumArmorDebuff  + SquadDebuff ) * (1 + SumvsDefense)  \r\n";
                        txtBox.Text += "Srapnel damage formula: BaseSrapnelDamage * RangePenalty * (1 + SumAdditives) * (1 + SumDebuff + SumArmorDebuff  + SquadDebuff ) * (1 + SumvsDefense)  \r\n\r\n";
                        txtBox.Text += "RangePenalty can be between 0.5 to 1 for Impact [AIM WELL!!] - and less for shrapnel between 0.5 to 0.9 .. will use 0.7 average from now on \r\n";
                        txtBox.Text += "6b Shredder will outdamage 6a shrapnel for a single cast (DOT will do full damage for even single shrapnel hit/ no range penalty and better vsarmor) BUT YOU CANNOT SPAM DOT WHEN YOU NEED TO KILL A BOSS  \r\n\r\n";
                        txtBox.Text += "DOT damage per tick formula: (BaseDOTDPS/2) *  (1 + SumAdditives) * (1 + SumDebuff + SumArmorDebuff  + SquadDebuff ) * (1 + SumvsDefense)  \r\n\r\n";
                        txtBox.Text += "some debuffs, ex Pull's expose cannot be activated vs Armor or Shields - I don't account for that here - but you can tick that debuff off in UI if you want numbers without it and RE-Calculate) \r\n\r\n";

                        tempString1 = "Impact Damage vs Health & Shields = Base Impact Damage " + FlakCannonImpactBaseDam.ToString() + " * ( 1 ";
                        tempString2 = "Impact Damage vs Armor = Base Impact Damage " + FlakCannonImpactBaseDam.ToString() + " * ( 1 ";

                        tempString3 = "Srapnel Damage vs Health & Shields = Base Srapnel Damage " + FlakCannonShrapnelBaseDam.ToString() + " *  AverageRangePen 0.7 * ( 1 ";
                        tempString4 = "Srapnel Damage vs Armor = Base Shrapnel Damage " + FlakCannonShrapnelBaseDam.ToString() + " * AverageRangePen 0.7 * ( 1 ";


                        if (FlakCannonBaseDOTDam != 0)
                        {
                            tempString5 = "DOT damage tick vs Health & Shields = (Base DOT DPS Damage/2) " + (FlakCannonBaseDOTDam / 2).ToString() + " * ( 1 ";
                            tempString6 = "DOT damage tick vs Armor = (Base DOT DPS Damage/2) " + (FlakCannonBaseDOTDam / 2).ToString() + " * ( 1 ";
                        }


                        // Will need to accumulate the strings and print at the end since I want to print 9 at once .. 
                        // need sum of debuffs and MAX(skill ArmorDebuff - cryo beam and turret don't stack) first 

                        //ADDITIVEs
                        SumAdditives = 0;


                        if (FlakCannonDam1 != 0)
                        {
                            SumAdditives += FlakCannonDam1;
                            tempString1 += " + 'Damage Evo 3' " + FlakCannonDam1.ToString();
                            tempString2 += " + 'Damage Evo 3' " + FlakCannonDam1.ToString();
                            tempString3 += " + 'Damage Evo 3' " + FlakCannonDam1.ToString();
                            tempString4 += " + 'Damage Evo 3' " + FlakCannonDam1.ToString();
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + 'Damage Evo 3' " + FlakCannonDam1.ToString();
                                tempString6 += " + 'Damage Evo 3' " + FlakCannonDam1.ToString();
                            }
                        }

                        if (FlakCannonDam2 != 0)
                        {
                            SumAdditives += FlakCannonDam2;
                            tempString1 += " + 'Damage Evo 4a' " + FlakCannonDam2.ToString();
                            tempString2 += " + 'Damage Evo 4a' " + FlakCannonDam2.ToString();
                            tempString3 += " + 'Damage Evo 4a' " + FlakCannonDam2.ToString();
                            tempString4 += " + 'Damage Evo 4a' " + FlakCannonDam2.ToString();
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + 'Damage Evo 4a' " + FlakCannonDam2.ToString();
                                tempString6 += " + 'Damage Evo 4a' " + FlakCannonDam2.ToString();
                            }
                        }


                        if (gearCPD != 0)
                        {
                            SumAdditives += gearCPD;
                            tempString1 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            tempString2 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            tempString3 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            tempString4 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                                tempString6 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearCPD.ToString();
                            }
                        }
                        if (booster1CPD != 0)
                        {
                            SumAdditives += booster1CPD;
                            tempString1 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            tempString2 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            tempString3 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            tempString4 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                                tempString6 += " + booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1CPD.ToString();
                            }
                        }
                        if (booster2CPD != 0)
                        {
                            SumAdditives += booster2CPD;
                            tempString1 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            tempString2 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            tempString3 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            tempString4 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                                tempString6 += " + booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2CPD.ToString();
                            }
                        }
                        if (apex1CPD != 0)
                        {
                            SumAdditives += apex1CPD;
                            tempString1 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            tempString2 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            tempString3 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            tempString4 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                                tempString6 += " + Apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1CPD.ToString();
                            }
                        }
                        if (apex2CPD != 0)
                        {
                            SumAdditives += apex2CPD;
                            tempString1 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            tempString2 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            tempString3 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            tempString4 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                                tempString6 += " + Apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2CPD.ToString();
                            }
                        }

                        if (float.Parse(comboBoxSelectVeteranLevel.Text) != 0)
                        {
                            SumAdditives += float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f;
                            tempString1 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString2 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString3 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString4 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                tempString6 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            }
                        }

                        if (skill1PDSum != 0)
                        {
                            SumAdditives += skill1PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            }
                        }
                        if (skill2PDSum != 0)
                        {
                            SumAdditives += skill2PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            }
                        }
                        if (skill3PDSum != 0)
                        {
                            SumAdditives += skill3PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            }
                        }
                        if (skill4PDSum != 0)
                        {
                            SumAdditives += skill4PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();

                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                tempString6 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            }
                        }
                        if (checkBoxBarricadePD.Checked)
                        {
                            SumAdditives += 0.2f;
                            tempString1 += " + PD from squad Barricade 0.2 ";
                            tempString2 += " + PD from squad Barricade 0.2 ";
                            tempString3 += " + PD from squad Barricade 0.2 ";
                            tempString4 += " + PD from squad Barricade 0.2 ";
                            if (FlakCannonBaseDOTDam != 0)
                            {

                                tempString5 += " + PD from squad Barricade 0.2 ";
                                tempString6 += " + PD from squad Barricade 0.2 ";
                            }
                        }
                        float SumFlakAdditives; SumFlakAdditives = SumAdditives;

                        //DEBUFFS
                        SumAdditives = 0;
                        tempString1 += " ) * ( 1 "; tempString2 += " ) * ( 1 "; tempString3 += " ) * ( 1 ";
                        if (FlakCannonBaseDOTDam != 0) { tempString4 += " ) * ( 1 "; tempString5 += " ) * ( 1 "; tempString6 += " ) * ( 1 "; }

                        if (skill1DebuffSum != 0)
                        {
                            SumAdditives += skill1DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";

                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            }
                        }


                        if (skill2DebuffSum != 0)
                        {
                            SumAdditives += skill2DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            if (FlakCannonBaseDOTDam != 0)
                            {

                                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            }
                        }

                        if (skill3DebuffSum != 0)
                        {
                            SumAdditives += skill3DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";

                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            }
                        }


                        if (skill4DebuffSum != 0)
                        {
                            SumAdditives += skill4DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                                tempString6 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            }
                        }

                        if (float.Parse(textBoxSumSquadDebuffsOnTarget.Text) != 0)
                        {
                            SumAdditives += float.Parse(textBoxSumSquadDebuffsOnTarget.Text);
                            tempString1 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString2 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString3 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString4 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            if (FlakCannonBaseDOTDam != 0)
                            {
                                tempString5 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text; tempString6 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            }
                        }

                        if (SumArmorDebuff != 0) { tempString2 += " + debuffvsArmor" + SumArmorDebuff.ToString();
                            tempString4 += " + debuffvsArmor" + SumArmorDebuff.ToString();
                            if (FlakCannonBaseDOTDam != 0) tempString6 += " + debuffvsArmor" + SumArmorDebuff.ToString(); }

                        SumDebuff = SumAdditives;
                        tempString1 += " ) * ( 1 )"; tempString2 += " ) * ( 1 ";
                        tempString3 += " ) * ( 1 )"; tempString4 += " ) * ( 1 ";
                        if (FlakCannonBaseDOTDam != 0) { tempString5 += " ) * ( 1 )"; tempString6 += " ) * ( 1 "; }


                        // vsDEFENSE 
                        //
                        // None (Kmerc, Thavok, Bscapper) have vsdefense passive. Power only has vs armor evos;



                        tempString1 += " = " + (FlakCannonImpactBaseDam * (1 + SumFlakAdditives) * (1 + SumDebuff)).ToString();
                        tempString3 += " = " + (FlakCannonShrapnelBaseDam * 0.7 * (1 + SumFlakAdditives) * (1 + SumDebuff)).ToString();

                        if (FlakCannonBaseDOTDam != 0)
                        {
                            tempString5 += " = " + ((FlakCannonBaseDOTDam / 2) * (1 + SumFlakAdditives) * (1 + SumDebuff)).ToString();

                        }



                        if (FlakCannonvsArmor != 0) { tempString2 += " + 5a vsArmor " + FlakCannonvsArmor.ToString(); }
                        tempString2 += " ) = " + (FlakCannonImpactBaseDam * (1 + SumFlakAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + FlakCannonvsArmor)).ToString();

                        SumAdditives = 0;
                        if (FlakCannonvsArmor != 0) { tempString4 += " + 5a vsArmor " + FlakCannonvsArmor.ToString(); SumAdditives += FlakCannonvsArmor; }
                        if (FlakCannonFvsArmor != 0) { tempString4 += " + Srapnel pen vsArmor" + FlakCannonFvsArmor.ToString(); SumAdditives += FlakCannonFvsArmor; }
                        tempString4 += " ) = " + (FlakCannonShrapnelBaseDam * (1 + SumFlakAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + SumAdditives)).ToString();

                        if (FlakCannonBaseDOTDam != 0)
                        {

                            if (FlakCannonvsArmor != 0) tempString6 += " + 5a vsArmor " + FlakCannonvsArmor.ToString();
                            tempString6 += " ) = " + ((FlakCannonBaseDOTDam / 2) * (1 + SumFlakAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + FlakCannonvsArmor)).ToString();
                        }



                        txtBox.Text += tempString1 + "\r\n";
                        txtBox.Text += tempString2 + "\r\n\r\n";
                        txtBox.Text += tempString3 + "\r\n";
                        txtBox.Text += tempString4 + "\r\n\r\n";

                        // do Sum Flak here
                        txtBox.Text += "Max of Shrapnel hits vs humanoid target = 8 "; if (FlakCannonBonusShrapnel != 0) txtBox.Text += "6a +50% extra shrapnels"; txtBox.Text += "\r\n";
                        txtBox.Text += "Total average shrapnel damage vs Health and Shields = " + (FlakCannonShrapnelBaseDam * 0.7 * (1 + SumFlakAdditives) * (1 + SumDebuff) * 8 * (1 + FlakCannonBonusShrapnel)).ToString() + "\r\n";
                        txtBox.Text += "Total average shrapnel damage vs Armor = " + (FlakCannonShrapnelBaseDam * (1 + SumFlakAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + SumAdditives) * 8 * (1 + FlakCannonBonusShrapnel)).ToString() + "\r\n\r\n";


                        if (FlakCannonBaseDOTDam != 0)
                        {

                            txtBox.Text += tempString5 + "\r\n";
                            txtBox.Text += tempString6 + "\r\n\r\n";

                            // NO DOT duration Bonus on any Thavok/KMerc/Scrapper 
                            txtBox.Text += "DOT duration : " + FlakCannonBaseDOTDur.ToString() + " seconds \r\n";

                            txtBox.Text += "Maximum Total Shredder DOT vs Health and Shields = " + (FlakCannonBaseDOTDam * (1 + SumFlakAdditives) * (1 + SumDebuff) * FlakCannonBaseDOTDur).ToString() + "\r\n";
                            txtBox.Text += "Maximum Total Shredder DOT vs Armor = " + (FlakCannonBaseDOTDam * (1 + SumFlakAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + FlakCannonvsArmor) * FlakCannonBaseDOTDur).ToString() + "\r\n";

                        }


                        break;

                    case "Lance":
                        //"Lance", "Lance description", false, "BaseDam=400;Detonator=1;Recharge=10", "1", "Recharge=0.1", "Dam=0.25", "Dam=0.3", "4b", "LWeak=0.4", "vsShields=0.35","Dam=0.3","Cost=0.45",

                        // AHuntress/AAdept/ADuelist/HKineticist [Ascension]
                        // vs shields vs rest vs [selected enemy] weakpoint (shields or else)
                        // cooldown or shieldcost(6b or ascension)  3



                        // combo boxes HAVE PLAYER CHOICES 
                        // Also need to get the right playingCharactersArray[SelectedCharIndex].Skill X CooldownMaxDurationPassiveTempEtc
                        TCooldownMaxDurationPassiveTempEtc = "";
                        if (playingCharactersArray[SelectedCharIndex].Skill1Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill1CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill2Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill2CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill3Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill3CooldownMaxDurationPassiveTempEtc;

                        //  txtBox.Text += TCooldownMaxDurationPassiveTempEtc;

                        float LanceBaseDam, LanceRecharge; LanceBaseDam = LanceRecharge = 0;

                        foreach (string s in TCooldownMaxDurationPassiveTempEtc.Split(';'))
                        {
                            //  "BaseDam="
                            if (s.StartsWith("BaseDam=")) LanceBaseDam = float.Parse(s.Substring(8, s.Length - 8));
                            if (s.StartsWith("Recharge=")) LanceRecharge = float.Parse(s.Substring(9, s.Length - 9));

                        }




                        //we will need to Find the right comboboxes by name .. 
                        //                         controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_1", true);
                        //                          comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        //                        float LancevsShields; LancevsShields = 0;
                        //                        foreach (string s in comboBox.Text.Split(';'))
                        //                       {
                        // check for Dam
                        //                           if (s.StartsWith("vsShields=")) LancevsShields1 += float.Parse(s.Substring(10, s.Length - 10));
                        //                            if (s.StartsWith("vsSynth=")) LancevsSynth1 += float.Parse(s.Substring(8, s.Length - 8));

                        //                       }

                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_2", true);
                        comboBox = controls[0] as ComboBox;
                        //   txtBox.Text += comboBox.Text + "\r\n";

                        float LanceRecharge1; LanceRecharge1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Recharge=")) LanceRecharge1 += float.Parse(s.Substring(9, s.Length - 9));

                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_3", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float LanceDam1; LanceDam1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) LanceDam1 += float.Parse(s.Substring(4, s.Length - 4));

                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_4", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float LanceDam2; LanceDam2 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) LanceDam2 += float.Parse(s.Substring(4, s.Length - 4));

                        }

                        //"Lance", "Lance description", false, "BaseDam=400;Detonator=1;Recharge=10", "1", "Recharge=0.1", "Dam=0.25", "Dam=0.3", "4b", "LWeak=0.4", "vsShields=0.35","Dam=0.3","Cost=0.45",

                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_5", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float LancevsShields, LanceWeak; LancevsShields = LanceWeak = 0;

                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            if (s.StartsWith("LWeak=")) LanceWeak += float.Parse(s.Substring(6, s.Length - 6));
                            if (s.StartsWith("vsShields=")) LancevsShields += float.Parse(s.Substring(10, s.Length - 10));
                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_6", true);
                        comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        float LanceDam3, LanceCost; LanceDam3 = LanceCost = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {

                            if (s.StartsWith("Dam=")) LanceDam3 += float.Parse(s.Substring(4, s.Length - 4));
                            if (s.StartsWith("Cost=")) LanceCost += float.Parse(s.Substring(5, s.Length - 5));
                        }


                        txtBox.Text += "Duration irrelevant ..no sustained effect \r\n\r\n";

                        if ((playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Human Kineticist")) && (checkBoxOnOffSkill4.Checked))
                        {
                            //  if (ascension 6b);
                            float AscensionDiscount; AscensionDiscount = 0;
                            foreach (string s in comboBoxSkill4_6.Text.Split(';'))
                            {
                                if (s.StartsWith("Discount=")) AscensionDiscount += float.Parse(s.Substring(9, s.Length - 9));
                            }
                            txtBox.Text += "Lance Ascension Shield cost = Ascension_Lance_Shield_Cost_Percent 33 / (1 + Ascension Shield Cost (build in) Discount 0.5"; //  shield cost with 6b perk .. 
                            if (AscensionDiscount != 0) txtBox.Text += " + Ascension 6b 'Efficient Ascension' Shield Cost (extra) Discount'" + AscensionDiscount.ToString();
                            txtBox.Text += " ) = " + (33 / (1 + 0.5 + AscensionDiscount)).ToString() + " % of Current Maximum Shields\r\n\r\n";
                        }
                        else if (LanceCost != 0) {
                            txtBox.Text += " Lance 'Shield Powered' Shield cost = 45 % of Current Maximum Shields \r\n\r\n ";  // shield cost
                        }
                        else {

                            txtBox.Text += "Cooldown FORMULA: (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";
                            txtBox.Text += "In the interest of developement speed this app ignores the WeaponWeight minigame - as long as you don't go over capacity AS YOU SHOULD! - the related term will be Zero \r\n\r\n";
                            txtBox.Text += "Cooldown = ( BaseLanceCooldown " + LanceRecharge + " / ( 1 ";

                            /// relevant variables for cooldown
                            /// BONUS STAT PRS, LanceRecharge1, LanceRecharge2 , gearPRS, booster1PRS, booster2PRS, skill1PRS to skill5PRS; + 
                            /// skill4PRTR
                            /// skill1PRPSum to skill3PRPSum
                            /// 

                            /// still at cooldown
                            /// (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";


                            SumAdditives = 0;
                            if (float.Parse(comboBoxBonusPRS.Text) != 0) { SumAdditives += float.Parse(comboBoxBonusPRS.Text) / 100; txtBox.Text += " + Bonus 'Power Recharge' Stat" + float.Parse(comboBoxBonusPRS.Text) / 100; }
                            if (LanceRecharge1 != 0) { SumAdditives += LanceRecharge1; txtBox.Text += " + 'Lance Recharge Evo 2' " + LanceRecharge1.ToString(); }
                            if (gearPRS != 0) { SumAdditives += gearPRS; txtBox.Text += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearPRS.ToString(); }
                            if (booster1PRS != 0) { SumAdditives += booster1PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1PRS.ToString(); }
                            if (booster2PRS != 0) { SumAdditives += booster2PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2PRS.ToString(); }
                            if (skill1PRS != 0) { SumAdditives += skill1PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PRS.ToString(); }
                            if (skill2PRS != 0) { SumAdditives += skill2PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PRS.ToString(); }
                            if (skill3PRS != 0) { SumAdditives += skill3PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PRS.ToString(); }
                            if (skill4PRS != 0) { SumAdditives += skill4PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PRS.ToString(); }
                            if (skill5PRS != 0) { SumAdditives += skill5PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5PRS.ToString(); }
                            txtBox.Text += " ) * ( 1";

                            PRP = 0;
                            // NO CHAR CURRENTLY HAS Lance AND ANNIHILATION
                            if (skill1PRPSum != 0) { PRP = skill1PRPSum; txtBox.Text += " + 'Annihilation PRP'" + skill1PRPSum.ToString(); }
                            if (skill2PRPSum != 0) { PRP = skill2PRPSum; txtBox.Text += " + 'Annihilation PRP'" + skill2PRPSum.ToString(); }
                            if (skill3PRPSum != 0) { PRP = skill3PRPSum; txtBox.Text += " + 'Annihilation PRP'" + skill3PRPSum.ToString(); }

                            txtBox.Text += " ) = " + ((LanceRecharge / (1 + SumAdditives)) * (1 + PRP)).ToString() + "\r\n";
                            //if (skill4PRTR != 0) { txtBox.Text += " Detonation Feedback" + (1-skill4PRTR).ToString() + " multiplier to remaining cooldown amount \r\n"; }
                            txtBox.Text += "\r\n\r\n";
                        }


                        /// relevant variables for damage

                        // will need to split  base // charged/ chain damage v*4 (health and synthhealth) 


                        ///////////////
                        /////////////// let the splittage begin


                        txtBox.Text += "Lance Damage formula: BaseDamage * (1 + SumAdditives) * Min( WeakLIMIT, (EnemyWeakMod + LanceWeak 5a) *  (1 + SumDebuff + SquadDebuff ) * (1 + SumvsDefense)  \r\n";
                        txtBox.Text += "WeakLIMIT= 1: if no weakspot hit; Breacher HAS NO WEAKSPOTS \r\n";
                        txtBox.Text += "WeakLIMIT= 8: otherwise default weakspot sum capped at 8 (destroyer)\r\n";
                        txtBox.Text += "WeakLIMIT=14: capped at 14 for APEX 'go for the eyes'\r\n";
                        txtBox.Text += "LANCE DOES NOT BENEFIT FROM +weakspot damage from passives, gear, boosters or APEX modifiers !!! \r\n\r\n";

                        txtBox.Text += "some debuffs, ex Pull's expose cannot be activated vs Armor or Shields - I don't account for that here - but you can tick that debuff off in UI if you want numbers without it and RE-Calculate) \r\n\r\n";

                        tempString1 = "non-weakspot Lance Damage vs Health and Armor = Base Impact Damage " + LanceBaseDam.ToString() + " * ( 1";
                        tempString2 = "non-weakspot Lance Damage vs Shields = Base Impact Damage " + LanceBaseDam.ToString() + " * ( 1";

                        tempString3 = "weakspot Lance Damage vs Health and Armor = " + LanceBaseDam.ToString() + " * ( 1";
                        tempString4 = "weakspot Lance Damage vs Shields = " + LanceBaseDam.ToString() + " * ( 1";

                        // Will need to accumulate the strings and print at the end since I want to print 9 at once .. 
                        // need sum of debuffs and MAX(skill ArmorDebuff - cryo beam and turret don't stack) first 
                        //"Lance", "Lance description", false, "BaseDam=400;Detonator=1;Recharge=10", "1", "Recharge=0.1", "Dam=0.25", "Dam=0.3", "4b", "LWeak=0.4", "vsShields=0.35","Dam=0.3","Cost=0.45",

                        //ADDITIVEs
                        SumAdditives = 0;

                        if (LanceDam1 != 0) { SumAdditives += LanceDam1;
                            tempString1 += " + 'Damage Evo 3' " + LanceDam1.ToString();
                            tempString2 += " + 'Damage Evo 3' " + LanceDam1.ToString();
                            tempString3 += " + 'Damage Evo 3' " + LanceDam1.ToString();
                            tempString4 += " + 'Damage Evo 3' " + LanceDam1.ToString();
                        }

                        if (LanceDam2 != 0)
                        {
                            SumAdditives += LanceDam2;
                            tempString1 += " + 'Damage Evo 4a' " + LanceDam2.ToString();
                            tempString2 += " + 'Damage Evo 4a' " + LanceDam2.ToString();
                            tempString3 += " + 'Damage Evo 4a' " + LanceDam2.ToString();
                            tempString4 += " + 'Damage Evo 4a' " + LanceDam2.ToString();
                        }

                        if (LanceDam3 != 0)
                        {
                            SumAdditives += LanceDam3;
                            tempString1 += " + 'Damage Evo 6a' " + LanceDam3.ToString();
                            tempString2 += " + 'Damage Evo 6a' " + LanceDam3.ToString();
                            tempString3 += " + 'Damage Evo 6a' " + LanceDam3.ToString();
                            tempString4 += " + 'Damage Evo 6a' " + LanceDam3.ToString();

                        }


                        if (gearBPD != 0)
                        {
                            SumAdditives += gearBPD;
                            tempString1 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearBPD.ToString();
                            tempString2 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearBPD.ToString();
                            tempString3 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearBPD.ToString();
                            tempString4 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearBPD.ToString();
                        }


                        if (booster1BPD != 0)
                        {
                            SumAdditives += booster1BPD;
                            tempString1 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1BPD.ToString();
                            tempString2 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1BPD.ToString();
                            tempString3 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1BPD.ToString();
                            tempString4 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1BPD.ToString();

                        }

                        if (booster2BPD != 0)
                        {
                            SumAdditives += booster2BPD;
                            tempString1 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2BPD.ToString();
                            tempString2 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2BPD.ToString();
                            tempString3 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2BPD.ToString();
                            tempString4 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2BPD.ToString();

                        }
                        if (apex1BPD != 0)
                        {
                            SumAdditives += apex1BPD;
                            tempString1 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1BPD.ToString();
                            tempString2 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1BPD.ToString();
                            tempString3 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1BPD.ToString();
                            tempString4 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1BPD.ToString();

                        }

                        if (apex2BPD != 0)
                        {
                            SumAdditives += apex2BPD;
                            tempString1 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2BPD.ToString();
                            tempString2 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2BPD.ToString();
                            tempString3 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2BPD.ToString();
                            tempString4 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2BPD.ToString();

                        }

                        if (float.Parse(comboBoxSelectVeteranLevel.Text) != 0)
                        {
                            SumAdditives += float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f;
                            tempString1 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString2 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString3 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString4 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();

                        }

                        if (skill1PDSum != 0)
                        {
                            SumAdditives += skill1PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();

                        }

                        if (skill2PDSum != 0)
                        {
                            SumAdditives += skill2PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();

                        }
                        if (skill3PDSum != 0)
                        {
                            SumAdditives += skill3PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();

                        }
                        if (skill4PDSum != 0)
                        {
                            SumAdditives += skill4PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();

                        }
                        if (skill4BPD != 0)
                        {
                            SumAdditives += skill4BPD;
                            tempString1 += " + BPD from 'Biotic Expert' evo " + skill4BPD.ToString();
                            tempString2 += " + BPD from 'Biotic Expert' evo " + skill4BPD.ToString();
                            tempString3 += " + BPD from 'Biotic Expert' evo " + skill4BPD.ToString();
                            tempString4 += " + BPD from 'Biotic Expert' evo " + skill4BPD.ToString();


                        }


                        if (checkBoxBarricadePD.Checked)
                        {
                            SumAdditives += 0.2f;
                            tempString1 += " + PD from squad Barricade 0.2 ";
                            tempString2 += " + PD from squad Barricade 0.2 ";
                            tempString3 += " + PD from squad Barricade 0.2 ";
                            tempString4 += " + PD from squad Barricade 0.2 ";

                        }

                        // Weakspot

                        //Min(WeakLIMIT, (EnemyWeakMod + LanceWeak 5a)
                        //WeakLIMIT =  1: if no weakspot hit; Breacher HAS NO WEAKSPOTS; 
                        //WeakLIMIT =  8: otherwise default weakspot sum capped at 8(destroyer);
                        //WeakLIMIT = 14: capped at 14 for APEX 'go for the eyes'

                        tempString3 += " ) * Min(";
                        tempString4 += " ) * Min(";
                        float WeakL; WeakL = 1;

                        if (comboBoxSelectEnemy.Text.Equals("Breacher")) { WeakL = 1; tempString3 += "breachers HAVE NO WEAKSPOTS 1,"; tempString4 += "breachers HAVE NO WEAKSPOTS 1,"; }
                        else if ((comboBoxSelectApex1.Text.Split('*')[0].Equals("Go for the eyes")) || (comboBoxSelectApex2.Text.Split('*')[0].Equals("Go for the eyes"))) { WeakL = 14; tempString3 += "Apex 'go fo the eyes' 14,"; tempString4 += "Apex 'go fo the eyes' 14,"; }
                        else { WeakL = 8; tempString3 += "WeakL = 8,"; tempString4 += "WeakL = 8,"; }

                        float WeakMul; WeakMul = 1;

                        // iterate enemy array until find index of selected enemy
                        int EnemyIndex; EnemyIndex = 0;
                        do
                        {
                            if (myEnemyStatsArray[EnemyIndex].enemyName.Equals(comboBoxSelectEnemy.Text)) break;
                            EnemyIndex++;
                        } while (EnemyIndex < constNrEnemies);


                        if (myEnemyStatsArray[EnemyIndex].baseWeak1 != 0)
                        {
                            WeakMul = myEnemyStatsArray[EnemyIndex].baseWeak1;
                            tempString3 += " " + myEnemyStatsArray[EnemyIndex].enemyName + " default weakspot damage" + myEnemyStatsArray[EnemyIndex].baseWeak1.ToString();
                            tempString4 += " " + myEnemyStatsArray[EnemyIndex].enemyName + " default weakspot damage" + myEnemyStatsArray[EnemyIndex].baseWeak1.ToString();

                            if (LanceWeak != 0)
                            {
                                WeakMul += LanceWeak;
                                tempString3 += " + lance weak 5a evo" + LanceWeak.ToString();
                                tempString4 += " + lance weak 5a evo" + LanceWeak.ToString();
                            }

                        }
                        else
                        {
                            //breacher
                            tempString3 += "1";
                            tempString4 += "1";
                        }

                        tempString1 += " ) * (1";
                        tempString2 += " ) * (1";
                        tempString3 += " ) * (1";
                        tempString4 += " ) * (1";


                        //DEBUFFS
                        float SumLanceAdditives; SumLanceAdditives = SumAdditives; SumAdditives = 0;

                    

                        if (skill1DebuffSum != 0)
                        {
                            SumAdditives += skill1DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); 
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); 
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString();
                         
                        }
                        if (skill2DebuffSum != 0)
                        {
                            SumAdditives += skill2DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();

                        }
                        if (skill3DebuffSum != 0)
                        {
                            SumAdditives += skill3DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();

                        }
                        if (skill4DebuffSum != 0)
                        {
                            SumAdditives += skill4DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();

                        }




                        if (float.Parse(textBoxSumSquadDebuffsOnTarget.Text) != 0)
                        {
                            SumAdditives += float.Parse(textBoxSumSquadDebuffsOnTarget.Text);
                            tempString1 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString2 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString3 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString4 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                         
                            
                        }
                 
                        SumDebuff = SumAdditives;
                                           
                 
                        tempString1 += " ) = " + (LanceBaseDam * (1 + SumLanceAdditives) * (1 + SumDebuff)).ToString();
                        tempString3 += " ) = " + (LanceBaseDam * (1 + SumLanceAdditives) * Math.Min(WeakL,WeakMul) * (1 + SumDebuff)).ToString();


                        if (LancevsShields != 0)
                        {
                            SumAdditives += LancevsShields;
                            tempString2 += ") * (1 + vs Shields evo 5b " + LancevsShields.ToString();
                            tempString4 += ") * (1 + vs Shields evo 5b " + LancevsShields.ToString();
                          }

                        tempString2 += " ) = " + (LanceBaseDam * (1 + SumLanceAdditives) * (1 + SumDebuff ) * (1 + LancevsShields)).ToString();
                        tempString4 += " ) = " + (LanceBaseDam * (1 + SumLanceAdditives) * Math.Min(WeakL, WeakMul) * (1 + SumDebuff) * (1 + LancevsShields)).ToString();

                        txtBox.Text += tempString1 + "\r\n";
                        txtBox.Text += tempString2 + "\r\n\r\n";
                        txtBox.Text += tempString3 + "\r\n";
                        txtBox.Text += tempString4 + "\r\n\r\n";

                        break;

                    case "Incinerate":
                        // "Incinerate", "incinerate description", false, "BaseDam=350;BaseDOTDam=45;BaseDOTDur=6;Recharge=12;FirePrimer=HA", "vsArmor=0.6", "Recharge=0.15", "DOTDam=0.35;IDam=0.35", "4a", "DOTDam=0.5;DOTDuration=0.5", "IDam=0.6", "vsArmor=0.65", "Detonator=1","6b",

                        //human infiltrator, krogan engineer ET, turian havok trooper, salarian architect ET and TEffectDur 
                                                                    
                        // combo boxes HAVE PLAYER CHOICES 
                        // Also need to get the right playingCharactersArray[SelectedCharIndex].Skill X CooldownMaxDurationPassiveTempEtc
                        TCooldownMaxDurationPassiveTempEtc = "";
                        if (playingCharactersArray[SelectedCharIndex].Skill1Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill1CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill2Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill2CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill3Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill3CooldownMaxDurationPassiveTempEtc;

                        //  txtBox.Text += TCooldownMaxDurationPassiveTempEtc;

                        float IncinerateImpactBaseDam, IncinerateBaseDOTDPS, IncinerateRecharge, IncinerateBaseDOTDur;
                        IncinerateImpactBaseDam = IncinerateBaseDOTDPS = IncinerateBaseDOTDur = IncinerateRecharge = 0; 

                        foreach (string s in TCooldownMaxDurationPassiveTempEtc.Split(';'))
                        {
                            //  "BaseDam="
                            if (s.StartsWith("BaseDam=")) IncinerateImpactBaseDam = float.Parse(s.Substring(8, s.Length - 8));
                            if (s.StartsWith("BaseDOTDam=")) IncinerateBaseDOTDPS = float.Parse(s.Substring(11, s.Length - 11));
                            if (s.StartsWith("BaseDOTDur=")) IncinerateBaseDOTDur = float.Parse(s.Substring(11, s.Length - 11));
                            if (s.StartsWith("Recharge=")) IncinerateRecharge = float.Parse(s.Substring(9, s.Length - 9));

                        }
                        //  txtBox.Text += IncinerateImpactBaseDam.ToString() + " " + IncinerateChargedBaseDam.ToString() + " " + IncinerateChainBaseDam.ToString() + " " + IncinerateBaseNrChains.ToString() + " " + IncinerateRecharge.ToString() + "\r\n";




 // "Incinerate", "incinerate description", false, "BaseDam=350;BaseDOTDam=45;BaseDOTDur=6;Recharge=12;FirePrimer=HA", "vsArmor=0.6", "Recharge=0.15", "DOTDam=0.35;IDam=0.35", "4a", "DOTDam=0.5;DOTDuration=0.5", "IDam=0.6", "vsArmor=0.65", "Detonator=1","6b",

                        
                        //we will need to Find the right comboboxes by name .. 
                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_1", true);
                        comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        float IncineratevsArmor1; IncineratevsArmor1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("vsArmor=")) IncineratevsArmor1 += float.Parse(s.Substring(8, s.Length - 8));
                        }

                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_2", true);
                        comboBox = controls[0] as ComboBox;
                        //   txtBox.Text += comboBox.Text + "\r\n";

                        float IncinerateRecharge1; IncinerateRecharge1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Recharge=")) IncinerateRecharge1 += float.Parse(s.Substring(9, s.Length - 9));

                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_3", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float IncinerateIDam1, IncinerateDOTDam1; IncinerateIDam1 = IncinerateDOTDam1 =0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("IDam=")) IncinerateIDam1 += float.Parse(s.Substring(5, s.Length - 5));
                            if (s.StartsWith("DOTDam=")) IncinerateDOTDam1 += float.Parse(s.Substring(7, s.Length - 7));

                        }

                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_4", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float  IncinerateDOTDam2, IncinerateDOTDur; IncinerateDOTDam2 = IncinerateDOTDur = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("DOTDam=")) IncinerateDOTDam2 += float.Parse(s.Substring(7, s.Length - 7));
                            if (s.StartsWith("DOTDuration=")) IncinerateDOTDur += float.Parse(s.Substring(12, s.Length - 12));

                        }
  // "Incinerate", "incinerate description", false, "BaseDam=350;BaseDOTDam=45;BaseDOTDur=6;Recharge=12;FirePrimer=HA", "vsArmor=0.6", "Recharge=0.15", "DOTDam=0.35;IDam=0.35", "4a", "DOTDam=0.5;DOTDuration=0.5", "IDam=0.6", "vsArmor=0.65", "Detonator=1","6b",

                         controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_5", true);
                         comboBox = controls[0] as ComboBox;
                                                //txtBox.Text += comboBox.Text + "\r\n";

                       float IncineratevsArmor2, IncinerateIDam2; IncineratevsArmor2 = IncinerateIDam2 = 0;

                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            if (s.StartsWith("IDam=")) IncinerateIDam2 += float.Parse(s.Substring(5, s.Length - 5));
                            if (s.StartsWith("vsArmor=")) IncineratevsArmor2 += float.Parse(s.Substring(8, s.Length - 8));
                        }


  //                                                controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_6", true);
 //                                               comboBox = controls[0] as ComboBox;
                                                //  txtBox.Text += comboBox.Text + "\r\n";

                                                
  //                                              foreach (string s in comboBox.Text.Split(';'))
//                                                {
                                              
  //                                              }

                        
                                                 // duration we'll care at the DOT section
                                                //txtBox.Text += "Duration irrelevant ..no sustained effect \r\n\r\n";

                                                txtBox.Text += "Cooldown FORMULA: (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";
                                                txtBox.Text += "In the interest of developement speed this app ignores the WeaponWeight minigame - as long as you don't go over capacity AS YOU SHOULD! - the related term will be Zero \r\n\r\n";
                                                txtBox.Text += "Cooldown = ( BaseIncinerateCooldown " + IncinerateRecharge + " / ( 1 ";


                                                /// relevant variables for cooldown
                                                /// BONUS STAT PRS, IncinerateRecharge1, IncinerateRecharge2 , gearPRS, booster1PRS, booster2PRS, skill1PRS to skill5PRS; + 
                                                /// skill4PRTR
                                                /// skill1PRPSum to skill3PRPSum
                                                /// 

                                                /// still at cooldown
                                                /// (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";

                                                SumAdditives = 0;
                                                if (float.Parse(comboBoxBonusPRS.Text) != 0) { SumAdditives += float.Parse(comboBoxBonusPRS.Text) / 100; txtBox.Text += " + Bonus 'Power Recharge' Stat" + float.Parse(comboBoxBonusPRS.Text) / 100; }
                                                if (IncinerateRecharge1 != 0) { SumAdditives += IncinerateRecharge1; txtBox.Text += " + 'Incinerate Recharge Evo 2' " + IncinerateRecharge1.ToString(); }
                                                if (gearPRS != 0) { SumAdditives += gearPRS; txtBox.Text += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearPRS.ToString(); }
                                                if (booster1PRS != 0) { SumAdditives += booster1PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1PRS.ToString(); }
                                                if (booster2PRS != 0) { SumAdditives += booster2PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2PRS.ToString(); }
                                                if (skill1PRS != 0) { SumAdditives += skill1PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PRS.ToString(); }
                                                if (skill2PRS != 0) { SumAdditives += skill2PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PRS.ToString(); }
                                                if (skill3PRS != 0) { SumAdditives += skill3PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PRS.ToString(); }
                                                if (skill4PRS != 0) { SumAdditives += skill4PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PRS.ToString(); }
                                                if (skill5PRS != 0) { SumAdditives += skill5PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5PRS.ToString(); }
                                                txtBox.Text += " ) * ( 1";

                                                PRP = 0;
                                                // NO CHAR CURRENTLY HAS Incinerate AND ANNIHILATION
                                                if (skill1PRPSum != 0) { PRP = skill1PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill1PRPSum.ToString(); }
                                                if (skill2PRPSum != 0) { PRP = skill2PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill2PRPSum.ToString(); }
                                                if (skill3PRPSum != 0) { PRP = skill3PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill3PRPSum.ToString(); }

                                                txtBox.Text += " ) = " + ((IncinerateRecharge / (1 + SumAdditives)) * (1 + PRP)).ToString() + "\r\n";
                                                //if (skill4PRTR != 0) { txtBox.Text += " Detonation Feedback" + (1-skill4PRTR).ToString() + " multiplier to remaining cooldown amount \r\n"; }
                                                txtBox.Text += "\r\n";


                                                /// relevant variables for damage

                                                // will need to split  base // charged/ chain damage v*4 (health and synthhealth) 


                                                ///////////////
                                                /////////////// let the splittage begin


                                                txtBox.Text += "Incinerate Impact Damage formula: BaseDamage * (1 + SumImpactAdditives) * (1 + SumDebuff + ETdebuff + SquadDebuff ) * (1 + SumvsDefense)  \r\n";
                                                txtBox.Text += "Incinerate DOT Damage per tick formula: ( BaseDOTDPS/2) * (1 + SumDOTAdditives) * (1 + SumDebuff + ETdebuff + SquadDebuff ) * (1 + SumvsDefense)  \r\n\r\n";
                                                txtBox.Text += "some debuffs, ex Pull's expose cannot be activated vs Armor or Shields - I don't account for that here - but you can tick that debuff off in UI if you want numbers without it and RE-Calculate) \r\n";
                                                txtBox.Text += "INCINERATE SELF PROCS Elemental Tech DEBUFF vsArmor and vsHealth (on the chars that have ET) \r\n\r\n";
                        
                                                tempString1 = "Impact Damage vs Health  = Base Impact Damage " + IncinerateImpactBaseDam.ToString() + " * ( 1";
                                                tempString2 = "Impact Damage vs Shields = Base Impact Damage " + IncinerateImpactBaseDam.ToString() + " * ( 1";
                                                tempString3 = "Impact Damage vs Armor = Base Impact Damage " + IncinerateImpactBaseDam.ToString() + " * ( 1";
                                                
                                                tempString4 = "DOT tick Damage vs Health = (BaseDOTDPS/2) Damage " + (IncinerateBaseDOTDPS / 2).ToString() + " * ( 1";
                                                tempString5 = "DOT tick Damage vs Armor = (BaseDOTDPS/2) Damage " + (IncinerateBaseDOTDPS / 2).ToString() + " * ( 1";

                      
                                                // Will need to accumulate the strings and print at the end since I want to print 9 at once .. 
                                                // need sum of debuffs and MAX(skill ArmorDebuff - cryo beam and turret don't stack) first 

                                                //ADDITIVEs
                        
                                             float SumIncinerateImpactAdditives, SumIncinerateDOTAdditives ; SumIncinerateImpactAdditives = SumIncinerateDOTAdditives = 0 ;

                        if (IncinerateIDam1 != 0)
                        {
                            SumIncinerateImpactAdditives += IncinerateIDam1;
                            tempString1 += " + 'Damage Evo 3' " + IncinerateIDam1.ToString();
                            tempString2 += " + 'Damage Evo 3' " + IncinerateIDam1.ToString();
                            tempString3 += " + 'Damage Evo 3' " + IncinerateIDam1.ToString();
                        }                                               
                       
                                                if (IncinerateIDam2 != 0)
                                                {
                            SumIncinerateImpactAdditives += IncinerateIDam2;
                                                    tempString1 += " + 'Impact Damage Evo 5a' " + IncinerateIDam2.ToString();
                                                    tempString2 += " + 'Impact Damage Evo 5a' " + IncinerateIDam2.ToString();
                                                    tempString3 += " + 'Impact Damage Evo 5a' " + IncinerateIDam2.ToString();
                                                    
                                                }

                        if (IncinerateDOTDam1 != 0)
                        {
                            SumIncinerateDOTAdditives += IncinerateDOTDam1;
                            tempString4 += " + 'Damage Evo 3' " + IncinerateDOTDam1.ToString();
                            tempString5 += " + 'Damage Evo 3' " + IncinerateDOTDam1.ToString();
                           
                        }
                        if (IncinerateDOTDam2 != 0)
                        {
                            SumIncinerateDOTAdditives += IncinerateDOTDam2;
                            tempString4 += " + 'DOT Damage Evo 4b' " + IncinerateDOTDam2.ToString();
                            tempString5 += " + 'DOT Damage Evo 4b' " + IncinerateDOTDam2.ToString();
                           
                        }


                        if (gearTPD != 0)
                                                {
                            SumIncinerateDOTAdditives += gearTPD; SumIncinerateImpactAdditives += gearTPD;
                            tempString1 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                                                    tempString2 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                                                    tempString3 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                                                    tempString4 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                                                    tempString5 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                                                                                                 }


                                                if (booster1TPD != 0)
                                                {
     
                            SumIncinerateDOTAdditives += booster1TPD; SumIncinerateImpactAdditives += booster1TPD;
                            tempString1 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                                                    tempString2 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                                                    tempString3 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                                                    tempString4 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                                                    tempString5 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                                                                                                  }

                                                if (booster2TPD != 0)
                                                {
                            SumIncinerateDOTAdditives += booster2TPD; SumIncinerateImpactAdditives += booster2TPD;

                            tempString1 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                                                    tempString2 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                                                    tempString3 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                                                    tempString4 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                                                    tempString5 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                                                                                                  }
                                                if (apex1TPD != 0)
                                                {
                                                    
                            SumIncinerateDOTAdditives += apex1TPD; SumIncinerateImpactAdditives += apex1TPD;

                            tempString1 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                                                    tempString2 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                                                    tempString3 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                                                    tempString4 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                                                    tempString5 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                                                  
                                                }

                                                if (apex2TPD != 0)
                                                {
                            SumIncinerateDOTAdditives += apex2TPD; SumIncinerateImpactAdditives += apex2TPD;

                            tempString1 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                                                    tempString2 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                                                    tempString3 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                                                    tempString4 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                                                    tempString5 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                                                     }

                                                if (float.Parse(comboBoxSelectVeteranLevel.Text) != 0)
                                                {
                                              
                            SumIncinerateDOTAdditives += float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f; SumIncinerateImpactAdditives += float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f;

                            tempString1 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                                    tempString2 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                                    tempString3 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                                    tempString4 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                                    tempString5 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                                  
                                                }

                                                if (skill1PDSum != 0)
                                                {
                                                  
                            SumIncinerateDOTAdditives += skill1PDSum; SumIncinerateImpactAdditives += skill1PDSum;

                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                                    tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                                    tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                                    tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                                    tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                                    }

                        if (skill2PDSum != 0)
                                                {
                            SumIncinerateDOTAdditives += skill2PDSum; SumIncinerateImpactAdditives += skill2PDSum;

                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                                    tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                                    tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                                    tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                                    tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                                    
                                                }
                                                if (skill3PDSum != 0)
                                                {
                            SumIncinerateDOTAdditives += skill3PDSum; SumIncinerateImpactAdditives += skill3PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                                    tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                                    tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                                    tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                                    tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                                            }
                                                if (skill4PDSum != 0)
                                                {
                            SumIncinerateDOTAdditives += skill4PDSum; SumIncinerateImpactAdditives += skill4PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                                    tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                                    tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                                    tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                                    tempString5 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                                                                               }


                                                if (checkBoxBarricadePD.Checked)
                                                {
                                                    
                            SumIncinerateDOTAdditives += 0.2f; SumIncinerateImpactAdditives += 0.2f;

                            tempString1 += " + PD from squad Barricade 0.2 ";
                                                    tempString2 += " + PD from squad Barricade 0.2 ";
                                                    tempString3 += " + PD from squad Barricade 0.2 ";
                                                    tempString4 += " + PD from squad Barricade 0.2 ";
                                                    tempString5 += " + PD from squad Barricade 0.2 ";
                                                  
                                                }


                                                //DEBUFFS
                                               SumAdditives = 0;

                                                tempString1 += " ) * ( 1"; tempString2 += " ) * ( 1"; tempString3 += " ) * ( 1";
                                                tempString4 += " ) * ( 1";  tempString5 += " ) * ( 1"; 

                                                if (skill1DebuffSum != 0)
                                                {
                                                    SumAdditives += skill1DebuffSum;
                                                    tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString();
                                                    tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); 
                                                    tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); 
                                                    tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); 
                                                    tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); 
                                                   }
                                             if (skill2DebuffSum != 0)
                                                   {
                            SumAdditives += skill2DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                            tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                        }

                        if (skill3DebuffSum != 0)
                        {
                            SumAdditives += skill3DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                            tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                        }

                        if (skill4DebuffSum != 0)
                        {
                            SumAdditives += skill4DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                            tempString5 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                        }


                        //  if WE HAVE ET skill46a ET AND checkBoxElementalTechOnTarget.checked 
                        // Incinerate does self proc ET
                        if (comboBoxSkill4_6.Text.Equals("ET=0.35"))
                                                {
                                                    SumAdditives += 0.35f;
                                                    tempString1 += " + debuffvsAll from Elemental Tech 0.35";
                                                  if (checkBoxElementalTechOnTarget.Checked)  tempString2 += " + debuffvsAll from Elemental Tech 0.35"; //No self proc vs shields
                                                    tempString3 += " + debuffvsAll from Elemental Tech 0.35";
                                                    tempString4 += " + debuffvsAll from Elemental Tech 0.35";
                                                    tempString5 += " + debuffvsAll from Elemental Tech 0.35";
                                                           }

                                                if (float.Parse(textBoxSumSquadDebuffsOnTarget.Text) != 0)
                                                {
                                                    SumAdditives += float.Parse(textBoxSumSquadDebuffsOnTarget.Text);
                                                    tempString1 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                                                    tempString2 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                                                    tempString3 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                                                    tempString4 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                                                    tempString5 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                                                   
                                                }

                                            //    if (SumArmorDebuff != 0)
                                            //    {
                                            //        tempString4 += " + debuffvsArmor" + SumArmorDebuff.ToString();
                                            //        tempString8 += " + debuffvsArmor" + SumArmorDebuff.ToString();
                                            //        tempString12 += " + debuffvsArmor" + SumArmorDebuff.ToString();
                                            //    }

                                                SumDebuff = SumAdditives;

                                                tempString1 += " ) * ( 1 "; tempString2 += " ) * ( 1 "; tempString3 += " ) * ( 1 ";
                        tempString4 += " ) * ( 1 "; tempString5 += " ) * ( 1 ";


                                                tempString1 += " ) = " + (IncinerateImpactBaseDam * (1 + SumIncinerateImpactAdditives) * (1 + SumDebuff)).ToString();
                                                tempString4 += " ) = " + ((IncinerateBaseDOTDPS/2) * (1 + SumIncinerateDOTAdditives) * (1 + SumDebuff)).ToString();
                                              

                                                if (skill4vsShields != 0) tempString2 += " + Passive vsShields " + skill4vsShields.ToString();
                        if (comboBoxSkill4_6.Text.Equals("ET=0.35") && (!checkBoxElementalTechOnTarget.Checked )) tempString2 += " ) = " + (IncinerateImpactBaseDam * (1 + SumIncinerateImpactAdditives) * (1 + SumDebuff - 0.35f) * (1 + skill4vsShields)).ToString(); // NO self ET vs shields
                        else tempString2 += " ) = " + (IncinerateImpactBaseDam * (1 + SumIncinerateImpactAdditives) * (1 + SumDebuff) * (1 + skill4vsShields)).ToString();


                        SumAdditives = IncineratevsArmor1 ;
                        tempString3 += " + Built-in vsArmor " + IncineratevsArmor1.ToString();
                        tempString5 += " + Built-in vsArmor " + IncineratevsArmor1.ToString();

                        if (IncineratevsArmor2  != 0)
                        {
                            SumAdditives = IncineratevsArmor2;
                            tempString3 += " + vsArmor evo 5b " + IncineratevsArmor2.ToString();
                            tempString5 += " + vsArmor evo 5b " + IncineratevsArmor2.ToString();
                        }


                        if (skill4vsArmor != 0)
                        {
                            SumAdditives += skill4vsArmor; 
                            tempString3 += " + Passive vsArmor " + skill4vsArmor.ToString();
                            tempString5 += " + Passive vsArmor " + skill4vsArmor.ToString();
                        }


                                                tempString3 += " ) = " + (IncinerateImpactBaseDam * (1 + SumIncinerateImpactAdditives) * (1 + SumDebuff ) * (1 + SumAdditives )).ToString();
                                                tempString5 += " ) = " + ((IncinerateBaseDOTDPS / 2) * (1 + SumIncinerateDOTAdditives) * (1 + SumDebuff ) * (1 + SumAdditives )).ToString();

                        txtBox.Text += tempString1 + "\r\n";
                        txtBox.Text += tempString2 + "\r\n";
                        txtBox.Text += tempString3 + "\r\n\r\n";
                        txtBox.Text += tempString4 + "\r\n";
                        txtBox.Text += "DOT tick Damage vs Shields = 0 \r\n";
                        txtBox.Text += tempString5 + "\r\n\r\n";

                        // need max total DOT vs health and armor

                        
                           txtBox.Text += "DOT duration : " + IncinerateBaseDOTDur.ToString() + " * ( 1";
                            if (skill4PEffectDur != 0) txtBox.Text += " + EffectDuration from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PEffectDur.ToString();
                            if (skill5PEffectDur != 0) txtBox.Text += " + EffectDuration from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5PEffectDur.ToString();
                            if (IncinerateDOTDur != 0) txtBox.Text += " + EffectDuration from evo 4b " + IncinerateDOTDur.ToString();
                            txtBox.Text += " ) = " + (IncinerateBaseDOTDur * (1 + skill4PEffectDur + skill5PEffectDur + IncinerateDOTDur)).ToString() + " seconds \r\n";

                            txtBox.Text += "Maximum Total Incinerate DOT vs Health = " + (IncinerateBaseDOTDPS * (1 + SumIncinerateDOTAdditives) * (1 + SumDebuff) * IncinerateBaseDOTDur * (1 + skill4PEffectDur + skill5PEffectDur + IncinerateDOTDur)).ToString() + "\r\n";
                            txtBox.Text += "Maximum Total Incinerate DOT vs Armor = " + (IncinerateBaseDOTDPS * (1 + SumIncinerateDOTAdditives) * (1 + SumDebuff) * (1 + SumAdditives ) * IncinerateBaseDOTDur * (1 + skill4PEffectDur + skill5PEffectDur + IncinerateDOTDur)).ToString() + "\r\n";
                         

                        break;

                    case "Flamethrower":
                        //"Flamethrower", "flamerthrow description", false, "BaseSDam=275;BaseDOTDam=200;BaseDOTDur=5;Recharge=12;FirePrimer=HA", "vsArmor=0.25", "Recharge=0.2", "IDam=0.25;DOTDam=0.25", "IDam=0.4;DOTDam=0.4", "Recharge=0.3", "5a", "DOTDam=0.5;DOTDuration=0.5", "vsArmor=0.8","6b",
                        // Krogan Mercenary and  Turian Agent
                        
                         
                         // combo boxes HAVE PLAYER CHOICES 
                        // Also need to get the right playingCharactersArray[SelectedCharIndex].Skill X CooldownMaxDurationPassiveTempEtc
                        TCooldownMaxDurationPassiveTempEtc = "";
                        if (playingCharactersArray[SelectedCharIndex].Skill1Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill1CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill2Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill2CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill3Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill3CooldownMaxDurationPassiveTempEtc;

                        //  txtBox.Text += TCooldownMaxDurationPassiveTempEtc;

                        float FlamerSutainedBaseDam, FlamerBaseDOTDPS, FlamerRecharge, FlamerBaseDOTDur;
                        FlamerSutainedBaseDam = FlamerBaseDOTDPS = FlamerBaseDOTDur = FlamerRecharge = 0; 

                        foreach (string s in TCooldownMaxDurationPassiveTempEtc.Split(';'))
                        {
                            //  "BaseDam="
                            if (s.StartsWith("BaseSDam=")) FlamerSutainedBaseDam = float.Parse(s.Substring(9, s.Length - 9));
                            if (s.StartsWith("BaseDOTDam=")) FlamerBaseDOTDPS = float.Parse(s.Substring(11, s.Length - 11));
                            if (s.StartsWith("BaseDOTDur=")) FlamerBaseDOTDur = float.Parse(s.Substring(11, s.Length - 11));
                            if (s.StartsWith("Recharge=")) FlamerRecharge = float.Parse(s.Substring(9, s.Length - 9));

                        }
                        //  txtBox.Text += IncinerateSutainedBaseDam.ToString() + " " + IncinerateChargedBaseDam.ToString() + " " + IncinerateChainBaseDam.ToString() + " " + IncinerateBaseNrChains.ToString() + " " + IncinerateRecharge.ToString() + "\r\n";

                        //"Flamethrower", "flamerthrow description", false, "BaseSDam=275;BaseDOTDam=200;BaseDOTDur=5;Recharge=12;FirePrimer=HA", "vsArmor=0.25", "Recharge=0.2", "IDam=0.25;DOTDam=0.25", "IDam=0.4;DOTDam=0.4", "Recharge=0.3", "5a", "DOTDam=0.5;DOTDuration=0.5", "vsArmor=0.8","6b",


                        //we will need to Find the right comboboxes by name .. 
                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_1", true);
                        comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        float FlamervsArmor1; FlamervsArmor1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("vsArmor=")) FlamervsArmor1 += float.Parse(s.Substring(8, s.Length - 8));
                        }

                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_2", true);
                        comboBox = controls[0] as ComboBox;
                        //   txtBox.Text += comboBox.Text + "\r\n";

                        float FlamerRecharge1; FlamerRecharge1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            
                            if (s.StartsWith("Recharge=")) FlamerRecharge1 += float.Parse(s.Substring(9, s.Length - 9));

                        }

                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_3", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float FlamerSdam1, FlamerDOTDam1; FlamerSdam1 = FlamerDOTDam1 =0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("IDam=")) FlamerSdam1 += float.Parse(s.Substring(5, s.Length - 5));
                            if (s.StartsWith("DOTDam=")) FlamerDOTDam1 += float.Parse(s.Substring(7, s.Length - 7));

                        }
                        //"Flamethrower", "flamerthrow description", false, "BaseSDam=275;BaseDOTDam=200;BaseDOTDur=5;Recharge=12;FirePrimer=HA", "vsArmor=0.25", "Recharge=0.2", "IDam=0.25;DOTDam=0.25", "IDam=0.4;DOTDam=0.4", "Recharge=0.3", "5a", "DOTDam=0.5;DOTDuration=0.5", "vsArmor=0.8","6b",

                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_4", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float FlamerSdam2, FlamerDOTDam2, FlamerRecharge2; FlamerSdam2 = FlamerDOTDam2 = FlamerRecharge2 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                           
                            if (s.StartsWith("IDam=")) FlamerSdam2 += float.Parse(s.Substring(5, s.Length - 5));
                            if (s.StartsWith("DOTDam=")) FlamerDOTDam2 += float.Parse(s.Substring(7, s.Length - 7));
                            if (s.StartsWith("Recharge=")) FlamerRecharge2 += float.Parse(s.Substring(9, s.Length - 9));

                        }

                         controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_5", true);
                         comboBox = controls[0] as ComboBox;
                                                //txtBox.Text += comboBox.Text + "\r\n";

                        float FlamerDOTDam3, FlamerDOTDur ; FlamerDOTDam3 = FlamerDOTDur =  0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            if (s.StartsWith("DOTDam=")) FlamerDOTDam3 += float.Parse(s.Substring(7, s.Length - 7));
                            if (s.StartsWith("DOTDuration=")) FlamerDOTDur += float.Parse(s.Substring(12, s.Length - 12));
                        }


                                                  controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_6", true);
                                                comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";
                        float FlamervsArmor2; FlamervsArmor2 = 0;
                                                foreach (string s in comboBox.Text.Split(';'))
                                                {
                            if (s.StartsWith("vsArmor=")) FlamervsArmor2 += float.Parse(s.Substring(8, s.Length - 8));

                        }


                        // duration we'll care at the DOT section
                        txtBox.Text += "Maximum Sustained Duration is FIXED 5 seconds - 16 damage ticks \r\n\r\n";

                        txtBox.Text += "Cooldown FORMULA: (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";
                        txtBox.Text += "In the interest of developement speed this app ignores the WeaponWeight minigame - as long as you don't go over capacity AS YOU SHOULD! - the related term will be Zero \r\n";
                        txtBox.Text += "(scaling cooldown) Minimum cooldown from canceling early ~35% of max lenght cooldown \r\n\r\n";
                        txtBox.Text += "Maximum Cooldown = ( BaseFlamerCooldown " + FlamerRecharge + " / ( 1 ";


                                                /// relevant variables for cooldown
                                                /// BONUS STAT PRS, FlamerRecharge1, FlamerRecharge2 , gearPRS, booster1PRS, booster2PRS, skill1PRS to skill5PRS; + 
                                                /// skill4PRTR
                                                /// skill1PRPSum to skill3PRPSum
                                                /// 

                                                /// still at cooldown
                                                /// (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";

                                                SumAdditives = 0;
                                                if (float.Parse(comboBoxBonusPRS.Text) != 0) { SumAdditives += float.Parse(comboBoxBonusPRS.Text) / 100; txtBox.Text += " + Bonus 'Power Recharge' Stat" + float.Parse(comboBoxBonusPRS.Text) / 100; }
                                                if (FlamerRecharge1 != 0) { SumAdditives += FlamerRecharge1; txtBox.Text += " + 'Flamer Recharge Evo 2' " + FlamerRecharge1.ToString(); }
                                                if (FlamerRecharge2 != 0) { SumAdditives += FlamerRecharge2; txtBox.Text += " + 'Flamer Recharge Evo 4b' " + FlamerRecharge2.ToString(); }
                                                if (gearPRS != 0) { SumAdditives += gearPRS; txtBox.Text += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearPRS.ToString(); }
                                                if (booster1PRS != 0) { SumAdditives += booster1PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1PRS.ToString(); }
                                                if (booster2PRS != 0) { SumAdditives += booster2PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2PRS.ToString(); }
                                                if (skill1PRS != 0) { SumAdditives += skill1PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PRS.ToString(); }
                                                if (skill2PRS != 0) { SumAdditives += skill2PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PRS.ToString(); }
                                                if (skill3PRS != 0) { SumAdditives += skill3PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PRS.ToString(); }
                                                if (skill4PRS != 0) { SumAdditives += skill4PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PRS.ToString(); }
                                                if (skill5PRS != 0) { SumAdditives += skill5PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5PRS.ToString(); }
                                                txtBox.Text += " ) * ( 1";

                                                PRP = 0;
                                                // NO CHAR CURRENTLY HAS Flamer AND ANNIHILATION
                                                if (skill1PRPSum != 0) { PRP = skill1PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill1PRPSum.ToString(); }
                                                if (skill2PRPSum != 0) { PRP = skill2PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill2PRPSum.ToString(); }
                                                if (skill3PRPSum != 0) { PRP = skill3PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill3PRPSum.ToString(); }

                                                txtBox.Text += " ) = " + ((FlamerRecharge / (1 + SumAdditives)) * (1 + PRP)).ToString() + "\r\n";
                                                //if (skill4PRTR != 0) { txtBox.Text += " Detonation Feedback" + (1-skill4PRTR).ToString() + " multiplier to remaining cooldown amount \r\n"; }
                                                txtBox.Text += "\r\n";
                                                txtBox.Text += "Takes 3 sustained stacks to RAMP the DOT to the maximum damage value ~1 second - Douse as many mooks as you can (jumping around) during the sustained period !! \r\n";
                                                txtBox.Text += "Or take advantage of the scaling cooldown - ~1 puffs is all you need to DOT kill a bunch of redbars !! \r\n\r\n ";
 

                        /// relevant variables for damage

                        // will need to split  base // charged/ chain damage v*4 (health and synthhealth) 


                        ///////////////
                        /////////////// let the splittage begin


                        txtBox.Text += "Flamer Sustained tick Damage formula: BaseDamage * (1 + SumSustainedAdditives) * (1 + SumDebuff + SumArmorDebuff + SquadDebuff ) * (1 + SumvsDefense)  \r\n";
                                                txtBox.Text += "Flamer DOT Damage per tick formula: ( BaseDOTDPS/2) * (1 + SumDOTAdditives) * (1 + SumDebuff + SumArmorDebuff + SquadDebuff ) * (1 + SumvsDefense)  \r\n\r\n";
                                                txtBox.Text += "some debuffs, ex Pull's expose cannot be activated vs Armor or Shields - I don't account for that here - but you can tick that debuff off in UI if you want numbers without it and RE-Calculate) \r\n\r\n";
                        
                                                tempString1 = "Sutained Damage tick vs Health and Shields = Base Sutained Damage " + FlamerSutainedBaseDam.ToString() + " * ( 1";
                                                tempString2 = "Sutained Damage tick vs Armor = Base Sutained Damage " + FlamerSutainedBaseDam.ToString() + " * ( 1";
                                                
                                                tempString3 = "DOT tick Damage vs Health = (BaseDOTDPS/2) Damage " + (FlamerBaseDOTDPS / 2).ToString() + " * ( 1";
                                                tempString4 = "DOT tick Damage vs Armor = (BaseDOTDPS/2) Damage " + (FlamerBaseDOTDPS / 2).ToString() + " * ( 1";

                      
                                                // Will need to accumulate the strings and print at the end since I want to print 9 at once .. 
                                                // need sum of debuffs and MAX(skill ArmorDebuff - cryo beam and turret don't stack) first 

                                                //ADDITIVEs
                        
                                             float SumFlamerSutainedAdditives, SumFlamerDOTAdditives ; SumFlamerSutainedAdditives = SumFlamerDOTAdditives = 0 ;

                        if (FlamerSdam1 != 0)
                        {
                            SumFlamerSutainedAdditives += FlamerSdam1;
                            tempString1 += " + 'Sustained Damage Evo 3' " + FlamerSdam1.ToString();
                            tempString2 += " + 'Sustained Damage Evo 3' " + FlamerSdam1.ToString();
                        }                                               
                        if (FlamerSdam2 != 0)
                                                {
                            SumFlamerSutainedAdditives += FlamerSdam2;
                            tempString1 += " + 'Sutained Damage Evo 4a' " + FlamerSdam2.ToString();
                            tempString2 += " + 'Sutained Damage Evo 4a' " + FlamerSdam2.ToString();
                                                                       
                                                }

                        if (FlamerDOTDam1 != 0)
                        {
                            SumFlamerDOTAdditives += FlamerDOTDam1;
                            tempString3 += " + 'DOT Damage Evo 3' " + FlamerDOTDam1.ToString();
                            tempString4 += " + 'DOT Damage Evo 3' " + FlamerDOTDam1.ToString();
                           
                        }
                        if (FlamerDOTDam2 != 0)
                        {
                            SumFlamerDOTAdditives += FlamerDOTDam2;
                            tempString3 += " + 'DOT Damage Evo 4a' " + FlamerDOTDam2.ToString();
                            tempString4 += " + 'DOT Damage Evo 4a' " + FlamerDOTDam2.ToString();
                           
                        }
                        if (FlamerDOTDam3 != 0)
                        {
                            SumFlamerDOTAdditives += FlamerDOTDam3;
                            tempString3 += " + 'DOT Damage Evo 5b' " + FlamerDOTDam3.ToString();
                            tempString4 += " + 'DOT Damage Evo 5b' " + FlamerDOTDam3.ToString();

                        }
                        

                        if (gearTPD != 0)
                                                {
                            SumFlamerDOTAdditives += gearTPD; SumFlamerSutainedAdditives += gearTPD;
                            tempString1 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                                                    tempString2 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                                                    tempString3 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                                                    tempString4 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                                                      }


                                                if (booster1TPD != 0)
                                                {
     
                            SumFlamerDOTAdditives += booster1TPD; SumFlamerSutainedAdditives += booster1TPD;
                            tempString1 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                                                    tempString2 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                                                    tempString3 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                                                    tempString4 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                                                                                                                                              }

                                                if (booster2TPD != 0)
                                                {
                            SumFlamerDOTAdditives += booster2TPD; SumFlamerSutainedAdditives += booster2TPD;

                            tempString1 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                                                    tempString2 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                                                    tempString3 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                                                    tempString4 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                                            
                                                                                                  }
                                                if (apex1TPD != 0)
                                                {
                                                    
                            SumFlamerDOTAdditives += apex1TPD; SumFlamerSutainedAdditives += apex1TPD;

                            tempString1 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                                                    tempString2 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                                                    tempString3 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                                                    tempString4 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                                                  
                                                }

                                                if (apex2TPD != 0)
                                                {
                            SumFlamerDOTAdditives += apex2TPD; SumFlamerSutainedAdditives += apex2TPD;

                            tempString1 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                                                    tempString2 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                                                    tempString3 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                                                    tempString4 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                                                                 }

                                                if (float.Parse(comboBoxSelectVeteranLevel.Text) != 0)
                                                {
                                              
                            SumFlamerDOTAdditives += float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f; SumFlamerSutainedAdditives += float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f;

                            tempString1 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                                    tempString2 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                                    tempString3 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                                    tempString4 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                                                                                           
                                                }

                                                if (skill1PDSum != 0)
                                                {
                                                  
                            SumFlamerDOTAdditives += skill1PDSum; SumFlamerSutainedAdditives += skill1PDSum;

                                                    tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                                    tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                                    tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                                    tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                                                   
                                                }

                                                if (skill2PDSum != 0)
                                                {
                            SumFlamerDOTAdditives += skill2PDSum; SumFlamerSutainedAdditives += skill2PDSum;

                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                                    tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                                    tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                                    tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                                                    
                                                }
                                                if (skill3PDSum != 0)
                                                {
                            SumFlamerDOTAdditives += skill3PDSum; SumFlamerSutainedAdditives += skill3PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                                    tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                                    tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                                    tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                                                            }
                                                if (skill4PDSum != 0)
                                                {
                            SumFlamerDOTAdditives += skill4PDSum; SumFlamerSutainedAdditives += skill4PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                                    tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                                    tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                                    tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                                                                                               }


                                                if (checkBoxBarricadePD.Checked)
                                                {
                                                    
                            SumFlamerDOTAdditives += 0.2f; SumFlamerSutainedAdditives += 0.2f;

                            tempString1 += " + PD from squad Barricade 0.2 ";
                                                    tempString2 += " + PD from squad Barricade 0.2 ";
                                                    tempString3 += " + PD from squad Barricade 0.2 ";
                                                    tempString4 += " + PD from squad Barricade 0.2 ";
                                                 
                                                }


                                                //DEBUFFS
                                               SumAdditives = 0;

                                                tempString1 += " ) * ( 1"; tempString2 += " ) * ( 1";
                                                tempString3 += " ) * ( 1";  tempString4 += " ) * ( 1"; 

                                                if (skill1DebuffSum != 0)
                                                {
                                                    SumAdditives += skill1DebuffSum;
                                                    tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString();
                                                    tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); 
                                                    tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); 
                                                    tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); 
                                                   }
                                             if (skill2DebuffSum != 0)
                                                   {
                            SumAdditives += skill2DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();

                        }

                        if (skill3DebuffSum != 0)
                        {
                            SumAdditives += skill3DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                        }

                        if (skill4DebuffSum != 0)
                        {
                            SumAdditives += skill4DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                        }


                        //  if WE HAVE ET skill46a ET AND checkBoxElementalTechOnTarget.checked 
                        // 
                        //if (comboBoxSkill4_6.Text.Equals("ET=0.35"))
                          //                      {
                          //                          SumAdditives += 0.35f;
                          //                          tempString1 += " + debuffvsAll from Elemental Tech 0.35";
                          //                        if (checkBoxElementalTechOnTarget.Checked)  tempString2 += " + debuffvsAll from Elemental Tech 0.35"; //No self proc vs shields
                          //                          tempString3 += " + debuffvsAll from Elemental Tech 0.35";
                          //                          tempString4 += " + debuffvsAll from Elemental Tech 0.35";
                          //                                 }

                                                if (float.Parse(textBoxSumSquadDebuffsOnTarget.Text) != 0)
                                                {
                                                    SumAdditives += float.Parse(textBoxSumSquadDebuffsOnTarget.Text);
                                                    tempString1 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                                                    tempString2 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                                                    tempString3 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                                                    tempString4 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                                                  
                                                }

                                                if (SumArmorDebuff != 0)
                                                {
                                                    tempString2 += " + debuffvsArmor" + SumArmorDebuff.ToString();
                                                    tempString4 += " + debuffvsArmor" + SumArmorDebuff.ToString();
                                            
                                                }

                                                SumDebuff = SumAdditives;

                                                tempString1 += " ) * ( 1 "; tempString2 += " ) * ( 1 "; 
                                                tempString3 += " ) * ( 1 "; tempString4 += " ) * ( 1 ";


                               tempString1 += " ) = " + (FlamerSutainedBaseDam * (1 + SumFlamerSutainedAdditives) * (1 + SumDebuff)).ToString();
                               tempString3 += " ) = " + ((FlamerBaseDOTDPS/2) * (1 + SumFlamerDOTAdditives) * (1 + SumDebuff)).ToString();
                                              
                                             

                        SumAdditives = FlamervsArmor1 ;
                        tempString2 += " + Built-in vsArmor " + FlamervsArmor1.ToString();
                        tempString4 += " + Built-in vsArmor " + FlamervsArmor1.ToString();

                        if (FlamervsArmor2  != 0)
                        {
                            SumAdditives += FlamervsArmor2;
                            tempString2 += " + vsArmor evo 5b " + FlamervsArmor2.ToString();
                            tempString4 += " + vsArmor evo 5b " + FlamervsArmor2.ToString();
                        }


                        //if (skill4vsArmor != 0)
                        //{
                        //    SumAdditives += skill4vsArmor; 
                        //    tempString3 += " + Passive vsArmor " + skill4vsArmor.ToString();
                        //    tempString5 += " + Passive vsArmor " + skill4vsArmor.ToString();
                       // }


                         tempString2 += " ) = " + (FlamerSutainedBaseDam * (1 + SumFlamerSutainedAdditives) * (1 + SumDebuff + SumArmorDebuff ) * (1 + SumAdditives )).ToString();
                         tempString4 += " ) = " + ((FlamerBaseDOTDPS / 2) * (1 + SumFlamerDOTAdditives) * (1 + SumDebuff + SumArmorDebuff ) * (1 + SumAdditives )).ToString();

                        txtBox.Text += tempString1 + "\r\n";
                        txtBox.Text += tempString2 + "\r\n\r\n";

                        //txtBox.Text += "Will need MAxIMUM SUSTAINED DAAMGE \r\n\r\n";
                        txtBox.Text += "Maximum Total Sustained vs Health and Shields (16 ticks) = " + (16 * FlamerSutainedBaseDam * (1 + SumFlamerSutainedAdditives) * (1 + SumDebuff)).ToString() + "\r\n";
                        txtBox.Text += "Maximum Total Sustained vs Armor (16 ticks) = " + (16 * FlamerSutainedBaseDam * (1 + SumFlamerSutainedAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + SumAdditives)).ToString() + "\r\n\r\n";


                        txtBox.Text += tempString3 + "\r\n";
                        txtBox.Text += "DOT tick Damage vs Shields = 0 \r\n";
                        txtBox.Text += tempString4 + "\r\n\r\n";

                        // need max total DOT vs health and armor

                        
                           txtBox.Text += "DOT duration : " + FlamerBaseDOTDur.ToString() + " * ( 1";
                            if (skill4PEffectDur != 0) txtBox.Text += " + EffectDuration from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PEffectDur.ToString();
                            if (skill5PEffectDur != 0) txtBox.Text += " + EffectDuration from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5PEffectDur.ToString();
                            if (FlamerDOTDur != 0) txtBox.Text += " + EffectDuration from evo 5b " + FlamerDOTDur.ToString();
                            txtBox.Text += " ) = " + (FlamerBaseDOTDur * (1 + skill4PEffectDur + skill5PEffectDur + FlamerDOTDur)).ToString() + " seconds \r\n";

                            txtBox.Text += "Maximum Total Flamer DOT vs Health = " + (FlamerBaseDOTDPS * (1 + SumFlamerDOTAdditives) * (1 + SumDebuff) * FlamerBaseDOTDur * (1 + skill4PEffectDur + skill5PEffectDur + FlamerDOTDur)).ToString() + "\r\n";
                        txtBox.Text += "Maximum Total Flamer DOT vs Armor = " + (FlamerBaseDOTDPS * (1 + SumFlamerDOTAdditives) * (1 + SumDebuff) * (1 + SumAdditives) * FlamerBaseDOTDur * (1 + skill4PEffectDur + skill5PEffectDur + FlamerDOTDur)).ToString() + "\r\n";
                        //txtBox.Text+= SumAdditives.ToString() ;
        
                        break;

                    case "Energy Drain":
 // "Energy Drain", "energy drain description", false, "BaseDamage=175;RShields=0.35;Recharge=12;Detonator=1", "vsShields=1;vsSynth=0.15", "Recharge=0.1", "Dam=0.25;RShields=0.15", "Dam=0.3;RShields=0.2", "Recharge=0.3", "RSHOT=0.06;RSHOTDur=4;TechPrimer=HSA", "5b","Dam=0.35;vsShields=0.75;vsSynth=0.15", "RShields=0.25;AllyRShields=0.5",

               // Human Sentinel, Asari Sentinel, Salarian Infiltrator, Angara Exemplar         
                         
                            // combo boxes HAVE PLAYER CHOICES 
                        // Also need to get the right playingCharactersArray[SelectedCharIndex].Skill X CooldownMaxDurationPassiveTempEtc
                        TCooldownMaxDurationPassiveTempEtc = "";
                        if (playingCharactersArray[SelectedCharIndex].Skill1Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill1CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill2Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill2CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill3Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill3CooldownMaxDurationPassiveTempEtc;

                        //  txtBox.Text += TCooldownMaxDurationPassiveTempEtc;

                        float EnergyDrainBaseDam, EnergyDrainRecharge, EnergyDrainRShields1;
                        EnergyDrainBaseDam = EnergyDrainRecharge = EnergyDrainRShields1 = 0; 

                        foreach (string s in TCooldownMaxDurationPassiveTempEtc.Split(';'))
                        {
                            //  "BaseDam="
                            if (s.StartsWith("BaseDamage=")) EnergyDrainBaseDam = float.Parse(s.Substring(11, s.Length - 11));
                            if (s.StartsWith("Recharge=")) EnergyDrainRecharge = float.Parse(s.Substring(9, s.Length - 9));
                            if (s.StartsWith("RShields=")) EnergyDrainRShields1 = float.Parse(s.Substring(9, s.Length - 9));
                        
                        }
                        //  txtBox.Text += EnergyDrainBaseDam.ToString() + " " + EnergyDrainChargedBaseDam.ToString() + " " + EnergyDrainChainBaseDam.ToString() + " " + EnergyDrainBaseNrChains.ToString() + " " + EnergyDrainRecharge.ToString() + "\r\n";
                        // duration don't care 
                        txtBox.Text += "Duration irrelevant ..no sustained effect \r\n\r\n";
                        

                        //we will need to Find the right comboboxes by name .. 
                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_1", true);
                        comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        float EnergyDrainvsShields1, EnergyDrainvsSynth1; EnergyDrainvsShields1 = EnergyDrainvsSynth1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("vsShields=")) EnergyDrainvsShields1 += float.Parse(s.Substring(10, s.Length - 10));
                            if (s.StartsWith("vsSynth=")) EnergyDrainvsSynth1 += float.Parse(s.Substring(8, s.Length - 8));

                        }

                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_2", true);
                        comboBox = controls[0] as ComboBox;
                        //   txtBox.Text += comboBox.Text + "\r\n";

                        float EnergyDrainRecharge1; EnergyDrainRecharge1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Recharge=")) EnergyDrainRecharge1 += float.Parse(s.Substring(9, s.Length - 9));

                        }

                        // "Energy Drain", "energy drain description", false, "BaseDamage=175;RShields=0.35;Recharge=12;Detonator=1", "vsShields=1;vsSynth=0.15", "Recharge=0.1", "Dam=0.25;RShields=0.15", "Dam=0.3;RShields=0.2", "Recharge=0.3", "RSHOT=0.06;RSHOTDur=4;TechPrimer=HSA", "5b","Dam=0.35;vsShields=0.75;vsSynth=0.15", "RShields=0.25;AllyRShields=0.5",


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_3", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float EnergyDrainDam1, EnergyDrainRShields2; EnergyDrainDam1 = EnergyDrainRShields2 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) EnergyDrainDam1 += float.Parse(s.Substring(4, s.Length - 4));
                            if (s.StartsWith("RShields=")) EnergyDrainRShields2 = float.Parse(s.Substring(9, s.Length - 9));
                              }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_4", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float EnergyDrainDam2, EnergyDrainRecharge2, EnergyDrainRShields3; EnergyDrainDam2 = EnergyDrainRecharge2 = EnergyDrainRShields3 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) EnergyDrainDam2 += float.Parse(s.Substring(4, s.Length - 4));
                            if (s.StartsWith("RShields=")) EnergyDrainRShields3 = float.Parse(s.Substring(9, s.Length - 9));
                            if (s.StartsWith("Recharge=")) EnergyDrainRecharge2 += float.Parse(s.Substring(9, s.Length - 9));
                        }

                        //"RSHOT=0.06;RSHOTDur=4;TechPrimer=HSA", "5b","Dam=0.35;vsShields=0.75;vsSynth=0.15", "RShields=0.25;AllyRShields=0.5",
                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_5", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float EnergyDrainRHOT, EnergyDrainRHOTDur; EnergyDrainRHOT = EnergyDrainRHOTDur = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            if (s.StartsWith("RSHOT=")) EnergyDrainRHOT += float.Parse(s.Substring(6, s.Length - 6));
                            if (s.StartsWith("RSHOTDur=")) EnergyDrainRHOTDur += float.Parse(s.Substring(9, s.Length - 9));
                              }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_6", true);
                        comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        float EnergyDrainvsShields2, EnergyDrainDam3, EnergyDrainvsSynth2, EnergyDrainRShields4; EnergyDrainvsShields2 = EnergyDrainDam3 = EnergyDrainvsSynth2 = EnergyDrainRShields4 = 0; 
                        foreach (string s in comboBox.Text.Split(';'))
                        {

                            if (s.StartsWith("vsShields=")) EnergyDrainvsShields2 += float.Parse(s.Substring(10, s.Length - 10));
                            if (s.StartsWith("Dam=")) EnergyDrainDam3 += float.Parse(s.Substring(4, s.Length - 4));
                            if (s.StartsWith("vsSynth=")) EnergyDrainvsSynth2 += float.Parse(s.Substring(8, s.Length - 8));
                            if (s.StartsWith("RShields=")) EnergyDrainRShields4 = float.Parse(s.Substring(9, s.Length - 9));

                        }


                        /// relevant variables for cooldown
                        /// BONUS STAT PRS, EnergyDrainRecharge1, EnergyDrainRecharge2 , gearPRS, booster1PRS, booster2PRS, skill1PRS to skill5PRS; + 
                        /// skill4PRTR
                        /// skill1PRPSum to skill3PRPSum
                        /// 


                        txtBox.Text += "Cooldown FORMULA: (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";
                        txtBox.Text += "In the interest of developement speed this app ignores the WeaponWeight minigame - as long as you don't go over capacity AS YOU SHOULD! - the related term will be Zero \r\n\r\n";
                        txtBox.Text += "Cooldown = ( BaseEnergyDrainCooldown " + EnergyDrainRecharge + " / ( 1 ";

                        /// still at cooldown
                        /// (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";

                        SumAdditives = 0;
                        if (float.Parse(comboBoxBonusPRS.Text) != 0) { SumAdditives += float.Parse(comboBoxBonusPRS.Text) / 100; txtBox.Text += " + Bonus 'Power Recharge' Stat" + float.Parse(comboBoxBonusPRS.Text) / 100; }
                        if (EnergyDrainRecharge1 != 0) { SumAdditives += EnergyDrainRecharge1; txtBox.Text += " + 'EnergyDrain Recharge Evo 2' " + EnergyDrainRecharge1.ToString(); }
                        if (EnergyDrainRecharge2 != 0) { SumAdditives += EnergyDrainRecharge2; txtBox.Text += " + 'EnergyDrain Recharge Evo 4b' " + EnergyDrainRecharge2.ToString(); }
                        if (gearPRS != 0) { SumAdditives += gearPRS; txtBox.Text += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearPRS.ToString(); }
                        if (booster1PRS != 0) { SumAdditives += booster1PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1PRS.ToString(); }
                        if (booster2PRS != 0) { SumAdditives += booster2PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2PRS.ToString(); }
                        if (skill1PRS != 0) { SumAdditives += skill1PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PRS.ToString(); }
                        if (skill2PRS != 0) { SumAdditives += skill2PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PRS.ToString(); }
                        if (skill3PRS != 0) { SumAdditives += skill3PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PRS.ToString(); }
                        if (skill4PRS != 0) { SumAdditives += skill4PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PRS.ToString(); }
                        if (skill5PRS != 0) { SumAdditives += skill5PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5PRS.ToString(); }
                        txtBox.Text += " ) * ( 1";

                         PRP = 0;
                        // NO CHAR CURRENTLY HAS EnergyDrain AND ANNIHILATION
                        if (skill1PRPSum != 0) { PRP = skill1PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill1PRPSum.ToString(); }
                        if (skill2PRPSum != 0) { PRP = skill2PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill2PRPSum.ToString(); }
                        if (skill3PRPSum != 0) { PRP = skill3PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill3PRPSum.ToString(); }

                        txtBox.Text += " ) = " + ((EnergyDrainRecharge / (1 + SumAdditives)) * (1 + PRP)).ToString() + "\r\n";
                        //if (skill4PRTR != 0) { txtBox.Text += " Detonation Feedback" + (1-skill4PRTR).ToString() + " multiplier to remaining cooldown amount \r\n"; }
                        txtBox.Text += "\r\n";


                        /// relevant variables for damage

                        // will need to split  base // charged/ chain damage v*4 (health and synthhealth) 
                        
                        ///////////////
                        /////////////// let the splittage begin


                        txtBox.Text += "EnergyDrain Damage formula: BaseDamage * (1 + SumAdditives) * (1 + (SumDebuff  + SquadDebuff ) * (1 + SumvsDefense)  \r\n";
                        txtBox.Text += "EnergyDrain ofCurrentMaxShield% Heal impact formula: CurMaxShields * (1 + SumImpactShieldHealAdditives) * (1+SumSupport) \r\n";
                        txtBox.Text += "EnergyDrain ofCurrentMaxShield% Heal over time per heal tick formula: CurMaxShields * (BaseHOTperSecond/4) * (1+SumSupport) \r\n\r\n";
                        txtBox.Text += "EnergyDrain's BENEFIT MULTIPLCIATIVELY FROM SUPPORT STAT IN PASSIVE !! \r\n";
                        txtBox.Text += "some debuffs, ex Pull's expose cannot be activated vs Armor or Shields - I don't account for that here - but you can tick that debuff off in UI if you want numbers without it and RE-Calculate) \r\n\r\n";

                        tempString1 = "Damage vs NON Synthetic Health = Base Damage " + EnergyDrainBaseDam.ToString() + " * ( 1";
                        tempString2 = "Damage vs Synthetic Health = Base Damage " + EnergyDrainBaseDam.ToString() + " * ( 1";
                        tempString3 = "Damage vs Shields = Base Damage " + EnergyDrainBaseDam.ToString() + " * ( 1";
                        tempString4 = "Damage vs Armor = Base Damage " + EnergyDrainBaseDam.ToString() + " * ( 1";

                        tempString5 = "Impact Percent Shield Heal = CurrentMaxShields * ( 1";
                        if (EnergyDrainRHOT != 0 ) tempString6 = "HOT per tick Percent Shield Heal = CurrentMaxShields * " + (EnergyDrainRHOT / 4).ToString() +  " " ;



                        // Will need to accumulate the strings and print at the end since I want to print 9 at once .. 
                        // need sum of debuffs and MAX(skill ArmorDebuff - cryo beam and turret don't stack) first 

                        //do RShield first since is separate and simple
                        SumAdditives = 0;
                        SumAdditives += EnergyDrainRShields1; tempString5 += " + built in " + EnergyDrainRShields1.ToString();
                        if (EnergyDrainRShields2 != 0) SumAdditives += EnergyDrainRShields2; tempString5 += " + evo 3 " + EnergyDrainRShields2.ToString();
                        if (EnergyDrainRShields3 != 0) SumAdditives += EnergyDrainRShields3; tempString5 += " + evo 4a " + EnergyDrainRShields3.ToString();
                        if (EnergyDrainRShields4 != 0) SumAdditives += EnergyDrainRShields4; tempString5 += " + evo 6b " + EnergyDrainRShields4.ToString();
                        float SumImpactShieldHealAdditives; SumImpactShieldHealAdditives = SumAdditives;

                        //ADDITIVEs
                        SumAdditives = 0;

                        if (EnergyDrainDam1 != 0) { SumAdditives += EnergyDrainDam1;
                            tempString1 += " + 'Damage Evo 3' " + EnergyDrainDam1.ToString();
                            tempString2 += " + 'Damage Evo 3' " + EnergyDrainDam1.ToString();
                            tempString3 += " + 'Damage Evo 3' " + EnergyDrainDam1.ToString();
                            tempString4 += " + 'Damage Evo 3' " + EnergyDrainDam1.ToString();
                                                 }

                        if (EnergyDrainDam2 != 0)
                        {
                            SumAdditives += EnergyDrainDam2;
                            tempString1 += " + 'Damage Evo 4a' " + EnergyDrainDam2.ToString();
                            tempString2 += " + 'Damage Evo 4a' " + EnergyDrainDam2.ToString();
                            tempString3 += " + 'Damage Evo 4a' " + EnergyDrainDam2.ToString();
                            tempString4 += " + 'Damage Evo 4a' " + EnergyDrainDam2.ToString();
                              }

                        if (EnergyDrainDam3 != 0)
                        {
                            SumAdditives += EnergyDrainDam3;
                            tempString1 += " + 'Damage Evo 6a' " + EnergyDrainDam3.ToString();
                            tempString2 += " + 'Damage Evo 6a' " + EnergyDrainDam3.ToString();
                            tempString3 += " + 'Damage Evo 6a' " + EnergyDrainDam3.ToString();
                            tempString4 += " + 'Damage Evo 6a' " + EnergyDrainDam3.ToString();
                            }

                        // vsSynth1 vsSynth2 ; 2, 6, 10 
                        SumAdditivesSynth = 0;
                        if (EnergyDrainvsSynth1 != 0)
                        {
                            SumAdditivesSynth += EnergyDrainvsSynth1;
                            tempString2 += " + 'vsSynth Evo 1' " + EnergyDrainvsSynth1.ToString();
                          
                        }

                        if (EnergyDrainvsSynth2 != 0)
                        {
                            SumAdditivesSynth += EnergyDrainvsSynth2;
                            tempString2 += " + 'vsSynth Evo 6a' " + EnergyDrainvsSynth2.ToString();
                         }

                        if (gearTPD != 0)
                        {
                            SumAdditives += gearTPD;
                            tempString1 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString2 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString3 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                            tempString4 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearTPD.ToString();
                           
                        }


                        if (booster1TPD != 0)
                        {
                            SumAdditives += booster1TPD;
                            tempString1 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString2 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString3 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                            tempString4 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1TPD.ToString();
                           
                        }

                        if (booster2TPD != 0)
                        {
                            SumAdditives += booster2TPD;
                            tempString1 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString2 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString3 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                            tempString4 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2TPD.ToString();
                           
                        }
                        if (apex1TPD != 0)
                        {
                            SumAdditives += apex1TPD;
                            tempString1 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString2 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString3 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                            tempString4 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1TPD.ToString();
                                                  }

                        if (apex2TPD != 0)
                        {
                            SumAdditives += apex2TPD;
                            tempString1 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString2 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString3 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                            tempString4 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2TPD.ToString();
                           
                        }

                        if (float.Parse(comboBoxSelectVeteranLevel.Text) != 0)
                        {
                            SumAdditives += float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f;
                            tempString1 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString2 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString3 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString4 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                         
                        }

                        if (skill1PDSum != 0)
                        {
                            SumAdditives += skill1PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
            
                        }

                        if (skill2PDSum != 0)
                        {
                            SumAdditives += skill2PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
           
                        }
                        if (skill3PDSum != 0)
                        {
                            SumAdditives += skill3PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                   
                        }
                        if (skill4PDSum != 0)
                        {
                            SumAdditives += skill4PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString4 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
             
                        }


                        if (checkBoxBarricadePD.Checked)
                        {
                            SumAdditives += 0.2f;
                            tempString1 += " + PD from squad Barricade 0.2 ";
                            tempString2 += " + PD from squad Barricade 0.2 ";
                            tempString3 += " + PD from squad Barricade 0.2 ";
                            tempString4 += " + PD from squad Barricade 0.2 ";
    
                        }


                        //DEBUFFS
                        float SumEnergyDrainAdditives; SumEnergyDrainAdditives = SumAdditives; SumAdditives = 0;

                        tempString1 += " ) * ( 1"; tempString2 += " ) * ( 1"; tempString3 += " ) * ( 1"; tempString4 += " ) * ( 1";
                     

                        if (skill1DebuffSum != 0)
                        {
                            SumAdditives += skill1DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                         

                        }

                        if (skill2DebuffSum != 0)
                        {
                            SumAdditives += skill2DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                           
                        }

                        if (skill3DebuffSum != 0)
                        {
                            SumAdditives += skill3DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                           
                        }

                        if (skill4DebuffSum != 0)
                        {
                            SumAdditives += skill4DebuffSum * (1 + skill5SupportSum);
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString1 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString2 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString3 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                            tempString4 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString(); if (skill5SupportSum != 0) tempString4 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + " )";
                           

                        }


                        //  if WE HAVE ET skill46a ET AND checkBoxElementalTechOnTarget.checked 
                        // NO EnergyDrain  ET char
                     //   if (comboBoxSkill4_6.Text.Equals("ET=0.35") && checkBoxElementalTechOnTarget.Checked)
                     //   {
                       //     SumAdditives += 0.35f;
                        //    tempString1 += " + debuffvsAll from Elemental Tech 0.35";
                         //   tempString2 += " + debuffvsAll from Elemental Tech 0.35";
                         //   tempString3 += " + debuffvsAll from Elemental Tech 0.35";
                          //  tempString4 += " + debuffvsAll from Elemental Tech 0.35";
                          //      }

                        if (float.Parse(textBoxSumSquadDebuffsOnTarget.Text) != 0)
                        {
                            SumAdditives += float.Parse(textBoxSumSquadDebuffsOnTarget.Text);
                            tempString1 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString2 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString3 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString4 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                          
                        }
                        if (SumArmorDebuff != 0)
                        {
                            tempString4 += " + debuffvsArmor" + SumArmorDebuff.ToString();
                                       }

                        SumDebuff = SumAdditives;

                        tempString1 += " ) * ( 1 "; tempString2 += " ) * ( 1 "; tempString3 += " ) * ( 1 "; tempString4 += " ) * ( 1 ";
                       

                        /////////////// REMEMBER SumAdditivesSynth

                        tempString1 += " ) = " + (EnergyDrainBaseDam * (1 + SumEnergyDrainAdditives) * (1 + SumDebuff)).ToString();
                        tempString2 += " ) = " + (EnergyDrainBaseDam * (1 + SumEnergyDrainAdditives + SumAdditivesSynth) * (1 + SumDebuff)).ToString();
                    
                      
                        SumAdditives = 0;

                        if (EnergyDrainvsShields1 != 0)
                        {
                            SumAdditives += EnergyDrainvsShields1;
                            tempString3 += " + built in vsShields " + EnergyDrainvsShields1.ToString();
                          
                        }


                        if (EnergyDrainvsShields2 != 0)
                        {
                            SumAdditives += EnergyDrainvsShields2;
                            tempString3 += " + evo 6a vsShields " + EnergyDrainvsShields2.ToString();
                         }

                      
                        if (skill4vsShields != 0)
                        {
                            SumAdditives += skill4vsShields;
                            tempString3 += " + Passive vsShields " + skill4vsShields.ToString();
                             }

                        tempString3 += " ) = " + (EnergyDrainBaseDam * (1 + SumEnergyDrainAdditives) * (1 + SumDebuff) * (1 + SumAdditives)).ToString();
                        


                        //4/8/12 vs armor
                        if (skill4vsArmor != 0)
                        {
                            tempString4 += " + Passive vsArmor " + skill4vsArmor.ToString();
                                                }
                        tempString4 += " ) = " + (EnergyDrainBaseDam * (1 + SumEnergyDrainAdditives) * (1 + SumDebuff + SumArmorDebuff) * (1 + skill4vsArmor)).ToString();

                        // Do Heal impact 
                        tempString5 += " ) ";
                        if (skill5SupportSum != 0) {
                                     tempString5 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + ") ";
                                     if (EnergyDrainRHOT != 0) tempString6 += " * ( 1 + SumSupport " + skill5SupportSum.ToString() + ") ";
                        }
                        tempString5 += " = " + (SumImpactShieldHealAdditives * (1 + skill5SupportSum)).ToString() + "%";
                        // DO HOT
                        // tempString6 = "HOT per tick Percent Shield Heal = CurrentMaxShields * " + (EnergyDrainRHOT / 4).ToString() +  " " ;
                        
                       if (EnergyDrainRHOT !=0 ) tempString6 += " = " + ((EnergyDrainRHOT / 4) * (1 + skill5SupportSum)).ToString() + "%";

                        txtBox.Text += tempString1 + "\r\n";
                        txtBox.Text += tempString2 + "\r\n";
                        txtBox.Text += tempString3 + "\r\n";
                        txtBox.Text += tempString4 + "\r\n\r\n";
                        txtBox.Text += tempString5 + "\r\n";

                        if (EnergyDrainRHOT != 0)
                        {
                            txtBox.Text += tempString6 + "\r\n\r\n";
                            // DO HOT Maximum total

                            txtBox.Text += "HOT duration : " + EnergyDrainRHOTDur.ToString() + " * ( 1";
                            if (skill4PEffectDur != 0) txtBox.Text += " + EffectDuration from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PEffectDur.ToString();
                            if (skill5PEffectDur != 0) txtBox.Text += " + EffectDuration from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5PEffectDur.ToString();
                            txtBox.Text += " ) = " + (EnergyDrainRHOTDur * (1 + skill4PEffectDur + skill5PEffectDur)).ToString() + " seconds   ";

                            txtBox.Text += "Maximum Total HOT Percent Shield = " + (EnergyDrainRHOT  * (1 + skill5SupportSum ) * EnergyDrainRHOTDur * (1 + skill4PEffectDur + skill5PEffectDur )).ToString() + "% \r\n";
                            
                        }

                        break;

                    case "Shield Boost":
// "Shield Boost", "sb description", false, "BaseHeal=125;BaseHOT=50;BaseHOTDur=3;Recharge=15", "1", "Recharge=0.1", "IHeal=0.2;HOT=0.2", "4a", "HOT=0.35", "Recharge=0.35", "IHeal=0.3", "TShields=1;EnableTCheck","HOTDur=1.5",
                    // angara insurgent Salarian operator
                        
                                 // combo boxes HAVE PLAYER CHOICES 
                                                // Also need to get the right playingCharactersArray[SelectedCharIndex].Skill X CooldownMaxDurationPassiveTempEtc
                                                TCooldownMaxDurationPassiveTempEtc = "";
                                                if (playingCharactersArray[SelectedCharIndex].Skill1Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill1CooldownMaxDurationPassiveTempEtc;
                                                if (playingCharactersArray[SelectedCharIndex].Skill2Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill2CooldownMaxDurationPassiveTempEtc;
                                                if (playingCharactersArray[SelectedCharIndex].Skill3Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill3CooldownMaxDurationPassiveTempEtc;

                                                //  txtBox.Text += TCooldownMaxDurationPassiveTempEtc;

                                                float ShieldBoostBaseHeal, ShieldBoostRecharge, ShieldBoostBaseHOT, ShieldBoostBaseHOTDur;
                                                ShieldBoostBaseHeal= ShieldBoostRecharge= ShieldBoostBaseHOT= ShieldBoostBaseHOTDur= 0; 

                                                foreach (string s in TCooldownMaxDurationPassiveTempEtc.Split(';'))
                                                {
                                                    //  "BaseDam="
                                                    if (s.StartsWith("BaseHeal=")) ShieldBoostBaseHeal = float.Parse(s.Substring(9, s.Length - 9));
                                                    if (s.StartsWith("BaseHOT=")) ShieldBoostBaseHOT = float.Parse(s.Substring(8, s.Length - 8));
                                                    if (s.StartsWith("BaseHOTDur=")) ShieldBoostBaseHOTDur = float.Parse(s.Substring(11, s.Length - 11));
                                                    if (s.StartsWith("Recharge=")) ShieldBoostRecharge = float.Parse(s.Substring(9, s.Length - 9));

                        }
                                                //  txtBox.Text += ShieldBoostBaseDam.ToString() + " " + ShieldBoostChargedBaseDam.ToString() + " " + ShieldBoostChainBaseDam.ToString() + " " + ShieldBoostBaseNrChains.ToString() + " " + ShieldBoostRecharge.ToString() + "\r\n";
                                                // duration don't care 
                                                txtBox.Text += "..(see bellow HOT duration math) \r\n\r\n";
                                               
                                                //we will need to Find the right comboboxes by name .. 
                        //                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_1", true);
                        //                        comboBox = controls[0] as ComboBox;
                                                //  txtBox.Text += comboBox.Text + "\r\n";

                       //                        foreach (string s in comboBox.Text.Split(';'))
                       //                         {
                       //                         }

                                                controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_2", true);
                                                comboBox = controls[0] as ComboBox;
                                                //   txtBox.Text += comboBox.Text + "\r\n";

                                                float ShieldBoostRecharge1; ShieldBoostRecharge1 = 0;
                                                foreach (string s in comboBox.Text.Split(';'))
                                                {
                                                    // check for Dam
                                                    if (s.StartsWith("Recharge=")) ShieldBoostRecharge1 += float.Parse(s.Substring(9, s.Length - 9));

                                                }

// "Shield Boost", "sb description", false, "BaseHeal=125;BaseHOT=50;BaseHOTDur=3;Recharge=15", "1", "Recharge=0.1", "IHeal=0.2;HOT=0.2", "4a", "HOT=0.35", "Recharge=0.35", "IHeal=0.3", "TShields=1;EnableTCheck","HOTDur=1.5",


                                                controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_3", true);
                                                comboBox = controls[0] as ComboBox;
                                                //txtBox.Text += comboBox.Text + "\r\n";

                                                float ShieldBoostHeal1, ShieldBoostHOT1; ShieldBoostHeal1 = ShieldBoostHOT1 = 0;
                                                foreach (string s in comboBox.Text.Split(';'))
                                                {
                                                    // check for Dam
                                                    if (s.StartsWith("IHeal=")) ShieldBoostHeal1 += float.Parse(s.Substring(6, s.Length - 6));
                                                    if (s.StartsWith("HOT=")) ShieldBoostHOT1 = float.Parse(s.Substring(4, s.Length - 4));
                                                      }


                                                controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_4", true);
                                                comboBox = controls[0] as ComboBox;
                                                //txtBox.Text += comboBox.Text + "\r\n";

                                                float ShieldBoostHOT2; ShieldBoostHOT2 = 0;
                                                foreach (string s in comboBox.Text.Split(';'))
                                                {
                                                 if (s.StartsWith("HOT=")) ShieldBoostHOT2 = float.Parse(s.Substring(4, s.Length - 4));
                                                 }

                                                //"RSHOT=0.06;RSHOTDur=4;TechPrimer=HSA", "5b","Dam=0.35;vsShields=0.75;vsSynth=0.15", "RShields=0.25;AllyRShields=0.5",
                                                controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_5", true);
                                                comboBox = controls[0] as ComboBox;
                                                //txtBox.Text += comboBox.Text + "\r\n";

                                                float ShieldBoostRecharge2 , ShieldBoostHeal2; ShieldBoostRecharge2 = ShieldBoostHeal2 = 0;
                                                foreach (string s in comboBox.Text.Split(';'))
                                                {
                                                if (s.StartsWith("Recharge=")) ShieldBoostRecharge2 += float.Parse(s.Substring(9, s.Length - 9));
                                                if (s.StartsWith("IHeal=")) ShieldBoostHeal2 += float.Parse(s.Substring(6, s.Length - 6));
                                                  }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_6", true);
                                                comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                                             float ShieldBoostHOTDur; ShieldBoostHOTDur = 0;
                                                foreach (string s in comboBox.Text.Split(';'))
                                                {
                                                    if (s.StartsWith("HOTDur=")) ShieldBoostHOTDur += float.Parse(s.Substring(7, s.Length - 7));
                                                }


                                                /// relevant variables for cooldown
                                                /// BONUS STAT PRS, ShieldBoostRecharge1, ShieldBoostRecharge2 , gearPRS, booster1PRS, booster2PRS, skill1PRS to skill5PRS; + 
                                                /// skill4PRTR
                                                /// skill1PRPSum to skill3PRPSum
                                                /// 


                                                txtBox.Text += "Cooldown FORMULA: (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";
                                                txtBox.Text += "In the interest of developement speed this app ignores the WeaponWeight minigame - as long as you don't go over capacity AS YOU SHOULD! - the related term will be Zero \r\n\r\n";
                                                txtBox.Text += "Cooldown = ( BaseShieldBoostCooldown " + ShieldBoostRecharge + " / ( 1 ";

                                                /// still at cooldown
                                                /// (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";

                                                SumAdditives = 0;
                                                if (float.Parse(comboBoxBonusPRS.Text) != 0) { SumAdditives += float.Parse(comboBoxBonusPRS.Text) / 100; txtBox.Text += " + Bonus 'Power Recharge' Stat" + float.Parse(comboBoxBonusPRS.Text) / 100; }
                                                if (ShieldBoostRecharge1 != 0) { SumAdditives += ShieldBoostRecharge1; txtBox.Text += " + 'ShieldBoost Recharge Evo 2' " + ShieldBoostRecharge1.ToString(); }
                                                if (ShieldBoostRecharge2 != 0) { SumAdditives += ShieldBoostRecharge2; txtBox.Text += " + 'ShieldBoost Recharge Evo 4b' " + ShieldBoostRecharge2.ToString(); }
                                                if (gearPRS != 0) { SumAdditives += gearPRS; txtBox.Text += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearPRS.ToString(); }
                                                if (booster1PRS != 0) { SumAdditives += booster1PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1PRS.ToString(); }
                                                if (booster2PRS != 0) { SumAdditives += booster2PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2PRS.ToString(); }
                                                if (skill1PRS != 0) { SumAdditives += skill1PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PRS.ToString(); }
                                                if (skill2PRS != 0) { SumAdditives += skill2PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PRS.ToString(); }
                                                if (skill3PRS != 0) { SumAdditives += skill3PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PRS.ToString(); }
                                                if (skill4PRS != 0) { SumAdditives += skill4PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PRS.ToString(); }
                                                if (skill5PRS != 0) { SumAdditives += skill5PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5PRS.ToString(); }
                                                txtBox.Text += " ) * ( 1";

                                                 PRP = 0;
                                                // NO CHAR CURRENTLY HAS ShieldBoost AND ANNIHILATION
                                                if (skill1PRPSum != 0) { PRP = skill1PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill1PRPSum.ToString(); }
                                                if (skill2PRPSum != 0) { PRP = skill2PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill2PRPSum.ToString(); }
                                                if (skill3PRPSum != 0) { PRP = skill3PRPSum; txtBox.Text += " + 'Annihilation PRP' )" + skill3PRPSum.ToString(); }

                                                txtBox.Text += " ) = " + ((ShieldBoostRecharge / (1 + SumAdditives)) * (1 + PRP)).ToString() + "\r\n";
                                                //if (skill4PRTR != 0) { txtBox.Text += " Detonation Feedback" + (1-skill4PRTR).ToString() + " multiplier to remaining cooldown amount \r\n"; }
                                                txtBox.Text += "\r\n";


                                                /// relevant variables for damage

                                                // will need to split  base // charged/ chain damage v*4 (health and synthhealth) 

                                                ///////////////
                                                /////////////// let the splittage begin


                                                txtBox.Text += "ShieldBoost Impact heal formula: BaseHeal * (1 + SumImpactHealAdditives + SumSupport)  \r\n";
                                                txtBox.Text += "ShieldBoost HOT tick heal formula: BaseHOT * (1 + SumHOTAdditives + SumSupport)  \r\n";
                                                txtBox.Text += "ShieldBoost benefits from support stat additively \r\n\r\n";

                                                tempString1 = "ShieldBoost Impact heal = BaseHeal " + ShieldBoostBaseHeal.ToString() + " * ( 1";
                                                tempString2 = "ShieldBoost HOT tick heal  = BaseHOT " + ShieldBoostBaseHOT.ToString() + " * ( 1";

                             float SumImpactHealAdditives, SumHOTAdditives;  SumHOTAdditives = SumImpactHealAdditives = 0;
                                  // Will need to accumulate the strings and print at the end since I want to print 9 at once .. 
                                  // need sum of debuffs and MAX(skill ArmorDebuff - cryo beam and turret don't stack) first 

                        //do RShield first since is separate and simple
                     
                                  if (ShieldBoostHeal1 != 0) { SumImpactHealAdditives += ShieldBoostHeal1;  tempString1 += " + ' Evo 3' " + ShieldBoostHeal1.ToString(); }
                                  if (ShieldBoostHeal2 != 0) { SumImpactHealAdditives += ShieldBoostHeal2; tempString1 += " + ' Evo 5b' " + ShieldBoostHeal2.ToString(); }
                                  if (ShieldBoostHOT1 != 0) { SumHOTAdditives += ShieldBoostHOT1; tempString2 += " + ' Evo 3' " + ShieldBoostHOT1.ToString(); }
                                  if (ShieldBoostHOT2 != 0) { SumHOTAdditives += ShieldBoostHOT2; tempString2 += " + ' Evo 4b ' " + ShieldBoostHOT2.ToString(); }
                     
                        if (skill5SupportSum != 0) { tempString1 += " + SumSupport " + skill5SupportSum.ToString() + " ) "; tempString2 += " + SumSupport " + skill5SupportSum.ToString() + " ) "; }
                        tempString1 += " ) = " + ShieldBoostBaseHeal * (1 + SumImpactHealAdditives + skill5SupportSum ) ;
                        tempString2 += " ) = " + ShieldBoostBaseHOT * (1 + SumHOTAdditives + skill5SupportSum);

                        txtBox.Text += tempString1 + "\r\n";
                                  txtBox.Text += tempString2 + "\r\n";
                                 
                                      // DO HOT Maximum total
                                 
                                      txtBox.Text += "HOT duration : " + ShieldBoostBaseHOTDur.ToString() + " * ( 1";
                                      if (skill4PEffectDur != 0) txtBox.Text += " + EffectDuration from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PEffectDur.ToString();
                                      if (skill5PEffectDur != 0) txtBox.Text += " + EffectDuration from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5PEffectDur.ToString();
                                      if (ShieldBoostHOTDur != 0) txtBox.Text += " + EffectDuration from evo 6b " + ShieldBoostHOTDur.ToString();
                                      txtBox.Text += " ) = " + (ShieldBoostBaseHOTDur * (1 + skill4PEffectDur + skill5PEffectDur + ShieldBoostHOTDur)).ToString() + " seconds   ";
                                      txtBox.Text += "Maximum Total HOT amount = " + (ShieldBoostBaseHOT * (1 + SumHOTAdditives + skill5SupportSum ) * ShieldBoostBaseHOTDur * (1 + skill4PEffectDur + skill5PEffectDur + ShieldBoostHOTDur )).ToString() + "\r\n";
                                                break;

                    case "Nova":
// "Nova", "Nova description", false, "BaseDam=420;Recharge=12", "1", "2", "Dam=0.3", "Dam=0.35", "4b", "vsArmor=1", "vsShields=1", "Dam=0.5;BioticPrimer=HSA","6b",
// Human Vanguard, Krogan Vanguard, Krogan Gladiator

                    
   
                        // combo boxes HAVE PLAYER CHOICES 
                        // Also need to get the right playingCharactersArray[SelectedCharIndex].Skill X CooldownMaxDurationPassiveTempEtc
                        TCooldownMaxDurationPassiveTempEtc = "";
                        if (playingCharactersArray[SelectedCharIndex].Skill1Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill1CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill2Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill2CooldownMaxDurationPassiveTempEtc;
                        if (playingCharactersArray[SelectedCharIndex].Skill3Name.Equals(ActiveSkillList[ASkillIndex])) TCooldownMaxDurationPassiveTempEtc = playingCharactersArray[SelectedCharIndex].Skill3CooldownMaxDurationPassiveTempEtc;

                        //  txtBox.Text += TCooldownMaxDurationPassiveTempEtc;

                        float NovaBaseDam, NovaRecharge; NovaBaseDam = NovaRecharge = 0;

                        foreach (string s in TCooldownMaxDurationPassiveTempEtc.Split(';'))
                        {
                            //  "BaseDam="
                            if (s.StartsWith("BaseDam=")) NovaBaseDam = float.Parse(s.Substring(8, s.Length - 8));
                            if (s.StartsWith("Recharge=")) NovaRecharge = float.Parse(s.Substring(9, s.Length - 9));

                        }

 
                        //we will need to Find the right comboboxes by name .. 
                        //                         controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_1", true);
                        //                          comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        //                        float NovavsShields; NovavsShields = 0;
                        //                        foreach (string s in comboBox.Text.Split(';'))
                        //                       {
                        // check for Dam
                        //                           if (s.StartsWith("vsShields=")) NovavsShields1 += float.Parse(s.Substring(10, s.Length - 10));
                        //                            if (s.StartsWith("vsSynth=")) NovavsSynth1 += float.Parse(s.Substring(8, s.Length - 8));

                        //                       }

 //                       controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_2", true);
//                        comboBox = controls[0] as ComboBox;
                        //   txtBox.Text += comboBox.Text + "\r\n";

//                        float NovaRecharge1; NovaRecharge1 = 0;
//                        foreach (string s in comboBox.Text.Split(';'))
                        //{
                            // check for Dam
                          //  if (s.StartsWith("Recharge=")) NovaRecharge1 += float.Parse(s.Substring(9, s.Length - 9));

                        //}


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_3", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float NovaDam1; NovaDam1 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) NovaDam1 += float.Parse(s.Substring(4, s.Length - 4));

                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_4", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float NovaDam2; NovaDam2 = 0;
                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            // check for Dam
                            if (s.StartsWith("Dam=")) NovaDam2 += float.Parse(s.Substring(4, s.Length - 4));

                        }

 // "Nova", "Nova description", false, "BaseDam=420;Recharge=12", "1", "2", "Dam=0.3", "Dam=0.35", "4b", "vsArmor=1", "vsShields=1", "Dam=0.5;BioticPrimer=HSA","6b",

                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_5", true);
                        comboBox = controls[0] as ComboBox;
                        //txtBox.Text += comboBox.Text + "\r\n";

                        float NovavsShields, NovavsArmor; NovavsShields = NovavsArmor = 0;

                        foreach (string s in comboBox.Text.Split(';'))
                        {
                            if (s.StartsWith("vsArmor=")) NovavsArmor += float.Parse(s.Substring(8, s.Length - 8));
                            if (s.StartsWith("vsShields=")) NovavsShields += float.Parse(s.Substring(10, s.Length - 10));
                        }


                        controls = this.Controls.Find("comboBoxSkill" + (ASkillIndex + 1).ToString() + "_6", true);
                        comboBox = controls[0] as ComboBox;
                        //  txtBox.Text += comboBox.Text + "\r\n";

                        float NovaDam3; NovaDam3 = 0; bool NovaShieldPowered; NovaShieldPowered = false;
                        foreach (string s in comboBox.Text.Split(';'))
                        {

                            if (s.StartsWith("Dam=")) NovaDam3 += float.Parse(s.Substring(4, s.Length - 4));
                            if (s.StartsWith("6b")) NovaShieldPowered =true;                        }


                        txtBox.Text += "Duration irrelevant ..no sustained effect \r\n\r\n";


                        if (NovaShieldPowered )
                        {
                            // ShieldPowered                                                                                                  
                            // there is a PERK REDUCING COST
                            // 5a skill5 biotic alacrty H vanguard 
                            if ((playingCharactersArray[SelectedCharIndex].CharacterName.Equals("Human Vanguard")) && (comboBoxSkill5_5.Text.Equals("5a"))) txtBox.Text += "Nova 'Shield Powered' Shield cost = up to 90 % of Current Maximum Shields \r\n\r\n ";
                            else  txtBox.Text += "Nova 'Shield Powered' Shield cost = up to 100 % of Current Maximum Shields \r\n\r\n ";  // shield cost
                        }
                        else
                        {
                            txtBox.Text += "Cooldown FORMULA: (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";
                            txtBox.Text += "In the interest of developement speed this app ignores the WeaponWeight minigame - as long as you don't go over capacity AS YOU SHOULD! - the related term will be Zero \r\n\r\n";
                            txtBox.Text += "Cooldown = ( BaseNovaCooldown " + NovaRecharge + " / ( 1 ";

                            /// relevant variables for cooldown
                            /// BONUS STAT PRS, NovaRecharge1, NovaRecharge2 , gearPRS, booster1PRS, booster2PRS, skill1PRS to skill5PRS; + 
                            /// skill4PRTR
                            /// skill1PRPSum to skill3PRPSum
                            /// 

                            /// still at cooldown
                            /// (BaseCooldown / (1 + SumPRS)) * (1 + Max(0,(SumWeaponsWeight-SumWeightCapacity))*2 + SumAnnihilationPRP )  \r\n";

                            SumAdditives = 0;
                            if (float.Parse(comboBoxBonusPRS.Text) != 0) { SumAdditives += float.Parse(comboBoxBonusPRS.Text) / 100; txtBox.Text += " + Bonus 'Power Recharge' Stat" + float.Parse(comboBoxBonusPRS.Text) / 100; }
                            //if (NovaRecharge1 != 0) { SumAdditives += NovaRecharge1; txtBox.Text += " + 'Nova Recharge Evo 2' " + NovaRecharge1.ToString(); }
                            if (gearPRS != 0) { SumAdditives += gearPRS; txtBox.Text += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearPRS.ToString(); }
                            if (booster1PRS != 0) { SumAdditives += booster1PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1PRS.ToString(); }
                            if (booster2PRS != 0) { SumAdditives += booster2PRS; txtBox.Text += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2PRS.ToString(); }
                            if (skill1PRS != 0) { SumAdditives += skill1PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PRS.ToString(); }
                            if (skill2PRS != 0) { SumAdditives += skill2PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PRS.ToString(); }
                            if (skill3PRS != 0) { SumAdditives += skill3PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PRS.ToString(); }
                            if (skill4PRS != 0) { SumAdditives += skill4PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PRS.ToString(); }
                            if (skill5PRS != 0) { SumAdditives += skill5PRS; txtBox.Text += " + PRS from '" + playingCharactersArray[SelectedCharIndex].Skill5Name + "' skill" + skill5PRS.ToString(); }
                            txtBox.Text += " ) * ( 1";

                            PRP = 0;
                            // NO CHAR CURRENTLY HAS Nova AND ANNIHILATION
                            if (skill1PRPSum != 0) { PRP = skill1PRPSum; txtBox.Text += " + 'Annihilation PRP'" + skill1PRPSum.ToString(); }
                            if (skill2PRPSum != 0) { PRP = skill2PRPSum; txtBox.Text += " + 'Annihilation PRP'" + skill2PRPSum.ToString(); }
                            if (skill3PRPSum != 0) { PRP = skill3PRPSum; txtBox.Text += " + 'Annihilation PRP'" + skill3PRPSum.ToString(); }

                            txtBox.Text += " ) = " + ((NovaRecharge / (1 + SumAdditives)) * (1 + PRP)).ToString() + "\r\n";
                            //if (skill4PRTR != 0) { txtBox.Text += " Detonation Feedback" + (1-skill4PRTR).ToString() + " multiplier to remaining cooldown amount \r\n"; }
                            txtBox.Text += "\r\n\r\n";
                        }


                        /// relevant variables for damage

                        // will need to split  base // charged/ chain damage v*4 (health and synthhealth) 


                        ///////////////
                        /////////////// let the splittage begin


                        txtBox.Text += "Nova Damage formula: BaseDamage * (1 + SumAdditives) *  (1 + SumDebuff + SquadDebuff ) * (1 + SumvsDefense)  \r\n\r\n";
                     
                        txtBox.Text += "some debuffs, ex Pull's expose cannot be activated vs Armor or Shields - I don't account for that here - but you can tick that debuff off in UI if you want numbers without it and RE-Calculate) \r\n\r\n";

                        tempString1 = "Nova Damage vs Health and Armor = Base Impact Damage " + NovaBaseDam.ToString() + " * ( 1";
                        tempString2 = "Nova Damage vs Shields = Base Impact Damage " + NovaBaseDam.ToString() + " * ( 1";
                        tempString3 = "Nova Damage vs Armor = " + NovaBaseDam.ToString() + " * ( 1";
                       

                        // Will need to accumulate the strings and print at the end since I want to print 9 at once .. 
                        // need sum of debuffs and MAX(skill ArmorDebuff - cryo beam and turret don't stack) first 
                        //"Nova", "Nova description", false, "BaseDam=400;Detonator=1;Recharge=10", "1", "Recharge=0.1", "Dam=0.25", "Dam=0.3", "4b", "LWeak=0.4", "vsShields=0.35","Dam=0.3","Cost=0.45",

                        //ADDITIVEs
                        SumAdditives = 0;

                        if (NovaDam1 != 0) { SumAdditives += NovaDam1;
                            tempString1 += " + 'Damage Evo 3' " + NovaDam1.ToString();
                            tempString2 += " + 'Damage Evo 3' " + NovaDam1.ToString();
                            tempString3 += " + 'Damage Evo 3' " + NovaDam1.ToString();
                                        }

                        if (NovaDam2 != 0)
                        {
                            SumAdditives += NovaDam2;
                            tempString1 += " + 'Damage Evo 4a' " + NovaDam2.ToString();
                            tempString2 += " + 'Damage Evo 4a' " + NovaDam2.ToString();
                            tempString3 += " + 'Damage Evo 4a' " + NovaDam2.ToString();
                           }

                        if (NovaDam3 != 0)
                        {
                            SumAdditives += NovaDam3;
                            tempString1 += " + 'Damage Evo 6a' " + NovaDam3.ToString();
                            tempString2 += " + 'Damage Evo 6a' " + NovaDam3.ToString();
                            tempString3 += " + 'Damage Evo 6a' " + NovaDam3.ToString();
                       
                        }


                        if (gearBPD != 0)
                        {
                            SumAdditives += gearBPD;
                            tempString1 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearBPD.ToString();
                            tempString2 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearBPD.ToString();
                            tempString3 += " +  gear '" + comboBoxSelectGear.Text.Split('*')[0] + "' " + gearBPD.ToString();
                                              }


                        if (booster1BPD != 0)
                        {
                            SumAdditives += booster1BPD;
                            tempString1 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1BPD.ToString();
                            tempString2 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1BPD.ToString();
                            tempString3 += " +  booster '" + comboBoxSelectBooster1.Text.Split('*')[0] + "' " + booster1BPD.ToString();
                       

                        }

                        if (booster2BPD != 0)
                        {
                            SumAdditives += booster2BPD;
                            tempString1 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2BPD.ToString();
                            tempString2 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2BPD.ToString();
                            tempString3 += " +  booster '" + comboBoxSelectBooster2.Text.Split('*')[0] + "' " + booster2BPD.ToString();
                      

                        }
                        if (apex1BPD != 0)
                        {
                            SumAdditives += apex1BPD;
                            tempString1 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1BPD.ToString();
                            tempString2 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1BPD.ToString();
                            tempString3 += " +  apex '" + comboBoxSelectApex1.Text.Split('*')[0] + "' " + apex1BPD.ToString();
                      

                        }

                        if (apex2BPD != 0)
                        {
                            SumAdditives += apex2BPD;
                            tempString1 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2BPD.ToString();
                            tempString2 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2BPD.ToString();
                            tempString3 += " +  apex '" + comboBoxSelectApex2.Text.Split('*')[0] + "' " + apex2BPD.ToString();
                       

                        }

                        if (float.Parse(comboBoxSelectVeteranLevel.Text) != 0)
                        {
                            SumAdditives += float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f;
                            tempString1 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString2 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                            tempString3 += " + Veteran PD Bonus " + (float.Parse(comboBoxSelectVeteranLevel.Text) * 0.04f).ToString();
                      
                        }

                        if (skill1PDSum != 0)
                        {
                            SumAdditives += skill1PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1PDSum.ToString();
                         
                        }

                        if (skill2PDSum != 0)
                        {
                            SumAdditives += skill2PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2PDSum.ToString();
                        

                        }
                        if (skill3PDSum != 0)
                        {
                            SumAdditives += skill3PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3PDSum.ToString();
                         
                        }
                        if (skill4PDSum != 0)
                        {
                            SumAdditives += skill4PDSum;
                            tempString1 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString2 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                            tempString3 += " + PD from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4PDSum.ToString();
                           

                        }
                        if (skill4BPD != 0)
                        {
                            SumAdditives += skill4BPD;
                            tempString1 += " + BPD from 'Biotic Expert' evo " + skill4BPD.ToString();
                            tempString2 += " + BPD from 'Biotic Expert' evo " + skill4BPD.ToString();
                            tempString3 += " + BPD from 'Biotic Expert' evo " + skill4BPD.ToString();
                                   }


                        if (checkBoxBarricadePD.Checked)
                        {
                            SumAdditives += 0.2f;
                            tempString1 += " + PD from squad Barricade 0.2 ";
                            tempString2 += " + PD from squad Barricade 0.2 ";
                            tempString3 += " + PD from squad Barricade 0.2 ";
                        

                        }

                       

                        tempString1 += " ) * (1";
                        tempString2 += " ) * (1";
                        tempString3 += " ) * (1";
                        tempString4 += " ) * (1";


                        //DEBUFFS
                        float SumNovaAdditives; SumNovaAdditives = SumAdditives; SumAdditives = 0;

                    

                        if (skill1DebuffSum != 0)
                        {
                            SumAdditives += skill1DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); 
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill1Name + "' skill" + skill1DebuffSum.ToString(); 
                        
                         
                        }
                        if (skill2DebuffSum != 0)
                        {
                            SumAdditives += skill2DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill2Name + "' skill" + skill2DebuffSum.ToString();
                          
                        }
                        if (skill3DebuffSum != 0)
                        {
                            SumAdditives += skill3DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill3Name + "' skill" + skill3DebuffSum.ToString();
                          
                        }
                        if (skill4DebuffSum != 0)
                        {
                            SumAdditives += skill4DebuffSum;
                            tempString1 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                            tempString2 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                            tempString3 += " + debuffvsAll from '" + playingCharactersArray[SelectedCharIndex].Skill4Name + "' skill" + skill4DebuffSum.ToString();
                          
                        }




                        if (float.Parse(textBoxSumSquadDebuffsOnTarget.Text) != 0)
                        {
                            SumAdditives += float.Parse(textBoxSumSquadDebuffsOnTarget.Text);
                            tempString1 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString2 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                            tempString3 += " + debuffvsAll from Squad " + textBoxSumSquadDebuffsOnTarget.Text;
                        
                            
                        }
                 
                        SumDebuff = SumAdditives;
                                           
                 
                        tempString1 += " ) = " + (NovaBaseDam * (1 + SumNovaAdditives) * (1 + SumDebuff)).ToString();
                    

                        if (NovavsShields != 0) tempString2 += ") * (1 + vs Shields evo 5b " + NovavsShields.ToString();
                        if (NovavsArmor != 0) tempString3 += ") * (1 + vs Armor evo 5a " + NovavsArmor.ToString();


                        tempString2 += " ) = " + (NovaBaseDam * (1 + SumNovaAdditives) * (1 + SumDebuff ) * (1 + NovavsShields)).ToString();
                        tempString3 += " ) = " + (NovaBaseDam * (1 + SumNovaAdditives) * (1 + SumDebuff) * (1 + NovavsArmor)).ToString();

                        txtBox.Text += tempString1 + "\r\n";
                        txtBox.Text += tempString2 + "\r\n";
                        txtBox.Text += tempString3 + "\r\n\r\n";


                        break;

                    case "Charge":


                        break;
                }
            }



        }

        private void comboSelectWeapon_SelectedIndexChanged(object sender, EventArgs e)

{
ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;

comboBoxSelectAddOn1.Items.Clear(); comboBoxSelectAddOn2.Items.Clear(); comboBoxSelectAddOn1.Items.Add("none"); comboBoxSelectAddOn2.Items.Add("none");
//  textBoxDebug.Text = selected; 

int WeaponIndex; WeaponIndex = 0;
do
{
    if (myGunArray[WeaponIndex].weaponName.Equals(selected)) break;
    WeaponIndex++;
} while (WeaponIndex < constNrGuns);


      for (int i = 0; i < constNrAddOns; i++)
       {

    if (myGunArray[WeaponIndex].weaponClass == myAddOnArray[i].AddOnWeaponClass) {
        comboBoxSelectAddOn1.Items.Add(myAddOnArray[i].AddOnName + "* " + myAddOnArray[i].AddOnEffects);
        comboBoxSelectAddOn2.Items.Add(myAddOnArray[i].AddOnName + "* " + myAddOnArray[i].AddOnEffects);
          }
  }

//  textBoxDebug.Text = WeaponIndex.ToString();
comboBoxSelectAddOn1.SelectedIndex = 0;
comboBoxSelectAddOn2.SelectedIndex = 0;
            // clear overwrite checkbox and values
            checkBoxOverwrite.Checked = false;
            textBoxOverwriteBaseWeaponDamage.Text = myGunArray[WeaponIndex].BWD.ToString()  ;
            textBoxOverwriteBaseWeaponMAGSize.Text = myGunArray[WeaponIndex].magazineSize.ToString();
        }

private void textBoxEnemyWeak1_TextChanged(object sender, EventArgs e)
{

}

private void textBoxEnemyHealth_TextChanged(object sender, EventArgs e)
{

}

private void comboBoxSelectBooster1_SelectedIndexChanged(object sender, EventArgs e)
{
// when you change (if not none and other not nore) set the other to none if same add-on group
ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
if (!selected.Equals("none") && (!comboBoxSelectBooster2.Text.Equals("none")))
{
    int BoosterIndex1; BoosterIndex1 = 0;
    do
    {
        if (myBoosterArray[BoosterIndex1].BoosterName.Equals(comboBoxSelectBooster2.Text.Split('*')[0])) break;
        BoosterIndex1++;
    } while (BoosterIndex1 < constNrBoosters);

    int BoosterIndex2; BoosterIndex2 = 0;
    do
    {
        if (myBoosterArray[BoosterIndex2].BoosterName.Equals(selected.Split('*')[0])) break;
        BoosterIndex2++;
    } while (BoosterIndex2 < constNrBoosters);

    if (myBoosterArray[BoosterIndex1].BoosterGroup == myBoosterArray[BoosterIndex2].BoosterGroup) comboBoxSelectBooster2.SelectedIndex = 0;
}

}

private void comboBoxSelectBooster2_SelectedIndexChanged(object sender, EventArgs e)
{
// when you change (if not none and other not nore) set the other to none if same add-on group
ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
if (!selected.Equals("none") && (!comboBoxSelectBooster1.Text.Equals("none")))
{
    int BoosterIndex1; BoosterIndex1 = 0;
    do
    {
        if (myBoosterArray[BoosterIndex1].BoosterName.Equals(comboBoxSelectBooster1.Text.Split('*')[0])) break;
        BoosterIndex1++;
    } while (BoosterIndex1 < constNrBoosters);

    int BoosterIndex2; BoosterIndex2 = 0;
    do
    {
        if (myBoosterArray[BoosterIndex2].BoosterName.Equals(selected.Split('*')[0])) break;
        BoosterIndex2++;
    } while (BoosterIndex2 < constNrBoosters);

    if (myBoosterArray[BoosterIndex1].BoosterGroup == myBoosterArray[BoosterIndex2].BoosterGroup) comboBoxSelectBooster1.SelectedIndex = 0;
}
}

        private void comboBoxSelectApex1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (!selected.Equals("none") && (!comboBoxSelectApex2.Text.Equals("none"))) if (comboBoxSelectApex2.Text.Equals(selected)) comboBoxSelectApex2.SelectedIndex = 0;
            
        }

        private void comboBoxSelectApex2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
            if (!selected.Equals("none") && (!comboBoxSelectApex1.Text.Equals("none"))) if (comboBoxSelectApex1.Text.Equals(selected)) comboBoxSelectApex1.SelectedIndex = 0;
        }

        private void comboBoxSkill3_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
          if (selected.Contains("EnableTCheck"))checkBoxSkill3_1.Enabled = true; else { checkBoxSkill3_1.Enabled = false; checkBoxSkill3_1.Checked = false; }

        }

        private void comboBoxSkill2_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
          if (selected.Contains("EnableTCheck"))checkBoxSkill2_1.Enabled = true; else { checkBoxSkill2_1.Enabled = false; checkBoxSkill2_1.Checked = false; }

        }

        private void comboBoxSkill1_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;
          if (selected.Contains("EnableTCheck"))checkBoxSkill1_1.Enabled = true; else { checkBoxSkill1_1.Enabled = false; checkBoxSkill1_1.Checked = false; }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSelectDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender; int selectedIdx = (int)comboBox.SelectedIndex;


            comboBoxSelectEnemy.Items.Clear();

            for (int i = 0; i < constNrEnemies; i++)
             {
            if (myEnemyStatsArray[i].difficulty-1 == selectedIdx) comboBoxSelectEnemy.Items.Add(myEnemyStatsArray[i].enemyName);
            
              }
              comboBoxSelectEnemy.SelectedIndex = 0;
        }

        private void comboBoxSelectEnemy_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;

            //  iterate enemy list until enemyname = selected and enemydiff-1 == selectdiff.selected index
            int EnemyIndex; EnemyIndex = 0;

            do
            {
                if ((myEnemyStatsArray[EnemyIndex].enemyName.Equals(selected)) && (myEnemyStatsArray[EnemyIndex].difficulty - 1 == comboBoxSelectDifficulty.SelectedIndex )) break;
               EnemyIndex++;
            } while (EnemyIndex  < constNrEnemies);

            textBoxEnemyShields.Text = myEnemyStatsArray[EnemyIndex].maxShields.ToString() ;
            textBoxEnemyArmor.Text = myEnemyStatsArray[EnemyIndex].maxArmor.ToString();
            textBoxEnemyHealth.Text = myEnemyStatsArray[EnemyIndex].maxHealth.ToString();
            textBoxEnemyWeak1.Text= myEnemyStatsArray[EnemyIndex].baseWeak1.ToString();
            textBoxEnemyWeak2.Text = myEnemyStatsArray[EnemyIndex].baseWeak2.ToString();

        }

        private void textBoxSumSquadDebuffsOnTarget_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender; string selected = (string)textBox.Text;
            float tempcheck;
            if (!float.TryParse(selected, out tempcheck)) textBoxSumSquadDebuffsOnTarget.Text = "0"; else { if (tempcheck > 1) tempcheck = 1; if (tempcheck < 0) tempcheck = 0; textBoxSumSquadDebuffsOnTarget.Text = tempcheck.ToString(); }
        }

        private void labelSumSquadDebuffsOnTarget_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOverwriteBaseWeaponDamage_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender; string selected = (string)textBox.Text;
            int tempcheck;

       

            if (!int.TryParse(selected, out tempcheck)) { textBoxOverwriteBaseWeaponDamage.Text = myGunArray[comboBoxSelectWeapon.SelectedIndex].BWD.ToString(); }

         
            else
            {
                float ftempcheck;
                ftempcheck = (float)tempcheck; // convert from int to float so we can compare
                if (ftempcheck > 1.25f * myGunArray[comboBoxSelectWeapon.SelectedIndex].BWD) ftempcheck = 1.25f * myGunArray[comboBoxSelectWeapon.SelectedIndex].BWD - 0.02f;
                if (ftempcheck < 0.75f * myGunArray[comboBoxSelectWeapon.SelectedIndex].BWD) ftempcheck = 0.75f * myGunArray[comboBoxSelectWeapon.SelectedIndex].BWD + 0.02f;
                textBoxOverwriteBaseWeaponDamage.Text = ((int)ftempcheck).ToString(); }
            }

        private void textBoxOverwriteBaseWeaponMAGSize_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender; string selected = (string)textBox.Text;
            int tempcheck;
       

            if (!int.TryParse(selected, out tempcheck)) { textBoxOverwriteBaseWeaponMAGSize.Text = myGunArray[comboBoxSelectWeapon.SelectedIndex].magazineSize.ToString(); }


            else
            {
               
                if (tempcheck > (int) (1.25f * myGunArray[comboBoxSelectWeapon.SelectedIndex].magazineSize)) tempcheck = (int)(1.25f * myGunArray[comboBoxSelectWeapon.SelectedIndex].magazineSize) ;
                if (tempcheck < (int)(0.75f * myGunArray[comboBoxSelectWeapon.SelectedIndex].magazineSize)) tempcheck = (int)(0.75f * myGunArray[comboBoxSelectWeapon.SelectedIndex].magazineSize) ;
                if (tempcheck == 0) tempcheck = 1;
                textBoxOverwriteBaseWeaponMAGSize.Text = ((int)tempcheck).ToString();
            }
        }

        private void buttonLoadBuild_Click(object sender, EventArgs e)
        {
            /*
             * 
 WILL NOT CHECK RESTRICTIONS (weapon- addons // toogleable skill or perk //  WILL LOAD WHAT THE STRING SAYS (texboxes should trigger validation ) )

cha=int 0..ConstNr ;|| comboBoxSelectChars  // char class 
vet=int 0..10;|| comboBoxSelectVeteranLevel         //veteran
bsH=int 0..10; || comboBoxBonusHealth  // bonus health bonus
bsS=int 0..10; || comboBoxBonusShields // bonus shields bonus
bPR=int 0..10; || comboBoxBonusPRS // bonus Power Recharge Speed
wpn=int 0..ConstNr || comboBoxSelectWeapon // selected weapon
gea=int 0..ConstNr || comboBoxSelectGear // selected gear
ad1=int 0..ConstNr || comboBoxSelectAddOn1
ad2=int 0..ConstNr || comboBoxSelectAddOn2
bt1=int 0..ConstNr || comboBoxSelectBooster1
bt2=int 0..ConstNr || comboBoxSelectBooster2
ap1=int 0..ConstNr || comboBoxSelectApex1
ap2=int 0..ConstNr || comboBoxSelectApex2

REPLACE BELLOW WITH String
cSBWD=0 or 1    // set false if ==1 set true;  checkBoxShieldBoostWD
cBWD=0 or 1    // set false if ==1 set true;  checkBoxBarricadeWD
cBPD=0 or 1    // set false if ==1 set true; checkBoxBarricadePD
cET=0 or 1    // set false if ==1 set true;  checkBoxElementalTechOnTarget
cWO=0 or 1  // checkBoxOverwrite
cbl=01010;

bwd=int     // textBoxOverwriteBaseWeaponDamage
bms=int     // textBoxOverwriteBaseWeaponMAGSize
sdt=float //textBoxSumSquadDebuffsOnTarget
dif=int   // comboBoxSelectDifficulty
ene=int  // comboBoxSelectEnemy 
cbs=string 01010; // checkBoxOnOffSkill1 to checkBoxOnOffSkill5

s1p=string 002107 // comboBoxSkill1_1 to 1_6  + 5 * checkBoxSkill1_1 to 1_6  (0=00  1=10 2=20  6=11 7=21 5=01 is illegal)
s2p=string 002102
s3p=string 002102
s4p=string 002102
s5p=string 002102

HIT Recalculate (which should hit GENERATE BUILD LINK AT THE END)
             * 
             * **/
                        initializeCombos(); // VALID OR NOT WE REINITILIZE COMBOS AND RESET CONTENT

            int tempIntIdx; tempIntIdx = 0; float tempfloatIdx; tempfloatIdx = 0;
            string tempSting; tempSting = "";

            foreach (string s in textBoxLoadBuild.Text.Split(';'))
            {
                if (s.StartsWith("cha=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= constNumberChars)) comboBoxSelectChars.SelectedIndex = tempIntIdx;
                if (s.StartsWith("vet=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= 10)) comboBoxSelectVeteranLevel.SelectedIndex = tempIntIdx;
                if (s.StartsWith("bsH=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= 10)) comboBoxBonusHealth.SelectedIndex = tempIntIdx;
                if (s.StartsWith("bsS=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= 10)) comboBoxBonusShields.SelectedIndex = tempIntIdx;
                if (s.StartsWith("bPR=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= 10)) comboBoxBonusPRS.SelectedIndex = tempIntIdx;
                if (s.StartsWith("wpn=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= constNrGuns)) comboBoxSelectWeapon.SelectedIndex = tempIntIdx;
                if (s.StartsWith("gea=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= constNrGear)) comboBoxSelectGear.SelectedIndex = tempIntIdx;
                //dirty very low on checks
                if (s.StartsWith("ad1=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= comboBoxSelectAddOn1.Items.Count)) comboBoxSelectAddOn1.SelectedIndex = tempIntIdx;
                if (s.StartsWith("ad2=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= comboBoxSelectAddOn2.Items.Count)) comboBoxSelectAddOn2.SelectedIndex = tempIntIdx;
                if (s.StartsWith("bt1=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= constNrBoosters)) comboBoxSelectBooster1.SelectedIndex = tempIntIdx;
                if (s.StartsWith("bt2=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= constNrBoosters)) comboBoxSelectBooster2.SelectedIndex = tempIntIdx;
                if (s.StartsWith("ap1=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= constNrAPEXMods)) comboBoxSelectApex1.SelectedIndex = tempIntIdx;
                if (s.StartsWith("ap2=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= constNrAPEXMods)) comboBoxSelectApex2.SelectedIndex = tempIntIdx;
                if (s.StartsWith("cbl=")) if (s.Substring(4, s.Length - 4).Length == 5)
                    {
                        tempSting = s.Substring(4, s.Length - 4);
                      //  MessageBox.Show(s.Substring(4, s.Length - 4));
                        if (tempSting[0] == '1') checkBoxShieldBoostWD.Checked = true; else checkBoxShieldBoostWD.Checked = false;
                        if (tempSting[1] == '1') checkBoxBarricadeWD.Checked = true; else checkBoxBarricadeWD.Checked = false;
                        if (tempSting[2] == '1') checkBoxBarricadePD.Checked = true; else checkBoxBarricadePD.Checked = false;
                        if (tempSting[3] == '1') checkBoxElementalTechOnTarget.Checked = true; else checkBoxElementalTechOnTarget.Checked = false;
                        if (tempSting[4] == '1') checkBoxOverwrite.Checked = true; else checkBoxOverwrite.Checked = false;
                        
                    }


                // bwd=int     // textBoxOverwriteBaseWeaponDamage
                if (s.StartsWith("bwd=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if (tempIntIdx >= 0)
                        {
                            textBoxOverwriteBaseWeaponDamage.Text = s.Substring(4, s.Length - 4);
                            // set focus  // lose focus to trigger validation
                            this.ActiveControl = textBoxOverwriteBaseWeaponDamage;
                            this.ActiveControl = buttonLoadBuild;
                        }



                //bms=int     // textBoxOverwriteBaseWeaponMAGSize
                if (s.StartsWith("bms=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if (tempIntIdx >= 0)
                        {
                            textBoxOverwriteBaseWeaponMAGSize.Text = s.Substring(4, s.Length - 4);
                            // set focus  // lose focus to trigger validation
                            this.ActiveControl = textBoxOverwriteBaseWeaponMAGSize;
                            this.ActiveControl = buttonLoadBuild;
                        }

                // sdt = float //textBoxSumSquadDebuffsOnTarget
                if (s.StartsWith("sdt=")) if (float.TryParse(s.Substring(4, s.Length - 4), out tempfloatIdx)) if ((tempfloatIdx >= 0) && (tempfloatIdx <=1) )
                        {
                            textBoxSumSquadDebuffsOnTarget.Text = s.Substring(4, s.Length - 4);
                            // set focus  // lose focus to trigger validation
                            this.ActiveControl = textBoxSumSquadDebuffsOnTarget;
                            this.ActiveControl = buttonLoadBuild;
                        }

                //  dif = int   // comboBoxSelectDifficulty
                if (s.StartsWith("dif=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= 3)) comboBoxSelectDifficulty.SelectedIndex = tempIntIdx;

                //  ene = int  // comboBoxSelectEnemy 
                if (s.StartsWith("ene=")) if (int.TryParse(s.Substring(4, s.Length - 4), out tempIntIdx)) if ((tempIntIdx >= 0) && (tempIntIdx <= comboBoxSelectEnemy.Items.Count)) comboBoxSelectEnemy.SelectedIndex = tempIntIdx;

                //cbs = string 01010; // checkBoxOnOffSkill1 to checkBoxOnOffSkill5
                if (s.StartsWith("cbs=")) if (s.Substring(4, s.Length - 4).Length == 5)
                    {
                        tempSting = s.Substring(4, s.Length - 4);
                        if (tempSting[0] == '1') checkBoxOnOffSkill1.Checked = true; else checkBoxOnOffSkill1.Checked = false;
                        if (tempSting[1] == '1') checkBoxOnOffSkill2.Checked = true; else checkBoxOnOffSkill2.Checked = false;
                        if (tempSting[2] == '1') checkBoxOnOffSkill3.Checked = true; else checkBoxOnOffSkill3.Checked = false;
                        if (tempSting[3] == '1') checkBoxOnOffSkill4.Checked = true; else checkBoxOnOffSkill4.Checked = false;
                        if (tempSting[4] == '1') checkBoxOnOffSkill5.Checked = true; else checkBoxOnOffSkill5.Checked = false;
                        //  MessageBox.Show(s.Substring(4, s.Length - 4));
                    }

                if (s.StartsWith("s1p=")) if (s.Substring(4, s.Length - 4).Length == 6)
                    {
                        //  MessageBox.Show(s.Substring(4, s.Length - 4));
                        tempSting = s.Substring(4, s.Length - 4);
                        switch (tempSting[5])
                        {
                            case '0':
                                //set skill 1_6 to "none"
                                //  MessageBox.Show("none");
                                comboBoxSkill1_6.Text = "none";
                                checkBoxSkill1_6.Checked = false;
                                break;
                            case '1':
                                // set perk 6a in combobox1_6
                                comboBoxSkill1_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo6a;
                                checkBoxSkill1_6.Checked = false;
                                break;
                            case '2':
                                comboBoxSkill1_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo6b;
                                checkBoxSkill1_6.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill1_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo6a;
                                checkBoxSkill1_6.Checked = true;
                                break;
                            case '7':
                                // MessageBox.Show(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo6b);
                                comboBoxSkill1_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo6b;
                                checkBoxSkill1_6.Checked = true;
                                break;
                        }
                        switch (tempSting[4])
                        {
                            case '0':
                                comboBoxSkill1_5.Text = "none";
                                checkBoxSkill1_5.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill1_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo5a;
                                checkBoxSkill1_5.Checked = false;
                                break;
                            case '2':
                                comboBoxSkill1_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo5b;
                                checkBoxSkill1_5.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill1_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo5a;
                                checkBoxSkill1_5.Checked = true;
                                break;
                            case '7':
                                comboBoxSkill1_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo5b;
                                checkBoxSkill1_5.Checked = true;
                                break;
                        }
                        switch (tempSting[3])
                        {
                            case '0':
                                comboBoxSkill1_4.Text = "none";
                                checkBoxSkill1_4.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill1_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo4a;
                                checkBoxSkill1_4.Checked = false;
                                break;
                            case '2':
                                comboBoxSkill1_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo4b;
                                checkBoxSkill1_4.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill1_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo4a;
                                checkBoxSkill1_4.Checked = true;
                                break;
                            case '7':
                                comboBoxSkill1_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo4b;
                                checkBoxSkill1_4.Checked = true;
                                break;
                        }
                        switch (tempSting[2])
                        {
                            case '0':
                                comboBoxSkill1_3.Text = "none";
                                checkBoxSkill1_3.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill1_3.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo3;
                                checkBoxSkill1_3.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill1_3.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo3;
                                checkBoxSkill1_3.Checked = true;
                                break;
                        }
                        switch (tempSting[1])
                        {
                            case '0':
                                comboBoxSkill1_2.Text = "none";
                                checkBoxSkill1_2.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill1_2.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo2;
                                checkBoxSkill1_2.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill1_2.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo2;
                                checkBoxSkill1_2.Checked = true;
                                break;
                        }
                        switch (tempSting[0])
                        {
                            case '1':
                                comboBoxSkill1_1.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo1;
                                checkBoxSkill1_1.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill1_1.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo1;
                                checkBoxSkill1_1.Checked = true;
                                break;

                        }
                    }
                if (s.StartsWith("s2p=")) if (s.Substring(4, s.Length - 4).Length == 6)
                    {
                        //  MessageBox.Show(s.Substring(4, s.Length - 4));
                        tempSting = s.Substring(4, s.Length - 4);
                        switch (tempSting[5])
                        {
                            case '0':
                                comboBoxSkill2_6.Text = "none";
                                checkBoxSkill2_6.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill2_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo6a;
                                checkBoxSkill2_6.Checked = false;
                                break;
                            case '2':
                                comboBoxSkill2_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo6b;
                                checkBoxSkill2_6.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill2_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo6a;
                                checkBoxSkill2_6.Checked = true;
                                break;
                            case '7':
                                comboBoxSkill2_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo6b;
                                checkBoxSkill2_6.Checked = true;
                                break;
                        }
                        switch (tempSting[4])
                        {
                            case '0':
                                comboBoxSkill2_5.Text = "none";
                                checkBoxSkill2_5.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill2_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo5a;
                                checkBoxSkill2_5.Checked = false;
                                break;
                            case '2':
                                comboBoxSkill2_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo5b;
                                checkBoxSkill2_5.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill2_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo5a;
                                checkBoxSkill2_5.Checked = true;
                                break;
                            case '7':
                                comboBoxSkill2_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo5b;
                                checkBoxSkill2_5.Checked = true;
                                break;
                        }
                        switch (tempSting[3])
                        {
                            case '0':
                                comboBoxSkill2_4.Text = "none";
                                checkBoxSkill2_4.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill2_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo4a;
                                checkBoxSkill2_4.Checked = false;
                                break;
                            case '2':
                                comboBoxSkill2_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo4b;
                                checkBoxSkill2_4.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill2_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo4a;
                                checkBoxSkill2_4.Checked = true;
                                break;
                            case '7':
                                comboBoxSkill2_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo4b;
                                checkBoxSkill2_4.Checked = true;
                                break;
                        }
                        switch (tempSting[2])
                        {
                            case '0':
                                comboBoxSkill2_3.Text = "none";
                                checkBoxSkill2_3.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill2_3.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo3;
                                checkBoxSkill2_3.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill2_3.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo3;
                                checkBoxSkill2_3.Checked = true;
                                break;
                        }
                        switch (tempSting[1])
                        {
                            case '0':
                                comboBoxSkill2_2.Text = "none";
                                checkBoxSkill2_2.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill2_2.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo2;
                                checkBoxSkill2_2.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill2_2.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo2;
                                checkBoxSkill2_2.Checked = true;
                                break;
                        }
                        switch (tempSting[0])
                        {
                            case '1':
                                comboBoxSkill2_1.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo1;
                                checkBoxSkill2_1.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill2_1.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo1;
                                checkBoxSkill2_1.Checked = true;
                                break;

                        }
                    }
                if (s.StartsWith("s3p=")) if (s.Substring(4, s.Length - 4).Length == 6)
                    {
                        //  MessageBox.Show(s.Substring(4, s.Length - 4));
                        tempSting = s.Substring(4, s.Length - 4);
                        switch (tempSting[5])
                        {
                            case '0':
                                comboBoxSkill3_6.Text = "none";
                                checkBoxSkill3_6.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill3_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo6a;
                                checkBoxSkill3_6.Checked = false;
                                break;
                            case '2':
                                comboBoxSkill3_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo6b;
                                checkBoxSkill3_6.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill3_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo6a;
                                checkBoxSkill3_6.Checked = true;
                                break;
                            case '7':
                                comboBoxSkill3_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo6b;
                                checkBoxSkill3_6.Checked = true;
                                break;
                        }
                        switch (tempSting[4])
                        {
                            case '0':
                                comboBoxSkill3_5.Text = "none";
                                checkBoxSkill3_5.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill3_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo5a;
                                checkBoxSkill3_5.Checked = false;
                                break;
                            case '2':
                                comboBoxSkill3_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo5b;
                                checkBoxSkill3_5.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill3_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo5a;
                                checkBoxSkill3_5.Checked = true;
                                break;
                            case '7':
                                comboBoxSkill3_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo5b;
                                checkBoxSkill3_5.Checked = true;
                                break;
                        }
                        switch (tempSting[3])
                        {
                            case '0':
                                comboBoxSkill3_4.Text = "none";
                                checkBoxSkill3_4.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill3_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo4a;
                                checkBoxSkill3_4.Checked = false;
                                break;
                            case '2':
                                comboBoxSkill3_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo4b;
                                checkBoxSkill3_4.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill3_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo4a;
                                checkBoxSkill3_4.Checked = true;
                                break;
                            case '7':
                                comboBoxSkill3_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo4b;
                                checkBoxSkill3_4.Checked = true;
                                break;
                        }
                        switch (tempSting[2])
                        {
                            case '0':
                                comboBoxSkill3_3.Text = "none";
                                checkBoxSkill3_3.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill3_3.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo3;
                                checkBoxSkill3_3.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill3_3.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo3;
                                checkBoxSkill3_3.Checked = true;
                                break;
                        }
                        switch (tempSting[1])
                        {
                            case '0':
                                comboBoxSkill3_2.Text = "none";
                                checkBoxSkill3_2.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill3_2.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo2;
                                checkBoxSkill3_2.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill3_2.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo2;
                                checkBoxSkill3_2.Checked = true;
                                break;
                        }
                        switch (tempSting[0])
                        {
                            case '1':
                                comboBoxSkill3_1.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo1;
                                checkBoxSkill3_1.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill3_1.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo1;
                                checkBoxSkill3_1.Checked = true;
                                break;

                        }
                    }
                if (s.StartsWith("s4p=")) if (s.Substring(4, s.Length - 4).Length == 6)
                    {
                        //  MessageBox.Show(s.Substring(4, s.Length - 4));
                        tempSting = s.Substring(4, s.Length - 4);
                        switch (tempSting[5])
                        {
                            case '0':
                                comboBoxSkill4_6.Text = "none";
                                checkBoxSkill4_6.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill4_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo6a;
                                checkBoxSkill4_6.Checked = false;
                                break;
                            case '2':
                                comboBoxSkill4_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo6b;
                                checkBoxSkill4_6.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill4_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo6a;
                                checkBoxSkill4_6.Checked = true;
                                break;
                            case '7':
                                comboBoxSkill4_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo6b;
                                checkBoxSkill4_6.Checked = true;
                                break;
                        }
                        switch (tempSting[4])
                        {
                            case '0':
                                comboBoxSkill4_5.Text = "none";
                                checkBoxSkill4_5.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill4_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo5a;
                                checkBoxSkill4_5.Checked = false;
                                break;
                            case '2':
                                comboBoxSkill4_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo5b;
                                checkBoxSkill4_5.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill4_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo5a;
                                checkBoxSkill4_5.Checked = true;
                                break;
                            case '7':
                                comboBoxSkill4_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo5b;
                                checkBoxSkill4_5.Checked = true;
                                break;
                        }
                        switch (tempSting[3])
                        {
                            case '0':
                                comboBoxSkill4_4.Text = "none";
                                checkBoxSkill4_4.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill4_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo4a;
                                checkBoxSkill4_4.Checked = false;
                                break;
                            case '2':
                                comboBoxSkill4_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo4b;
                                checkBoxSkill4_4.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill4_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo4a;
                                checkBoxSkill4_4.Checked = true;
                                break;
                            case '7':
                                comboBoxSkill4_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo4b;
                                checkBoxSkill4_4.Checked = true;
                                break;
                        }
                        switch (tempSting[2])
                        {
                            case '0':
                                comboBoxSkill4_3.Text = "none";
                                checkBoxSkill4_3.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill4_3.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo3;
                                checkBoxSkill4_3.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill4_3.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo3;
                                checkBoxSkill4_3.Checked = true;
                                break;
                        }
                        switch (tempSting[1])
                        {
                            case '0':
                                comboBoxSkill4_2.Text = "none";
                                checkBoxSkill4_2.Checked = false;
                                break;
                            case '1':
                                comboBoxSkill4_2.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo2;
                                checkBoxSkill4_2.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill4_2.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo2;
                                checkBoxSkill4_2.Checked = true;
                                break;
                        }
                        switch (tempSting[0])
                        {
                            case '1':
                                comboBoxSkill4_1.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo1;
                                checkBoxSkill4_1.Checked = false;
                                break;
                            case '6':
                                comboBoxSkill4_1.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo1;
                                checkBoxSkill4_1.Checked = true;
                                break;

                        }
                    }
                                                if (s.StartsWith("s5p=")) if (s.Substring(4, s.Length - 4).Length == 6)
                                                    {
                                                        //  MessageBox.Show(s.Substring(4, s.Length - 4));
                                                        tempSting = s.Substring(4, s.Length - 4);
                                                        switch (tempSting[5])
                                                        {
                                                            case '0':
                                                                comboBoxSkill5_6.Text = "none";
                                                                checkBoxSkill5_6.Checked = false;
                                                                break;
                                                            case '1':
                                                                comboBoxSkill5_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo6a;
                                                                checkBoxSkill5_6.Checked = false;
                                                                break;
                                                            case '2':
                                                                comboBoxSkill5_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo6b;
                                                                checkBoxSkill5_6.Checked = false;
                                                                break;
                                                            case '6':
                                                                comboBoxSkill5_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo6a;
                                                                checkBoxSkill5_6.Checked = true;
                                                                break;
                                                            case '7':
                                                                comboBoxSkill5_6.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo6b;
                                                                checkBoxSkill5_6.Checked = true;
                                                                break;
                                                        }
                                                        switch (tempSting[4])
                                                        {
                                                            case '0':
                                                                comboBoxSkill5_5.Text = "none";
                                                                checkBoxSkill5_5.Checked = false;
                                                                break;
                                                            case '1':
                                                                comboBoxSkill5_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo5a;
                                                                checkBoxSkill5_5.Checked = false;
                                                                break;
                                                            case '2':
                                                                comboBoxSkill5_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo5b;
                                                                checkBoxSkill5_5.Checked = false;
                                                                break;
                                                            case '6':
                                                                comboBoxSkill5_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo5a;
                                                                checkBoxSkill5_5.Checked = true;
                                                                break;
                                                            case '7':
                                                                comboBoxSkill5_5.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo5b;
                                                                checkBoxSkill5_5.Checked = true;
                                                                break;
                                                        }
                                                        switch (tempSting[3])
                                                        {
                                                            case '0':
                                                                comboBoxSkill5_4.Text = "none";
                                                                checkBoxSkill5_4.Checked = false;
                                                                break;
                                                            case '1':
                                                                comboBoxSkill5_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo4a;
                                                                checkBoxSkill5_4.Checked = false;
                                                                break;
                                                            case '2':
                                                                comboBoxSkill5_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo4b;
                                                                checkBoxSkill5_4.Checked = false;
                                                                break;
                                                            case '6':
                                                                comboBoxSkill5_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo4a;
                                                                checkBoxSkill5_4.Checked = true;
                                                                break;
                                                            case '7':
                                                                comboBoxSkill5_4.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo4b;
                                                                checkBoxSkill5_4.Checked = true;
                                                                break;
                                                        }
                                                        switch (tempSting[2])
                                                        {
                                                            case '0':
                                                                comboBoxSkill5_3.Text = "none";
                                                                checkBoxSkill5_3.Checked = false;
                                                                break;
                                                            case '1':
                                                                comboBoxSkill5_3.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo3;
                                                                checkBoxSkill5_3.Checked = false;
                                                                break;
                                                            case '6':
                                                                comboBoxSkill5_3.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo3;
                                                                checkBoxSkill5_3.Checked = true;
                                                                break;
                                                        }
                                                        switch (tempSting[1])
                                                        {
                                                            case '0':
                                                                comboBoxSkill5_2.Text = "none";
                                                                checkBoxSkill5_2.Checked = false;
                                                                break;
                                                            case '1':
                                                                comboBoxSkill5_2.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo2;
                                                                checkBoxSkill5_2.Checked = false;
                                                                break;
                                                            case '6':
                                                                comboBoxSkill5_2.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo2;
                                                                checkBoxSkill5_2.Checked = true;
                                                                break;
                                                        }
                                                        switch (tempSting[0])
                                                        {
                                                            case '1':
                                                                comboBoxSkill5_1.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo1;
                                                                checkBoxSkill5_1.Checked = false;
                                                                break;
                                                            case '6':
                                                                comboBoxSkill5_1.Text = playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo1;
                                                                checkBoxSkill5_1.Checked = true;
                                                                break;

                                                        }
                                                        //s1p = string 002107 // comboBoxSkill1_1 to 1_6  + 5 * checkBoxSkill1_1 to 1_6  (0=00  1=10 2=20  6=11 7=21 5=01 is illegal)
                                                        //s2p = string 002102
                                                        //s3p = string 002102
                                                        //s4p = string 002102
                                                        //s5p = string 002102

                                                    }
            }
            // DO RECALCULATE
            buttonReCalculate.PerformClick();
        }

        private void textBoxLoadBuild_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuildLink_Click(object sender, EventArgs e)
        {

            //  cbl = 00001; bwd = 4; bms = 234; sdt = 0.3; dif = 2; ene = 4; cbs = 00000; s1p = 166700; s2p = 166700; s3p = 166700; s4p = 166700; s5p = 166700;
            textBoxExportBuild.Text = "";
            textBoxExportBuild.Text = ";cha=" + comboBoxSelectChars.SelectedIndex + ";";
            textBoxExportBuild.Text += "vet=" + comboBoxSelectVeteranLevel.SelectedIndex + ";";
            textBoxExportBuild.Text += "bsH=" + comboBoxBonusHealth.SelectedIndex + ";";
            textBoxExportBuild.Text += "bsS=" + comboBoxBonusShields.SelectedIndex + ";";
            textBoxExportBuild.Text += "bPR=" + comboBoxBonusPRS.SelectedIndex + ";";
            textBoxExportBuild.Text += "wpn=" + comboBoxSelectWeapon.SelectedIndex + ";";
            textBoxExportBuild.Text += "gea=" + comboBoxSelectGear.SelectedIndex + ";";
            textBoxExportBuild.Text += "ad1=" + comboBoxSelectAddOn1.SelectedIndex + ";";
            textBoxExportBuild.Text += "ad2=" + comboBoxSelectAddOn2.SelectedIndex + ";";
            textBoxExportBuild.Text += "bt1=" + comboBoxSelectBooster1.SelectedIndex + ";";
            textBoxExportBuild.Text += "bt2=" + comboBoxSelectBooster2.SelectedIndex + ";";
            textBoxExportBuild.Text += "ap1=" + comboBoxSelectApex1.SelectedIndex + ";";
            textBoxExportBuild.Text += "ap2=" + comboBoxSelectApex2.SelectedIndex + ";";
            textBoxExportBuild.Text += "cbl=";
            if (checkBoxShieldBoostWD.Checked) textBoxExportBuild.Text+= "1"; else textBoxExportBuild.Text += "0";
            if (checkBoxBarricadeWD.Checked) textBoxExportBuild.Text += '1'; else textBoxExportBuild.Text += '0';
            if (checkBoxBarricadePD.Checked) textBoxExportBuild.Text += '1'; else textBoxExportBuild.Text += '0';
            if (checkBoxElementalTechOnTarget.Checked) textBoxExportBuild.Text += '1'; else textBoxExportBuild.Text += '0';
            if (checkBoxOverwrite.Checked) textBoxExportBuild.Text += "1;"; else textBoxExportBuild.Text += "0;";

            textBoxExportBuild.Text += "bwd=" + textBoxOverwriteBaseWeaponDamage.Text + ";";
            textBoxExportBuild.Text += "bms=" + textBoxOverwriteBaseWeaponMAGSize.Text + ";";
            textBoxExportBuild.Text += "sdt=" + textBoxSumSquadDebuffsOnTarget.Text + ";";
            textBoxExportBuild.Text += "dif=" + comboBoxSelectDifficulty.SelectedIndex + ";";
            textBoxExportBuild.Text += "ene=" + comboBoxSelectEnemy.SelectedIndex + ";";

            textBoxExportBuild.Text += "cbs=";
            if (checkBoxOnOffSkill1.Checked) textBoxExportBuild.Text += "1"; else textBoxExportBuild.Text += "0";
            if (checkBoxOnOffSkill2.Checked) textBoxExportBuild.Text += "1"; else textBoxExportBuild.Text += "0";
            if (checkBoxOnOffSkill3.Checked) textBoxExportBuild.Text += "1"; else textBoxExportBuild.Text += "0";
            if (checkBoxOnOffSkill4.Checked) textBoxExportBuild.Text += "1"; else textBoxExportBuild.Text += "0";
            if (checkBoxOnOffSkill5.Checked) textBoxExportBuild.Text += "1;"; else textBoxExportBuild.Text += "0;";

            int tempInt;

            textBoxExportBuild.Text += "s1p="; tempInt = 0; 
            tempInt +=1; if (checkBoxSkill1_1.Checked) tempInt +=5 ;  textBoxExportBuild.Text +=tempInt.ToString(); tempInt = 0;
            if (!comboBoxSkill1_2.Text.Equals("none")) tempInt += 1; if (checkBoxSkill1_2.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (!comboBoxSkill1_3.Text.Equals("none")) tempInt += 1; if (checkBoxSkill1_3.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if  (comboBoxSkill1_4.Text.Equals("none")) textBoxExportBuild.Text += "0";
            else {
                                               if (comboBoxSkill1_4.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo4a)) tempInt += 1; else tempInt += 2;
                                               if (checkBoxSkill1_4.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
                  }
            if (comboBoxSkill1_5.Text.Equals("none")) textBoxExportBuild.Text += "0";
            else
            {
                if (comboBoxSkill1_5.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo5a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill1_5.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            }
            if (comboBoxSkill1_6.Text.Equals("none")) textBoxExportBuild.Text += "0;";
            else
            {
                if (comboBoxSkill1_6.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill1evo6a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill1_6.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString() + ";"; 
            }

            textBoxExportBuild.Text += "s2p="; tempInt = 0;
            tempInt += 1; if (checkBoxSkill2_1.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (!comboBoxSkill2_2.Text.Equals("none")) tempInt += 1; if (checkBoxSkill2_2.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (!comboBoxSkill2_3.Text.Equals("none")) tempInt += 1; if (checkBoxSkill2_3.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (comboBoxSkill2_4.Text.Equals("none")) textBoxExportBuild.Text += "0";
            else
            {
                if (comboBoxSkill2_4.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo4a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill2_4.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            }
            if (comboBoxSkill2_5.Text.Equals("none")) textBoxExportBuild.Text += "0";
            else
            {
                if (comboBoxSkill2_5.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo5a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill2_5.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            }
            if (comboBoxSkill2_6.Text.Equals("none")) textBoxExportBuild.Text += "0;";
            else
            {
                if (comboBoxSkill2_6.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill2evo6a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill2_6.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString() + ";";
            }

            textBoxExportBuild.Text += "s3p="; tempInt = 0;
            tempInt += 1; if (checkBoxSkill3_1.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (!comboBoxSkill3_2.Text.Equals("none")) tempInt += 1; if (checkBoxSkill3_2.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (!comboBoxSkill3_3.Text.Equals("none")) tempInt += 1; if (checkBoxSkill3_3.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (comboBoxSkill3_4.Text.Equals("none")) textBoxExportBuild.Text += "0";
            else
            {
                if (comboBoxSkill3_4.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo4a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill3_4.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            }
            if (comboBoxSkill3_5.Text.Equals("none")) textBoxExportBuild.Text += "0";
            else
            {
                if (comboBoxSkill3_5.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo5a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill3_5.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            }
            if (comboBoxSkill3_6.Text.Equals("none")) textBoxExportBuild.Text += "0;";
            else
            {
                if (comboBoxSkill3_6.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill3evo6a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill3_6.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString() + ";";
            }

            textBoxExportBuild.Text += "s4p="; tempInt = 0;
            if (!comboBoxSkill4_1.Text.Equals("none")) tempInt += 1; if (checkBoxSkill4_1.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (!comboBoxSkill4_2.Text.Equals("none")) tempInt += 1; if (checkBoxSkill4_2.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (!comboBoxSkill4_3.Text.Equals("none")) tempInt += 1; if (checkBoxSkill4_3.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (comboBoxSkill4_4.Text.Equals("none")) textBoxExportBuild.Text += "0";
            else
            {
                if (comboBoxSkill4_4.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo4a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill4_4.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            }
            if (comboBoxSkill4_5.Text.Equals("none")) textBoxExportBuild.Text += "0";
            else
            {
                if (comboBoxSkill4_5.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo5a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill4_5.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            }
            if (comboBoxSkill4_6.Text.Equals("none")) textBoxExportBuild.Text += "0;";
            else
            {
                if (comboBoxSkill4_6.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill4evo6a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill4_6.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString() + ";";
            }
            textBoxExportBuild.Text += "s5p="; tempInt = 0;
            if (!comboBoxSkill5_1.Text.Equals("none")) tempInt += 1; if (checkBoxSkill5_1.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (!comboBoxSkill5_2.Text.Equals("none")) tempInt += 1; if (checkBoxSkill5_2.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (!comboBoxSkill5_3.Text.Equals("none")) tempInt += 1; if (checkBoxSkill5_3.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            if (comboBoxSkill5_4.Text.Equals("none")) textBoxExportBuild.Text += "0";
            else
            {
                if (comboBoxSkill5_4.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo4a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill5_4.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            }
            if (comboBoxSkill5_5.Text.Equals("none")) textBoxExportBuild.Text += "0";
            else
            {
                if (comboBoxSkill5_5.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo5a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill5_5.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString(); tempInt = 0;
            }
            if (comboBoxSkill5_6.Text.Equals("none")) textBoxExportBuild.Text += "0;";
            else
            {
                if (comboBoxSkill5_6.Text.Equals(playingCharactersArray[comboBoxSelectChars.SelectedIndex].Skill5evo6a)) tempInt += 1; else tempInt += 2;
                if (checkBoxSkill5_6.Checked) tempInt += 5; textBoxExportBuild.Text += tempInt.ToString() + ";";
            }
        }
    }
    }

 
 