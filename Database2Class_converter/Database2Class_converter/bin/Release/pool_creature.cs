using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Pool_creature
	{
		int guid = 0; //Comment: 
		int OLD_guid = 0;

		int pool_entry = 0; //Comment: 
		int OLD_pool_entry = 0;

		float chance = 0f; //Comment: 
		float OLD_chance = 0f;

		string description = null; //Comment: 
		string OLD_description = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Pool_creature(int _guid, int _pool_entry, float _chance, string _description)
		{
			guid = _guid;
			pool_entry = _pool_entry;
			chance = _chance;
			description = _description;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM pool_creature WHERE guid = @guid AND pool_entry = @pool_entry AND chance = @chance AND description = @description;";
			MySqlParameter guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter pool_entryParameter = new MySqlParameter("@pool_entry", MySqlDbType.VarChar, 0);
			MySqlParameter chanceParameter = new MySqlParameter("@chance", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			pool_entryParameter.Value = pool_entry;
			chanceParameter.Value = chance;
			descriptionParameter.Value = description;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(pool_entryParameter);
			cmd.Parameters.Add(chanceParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE pool_creature SET guid = @newguid, pool_entry = @newpool_entry, chance = @newchance, description = @newdescription WHERE guid = @guid AND pool_entry = @pool_entry AND chance = @chance AND description = @description;";
			MySqlParameter OLD_guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_pool_entryParameter = new MySqlParameter("@pool_entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_chanceParameter = new MySqlParameter("@chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@newguid", MySqlDbType.VarChar, 0);
			MySqlParameter pool_entryParameter = new MySqlParameter("@newpool_entry", MySqlDbType.VarChar, 0);
			MySqlParameter chanceParameter = new MySqlParameter("@newchance", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@newdescription", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			pool_entryParameter.Value = pool_entry;
			chanceParameter.Value = chance;
			descriptionParameter.Value = description;
			OLD_guidParameter.Value = OLD_guid;
			OLD_pool_entryParameter.Value = OLD_pool_entry;
			OLD_chanceParameter.Value = OLD_chance;
			OLD_descriptionParameter.Value = OLD_description;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(pool_entryParameter);
			cmd.Parameters.Add(chanceParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(OLD_guidParameter);
			cmd.Parameters.Add(OLD_pool_entryParameter);
			cmd.Parameters.Add(OLD_chanceParameter);
			cmd.Parameters.Add(OLD_descriptionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_guid = guid;
			OLD_pool_entry = pool_entry;
			OLD_chance = chance;
			OLD_description = description;
		}
	}
}
