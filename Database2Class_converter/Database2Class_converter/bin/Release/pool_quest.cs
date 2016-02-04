using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Pool_quest
	{
		int entry = 0; //Comment: 
		int OLD_entry = 0;

		int pool_entry = 0; //Comment: 
		int OLD_pool_entry = 0;

		string description = null; //Comment: 
		string OLD_description = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Pool_quest(int _entry, int _pool_entry, string _description)
		{
			entry = _entry;
			pool_entry = _pool_entry;
			description = _description;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM pool_quest WHERE entry = @entry AND pool_entry = @pool_entry AND description = @description;";
			MySqlParameter entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter pool_entryParameter = new MySqlParameter("@pool_entry", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			pool_entryParameter.Value = pool_entry;
			descriptionParameter.Value = description;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(pool_entryParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE pool_quest SET entry = @newentry, pool_entry = @newpool_entry, description = @newdescription WHERE entry = @entry AND pool_entry = @pool_entry AND description = @description;";
			MySqlParameter OLD_entryParameter = new MySqlParameter("@entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_pool_entryParameter = new MySqlParameter("@pool_entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			MySqlParameter entryParameter = new MySqlParameter("@newentry", MySqlDbType.VarChar, 0);
			MySqlParameter pool_entryParameter = new MySqlParameter("@newpool_entry", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@newdescription", MySqlDbType.VarChar, 0);
			entryParameter.Value = entry;
			pool_entryParameter.Value = pool_entry;
			descriptionParameter.Value = description;
			OLD_entryParameter.Value = OLD_entry;
			OLD_pool_entryParameter.Value = OLD_pool_entry;
			OLD_descriptionParameter.Value = OLD_description;
			cmd.Parameters.Add(entryParameter);
			cmd.Parameters.Add(pool_entryParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(OLD_entryParameter);
			cmd.Parameters.Add(OLD_pool_entryParameter);
			cmd.Parameters.Add(OLD_descriptionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_entry = entry;
			OLD_pool_entry = pool_entry;
			OLD_description = description;
		}
	}
}
