using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Spell_proc_event
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int SchoolMask = 0; //Comment: 
		int OLD_SchoolMask = 0;

		int SpellFamilyName = 0; //Comment: 
		int OLD_SpellFamilyName = 0;

		int SpellFamilyMask0 = 0; //Comment: 
		int OLD_SpellFamilyMask0 = 0;

		int SpellFamilyMask1 = 0; //Comment: 
		int OLD_SpellFamilyMask1 = 0;

		int SpellFamilyMask2 = 0; //Comment: 
		int OLD_SpellFamilyMask2 = 0;

		int spellFamilyMask3 = 0; //Comment: 
		int OLD_spellFamilyMask3 = 0;

		int procFlags = 0; //Comment: 
		int OLD_procFlags = 0;

		int procEx = 0; //Comment: 
		int OLD_procEx = 0;

		float ppmRate = 0f; //Comment: 
		float OLD_ppmRate = 0f;

		float CustomChance = 0f; //Comment: 
		float OLD_CustomChance = 0f;

		int Cooldown = 0; //Comment: 
		int OLD_Cooldown = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Spell_proc_event(int _entry, int _SchoolMask, int _SpellFamilyName, int _SpellFamilyMask0, int _SpellFamilyMask1, int _SpellFamilyMask2, int _spellFamilyMask3, int _procFlags, int _procEx, float _ppmRate, float _CustomChance, int _Cooldown)
		{
			entry = _entry;
			SchoolMask = _SchoolMask;
			SpellFamilyName = _SpellFamilyName;
			SpellFamilyMask0 = _SpellFamilyMask0;
			SpellFamilyMask1 = _SpellFamilyMask1;
			SpellFamilyMask2 = _SpellFamilyMask2;
			spellFamilyMask3 = _spellFamilyMask3;
			procFlags = _procFlags;
			procEx = _procEx;
			ppmRate = _ppmRate;
			CustomChance = _CustomChance;
			Cooldown = _Cooldown;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM spell_proc_event WHERE entry = @entry AND SchoolMask = @SchoolMask AND SpellFamilyName = @SpellFamilyName AND SpellFamilyMask0 = @SpellFamilyMask0 AND SpellFamilyMask1 = @SpellFamilyMask1 AND SpellFamilyMask2 = @SpellFamilyMask2 AND spellFamilyMask3 = @spellFamilyMask3 AND procFlags = @procFlags AND procEx = @procEx AND ppmRate = @ppmRate AND CustomChance = @CustomChance AND Cooldown = @Cooldown;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter schoolmaskParameter = new MySqlParameter("@SchoolMask", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilynameParameter = new MySqlParameter("@SpellFamilyName", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask0Parameter = new MySqlParameter("@SpellFamilyMask0", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask1Parameter = new MySqlParameter("@SpellFamilyMask1", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask2Parameter = new MySqlParameter("@SpellFamilyMask2", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask3Parameter = new MySqlParameter("@spellFamilyMask3", MySqlDbType.VarChar, 0);
			MySqlParameter procflagsParameter = new MySqlParameter("@procFlags", MySqlDbType.VarChar, 0);
			MySqlParameter procexParameter = new MySqlParameter("@procEx", MySqlDbType.VarChar, 0);
			MySqlParameter ppmrateParameter = new MySqlParameter("@ppmRate", MySqlDbType.VarChar, 0);
			MySqlParameter customchanceParameter = new MySqlParameter("@CustomChance", MySqlDbType.VarChar, 0);
			MySqlParameter cooldownParameter = new MySqlParameter("@Cooldown", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			schoolmaskParameter.Value = SchoolMask;
			spellfamilynameParameter.Value = SpellFamilyName;
			spellfamilymask0Parameter.Value = SpellFamilyMask0;
			spellfamilymask1Parameter.Value = SpellFamilyMask1;
			spellfamilymask2Parameter.Value = SpellFamilyMask2;
			spellfamilymask3Parameter.Value = spellFamilyMask3;
			procflagsParameter.Value = procFlags;
			procexParameter.Value = procEx;
			ppmrateParameter.Value = ppmRate;
			customchanceParameter.Value = CustomChance;
			cooldownParameter.Value = Cooldown;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(schoolmaskParameter);
			cmd.Parameters.Add(spellfamilynameParameter);
			cmd.Parameters.Add(spellfamilymask0Parameter);
			cmd.Parameters.Add(spellfamilymask1Parameter);
			cmd.Parameters.Add(spellfamilymask2Parameter);
			cmd.Parameters.Add(spellfamilymask3Parameter);
			cmd.Parameters.Add(procflagsParameter);
			cmd.Parameters.Add(procexParameter);
			cmd.Parameters.Add(ppmrateParameter);
			cmd.Parameters.Add(customchanceParameter);
			cmd.Parameters.Add(cooldownParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE spell_proc_event SET entry = @newentry, SchoolMask = @newSchoolMask, SpellFamilyName = @newSpellFamilyName, SpellFamilyMask0 = @newSpellFamilyMask0, SpellFamilyMask1 = @newSpellFamilyMask1, SpellFamilyMask2 = @newSpellFamilyMask2, spellFamilyMask3 = @newspellFamilyMask3, procFlags = @newprocFlags, procEx = @newprocEx, ppmRate = @newppmRate, CustomChance = @newCustomChance, Cooldown = @newCooldown WHERE entry = @entry AND SchoolMask = @SchoolMask AND SpellFamilyName = @SpellFamilyName AND SpellFamilyMask0 = @SpellFamilyMask0 AND SpellFamilyMask1 = @SpellFamilyMask1 AND SpellFamilyMask2 = @SpellFamilyMask2 AND spellFamilyMask3 = @spellFamilyMask3 AND procFlags = @procFlags AND procEx = @procEx AND ppmRate = @ppmRate AND CustomChance = @CustomChance AND Cooldown = @Cooldown;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_schoolmaskParameter = new MySqlParameter("@SchoolMask", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellfamilynameParameter = new MySqlParameter("@SpellFamilyName", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellfamilymask0Parameter = new MySqlParameter("@SpellFamilyMask0", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellfamilymask1Parameter = new MySqlParameter("@SpellFamilyMask1", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellfamilymask2Parameter = new MySqlParameter("@SpellFamilyMask2", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_spellfamilymask3Parameter = new MySqlParameter("@spellFamilyMask3", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_procflagsParameter = new MySqlParameter("@procFlags", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_procexParameter = new MySqlParameter("@procEx", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_ppmrateParameter = new MySqlParameter("@ppmRate", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_customchanceParameter = new MySqlParameter("@CustomChance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_cooldownParameter = new MySqlParameter("@Cooldown", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter schoolmaskParameter = new MySqlParameter("@newSchoolMask", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilynameParameter = new MySqlParameter("@newSpellFamilyName", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask0Parameter = new MySqlParameter("@newSpellFamilyMask0", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask1Parameter = new MySqlParameter("@newSpellFamilyMask1", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask2Parameter = new MySqlParameter("@newSpellFamilyMask2", MySqlDbType.VarChar, 0);
			MySqlParameter spellfamilymask3Parameter = new MySqlParameter("@newspellFamilyMask3", MySqlDbType.VarChar, 0);
			MySqlParameter procflagsParameter = new MySqlParameter("@newprocFlags", MySqlDbType.VarChar, 0);
			MySqlParameter procexParameter = new MySqlParameter("@newprocEx", MySqlDbType.VarChar, 0);
			MySqlParameter ppmrateParameter = new MySqlParameter("@newppmRate", MySqlDbType.VarChar, 0);
			MySqlParameter customchanceParameter = new MySqlParameter("@newCustomChance", MySqlDbType.VarChar, 0);
			MySqlParameter cooldownParameter = new MySqlParameter("@newCooldown", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			schoolmaskParameter.Value = SchoolMask;
			spellfamilynameParameter.Value = SpellFamilyName;
			spellfamilymask0Parameter.Value = SpellFamilyMask0;
			spellfamilymask1Parameter.Value = SpellFamilyMask1;
			spellfamilymask2Parameter.Value = SpellFamilyMask2;
			spellfamilymask3Parameter.Value = spellFamilyMask3;
			procflagsParameter.Value = procFlags;
			procexParameter.Value = procEx;
			ppmrateParameter.Value = ppmRate;
			customchanceParameter.Value = CustomChance;
			cooldownParameter.Value = Cooldown;
			OLD_entryParameter.Value = OLD_entry;
			OLD_schoolmaskParameter.Value = OLD_SchoolMask;
			OLD_spellfamilynameParameter.Value = OLD_SpellFamilyName;
			OLD_spellfamilymask0Parameter.Value = OLD_SpellFamilyMask0;
			OLD_spellfamilymask1Parameter.Value = OLD_SpellFamilyMask1;
			OLD_spellfamilymask2Parameter.Value = OLD_SpellFamilyMask2;
			OLD_spellfamilymask3Parameter.Value = OLD_spellFamilyMask3;
			OLD_procflagsParameter.Value = OLD_procFlags;
			OLD_procexParameter.Value = OLD_procEx;
			OLD_ppmrateParameter.Value = OLD_ppmRate;
			OLD_customchanceParameter.Value = OLD_CustomChance;
			OLD_cooldownParameter.Value = OLD_Cooldown;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(schoolmaskParameter);
			cmd.Parameters.Add(spellfamilynameParameter);
			cmd.Parameters.Add(spellfamilymask0Parameter);
			cmd.Parameters.Add(spellfamilymask1Parameter);
			cmd.Parameters.Add(spellfamilymask2Parameter);
			cmd.Parameters.Add(spellfamilymask3Parameter);
			cmd.Parameters.Add(procflagsParameter);
			cmd.Parameters.Add(procexParameter);
			cmd.Parameters.Add(ppmrateParameter);
			cmd.Parameters.Add(customchanceParameter);
			cmd.Parameters.Add(cooldownParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_schoolmaskParameter);
			cmd.Parameters.Add(OLD_spellfamilynameParameter);
			cmd.Parameters.Add(OLD_spellfamilymask0Parameter);
			cmd.Parameters.Add(OLD_spellfamilymask1Parameter);
			cmd.Parameters.Add(OLD_spellfamilymask2Parameter);
			cmd.Parameters.Add(OLD_spellfamilymask3Parameter);
			cmd.Parameters.Add(OLD_procflagsParameter);
			cmd.Parameters.Add(OLD_procexParameter);
			cmd.Parameters.Add(OLD_ppmrateParameter);
			cmd.Parameters.Add(OLD_customchanceParameter);
			cmd.Parameters.Add(OLD_cooldownParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_SchoolMask = SchoolMask;
			OLD_SpellFamilyName = SpellFamilyName;
			OLD_SpellFamilyMask0 = SpellFamilyMask0;
			OLD_SpellFamilyMask1 = SpellFamilyMask1;
			OLD_SpellFamilyMask2 = SpellFamilyMask2;
			OLD_spellFamilyMask3 = spellFamilyMask3;
			OLD_procFlags = procFlags;
			OLD_procEx = procEx;
			OLD_ppmRate = ppmRate;
			OLD_CustomChance = CustomChance;
			OLD_Cooldown = Cooldown;
		}
	}
}
