using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Skill_discovery_template
	{
		int spellId = 0; //Comment: SpellId of the discoverable spell
		int OLD_spellId = 0;

		int reqSpell = 0; //Comment: spell requirement
		int OLD_reqSpell = 0;

		int reqSkillValue = 0; //Comment: skill points requirement
		int OLD_reqSkillValue = 0;

		float chance = 0f; //Comment: chance to discover
		float OLD_chance = 0f;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Skill_discovery_template(int _spellId, int _reqSpell, int _reqSkillValue, float _chance)
		{
			spellId = _spellId;
			reqSpell = _reqSpell;
			reqSkillValue = _reqSkillValue;
			chance = _chance;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM skill_discovery_template WHERE spellId = @spellId AND reqSpell = @reqSpell AND reqSkillValue = @reqSkillValue AND chance = @chance;";
			MySqlParameter spellidParameter = new MySqlParameter("@spellId", MySqlDbType.VarChar, 0);
			MySqlParameter reqspellParameter = new MySqlParameter("@reqSpell", MySqlDbType.VarChar, 0);
			MySqlParameter reqskillvalueParameter = new MySqlParameter("@reqSkillValue", MySqlDbType.VarChar, 0);
			MySqlParameter chanceParameter = new MySqlParameter("@chance", MySqlDbType.VarChar, 0);
			spellidParameter.Value = spellId;
			reqspellParameter.Value = reqSpell;
			reqskillvalueParameter.Value = reqSkillValue;
			chanceParameter.Value = chance;
			cmd.Parameters.Add(spellidParameter);
			cmd.Parameters.Add(reqspellParameter);
			cmd.Parameters.Add(reqskillvalueParameter);
			cmd.Parameters.Add(chanceParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE skill_discovery_template SET spellId = @newspellId, reqSpell = @newreqSpell, reqSkillValue = @newreqSkillValue, chance = @newchance WHERE spellId = @spellId AND reqSpell = @reqSpell AND reqSkillValue = @reqSkillValue AND chance = @chance;";
			MySqlParameter OLD_spellidParameter = new MySqlParameter("@spellId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_reqspellParameter = new MySqlParameter("@reqSpell", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_reqskillvalueParameter = new MySqlParameter("@reqSkillValue", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_chanceParameter = new MySqlParameter("@chance", MySqlDbType.VarChar, 0);
			MySqlParameter spellidParameter = new MySqlParameter("@newspellId", MySqlDbType.VarChar, 0);
			MySqlParameter reqspellParameter = new MySqlParameter("@newreqSpell", MySqlDbType.VarChar, 0);
			MySqlParameter reqskillvalueParameter = new MySqlParameter("@newreqSkillValue", MySqlDbType.VarChar, 0);
			MySqlParameter chanceParameter = new MySqlParameter("@newchance", MySqlDbType.VarChar, 0);
			spellidParameter.Value = spellId;
			reqspellParameter.Value = reqSpell;
			reqskillvalueParameter.Value = reqSkillValue;
			chanceParameter.Value = chance;
			OLD_spellidParameter.Value = OLD_spellId;
			OLD_reqspellParameter.Value = OLD_reqSpell;
			OLD_reqskillvalueParameter.Value = OLD_reqSkillValue;
			OLD_chanceParameter.Value = OLD_chance;
			cmd.Parameters.Add(spellidParameter);
			cmd.Parameters.Add(reqspellParameter);
			cmd.Parameters.Add(reqskillvalueParameter);
			cmd.Parameters.Add(chanceParameter);
			cmd.Parameters.Add(OLD_spellidParameter);
			cmd.Parameters.Add(OLD_reqspellParameter);
			cmd.Parameters.Add(OLD_reqskillvalueParameter);
			cmd.Parameters.Add(OLD_chanceParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_spellId = spellId;
			OLD_reqSpell = reqSpell;
			OLD_reqSkillValue = reqSkillValue;
			OLD_chance = chance;
		}
	}
}
