using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Pool_template
	{
		int entry = 0; //Comment: Pool entry
		int OLD_entry = 0;

		int max_limit = 0; //Comment: Max number of objects (0) is no limit
		int OLD_max_limit = 0;

		string description = null; //Comment: 
		string OLD_description = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Pool_template(int _entry, int _max_limit, string _description)
		{
			entry = _entry;
			max_limit = _max_limit;
			description = _description;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM pool_template WHERE entry = @entry AND max_limit = @max_limit AND description = @description;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter max_limitParameter = new MySqlParameter("@max_limit", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			max_limitParameter.Value = max_limit;
			descriptionParameter.Value = description;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(max_limitParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE pool_template SET entry = @newentry, max_limit = @newmax_limit, description = @newdescription WHERE entry = @entry AND max_limit = @max_limit AND description = @description;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_max_limitParameter = new MySqlParameter("@max_limit", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter max_limitParameter = new MySqlParameter("@newmax_limit", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@newdescription", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			max_limitParameter.Value = max_limit;
			descriptionParameter.Value = description;
			OLD_entryParameter.Value = OLD_entry;
			OLD_max_limitParameter.Value = OLD_max_limit;
			OLD_descriptionParameter.Value = OLD_description;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(max_limitParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_max_limitParameter);
			cmd.Parameters.Add(OLD_descriptionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_max_limit = max_limit;
			OLD_description = description;
		}
	}
}
