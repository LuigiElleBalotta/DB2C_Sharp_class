using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Skill_extra_item_template
	{
		int spellId = 0; //Comment: SpellId of the item creation spell
		int OLD_spellId = 0;

		int requiredSpecialization = 0; //Comment: Specialization spell id
		int OLD_requiredSpecialization = 0;

		float additionalCreateChance = 0f; //Comment: chance to create add
		float OLD_additionalCreateChance = 0f;

		int additionalMaxNum = 0; //Comment: max num of adds
		int OLD_additionalMaxNum = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Skill_extra_item_template(int _spellId, int _requiredSpecialization, float _additionalCreateChance, int _additionalMaxNum)
		{
			spellId = _spellId;
			requiredSpecialization = _requiredSpecialization;
			additionalCreateChance = _additionalCreateChance;
			additionalMaxNum = _additionalMaxNum;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM skill_extra_item_template WHERE spellId = @spellId AND requiredSpecialization = @requiredSpecialization AND additionalCreateChance = @additionalCreateChance AND additionalMaxNum = @additionalMaxNum;";
			MySqlParameter spellidParameter = new MySqlParameter("@spellId", MySqlDbType.VarChar, 0);
			MySqlParameter requiredspecializationParameter = new MySqlParameter("@requiredSpecialization", MySqlDbType.VarChar, 0);
			MySqlParameter additionalcreatechanceParameter = new MySqlParameter("@additionalCreateChance", MySqlDbType.VarChar, 0);
			MySqlParameter additionalmaxnumParameter = new MySqlParameter("@additionalMaxNum", MySqlDbType.VarChar, 0);
			spellidParameter.Value = spellId;
			requiredspecializationParameter.Value = requiredSpecialization;
			additionalcreatechanceParameter.Value = additionalCreateChance;
			additionalmaxnumParameter.Value = additionalMaxNum;
			cmd.Parameters.Add(spellidParameter);
			cmd.Parameters.Add(requiredspecializationParameter);
			cmd.Parameters.Add(additionalcreatechanceParameter);
			cmd.Parameters.Add(additionalmaxnumParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE skill_extra_item_template SET spellId = @newspellId, requiredSpecialization = @newrequiredSpecialization, additionalCreateChance = @newadditionalCreateChance, additionalMaxNum = @newadditionalMaxNum WHERE spellId = @spellId AND requiredSpecialization = @requiredSpecialization AND additionalCreateChance = @additionalCreateChance AND additionalMaxNum = @additionalMaxNum;";
			MySqlParameter OLD_spellidParameter = new MySqlParameter("@spellId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_requiredspecializationParameter = new MySqlParameter("@requiredSpecialization", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_additionalcreatechanceParameter = new MySqlParameter("@additionalCreateChance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_additionalmaxnumParameter = new MySqlParameter("@additionalMaxNum", MySqlDbType.VarChar, 0);
			MySqlParameter spellidParameter = new MySqlParameter("@newspellId", MySqlDbType.VarChar, 0);
			MySqlParameter requiredspecializationParameter = new MySqlParameter("@newrequiredSpecialization", MySqlDbType.VarChar, 0);
			MySqlParameter additionalcreatechanceParameter = new MySqlParameter("@newadditionalCreateChance", MySqlDbType.VarChar, 0);
			MySqlParameter additionalmaxnumParameter = new MySqlParameter("@newadditionalMaxNum", MySqlDbType.VarChar, 0);
			spellidParameter.Value = spellId;
			requiredspecializationParameter.Value = requiredSpecialization;
			additionalcreatechanceParameter.Value = additionalCreateChance;
			additionalmaxnumParameter.Value = additionalMaxNum;
			OLD_spellidParameter.Value = OLD_spellId;
			OLD_requiredspecializationParameter.Value = OLD_requiredSpecialization;
			OLD_additionalcreatechanceParameter.Value = OLD_additionalCreateChance;
			OLD_additionalmaxnumParameter.Value = OLD_additionalMaxNum;
			cmd.Parameters.Add(spellidParameter);
			cmd.Parameters.Add(requiredspecializationParameter);
			cmd.Parameters.Add(additionalcreatechanceParameter);
			cmd.Parameters.Add(additionalmaxnumParameter);
			cmd.Parameters.Add(OLD_spellidParameter);
			cmd.Parameters.Add(OLD_requiredspecializationParameter);
			cmd.Parameters.Add(OLD_additionalcreatechanceParameter);
			cmd.Parameters.Add(OLD_additionalmaxnumParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_spellId = spellId;
			OLD_requiredSpecialization = requiredSpecialization;
			OLD_additionalCreateChance = additionalCreateChance;
			OLD_additionalMaxNum = additionalMaxNum;
		}
	}
}
