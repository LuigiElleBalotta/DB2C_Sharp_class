using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Creature_template
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int difficulty_entry_1 = 0; //Comment: 
		int OLD_difficulty_entry_1 = 0;

		int difficulty_entry_2 = 0; //Comment: 
		int OLD_difficulty_entry_2 = 0;

		int difficulty_entry_3 = 0; //Comment: 
		int OLD_difficulty_entry_3 = 0;

		int KillCredit1 = 0; //Comment: 
		int OLD_KillCredit1 = 0;

		int KillCredit2 = 0; //Comment: 
		int OLD_KillCredit2 = 0;

		int modelid1 = 0; //Comment: 
		int OLD_modelid1 = 0;

		int modelid2 = 0; //Comment: 
		int OLD_modelid2 = 0;

		int modelid3 = 0; //Comment: 
		int OLD_modelid3 = 0;

		int modelid4 = 0; //Comment: 
		int OLD_modelid4 = 0;

		char name = '0'; //Comment: 
		char OLD_name = '0';

		char femaleName = Char.MinValue; //Comment: 
		char OLD_femaleName = Char.MinValue;

		char subname = Char.MinValue; //Comment: 
		char OLD_subname = Char.MinValue;

		char IconName = Char.MinValue; //Comment: 
		char OLD_IconName = Char.MinValue;

		int gossip_menu_id = 0; //Comment: 
		int OLD_gossip_menu_id = 0;

		int minlevel = 1; //Comment: 
		int OLD_minlevel = 1;

		int maxlevel = 1; //Comment: 
		int OLD_maxlevel = 1;

		int exp = 0; //Comment: 
		int OLD_exp = 0;

		int exp_unk = 0; //Comment: 
		int OLD_exp_unk = 0;

		int faction = 0; //Comment: 
		int OLD_faction = 0;

		int npcflag = 0; //Comment: 
		int OLD_npcflag = 0;

		float speed_walk = 1f; //Comment: Result of 2.5/2.5, most common value
		float OLD_speed_walk = 1f;

		float speed_run = 1.14286f; //Comment: Result of 8.0/7.0, most common value
		float OLD_speed_run = 1.14286f;

		float scale = 1f; //Comment: 
		float OLD_scale = 1f;

		int rank = 0; //Comment: 
		int OLD_rank = 0;

		int dmgschool = 0; //Comment: 
		int OLD_dmgschool = 0;

		int BaseAttackTime = 0; //Comment: 
		int OLD_BaseAttackTime = 0;

		int RangeAttackTime = 0; //Comment: 
		int OLD_RangeAttackTime = 0;

		float BaseVariance = 1f; //Comment: 
		float OLD_BaseVariance = 1f;

		float RangeVariance = 1f; //Comment: 
		float OLD_RangeVariance = 1f;

		int unit_class = 0; //Comment: 
		int OLD_unit_class = 0;

		int unit_flags = 0; //Comment: 
		int OLD_unit_flags = 0;

		int unit_flags2 = 0; //Comment: 
		int OLD_unit_flags2 = 0;

		int dynamicflags = 0; //Comment: 
		int OLD_dynamicflags = 0;

		int family = 0; //Comment: 
		int OLD_family = 0;

		int trainer_type = 0; //Comment: 
		int OLD_trainer_type = 0;

		int trainer_class = 0; //Comment: 
		int OLD_trainer_class = 0;

		int trainer_race = 0; //Comment: 
		int OLD_trainer_race = 0;

		int type = 0; //Comment: 
		int OLD_type = 0;

		int type_flags = 0; //Comment: 
		int OLD_type_flags = 0;

		int type_flags2 = 0; //Comment: 
		int OLD_type_flags2 = 0;

		int lootid = 0; //Comment: 
		int OLD_lootid = 0;

		int pickpocketloot = 0; //Comment: 
		int OLD_pickpocketloot = 0;

		int skinloot = 0; //Comment: 
		int OLD_skinloot = 0;

		int resistance1 = 0; //Comment: 
		int OLD_resistance1 = 0;

		int resistance2 = 0; //Comment: 
		int OLD_resistance2 = 0;

		int resistance3 = 0; //Comment: 
		int OLD_resistance3 = 0;

		int resistance4 = 0; //Comment: 
		int OLD_resistance4 = 0;

		int resistance5 = 0; //Comment: 
		int OLD_resistance5 = 0;

		int resistance6 = 0; //Comment: 
		int OLD_resistance6 = 0;

		int spell1 = 0; //Comment: 
		int OLD_spell1 = 0;

		int spell2 = 0; //Comment: 
		int OLD_spell2 = 0;

		int spell3 = 0; //Comment: 
		int OLD_spell3 = 0;

		int spell4 = 0; //Comment: 
		int OLD_spell4 = 0;

		int spell5 = 0; //Comment: 
		int OLD_spell5 = 0;

		int spell6 = 0; //Comment: 
		int OLD_spell6 = 0;

		int spell7 = 0; //Comment: 
		int OLD_spell7 = 0;

		int spell8 = 0; //Comment: 
		int OLD_spell8 = 0;

		int VehicleId = 0; //Comment: 
		int OLD_VehicleId = 0;

		int mingold = 0; //Comment: 
		int OLD_mingold = 0;

		int maxgold = 0; //Comment: 
		int OLD_maxgold = 0;

		char AIName = Char.MinValue; //Comment: 
		char OLD_AIName = Char.MinValue;

		int MovementType = 0; //Comment: 
		int OLD_MovementType = 0;

		int InhabitType = 3; //Comment: 
		int OLD_InhabitType = 3;

		float HoverHeight = 1f; //Comment: 
		float OLD_HoverHeight = 1f;

		float HealthModifier = 1f; //Comment: 
		float OLD_HealthModifier = 1f;

		float HealthModifierExtra = 1f; //Comment: 
		float OLD_HealthModifierExtra = 1f;

		float ManaModifier = 1f; //Comment: 
		float OLD_ManaModifier = 1f;

		float ManaModifierExtra = 1f; //Comment: 
		float OLD_ManaModifierExtra = 1f;

		float ArmorModifier = 1f; //Comment: 
		float OLD_ArmorModifier = 1f;

		float DamageModifier = 1f; //Comment: 
		float OLD_DamageModifier = 1f;

		float ExperienceModifier = 1f; //Comment: 
		float OLD_ExperienceModifier = 1f;

		int RacialLeader = 0; //Comment: 
		int OLD_RacialLeader = 0;

		int movementId = 0; //Comment: 
		int OLD_movementId = 0;

		int RegenHealth = 1; //Comment: 
		int OLD_RegenHealth = 1;

		int mechanic_immune_mask = 0; //Comment: 
		int OLD_mechanic_immune_mask = 0;

		int flags_extra = 0; //Comment: 
		int OLD_flags_extra = 0;

		char ScriptName = Char.MinValue; //Comment: 
		char OLD_ScriptName = Char.MinValue;

		int VerifiedBuild = 0; //Comment: 
		int OLD_VerifiedBuild = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Creature_template(int _entry, int _difficulty_entry_1, int _difficulty_entry_2, int _difficulty_entry_3, int _KillCredit1, int _KillCredit2, int _modelid1, int _modelid2, int _modelid3, int _modelid4, char _name, char _femaleName, char _subname, char _IconName, int _gossip_menu_id, int _minlevel, int _maxlevel, int _exp, int _exp_unk, int _faction, int _npcflag, float _speed_walk, float _speed_run, float _scale, int _rank, int _dmgschool, int _BaseAttackTime, int _RangeAttackTime, float _BaseVariance, float _RangeVariance, int _unit_class, int _unit_flags, int _unit_flags2, int _dynamicflags, int _family, int _trainer_type, int _trainer_class, int _trainer_race, int _type, int _type_flags, int _type_flags2, int _lootid, int _pickpocketloot, int _skinloot, int _resistance1, int _resistance2, int _resistance3, int _resistance4, int _resistance5, int _resistance6, int _spell1, int _spell2, int _spell3, int _spell4, int _spell5, int _spell6, int _spell7, int _spell8, int _VehicleId, int _mingold, int _maxgold, char _AIName, int _MovementType, int _InhabitType, float _HoverHeight, float _HealthModifier, float _HealthModifierExtra, float _ManaModifier, float _ManaModifierExtra, float _ArmorModifier, float _DamageModifier, float _ExperienceModifier, int _RacialLeader, int _movementId, int _RegenHealth, int _mechanic_immune_mask, int _flags_extra, char _ScriptName, int _VerifiedBuild)
		{
			entry = _entry;
			difficulty_entry_1 = _difficulty_entry_1;
			difficulty_entry_2 = _difficulty_entry_2;
			difficulty_entry_3 = _difficulty_entry_3;
			KillCredit1 = _KillCredit1;
			KillCredit2 = _KillCredit2;
			modelid1 = _modelid1;
			modelid2 = _modelid2;
			modelid3 = _modelid3;
			modelid4 = _modelid4;
			name = _name;
			femaleName = _femaleName;
			subname = _subname;
			IconName = _IconName;
			gossip_menu_id = _gossip_menu_id;
			minlevel = _minlevel;
			maxlevel = _maxlevel;
			exp = _exp;
			exp_unk = _exp_unk;
			faction = _faction;
			npcflag = _npcflag;
			speed_walk = _speed_walk;
			speed_run = _speed_run;
			scale = _scale;
			rank = _rank;
			dmgschool = _dmgschool;
			BaseAttackTime = _BaseAttackTime;
			RangeAttackTime = _RangeAttackTime;
			BaseVariance = _BaseVariance;
			RangeVariance = _RangeVariance;
			unit_class = _unit_class;
			unit_flags = _unit_flags;
			unit_flags2 = _unit_flags2;
			dynamicflags = _dynamicflags;
			family = _family;
			trainer_type = _trainer_type;
			trainer_class = _trainer_class;
			trainer_race = _trainer_race;
			type = _type;
			type_flags = _type_flags;
			type_flags2 = _type_flags2;
			lootid = _lootid;
			pickpocketloot = _pickpocketloot;
			skinloot = _skinloot;
			resistance1 = _resistance1;
			resistance2 = _resistance2;
			resistance3 = _resistance3;
			resistance4 = _resistance4;
			resistance5 = _resistance5;
			resistance6 = _resistance6;
			spell1 = _spell1;
			spell2 = _spell2;
			spell3 = _spell3;
			spell4 = _spell4;
			spell5 = _spell5;
			spell6 = _spell6;
			spell7 = _spell7;
			spell8 = _spell8;
			VehicleId = _VehicleId;
			mingold = _mingold;
			maxgold = _maxgold;
			AIName = _AIName;
			MovementType = _MovementType;
			InhabitType = _InhabitType;
			HoverHeight = _HoverHeight;
			HealthModifier = _HealthModifier;
			HealthModifierExtra = _HealthModifierExtra;
			ManaModifier = _ManaModifier;
			ManaModifierExtra = _ManaModifierExtra;
			ArmorModifier = _ArmorModifier;
			DamageModifier = _DamageModifier;
			ExperienceModifier = _ExperienceModifier;
			RacialLeader = _RacialLeader;
			movementId = _movementId;
			RegenHealth = _RegenHealth;
			mechanic_immune_mask = _mechanic_immune_mask;
			flags_extra = _flags_extra;
			ScriptName = _ScriptName;
			VerifiedBuild = _VerifiedBuild;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM creature_template WHERE entry = @entry AND difficulty_entry_1 = @difficulty_entry_1 AND difficulty_entry_2 = @difficulty_entry_2 AND difficulty_entry_3 = @difficulty_entry_3 AND KillCredit1 = @KillCredit1 AND KillCredit2 = @KillCredit2 AND modelid1 = @modelid1 AND modelid2 = @modelid2 AND modelid3 = @modelid3 AND modelid4 = @modelid4 AND name = @name AND femaleName = @femaleName AND subname = @subname AND IconName = @IconName AND gossip_menu_id = @gossip_menu_id AND minlevel = @minlevel AND maxlevel = @maxlevel AND exp = @exp AND exp_unk = @exp_unk AND faction = @faction AND npcflag = @npcflag AND speed_walk = @speed_walk AND speed_run = @speed_run AND scale = @scale AND rank = @rank AND dmgschool = @dmgschool AND BaseAttackTime = @BaseAttackTime AND RangeAttackTime = @RangeAttackTime AND BaseVariance = @BaseVariance AND RangeVariance = @RangeVariance AND unit_class = @unit_class AND unit_flags = @unit_flags AND unit_flags2 = @unit_flags2 AND dynamicflags = @dynamicflags AND family = @family AND trainer_type = @trainer_type AND trainer_class = @trainer_class AND trainer_race = @trainer_race AND type = @type AND type_flags = @type_flags AND type_flags2 = @type_flags2 AND lootid = @lootid AND pickpocketloot = @pickpocketloot AND skinloot = @skinloot AND resistance1 = @resistance1 AND resistance2 = @resistance2 AND resistance3 = @resistance3 AND resistance4 = @resistance4 AND resistance5 = @resistance5 AND resistance6 = @resistance6 AND spell1 = @spell1 AND spell2 = @spell2 AND spell3 = @spell3 AND spell4 = @spell4 AND spell5 = @spell5 AND spell6 = @spell6 AND spell7 = @spell7 AND spell8 = @spell8 AND VehicleId = @VehicleId AND mingold = @mingold AND maxgold = @maxgold AND AIName = @AIName AND MovementType = @MovementType AND InhabitType = @InhabitType AND HoverHeight = @HoverHeight AND HealthModifier = @HealthModifier AND HealthModifierExtra = @HealthModifierExtra AND ManaModifier = @ManaModifier AND ManaModifierExtra = @ManaModifierExtra AND ArmorModifier = @ArmorModifier AND DamageModifier = @DamageModifier AND ExperienceModifier = @ExperienceModifier AND RacialLeader = @RacialLeader AND movementId = @movementId AND RegenHealth = @RegenHealth AND mechanic_immune_mask = @mechanic_immune_mask AND flags_extra = @flags_extra AND ScriptName = @ScriptName AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter difficulty_entry_1Parameter = new MySqlParameter("@difficulty_entry_1", MySqlDbType.VarChar, 0);
			MySqlParameter difficulty_entry_2Parameter = new MySqlParameter("@difficulty_entry_2", MySqlDbType.VarChar, 0);
			MySqlParameter difficulty_entry_3Parameter = new MySqlParameter("@difficulty_entry_3", MySqlDbType.VarChar, 0);
			MySqlParameter killcredit1Parameter = new MySqlParameter("@KillCredit1", MySqlDbType.VarChar, 0);
			MySqlParameter killcredit2Parameter = new MySqlParameter("@KillCredit2", MySqlDbType.VarChar, 0);
			MySqlParameter modelid1Parameter = new MySqlParameter("@modelid1", MySqlDbType.VarChar, 0);
			MySqlParameter modelid2Parameter = new MySqlParameter("@modelid2", MySqlDbType.VarChar, 0);
			MySqlParameter modelid3Parameter = new MySqlParameter("@modelid3", MySqlDbType.VarChar, 0);
			MySqlParameter modelid4Parameter = new MySqlParameter("@modelid4", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter femalenameParameter = new MySqlParameter("@femaleName", MySqlDbType.VarChar, 0);
			MySqlParameter subnameParameter = new MySqlParameter("@subname", MySqlDbType.VarChar, 0);
			MySqlParameter iconnameParameter = new MySqlParameter("@IconName", MySqlDbType.VarChar, 0);
			MySqlParameter gossip_menu_idParameter = new MySqlParameter("@gossip_menu_id", MySqlDbType.VarChar, 0);
			MySqlParameter minlevelParameter = new MySqlParameter("@minlevel", MySqlDbType.VarChar, 0);
			MySqlParameter maxlevelParameter = new MySqlParameter("@maxlevel", MySqlDbType.VarChar, 0);
			MySqlParameter expParameter = new MySqlParameter("@exp", MySqlDbType.VarChar, 0);
			MySqlParameter exp_unkParameter = new MySqlParameter("@exp_unk", MySqlDbType.VarChar, 0);
			MySqlParameter factionParameter = new MySqlParameter("@faction", MySqlDbType.VarChar, 0);
			MySqlParameter npcflagParameter = new MySqlParameter("@npcflag", MySqlDbType.VarChar, 0);
			MySqlParameter speed_walkParameter = new MySqlParameter("@speed_walk", MySqlDbType.VarChar, 0);
			MySqlParameter speed_runParameter = new MySqlParameter("@speed_run", MySqlDbType.VarChar, 0);
			MySqlParameter scaleParameter = new MySqlParameter("@scale", MySqlDbType.VarChar, 0);
			MySqlParameter rankParameter = new MySqlParameter("@rank", MySqlDbType.VarChar, 0);
			MySqlParameter dmgschoolParameter = new MySqlParameter("@dmgschool", MySqlDbType.VarChar, 0);
			MySqlParameter baseattacktimeParameter = new MySqlParameter("@BaseAttackTime", MySqlDbType.VarChar, 0);
			MySqlParameter rangeattacktimeParameter = new MySqlParameter("@RangeAttackTime", MySqlDbType.VarChar, 0);
			MySqlParameter basevarianceParameter = new MySqlParameter("@BaseVariance", MySqlDbType.VarChar, 0);
			MySqlParameter rangevarianceParameter = new MySqlParameter("@RangeVariance", MySqlDbType.VarChar, 0);
			MySqlParameter unit_classParameter = new MySqlParameter("@unit_class", MySqlDbType.VarChar, 0);
			MySqlParameter unit_flagsParameter = new MySqlParameter("@unit_flags", MySqlDbType.VarChar, 0);
			MySqlParameter unit_flags2Parameter = new MySqlParameter("@unit_flags2", MySqlDbType.VarChar, 0);
			MySqlParameter dynamicflagsParameter = new MySqlParameter("@dynamicflags", MySqlDbType.VarChar, 0);
			MySqlParameter familyParameter = new MySqlParameter("@family", MySqlDbType.VarChar, 0);
			MySqlParameter trainer_typeParameter = new MySqlParameter("@trainer_type", MySqlDbType.VarChar, 0);
			MySqlParameter trainer_classParameter = new MySqlParameter("@trainer_class", MySqlDbType.VarChar, 0);
			MySqlParameter trainer_raceParameter = new MySqlParameter("@trainer_race", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter type_flagsParameter = new MySqlParameter("@type_flags", MySqlDbType.VarChar, 0);
			MySqlParameter type_flags2Parameter = new MySqlParameter("@type_flags2", MySqlDbType.VarChar, 0);
			MySqlParameter lootidParameter = new MySqlParameter("@lootid", MySqlDbType.VarChar, 0);
			MySqlParameter pickpocketlootParameter = new MySqlParameter("@pickpocketloot", MySqlDbType.VarChar, 0);
			MySqlParameter skinlootParameter = new MySqlParameter("@skinloot", MySqlDbType.VarChar, 0);
			MySqlParameter resistance1Parameter = new MySqlParameter("@resistance1", MySqlDbType.VarChar, 0);
			MySqlParameter resistance2Parameter = new MySqlParameter("@resistance2", MySqlDbType.VarChar, 0);
			MySqlParameter resistance3Parameter = new MySqlParameter("@resistance3", MySqlDbType.VarChar, 0);
			MySqlParameter resistance4Parameter = new MySqlParameter("@resistance4", MySqlDbType.VarChar, 0);
			MySqlParameter resistance5Parameter = new MySqlParameter("@resistance5", MySqlDbType.VarChar, 0);
			MySqlParameter resistance6Parameter = new MySqlParameter("@resistance6", MySqlDbType.VarChar, 0);
			MySqlParameter spell1Parameter = new MySqlParameter("@spell1", MySqlDbType.VarChar, 0);
			MySqlParameter spell2Parameter = new MySqlParameter("@spell2", MySqlDbType.VarChar, 0);
			MySqlParameter spell3Parameter = new MySqlParameter("@spell3", MySqlDbType.VarChar, 0);
			MySqlParameter spell4Parameter = new MySqlParameter("@spell4", MySqlDbType.VarChar, 0);
			MySqlParameter spell5Parameter = new MySqlParameter("@spell5", MySqlDbType.VarChar, 0);
			MySqlParameter spell6Parameter = new MySqlParameter("@spell6", MySqlDbType.VarChar, 0);
			MySqlParameter spell7Parameter = new MySqlParameter("@spell7", MySqlDbType.VarChar, 0);
			MySqlParameter spell8Parameter = new MySqlParameter("@spell8", MySqlDbType.VarChar, 0);
			MySqlParameter vehicleidParameter = new MySqlParameter("@VehicleId", MySqlDbType.VarChar, 0);
			MySqlParameter mingoldParameter = new MySqlParameter("@mingold", MySqlDbType.VarChar, 0);
			MySqlParameter maxgoldParameter = new MySqlParameter("@maxgold", MySqlDbType.VarChar, 0);
			MySqlParameter ainameParameter = new MySqlParameter("@AIName", MySqlDbType.VarChar, 0);
			MySqlParameter movementtypeParameter = new MySqlParameter("@MovementType", MySqlDbType.VarChar, 0);
			MySqlParameter inhabittypeParameter = new MySqlParameter("@InhabitType", MySqlDbType.VarChar, 0);
			MySqlParameter hoverheightParameter = new MySqlParameter("@HoverHeight", MySqlDbType.VarChar, 0);
			MySqlParameter healthmodifierParameter = new MySqlParameter("@HealthModifier", MySqlDbType.VarChar, 0);
			MySqlParameter healthmodifierextraParameter = new MySqlParameter("@HealthModifierExtra", MySqlDbType.VarChar, 0);
			MySqlParameter manamodifierParameter = new MySqlParameter("@ManaModifier", MySqlDbType.VarChar, 0);
			MySqlParameter manamodifierextraParameter = new MySqlParameter("@ManaModifierExtra", MySqlDbType.VarChar, 0);
			MySqlParameter armormodifierParameter = new MySqlParameter("@ArmorModifier", MySqlDbType.VarChar, 0);
			MySqlParameter damagemodifierParameter = new MySqlParameter("@DamageModifier", MySqlDbType.VarChar, 0);
			MySqlParameter experiencemodifierParameter = new MySqlParameter("@ExperienceModifier", MySqlDbType.VarChar, 0);
			MySqlParameter racialleaderParameter = new MySqlParameter("@RacialLeader", MySqlDbType.VarChar, 0);
			MySqlParameter movementidParameter = new MySqlParameter("@movementId", MySqlDbType.VarChar, 0);
			MySqlParameter regenhealthParameter = new MySqlParameter("@RegenHealth", MySqlDbType.VarChar, 0);
			MySqlParameter mechanic_immune_maskParameter = new MySqlParameter("@mechanic_immune_mask", MySqlDbType.VarChar, 0);
			MySqlParameter flags_extraParameter = new MySqlParameter("@flags_extra", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			difficulty_entry_1Parameter.Value = difficulty_entry_1;
			difficulty_entry_2Parameter.Value = difficulty_entry_2;
			difficulty_entry_3Parameter.Value = difficulty_entry_3;
			killcredit1Parameter.Value = KillCredit1;
			killcredit2Parameter.Value = KillCredit2;
			modelid1Parameter.Value = modelid1;
			modelid2Parameter.Value = modelid2;
			modelid3Parameter.Value = modelid3;
			modelid4Parameter.Value = modelid4;
			nameParameter.Value = name;
			femalenameParameter.Value = femaleName;
			subnameParameter.Value = subname;
			iconnameParameter.Value = IconName;
			gossip_menu_idParameter.Value = gossip_menu_id;
			minlevelParameter.Value = minlevel;
			maxlevelParameter.Value = maxlevel;
			expParameter.Value = exp;
			exp_unkParameter.Value = exp_unk;
			factionParameter.Value = faction;
			npcflagParameter.Value = npcflag;
			speed_walkParameter.Value = speed_walk;
			speed_runParameter.Value = speed_run;
			scaleParameter.Value = scale;
			rankParameter.Value = rank;
			dmgschoolParameter.Value = dmgschool;
			baseattacktimeParameter.Value = BaseAttackTime;
			rangeattacktimeParameter.Value = RangeAttackTime;
			basevarianceParameter.Value = BaseVariance;
			rangevarianceParameter.Value = RangeVariance;
			unit_classParameter.Value = unit_class;
			unit_flagsParameter.Value = unit_flags;
			unit_flags2Parameter.Value = unit_flags2;
			dynamicflagsParameter.Value = dynamicflags;
			familyParameter.Value = family;
			trainer_typeParameter.Value = trainer_type;
			trainer_classParameter.Value = trainer_class;
			trainer_raceParameter.Value = trainer_race;
			typeParameter.Value = type;
			type_flagsParameter.Value = type_flags;
			type_flags2Parameter.Value = type_flags2;
			lootidParameter.Value = lootid;
			pickpocketlootParameter.Value = pickpocketloot;
			skinlootParameter.Value = skinloot;
			resistance1Parameter.Value = resistance1;
			resistance2Parameter.Value = resistance2;
			resistance3Parameter.Value = resistance3;
			resistance4Parameter.Value = resistance4;
			resistance5Parameter.Value = resistance5;
			resistance6Parameter.Value = resistance6;
			spell1Parameter.Value = spell1;
			spell2Parameter.Value = spell2;
			spell3Parameter.Value = spell3;
			spell4Parameter.Value = spell4;
			spell5Parameter.Value = spell5;
			spell6Parameter.Value = spell6;
			spell7Parameter.Value = spell7;
			spell8Parameter.Value = spell8;
			vehicleidParameter.Value = VehicleId;
			mingoldParameter.Value = mingold;
			maxgoldParameter.Value = maxgold;
			ainameParameter.Value = AIName;
			movementtypeParameter.Value = MovementType;
			inhabittypeParameter.Value = InhabitType;
			hoverheightParameter.Value = HoverHeight;
			healthmodifierParameter.Value = HealthModifier;
			healthmodifierextraParameter.Value = HealthModifierExtra;
			manamodifierParameter.Value = ManaModifier;
			manamodifierextraParameter.Value = ManaModifierExtra;
			armormodifierParameter.Value = ArmorModifier;
			damagemodifierParameter.Value = DamageModifier;
			experiencemodifierParameter.Value = ExperienceModifier;
			racialleaderParameter.Value = RacialLeader;
			movementidParameter.Value = movementId;
			regenhealthParameter.Value = RegenHealth;
			mechanic_immune_maskParameter.Value = mechanic_immune_mask;
			flags_extraParameter.Value = flags_extra;
			scriptnameParameter.Value = ScriptName;
			verifiedbuildParameter.Value = VerifiedBuild;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(difficulty_entry_1Parameter);
			cmd.Parameters.Add(difficulty_entry_2Parameter);
			cmd.Parameters.Add(difficulty_entry_3Parameter);
			cmd.Parameters.Add(killcredit1Parameter);
			cmd.Parameters.Add(killcredit2Parameter);
			cmd.Parameters.Add(modelid1Parameter);
			cmd.Parameters.Add(modelid2Parameter);
			cmd.Parameters.Add(modelid3Parameter);
			cmd.Parameters.Add(modelid4Parameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(femalenameParameter);
			cmd.Parameters.Add(subnameParameter);
			cmd.Parameters.Add(iconnameParameter);
			cmd.Parameters.Add(gossip_menu_idParameter);
			cmd.Parameters.Add(minlevelParameter);
			cmd.Parameters.Add(maxlevelParameter);
			cmd.Parameters.Add(expParameter);
			cmd.Parameters.Add(exp_unkParameter);
			cmd.Parameters.Add(factionParameter);
			cmd.Parameters.Add(npcflagParameter);
			cmd.Parameters.Add(speed_walkParameter);
			cmd.Parameters.Add(speed_runParameter);
			cmd.Parameters.Add(scaleParameter);
			cmd.Parameters.Add(rankParameter);
			cmd.Parameters.Add(dmgschoolParameter);
			cmd.Parameters.Add(baseattacktimeParameter);
			cmd.Parameters.Add(rangeattacktimeParameter);
			cmd.Parameters.Add(basevarianceParameter);
			cmd.Parameters.Add(rangevarianceParameter);
			cmd.Parameters.Add(unit_classParameter);
			cmd.Parameters.Add(unit_flagsParameter);
			cmd.Parameters.Add(unit_flags2Parameter);
			cmd.Parameters.Add(dynamicflagsParameter);
			cmd.Parameters.Add(familyParameter);
			cmd.Parameters.Add(trainer_typeParameter);
			cmd.Parameters.Add(trainer_classParameter);
			cmd.Parameters.Add(trainer_raceParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(type_flagsParameter);
			cmd.Parameters.Add(type_flags2Parameter);
			cmd.Parameters.Add(lootidParameter);
			cmd.Parameters.Add(pickpocketlootParameter);
			cmd.Parameters.Add(skinlootParameter);
			cmd.Parameters.Add(resistance1Parameter);
			cmd.Parameters.Add(resistance2Parameter);
			cmd.Parameters.Add(resistance3Parameter);
			cmd.Parameters.Add(resistance4Parameter);
			cmd.Parameters.Add(resistance5Parameter);
			cmd.Parameters.Add(resistance6Parameter);
			cmd.Parameters.Add(spell1Parameter);
			cmd.Parameters.Add(spell2Parameter);
			cmd.Parameters.Add(spell3Parameter);
			cmd.Parameters.Add(spell4Parameter);
			cmd.Parameters.Add(spell5Parameter);
			cmd.Parameters.Add(spell6Parameter);
			cmd.Parameters.Add(spell7Parameter);
			cmd.Parameters.Add(spell8Parameter);
			cmd.Parameters.Add(vehicleidParameter);
			cmd.Parameters.Add(mingoldParameter);
			cmd.Parameters.Add(maxgoldParameter);
			cmd.Parameters.Add(ainameParameter);
			cmd.Parameters.Add(movementtypeParameter);
			cmd.Parameters.Add(inhabittypeParameter);
			cmd.Parameters.Add(hoverheightParameter);
			cmd.Parameters.Add(healthmodifierParameter);
			cmd.Parameters.Add(healthmodifierextraParameter);
			cmd.Parameters.Add(manamodifierParameter);
			cmd.Parameters.Add(manamodifierextraParameter);
			cmd.Parameters.Add(armormodifierParameter);
			cmd.Parameters.Add(damagemodifierParameter);
			cmd.Parameters.Add(experiencemodifierParameter);
			cmd.Parameters.Add(racialleaderParameter);
			cmd.Parameters.Add(movementidParameter);
			cmd.Parameters.Add(regenhealthParameter);
			cmd.Parameters.Add(mechanic_immune_maskParameter);
			cmd.Parameters.Add(flags_extraParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE creature_template SET entry = @newentry, difficulty_entry_1 = @newdifficulty_entry_1, difficulty_entry_2 = @newdifficulty_entry_2, difficulty_entry_3 = @newdifficulty_entry_3, KillCredit1 = @newKillCredit1, KillCredit2 = @newKillCredit2, modelid1 = @newmodelid1, modelid2 = @newmodelid2, modelid3 = @newmodelid3, modelid4 = @newmodelid4, name = @newname, femaleName = @newfemaleName, subname = @newsubname, IconName = @newIconName, gossip_menu_id = @newgossip_menu_id, minlevel = @newminlevel, maxlevel = @newmaxlevel, exp = @newexp, exp_unk = @newexp_unk, faction = @newfaction, npcflag = @newnpcflag, speed_walk = @newspeed_walk, speed_run = @newspeed_run, scale = @newscale, rank = @newrank, dmgschool = @newdmgschool, BaseAttackTime = @newBaseAttackTime, RangeAttackTime = @newRangeAttackTime, BaseVariance = @newBaseVariance, RangeVariance = @newRangeVariance, unit_class = @newunit_class, unit_flags = @newunit_flags, unit_flags2 = @newunit_flags2, dynamicflags = @newdynamicflags, family = @newfamily, trainer_type = @newtrainer_type, trainer_class = @newtrainer_class, trainer_race = @newtrainer_race, type = @newtype, type_flags = @newtype_flags, type_flags2 = @newtype_flags2, lootid = @newlootid, pickpocketloot = @newpickpocketloot, skinloot = @newskinloot, resistance1 = @newresistance1, resistance2 = @newresistance2, resistance3 = @newresistance3, resistance4 = @newresistance4, resistance5 = @newresistance5, resistance6 = @newresistance6, spell1 = @newspell1, spell2 = @newspell2, spell3 = @newspell3, spell4 = @newspell4, spell5 = @newspell5, spell6 = @newspell6, spell7 = @newspell7, spell8 = @newspell8, VehicleId = @newVehicleId, mingold = @newmingold, maxgold = @newmaxgold, AIName = @newAIName, MovementType = @newMovementType, InhabitType = @newInhabitType, HoverHeight = @newHoverHeight, HealthModifier = @newHealthModifier, HealthModifierExtra = @newHealthModifierExtra, ManaModifier = @newManaModifier, ManaModifierExtra = @newManaModifierExtra, ArmorModifier = @newArmorModifier, DamageModifier = @newDamageModifier, ExperienceModifier = @newExperienceModifier, RacialLeader = @newRacialLeader, movementId = @newmovementId, RegenHealth = @newRegenHealth, mechanic_immune_mask = @newmechanic_immune_mask, flags_extra = @newflags_extra, ScriptName = @newScriptName, VerifiedBuild = @newVerifiedBuild WHERE entry = @entry AND difficulty_entry_1 = @difficulty_entry_1 AND difficulty_entry_2 = @difficulty_entry_2 AND difficulty_entry_3 = @difficulty_entry_3 AND KillCredit1 = @KillCredit1 AND KillCredit2 = @KillCredit2 AND modelid1 = @modelid1 AND modelid2 = @modelid2 AND modelid3 = @modelid3 AND modelid4 = @modelid4 AND name = @name AND femaleName = @femaleName AND subname = @subname AND IconName = @IconName AND gossip_menu_id = @gossip_menu_id AND minlevel = @minlevel AND maxlevel = @maxlevel AND exp = @exp AND exp_unk = @exp_unk AND faction = @faction AND npcflag = @npcflag AND speed_walk = @speed_walk AND speed_run = @speed_run AND scale = @scale AND rank = @rank AND dmgschool = @dmgschool AND BaseAttackTime = @BaseAttackTime AND RangeAttackTime = @RangeAttackTime AND BaseVariance = @BaseVariance AND RangeVariance = @RangeVariance AND unit_class = @unit_class AND unit_flags = @unit_flags AND unit_flags2 = @unit_flags2 AND dynamicflags = @dynamicflags AND family = @family AND trainer_type = @trainer_type AND trainer_class = @trainer_class AND trainer_race = @trainer_race AND type = @type AND type_flags = @type_flags AND type_flags2 = @type_flags2 AND lootid = @lootid AND pickpocketloot = @pickpocketloot AND skinloot = @skinloot AND resistance1 = @resistance1 AND resistance2 = @resistance2 AND resistance3 = @resistance3 AND resistance4 = @resistance4 AND resistance5 = @resistance5 AND resistance6 = @resistance6 AND spell1 = @spell1 AND spell2 = @spell2 AND spell3 = @spell3 AND spell4 = @spell4 AND spell5 = @spell5 AND spell6 = @spell6 AND spell7 = @spell7 AND spell8 = @spell8 AND VehicleId = @VehicleId AND mingold = @mingold AND maxgold = @maxgold AND AIName = @AIName AND MovementType = @MovementType AND InhabitType = @InhabitType AND HoverHeight = @HoverHeight AND HealthModifier = @HealthModifier AND HealthModifierExtra = @HealthModifierExtra AND ManaModifier = @ManaModifier AND ManaModifierExtra = @ManaModifierExtra AND ArmorModifier = @ArmorModifier AND DamageModifier = @DamageModifier AND ExperienceModifier = @ExperienceModifier AND RacialLeader = @RacialLeader AND movementId = @movementId AND RegenHealth = @RegenHealth AND mechanic_immune_mask = @mechanic_immune_mask AND flags_extra = @flags_extra AND ScriptName = @ScriptName AND VerifiedBuild = @VerifiedBuild;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_difficulty_entry_1Parameter = new MySqlParameter("@difficulty_entry_1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_difficulty_entry_2Parameter = new MySqlParameter("@difficulty_entry_2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_difficulty_entry_3Parameter = new MySqlParameter("@difficulty_entry_3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_killcredit1Parameter = new MySqlParameter("@KillCredit1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_killcredit2Parameter = new MySqlParameter("@KillCredit2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_modelid1Parameter = new MySqlParameter("@modelid1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_modelid2Parameter = new MySqlParameter("@modelid2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_modelid3Parameter = new MySqlParameter("@modelid3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_modelid4Parameter = new MySqlParameter("@modelid4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_nameParameter = new MySqlParameter("@name", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_femalenameParameter = new MySqlParameter("@femaleName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_subnameParameter = new MySqlParameter("@subname", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_iconnameParameter = new MySqlParameter("@IconName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_gossip_menu_idParameter = new MySqlParameter("@gossip_menu_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_minlevelParameter = new MySqlParameter("@minlevel", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_maxlevelParameter = new MySqlParameter("@maxlevel", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_expParameter = new MySqlParameter("@exp", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_exp_unkParameter = new MySqlParameter("@exp_unk", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_factionParameter = new MySqlParameter("@faction", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_npcflagParameter = new MySqlParameter("@npcflag", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_speed_walkParameter = new MySqlParameter("@speed_walk", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_speed_runParameter = new MySqlParameter("@speed_run", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scaleParameter = new MySqlParameter("@scale", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rankParameter = new MySqlParameter("@rank", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_dmgschoolParameter = new MySqlParameter("@dmgschool", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_baseattacktimeParameter = new MySqlParameter("@BaseAttackTime", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rangeattacktimeParameter = new MySqlParameter("@RangeAttackTime", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_basevarianceParameter = new MySqlParameter("@BaseVariance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_rangevarianceParameter = new MySqlParameter("@RangeVariance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_unit_classParameter = new MySqlParameter("@unit_class", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_unit_flagsParameter = new MySqlParameter("@unit_flags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_unit_flags2Parameter = new MySqlParameter("@unit_flags2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_dynamicflagsParameter = new MySqlParameter("@dynamicflags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_familyParameter = new MySqlParameter("@family", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_trainer_typeParameter = new MySqlParameter("@trainer_type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_trainer_classParameter = new MySqlParameter("@trainer_class", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_trainer_raceParameter = new MySqlParameter("@trainer_race", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_typeParameter = new MySqlParameter("@type", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_type_flagsParameter = new MySqlParameter("@type_flags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_type_flags2Parameter = new MySqlParameter("@type_flags2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_lootidParameter = new MySqlParameter("@lootid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_pickpocketlootParameter = new MySqlParameter("@pickpocketloot", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_skinlootParameter = new MySqlParameter("@skinloot", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_resistance1Parameter = new MySqlParameter("@resistance1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_resistance2Parameter = new MySqlParameter("@resistance2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_resistance3Parameter = new MySqlParameter("@resistance3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_resistance4Parameter = new MySqlParameter("@resistance4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_resistance5Parameter = new MySqlParameter("@resistance5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_resistance6Parameter = new MySqlParameter("@resistance6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell1Parameter = new MySqlParameter("@spell1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell2Parameter = new MySqlParameter("@spell2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell3Parameter = new MySqlParameter("@spell3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell4Parameter = new MySqlParameter("@spell4", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell5Parameter = new MySqlParameter("@spell5", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell6Parameter = new MySqlParameter("@spell6", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell7Parameter = new MySqlParameter("@spell7", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spell8Parameter = new MySqlParameter("@spell8", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_vehicleidParameter = new MySqlParameter("@VehicleId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mingoldParameter = new MySqlParameter("@mingold", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_maxgoldParameter = new MySqlParameter("@maxgold", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_ainameParameter = new MySqlParameter("@AIName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_movementtypeParameter = new MySqlParameter("@MovementType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_inhabittypeParameter = new MySqlParameter("@InhabitType", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_hoverheightParameter = new MySqlParameter("@HoverHeight", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_healthmodifierParameter = new MySqlParameter("@HealthModifier", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_healthmodifierextraParameter = new MySqlParameter("@HealthModifierExtra", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_manamodifierParameter = new MySqlParameter("@ManaModifier", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_manamodifierextraParameter = new MySqlParameter("@ManaModifierExtra", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_armormodifierParameter = new MySqlParameter("@ArmorModifier", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_damagemodifierParameter = new MySqlParameter("@DamageModifier", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_experiencemodifierParameter = new MySqlParameter("@ExperienceModifier", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_racialleaderParameter = new MySqlParameter("@RacialLeader", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_movementidParameter = new MySqlParameter("@movementId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_regenhealthParameter = new MySqlParameter("@RegenHealth", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mechanic_immune_maskParameter = new MySqlParameter("@mechanic_immune_mask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_flags_extraParameter = new MySqlParameter("@flags_extra", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_scriptnameParameter = new MySqlParameter("@ScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_verifiedbuildParameter = new MySqlParameter("@VerifiedBuild", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter difficulty_entry_1Parameter = new MySqlParameter("@newdifficulty_entry_1", MySqlDbType.VarChar, 0);
			MySqlParameter difficulty_entry_2Parameter = new MySqlParameter("@newdifficulty_entry_2", MySqlDbType.VarChar, 0);
			MySqlParameter difficulty_entry_3Parameter = new MySqlParameter("@newdifficulty_entry_3", MySqlDbType.VarChar, 0);
			MySqlParameter killcredit1Parameter = new MySqlParameter("@newKillCredit1", MySqlDbType.VarChar, 0);
			MySqlParameter killcredit2Parameter = new MySqlParameter("@newKillCredit2", MySqlDbType.VarChar, 0);
			MySqlParameter modelid1Parameter = new MySqlParameter("@newmodelid1", MySqlDbType.VarChar, 0);
			MySqlParameter modelid2Parameter = new MySqlParameter("@newmodelid2", MySqlDbType.VarChar, 0);
			MySqlParameter modelid3Parameter = new MySqlParameter("@newmodelid3", MySqlDbType.VarChar, 0);
			MySqlParameter modelid4Parameter = new MySqlParameter("@newmodelid4", MySqlDbType.VarChar, 0);
			MySqlParameter nameParameter = new MySqlParameter("@newname", MySqlDbType.VarChar, 0);
			MySqlParameter femalenameParameter = new MySqlParameter("@newfemaleName", MySqlDbType.VarChar, 0);
			MySqlParameter subnameParameter = new MySqlParameter("@newsubname", MySqlDbType.VarChar, 0);
			MySqlParameter iconnameParameter = new MySqlParameter("@newIconName", MySqlDbType.VarChar, 0);
			MySqlParameter gossip_menu_idParameter = new MySqlParameter("@newgossip_menu_id", MySqlDbType.VarChar, 0);
			MySqlParameter minlevelParameter = new MySqlParameter("@newminlevel", MySqlDbType.VarChar, 0);
			MySqlParameter maxlevelParameter = new MySqlParameter("@newmaxlevel", MySqlDbType.VarChar, 0);
			MySqlParameter expParameter = new MySqlParameter("@newexp", MySqlDbType.VarChar, 0);
			MySqlParameter exp_unkParameter = new MySqlParameter("@newexp_unk", MySqlDbType.VarChar, 0);
			MySqlParameter factionParameter = new MySqlParameter("@newfaction", MySqlDbType.VarChar, 0);
			MySqlParameter npcflagParameter = new MySqlParameter("@newnpcflag", MySqlDbType.VarChar, 0);
			MySqlParameter speed_walkParameter = new MySqlParameter("@newspeed_walk", MySqlDbType.VarChar, 0);
			MySqlParameter speed_runParameter = new MySqlParameter("@newspeed_run", MySqlDbType.VarChar, 0);
			MySqlParameter scaleParameter = new MySqlParameter("@newscale", MySqlDbType.VarChar, 0);
			MySqlParameter rankParameter = new MySqlParameter("@newrank", MySqlDbType.VarChar, 0);
			MySqlParameter dmgschoolParameter = new MySqlParameter("@newdmgschool", MySqlDbType.VarChar, 0);
			MySqlParameter baseattacktimeParameter = new MySqlParameter("@newBaseAttackTime", MySqlDbType.VarChar, 0);
			MySqlParameter rangeattacktimeParameter = new MySqlParameter("@newRangeAttackTime", MySqlDbType.VarChar, 0);
			MySqlParameter basevarianceParameter = new MySqlParameter("@newBaseVariance", MySqlDbType.VarChar, 0);
			MySqlParameter rangevarianceParameter = new MySqlParameter("@newRangeVariance", MySqlDbType.VarChar, 0);
			MySqlParameter unit_classParameter = new MySqlParameter("@newunit_class", MySqlDbType.VarChar, 0);
			MySqlParameter unit_flagsParameter = new MySqlParameter("@newunit_flags", MySqlDbType.VarChar, 0);
			MySqlParameter unit_flags2Parameter = new MySqlParameter("@newunit_flags2", MySqlDbType.VarChar, 0);
			MySqlParameter dynamicflagsParameter = new MySqlParameter("@newdynamicflags", MySqlDbType.VarChar, 0);
			MySqlParameter familyParameter = new MySqlParameter("@newfamily", MySqlDbType.VarChar, 0);
			MySqlParameter trainer_typeParameter = new MySqlParameter("@newtrainer_type", MySqlDbType.VarChar, 0);
			MySqlParameter trainer_classParameter = new MySqlParameter("@newtrainer_class", MySqlDbType.VarChar, 0);
			MySqlParameter trainer_raceParameter = new MySqlParameter("@newtrainer_race", MySqlDbType.VarChar, 0);
			MySqlParameter typeParameter = new MySqlParameter("@newtype", MySqlDbType.VarChar, 0);
			MySqlParameter type_flagsParameter = new MySqlParameter("@newtype_flags", MySqlDbType.VarChar, 0);
			MySqlParameter type_flags2Parameter = new MySqlParameter("@newtype_flags2", MySqlDbType.VarChar, 0);
			MySqlParameter lootidParameter = new MySqlParameter("@newlootid", MySqlDbType.VarChar, 0);
			MySqlParameter pickpocketlootParameter = new MySqlParameter("@newpickpocketloot", MySqlDbType.VarChar, 0);
			MySqlParameter skinlootParameter = new MySqlParameter("@newskinloot", MySqlDbType.VarChar, 0);
			MySqlParameter resistance1Parameter = new MySqlParameter("@newresistance1", MySqlDbType.VarChar, 0);
			MySqlParameter resistance2Parameter = new MySqlParameter("@newresistance2", MySqlDbType.VarChar, 0);
			MySqlParameter resistance3Parameter = new MySqlParameter("@newresistance3", MySqlDbType.VarChar, 0);
			MySqlParameter resistance4Parameter = new MySqlParameter("@newresistance4", MySqlDbType.VarChar, 0);
			MySqlParameter resistance5Parameter = new MySqlParameter("@newresistance5", MySqlDbType.VarChar, 0);
			MySqlParameter resistance6Parameter = new MySqlParameter("@newresistance6", MySqlDbType.VarChar, 0);
			MySqlParameter spell1Parameter = new MySqlParameter("@newspell1", MySqlDbType.VarChar, 0);
			MySqlParameter spell2Parameter = new MySqlParameter("@newspell2", MySqlDbType.VarChar, 0);
			MySqlParameter spell3Parameter = new MySqlParameter("@newspell3", MySqlDbType.VarChar, 0);
			MySqlParameter spell4Parameter = new MySqlParameter("@newspell4", MySqlDbType.VarChar, 0);
			MySqlParameter spell5Parameter = new MySqlParameter("@newspell5", MySqlDbType.VarChar, 0);
			MySqlParameter spell6Parameter = new MySqlParameter("@newspell6", MySqlDbType.VarChar, 0);
			MySqlParameter spell7Parameter = new MySqlParameter("@newspell7", MySqlDbType.VarChar, 0);
			MySqlParameter spell8Parameter = new MySqlParameter("@newspell8", MySqlDbType.VarChar, 0);
			MySqlParameter vehicleidParameter = new MySqlParameter("@newVehicleId", MySqlDbType.VarChar, 0);
			MySqlParameter mingoldParameter = new MySqlParameter("@newmingold", MySqlDbType.VarChar, 0);
			MySqlParameter maxgoldParameter = new MySqlParameter("@newmaxgold", MySqlDbType.VarChar, 0);
			MySqlParameter ainameParameter = new MySqlParameter("@newAIName", MySqlDbType.VarChar, 0);
			MySqlParameter movementtypeParameter = new MySqlParameter("@newMovementType", MySqlDbType.VarChar, 0);
			MySqlParameter inhabittypeParameter = new MySqlParameter("@newInhabitType", MySqlDbType.VarChar, 0);
			MySqlParameter hoverheightParameter = new MySqlParameter("@newHoverHeight", MySqlDbType.VarChar, 0);
			MySqlParameter healthmodifierParameter = new MySqlParameter("@newHealthModifier", MySqlDbType.VarChar, 0);
			MySqlParameter healthmodifierextraParameter = new MySqlParameter("@newHealthModifierExtra", MySqlDbType.VarChar, 0);
			MySqlParameter manamodifierParameter = new MySqlParameter("@newManaModifier", MySqlDbType.VarChar, 0);
			MySqlParameter manamodifierextraParameter = new MySqlParameter("@newManaModifierExtra", MySqlDbType.VarChar, 0);
			MySqlParameter armormodifierParameter = new MySqlParameter("@newArmorModifier", MySqlDbType.VarChar, 0);
			MySqlParameter damagemodifierParameter = new MySqlParameter("@newDamageModifier", MySqlDbType.VarChar, 0);
			MySqlParameter experiencemodifierParameter = new MySqlParameter("@newExperienceModifier", MySqlDbType.VarChar, 0);
			MySqlParameter racialleaderParameter = new MySqlParameter("@newRacialLeader", MySqlDbType.VarChar, 0);
			MySqlParameter movementidParameter = new MySqlParameter("@newmovementId", MySqlDbType.VarChar, 0);
			MySqlParameter regenhealthParameter = new MySqlParameter("@newRegenHealth", MySqlDbType.VarChar, 0);
			MySqlParameter mechanic_immune_maskParameter = new MySqlParameter("@newmechanic_immune_mask", MySqlDbType.VarChar, 0);
			MySqlParameter flags_extraParameter = new MySqlParameter("@newflags_extra", MySqlDbType.VarChar, 0);
			MySqlParameter scriptnameParameter = new MySqlParameter("@newScriptName", MySqlDbType.VarChar, 0);
			MySqlParameter verifiedbuildParameter = new MySqlParameter("@newVerifiedBuild", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			difficulty_entry_1Parameter.Value = difficulty_entry_1;
			difficulty_entry_2Parameter.Value = difficulty_entry_2;
			difficulty_entry_3Parameter.Value = difficulty_entry_3;
			killcredit1Parameter.Value = KillCredit1;
			killcredit2Parameter.Value = KillCredit2;
			modelid1Parameter.Value = modelid1;
			modelid2Parameter.Value = modelid2;
			modelid3Parameter.Value = modelid3;
			modelid4Parameter.Value = modelid4;
			nameParameter.Value = name;
			femalenameParameter.Value = femaleName;
			subnameParameter.Value = subname;
			iconnameParameter.Value = IconName;
			gossip_menu_idParameter.Value = gossip_menu_id;
			minlevelParameter.Value = minlevel;
			maxlevelParameter.Value = maxlevel;
			expParameter.Value = exp;
			exp_unkParameter.Value = exp_unk;
			factionParameter.Value = faction;
			npcflagParameter.Value = npcflag;
			speed_walkParameter.Value = speed_walk;
			speed_runParameter.Value = speed_run;
			scaleParameter.Value = scale;
			rankParameter.Value = rank;
			dmgschoolParameter.Value = dmgschool;
			baseattacktimeParameter.Value = BaseAttackTime;
			rangeattacktimeParameter.Value = RangeAttackTime;
			basevarianceParameter.Value = BaseVariance;
			rangevarianceParameter.Value = RangeVariance;
			unit_classParameter.Value = unit_class;
			unit_flagsParameter.Value = unit_flags;
			unit_flags2Parameter.Value = unit_flags2;
			dynamicflagsParameter.Value = dynamicflags;
			familyParameter.Value = family;
			trainer_typeParameter.Value = trainer_type;
			trainer_classParameter.Value = trainer_class;
			trainer_raceParameter.Value = trainer_race;
			typeParameter.Value = type;
			type_flagsParameter.Value = type_flags;
			type_flags2Parameter.Value = type_flags2;
			lootidParameter.Value = lootid;
			pickpocketlootParameter.Value = pickpocketloot;
			skinlootParameter.Value = skinloot;
			resistance1Parameter.Value = resistance1;
			resistance2Parameter.Value = resistance2;
			resistance3Parameter.Value = resistance3;
			resistance4Parameter.Value = resistance4;
			resistance5Parameter.Value = resistance5;
			resistance6Parameter.Value = resistance6;
			spell1Parameter.Value = spell1;
			spell2Parameter.Value = spell2;
			spell3Parameter.Value = spell3;
			spell4Parameter.Value = spell4;
			spell5Parameter.Value = spell5;
			spell6Parameter.Value = spell6;
			spell7Parameter.Value = spell7;
			spell8Parameter.Value = spell8;
			vehicleidParameter.Value = VehicleId;
			mingoldParameter.Value = mingold;
			maxgoldParameter.Value = maxgold;
			ainameParameter.Value = AIName;
			movementtypeParameter.Value = MovementType;
			inhabittypeParameter.Value = InhabitType;
			hoverheightParameter.Value = HoverHeight;
			healthmodifierParameter.Value = HealthModifier;
			healthmodifierextraParameter.Value = HealthModifierExtra;
			manamodifierParameter.Value = ManaModifier;
			manamodifierextraParameter.Value = ManaModifierExtra;
			armormodifierParameter.Value = ArmorModifier;
			damagemodifierParameter.Value = DamageModifier;
			experiencemodifierParameter.Value = ExperienceModifier;
			racialleaderParameter.Value = RacialLeader;
			movementidParameter.Value = movementId;
			regenhealthParameter.Value = RegenHealth;
			mechanic_immune_maskParameter.Value = mechanic_immune_mask;
			flags_extraParameter.Value = flags_extra;
			scriptnameParameter.Value = ScriptName;
			verifiedbuildParameter.Value = VerifiedBuild;
			OLD_entryParameter.Value = OLD_entry;
			OLD_difficulty_entry_1Parameter.Value = OLD_difficulty_entry_1;
			OLD_difficulty_entry_2Parameter.Value = OLD_difficulty_entry_2;
			OLD_difficulty_entry_3Parameter.Value = OLD_difficulty_entry_3;
			OLD_killcredit1Parameter.Value = OLD_KillCredit1;
			OLD_killcredit2Parameter.Value = OLD_KillCredit2;
			OLD_modelid1Parameter.Value = OLD_modelid1;
			OLD_modelid2Parameter.Value = OLD_modelid2;
			OLD_modelid3Parameter.Value = OLD_modelid3;
			OLD_modelid4Parameter.Value = OLD_modelid4;
			OLD_nameParameter.Value = OLD_name;
			OLD_femalenameParameter.Value = OLD_femaleName;
			OLD_subnameParameter.Value = OLD_subname;
			OLD_iconnameParameter.Value = OLD_IconName;
			OLD_gossip_menu_idParameter.Value = OLD_gossip_menu_id;
			OLD_minlevelParameter.Value = OLD_minlevel;
			OLD_maxlevelParameter.Value = OLD_maxlevel;
			OLD_expParameter.Value = OLD_exp;
			OLD_exp_unkParameter.Value = OLD_exp_unk;
			OLD_factionParameter.Value = OLD_faction;
			OLD_npcflagParameter.Value = OLD_npcflag;
			OLD_speed_walkParameter.Value = OLD_speed_walk;
			OLD_speed_runParameter.Value = OLD_speed_run;
			OLD_scaleParameter.Value = OLD_scale;
			OLD_rankParameter.Value = OLD_rank;
			OLD_dmgschoolParameter.Value = OLD_dmgschool;
			OLD_baseattacktimeParameter.Value = OLD_BaseAttackTime;
			OLD_rangeattacktimeParameter.Value = OLD_RangeAttackTime;
			OLD_basevarianceParameter.Value = OLD_BaseVariance;
			OLD_rangevarianceParameter.Value = OLD_RangeVariance;
			OLD_unit_classParameter.Value = OLD_unit_class;
			OLD_unit_flagsParameter.Value = OLD_unit_flags;
			OLD_unit_flags2Parameter.Value = OLD_unit_flags2;
			OLD_dynamicflagsParameter.Value = OLD_dynamicflags;
			OLD_familyParameter.Value = OLD_family;
			OLD_trainer_typeParameter.Value = OLD_trainer_type;
			OLD_trainer_classParameter.Value = OLD_trainer_class;
			OLD_trainer_raceParameter.Value = OLD_trainer_race;
			OLD_typeParameter.Value = OLD_type;
			OLD_type_flagsParameter.Value = OLD_type_flags;
			OLD_type_flags2Parameter.Value = OLD_type_flags2;
			OLD_lootidParameter.Value = OLD_lootid;
			OLD_pickpocketlootParameter.Value = OLD_pickpocketloot;
			OLD_skinlootParameter.Value = OLD_skinloot;
			OLD_resistance1Parameter.Value = OLD_resistance1;
			OLD_resistance2Parameter.Value = OLD_resistance2;
			OLD_resistance3Parameter.Value = OLD_resistance3;
			OLD_resistance4Parameter.Value = OLD_resistance4;
			OLD_resistance5Parameter.Value = OLD_resistance5;
			OLD_resistance6Parameter.Value = OLD_resistance6;
			OLD_spell1Parameter.Value = OLD_spell1;
			OLD_spell2Parameter.Value = OLD_spell2;
			OLD_spell3Parameter.Value = OLD_spell3;
			OLD_spell4Parameter.Value = OLD_spell4;
			OLD_spell5Parameter.Value = OLD_spell5;
			OLD_spell6Parameter.Value = OLD_spell6;
			OLD_spell7Parameter.Value = OLD_spell7;
			OLD_spell8Parameter.Value = OLD_spell8;
			OLD_vehicleidParameter.Value = OLD_VehicleId;
			OLD_mingoldParameter.Value = OLD_mingold;
			OLD_maxgoldParameter.Value = OLD_maxgold;
			OLD_ainameParameter.Value = OLD_AIName;
			OLD_movementtypeParameter.Value = OLD_MovementType;
			OLD_inhabittypeParameter.Value = OLD_InhabitType;
			OLD_hoverheightParameter.Value = OLD_HoverHeight;
			OLD_healthmodifierParameter.Value = OLD_HealthModifier;
			OLD_healthmodifierextraParameter.Value = OLD_HealthModifierExtra;
			OLD_manamodifierParameter.Value = OLD_ManaModifier;
			OLD_manamodifierextraParameter.Value = OLD_ManaModifierExtra;
			OLD_armormodifierParameter.Value = OLD_ArmorModifier;
			OLD_damagemodifierParameter.Value = OLD_DamageModifier;
			OLD_experiencemodifierParameter.Value = OLD_ExperienceModifier;
			OLD_racialleaderParameter.Value = OLD_RacialLeader;
			OLD_movementidParameter.Value = OLD_movementId;
			OLD_regenhealthParameter.Value = OLD_RegenHealth;
			OLD_mechanic_immune_maskParameter.Value = OLD_mechanic_immune_mask;
			OLD_flags_extraParameter.Value = OLD_flags_extra;
			OLD_scriptnameParameter.Value = OLD_ScriptName;
			OLD_verifiedbuildParameter.Value = OLD_VerifiedBuild;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(difficulty_entry_1Parameter);
			cmd.Parameters.Add(difficulty_entry_2Parameter);
			cmd.Parameters.Add(difficulty_entry_3Parameter);
			cmd.Parameters.Add(killcredit1Parameter);
			cmd.Parameters.Add(killcredit2Parameter);
			cmd.Parameters.Add(modelid1Parameter);
			cmd.Parameters.Add(modelid2Parameter);
			cmd.Parameters.Add(modelid3Parameter);
			cmd.Parameters.Add(modelid4Parameter);
			cmd.Parameters.Add(nameParameter);
			cmd.Parameters.Add(femalenameParameter);
			cmd.Parameters.Add(subnameParameter);
			cmd.Parameters.Add(iconnameParameter);
			cmd.Parameters.Add(gossip_menu_idParameter);
			cmd.Parameters.Add(minlevelParameter);
			cmd.Parameters.Add(maxlevelParameter);
			cmd.Parameters.Add(expParameter);
			cmd.Parameters.Add(exp_unkParameter);
			cmd.Parameters.Add(factionParameter);
			cmd.Parameters.Add(npcflagParameter);
			cmd.Parameters.Add(speed_walkParameter);
			cmd.Parameters.Add(speed_runParameter);
			cmd.Parameters.Add(scaleParameter);
			cmd.Parameters.Add(rankParameter);
			cmd.Parameters.Add(dmgschoolParameter);
			cmd.Parameters.Add(baseattacktimeParameter);
			cmd.Parameters.Add(rangeattacktimeParameter);
			cmd.Parameters.Add(basevarianceParameter);
			cmd.Parameters.Add(rangevarianceParameter);
			cmd.Parameters.Add(unit_classParameter);
			cmd.Parameters.Add(unit_flagsParameter);
			cmd.Parameters.Add(unit_flags2Parameter);
			cmd.Parameters.Add(dynamicflagsParameter);
			cmd.Parameters.Add(familyParameter);
			cmd.Parameters.Add(trainer_typeParameter);
			cmd.Parameters.Add(trainer_classParameter);
			cmd.Parameters.Add(trainer_raceParameter);
			cmd.Parameters.Add(typeParameter);
			cmd.Parameters.Add(type_flagsParameter);
			cmd.Parameters.Add(type_flags2Parameter);
			cmd.Parameters.Add(lootidParameter);
			cmd.Parameters.Add(pickpocketlootParameter);
			cmd.Parameters.Add(skinlootParameter);
			cmd.Parameters.Add(resistance1Parameter);
			cmd.Parameters.Add(resistance2Parameter);
			cmd.Parameters.Add(resistance3Parameter);
			cmd.Parameters.Add(resistance4Parameter);
			cmd.Parameters.Add(resistance5Parameter);
			cmd.Parameters.Add(resistance6Parameter);
			cmd.Parameters.Add(spell1Parameter);
			cmd.Parameters.Add(spell2Parameter);
			cmd.Parameters.Add(spell3Parameter);
			cmd.Parameters.Add(spell4Parameter);
			cmd.Parameters.Add(spell5Parameter);
			cmd.Parameters.Add(spell6Parameter);
			cmd.Parameters.Add(spell7Parameter);
			cmd.Parameters.Add(spell8Parameter);
			cmd.Parameters.Add(vehicleidParameter);
			cmd.Parameters.Add(mingoldParameter);
			cmd.Parameters.Add(maxgoldParameter);
			cmd.Parameters.Add(ainameParameter);
			cmd.Parameters.Add(movementtypeParameter);
			cmd.Parameters.Add(inhabittypeParameter);
			cmd.Parameters.Add(hoverheightParameter);
			cmd.Parameters.Add(healthmodifierParameter);
			cmd.Parameters.Add(healthmodifierextraParameter);
			cmd.Parameters.Add(manamodifierParameter);
			cmd.Parameters.Add(manamodifierextraParameter);
			cmd.Parameters.Add(armormodifierParameter);
			cmd.Parameters.Add(damagemodifierParameter);
			cmd.Parameters.Add(experiencemodifierParameter);
			cmd.Parameters.Add(racialleaderParameter);
			cmd.Parameters.Add(movementidParameter);
			cmd.Parameters.Add(regenhealthParameter);
			cmd.Parameters.Add(mechanic_immune_maskParameter);
			cmd.Parameters.Add(flags_extraParameter);
			cmd.Parameters.Add(scriptnameParameter);
			cmd.Parameters.Add(verifiedbuildParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_difficulty_entry_1Parameter);
			cmd.Parameters.Add(OLD_difficulty_entry_2Parameter);
			cmd.Parameters.Add(OLD_difficulty_entry_3Parameter);
			cmd.Parameters.Add(OLD_killcredit1Parameter);
			cmd.Parameters.Add(OLD_killcredit2Parameter);
			cmd.Parameters.Add(OLD_modelid1Parameter);
			cmd.Parameters.Add(OLD_modelid2Parameter);
			cmd.Parameters.Add(OLD_modelid3Parameter);
			cmd.Parameters.Add(OLD_modelid4Parameter);
			cmd.Parameters.Add(OLD_nameParameter);
			cmd.Parameters.Add(OLD_femalenameParameter);
			cmd.Parameters.Add(OLD_subnameParameter);
			cmd.Parameters.Add(OLD_iconnameParameter);
			cmd.Parameters.Add(OLD_gossip_menu_idParameter);
			cmd.Parameters.Add(OLD_minlevelParameter);
			cmd.Parameters.Add(OLD_maxlevelParameter);
			cmd.Parameters.Add(OLD_expParameter);
			cmd.Parameters.Add(OLD_exp_unkParameter);
			cmd.Parameters.Add(OLD_factionParameter);
			cmd.Parameters.Add(OLD_npcflagParameter);
			cmd.Parameters.Add(OLD_speed_walkParameter);
			cmd.Parameters.Add(OLD_speed_runParameter);
			cmd.Parameters.Add(OLD_scaleParameter);
			cmd.Parameters.Add(OLD_rankParameter);
			cmd.Parameters.Add(OLD_dmgschoolParameter);
			cmd.Parameters.Add(OLD_baseattacktimeParameter);
			cmd.Parameters.Add(OLD_rangeattacktimeParameter);
			cmd.Parameters.Add(OLD_basevarianceParameter);
			cmd.Parameters.Add(OLD_rangevarianceParameter);
			cmd.Parameters.Add(OLD_unit_classParameter);
			cmd.Parameters.Add(OLD_unit_flagsParameter);
			cmd.Parameters.Add(OLD_unit_flags2Parameter);
			cmd.Parameters.Add(OLD_dynamicflagsParameter);
			cmd.Parameters.Add(OLD_familyParameter);
			cmd.Parameters.Add(OLD_trainer_typeParameter);
			cmd.Parameters.Add(OLD_trainer_classParameter);
			cmd.Parameters.Add(OLD_trainer_raceParameter);
			cmd.Parameters.Add(OLD_typeParameter);
			cmd.Parameters.Add(OLD_type_flagsParameter);
			cmd.Parameters.Add(OLD_type_flags2Parameter);
			cmd.Parameters.Add(OLD_lootidParameter);
			cmd.Parameters.Add(OLD_pickpocketlootParameter);
			cmd.Parameters.Add(OLD_skinlootParameter);
			cmd.Parameters.Add(OLD_resistance1Parameter);
			cmd.Parameters.Add(OLD_resistance2Parameter);
			cmd.Parameters.Add(OLD_resistance3Parameter);
			cmd.Parameters.Add(OLD_resistance4Parameter);
			cmd.Parameters.Add(OLD_resistance5Parameter);
			cmd.Parameters.Add(OLD_resistance6Parameter);
			cmd.Parameters.Add(OLD_spell1Parameter);
			cmd.Parameters.Add(OLD_spell2Parameter);
			cmd.Parameters.Add(OLD_spell3Parameter);
			cmd.Parameters.Add(OLD_spell4Parameter);
			cmd.Parameters.Add(OLD_spell5Parameter);
			cmd.Parameters.Add(OLD_spell6Parameter);
			cmd.Parameters.Add(OLD_spell7Parameter);
			cmd.Parameters.Add(OLD_spell8Parameter);
			cmd.Parameters.Add(OLD_vehicleidParameter);
			cmd.Parameters.Add(OLD_mingoldParameter);
			cmd.Parameters.Add(OLD_maxgoldParameter);
			cmd.Parameters.Add(OLD_ainameParameter);
			cmd.Parameters.Add(OLD_movementtypeParameter);
			cmd.Parameters.Add(OLD_inhabittypeParameter);
			cmd.Parameters.Add(OLD_hoverheightParameter);
			cmd.Parameters.Add(OLD_healthmodifierParameter);
			cmd.Parameters.Add(OLD_healthmodifierextraParameter);
			cmd.Parameters.Add(OLD_manamodifierParameter);
			cmd.Parameters.Add(OLD_manamodifierextraParameter);
			cmd.Parameters.Add(OLD_armormodifierParameter);
			cmd.Parameters.Add(OLD_damagemodifierParameter);
			cmd.Parameters.Add(OLD_experiencemodifierParameter);
			cmd.Parameters.Add(OLD_racialleaderParameter);
			cmd.Parameters.Add(OLD_movementidParameter);
			cmd.Parameters.Add(OLD_regenhealthParameter);
			cmd.Parameters.Add(OLD_mechanic_immune_maskParameter);
			cmd.Parameters.Add(OLD_flags_extraParameter);
			cmd.Parameters.Add(OLD_scriptnameParameter);
			cmd.Parameters.Add(OLD_verifiedbuildParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_difficulty_entry_1 = difficulty_entry_1;
			OLD_difficulty_entry_2 = difficulty_entry_2;
			OLD_difficulty_entry_3 = difficulty_entry_3;
			OLD_KillCredit1 = KillCredit1;
			OLD_KillCredit2 = KillCredit2;
			OLD_modelid1 = modelid1;
			OLD_modelid2 = modelid2;
			OLD_modelid3 = modelid3;
			OLD_modelid4 = modelid4;
			OLD_name = name;
			OLD_femaleName = femaleName;
			OLD_subname = subname;
			OLD_IconName = IconName;
			OLD_gossip_menu_id = gossip_menu_id;
			OLD_minlevel = minlevel;
			OLD_maxlevel = maxlevel;
			OLD_exp = exp;
			OLD_exp_unk = exp_unk;
			OLD_faction = faction;
			OLD_npcflag = npcflag;
			OLD_speed_walk = speed_walk;
			OLD_speed_run = speed_run;
			OLD_scale = scale;
			OLD_rank = rank;
			OLD_dmgschool = dmgschool;
			OLD_BaseAttackTime = BaseAttackTime;
			OLD_RangeAttackTime = RangeAttackTime;
			OLD_BaseVariance = BaseVariance;
			OLD_RangeVariance = RangeVariance;
			OLD_unit_class = unit_class;
			OLD_unit_flags = unit_flags;
			OLD_unit_flags2 = unit_flags2;
			OLD_dynamicflags = dynamicflags;
			OLD_family = family;
			OLD_trainer_type = trainer_type;
			OLD_trainer_class = trainer_class;
			OLD_trainer_race = trainer_race;
			OLD_type = type;
			OLD_type_flags = type_flags;
			OLD_type_flags2 = type_flags2;
			OLD_lootid = lootid;
			OLD_pickpocketloot = pickpocketloot;
			OLD_skinloot = skinloot;
			OLD_resistance1 = resistance1;
			OLD_resistance2 = resistance2;
			OLD_resistance3 = resistance3;
			OLD_resistance4 = resistance4;
			OLD_resistance5 = resistance5;
			OLD_resistance6 = resistance6;
			OLD_spell1 = spell1;
			OLD_spell2 = spell2;
			OLD_spell3 = spell3;
			OLD_spell4 = spell4;
			OLD_spell5 = spell5;
			OLD_spell6 = spell6;
			OLD_spell7 = spell7;
			OLD_spell8 = spell8;
			OLD_VehicleId = VehicleId;
			OLD_mingold = mingold;
			OLD_maxgold = maxgold;
			OLD_AIName = AIName;
			OLD_MovementType = MovementType;
			OLD_InhabitType = InhabitType;
			OLD_HoverHeight = HoverHeight;
			OLD_HealthModifier = HealthModifier;
			OLD_HealthModifierExtra = HealthModifierExtra;
			OLD_ManaModifier = ManaModifier;
			OLD_ManaModifierExtra = ManaModifierExtra;
			OLD_ArmorModifier = ArmorModifier;
			OLD_DamageModifier = DamageModifier;
			OLD_ExperienceModifier = ExperienceModifier;
			OLD_RacialLeader = RacialLeader;
			OLD_movementId = movementId;
			OLD_RegenHealth = RegenHealth;
			OLD_mechanic_immune_mask = mechanic_immune_mask;
			OLD_flags_extra = flags_extra;
			OLD_ScriptName = ScriptName;
			OLD_VerifiedBuild = VerifiedBuild;
		}
	}
}
