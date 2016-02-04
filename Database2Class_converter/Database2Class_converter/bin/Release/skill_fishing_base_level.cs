using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Skill_fishing_base_level
	{
		int entry = 0; //Comment: Area identifier
		int OLD_entry = 0;

		int skill = 0; //Comment: Base skill level requirement
		int OLD_skill = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Skill_fishing_base_level(int _entry, int _skill)
		{
			entry = _entry;
			skill = _skill;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM skill_fishing_base_level WHERE entry = @entry AND skill = @skill;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter skillParameter = new MySqlParameter("@skill", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			skillParameter.Value = skill;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(skillParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE skill_fishing_base_level SET entry = @newentry, skill = @newskill WHERE entry = @entry AND skill = @skill;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_skillParameter = new MySqlParameter("@skill", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter skillParameter = new MySqlParameter("@newskill", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			skillParameter.Value = skill;
			OLD_entryParameter.Value = OLD_entry;
			OLD_skillParameter.Value = OLD_skill;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(skillParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_skillParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_skill = skill;
		}
	}
}
