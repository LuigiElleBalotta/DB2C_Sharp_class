using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Skill_perfect_item_template
	{
		int spellId = 0; //Comment: SpellId of the item creation spell
		int OLD_spellId = 0;

		int requiredSpecialization = 0; //Comment: Specialization spell id
		int OLD_requiredSpecialization = 0;

		float perfectCreateChance = 0f; //Comment: chance to create the perfect item instead
		float OLD_perfectCreateChance = 0f;

		int perfectItemType = 0; //Comment: perfect item type to create instead
		int OLD_perfectItemType = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Skill_perfect_item_template(int _spellId, int _requiredSpecialization, float _perfectCreateChance, int _perfectItemType)
		{
			spellId = _spellId;
			requiredSpecialization = _requiredSpecialization;
			perfectCreateChance = _perfectCreateChance;
			perfectItemType = _perfectItemType;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM skill_perfect_item_template WHERE spellId = @spellId AND requiredSpecialization = @requiredSpecialization AND perfectCreateChance = @perfectCreateChance AND perfectItemType = @perfectItemType;";
			MySqlParameter spellidParameter = new MySqlParameter("@spellId", MySqlDbType.VarChar, 0);
			MySqlParameter requiredspecializationParameter = new MySqlParameter("@requiredSpecialization", MySqlDbType.VarChar, 0);
			MySqlParameter perfectcreatechanceParameter = new MySqlParameter("@perfectCreateChance", MySqlDbType.VarChar, 0);
			MySqlParameter perfectitemtypeParameter = new MySqlParameter("@perfectItemType", MySqlDbType.VarChar, 0);
			spellidParameter.Value = spellId;
			requiredspecializationParameter.Value = requiredSpecialization;
			perfectcreatechanceParameter.Value = perfectCreateChance;
			perfectitemtypeParameter.Value = perfectItemType;
			cmd.Parameters.Add(spellidParameter);
			cmd.Parameters.Add(requiredspecializationParameter);
			cmd.Parameters.Add(perfectcreatechanceParameter);
			cmd.Parameters.Add(perfectitemtypeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE skill_perfect_item_template SET spellId = @newspellId, requiredSpecialization = @newrequiredSpecialization, perfectCreateChance = @newperfectCreateChance, perfectItemType = @newperfectItemType WHERE spellId = @spellId AND requiredSpecialization = @requiredSpecialization AND perfectCreateChance = @perfectCreateChance AND perfectItemType = @perfectItemType;";
			MySqlParameter OLD_spellidParameter = new MySqlParameter("@spellId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_requiredspecializationParameter = new MySqlParameter("@requiredSpecialization", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_perfectcreatechanceParameter = new MySqlParameter("@perfectCreateChance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_perfectitemtypeParameter = new MySqlParameter("@perfectItemType", MySqlDbType.VarChar, 0);
			MySqlParameter spellidParameter = new MySqlParameter("@newspellId", MySqlDbType.VarChar, 0);
			MySqlParameter requiredspecializationParameter = new MySqlParameter("@newrequiredSpecialization", MySqlDbType.VarChar, 0);
			MySqlParameter perfectcreatechanceParameter = new MySqlParameter("@newperfectCreateChance", MySqlDbType.VarChar, 0);
			MySqlParameter perfectitemtypeParameter = new MySqlParameter("@newperfectItemType", MySqlDbType.VarChar, 0);
			spellidParameter.Value = spellId;
			requiredspecializationParameter.Value = requiredSpecialization;
			perfectcreatechanceParameter.Value = perfectCreateChance;
			perfectitemtypeParameter.Value = perfectItemType;
			OLD_spellidParameter.Value = OLD_spellId;
			OLD_requiredspecializationParameter.Value = OLD_requiredSpecialization;
			OLD_perfectcreatechanceParameter.Value = OLD_perfectCreateChance;
			OLD_perfectitemtypeParameter.Value = OLD_perfectItemType;
			cmd.Parameters.Add(spellidParameter);
			cmd.Parameters.Add(requiredspecializationParameter);
			cmd.Parameters.Add(perfectcreatechanceParameter);
			cmd.Parameters.Add(perfectitemtypeParameter);
			cmd.Parameters.Add(OLD_spellidParameter);
			cmd.Parameters.Add(OLD_requiredspecializationParameter);
			cmd.Parameters.Add(OLD_perfectcreatechanceParameter);
			cmd.Parameters.Add(OLD_perfectitemtypeParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_spellId = spellId;
			OLD_requiredSpecialization = requiredSpecialization;
			OLD_perfectCreateChance = perfectCreateChance;
			OLD_perfectItemType = perfectItemType;
		}
	}
}
