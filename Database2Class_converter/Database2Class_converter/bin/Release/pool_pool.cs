using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Pool_pool
	{
		int pool_id = 0; //Comment: 
		int OLD_pool_id = 0;

		int mother_pool = 0; //Comment: 
		int OLD_mother_pool = 0;

		float chance = 0f; //Comment: 
		float OLD_chance = 0f;

		string description = null; //Comment: 
		string OLD_description = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Pool_pool(int _pool_id, int _mother_pool, float _chance, string _description)
		{
			pool_id = _pool_id;
			mother_pool = _mother_pool;
			chance = _chance;
			description = _description;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM pool_pool WHERE pool_id = @pool_id AND mother_pool = @mother_pool AND chance = @chance AND description = @description;";
			MySqlParameter pool_idParameter = new MySqlParameter("@pool_id", MySqlDbType.VarChar, 0);
			MySqlParameter mother_poolParameter = new MySqlParameter("@mother_pool", MySqlDbType.VarChar, 0);
			MySqlParameter chanceParameter = new MySqlParameter("@chance", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			pool_idParameter.Value = pool_id;
			mother_poolParameter.Value = mother_pool;
			chanceParameter.Value = chance;
			descriptionParameter.Value = description;
			cmd.Parameters.Add(pool_idParameter);
			cmd.Parameters.Add(mother_poolParameter);
			cmd.Parameters.Add(chanceParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE pool_pool SET pool_id = @newpool_id, mother_pool = @newmother_pool, chance = @newchance, description = @newdescription WHERE pool_id = @pool_id AND mother_pool = @mother_pool AND chance = @chance AND description = @description;";
			MySqlParameter OLD_pool_idParameter = new MySqlParameter("@pool_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_mother_poolParameter = new MySqlParameter("@mother_pool", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_chanceParameter = new MySqlParameter("@chance", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			MySqlParameter pool_idParameter = new MySqlParameter("@newpool_id", MySqlDbType.VarChar, 0);
			MySqlParameter mother_poolParameter = new MySqlParameter("@newmother_pool", MySqlDbType.VarChar, 0);
			MySqlParameter chanceParameter = new MySqlParameter("@newchance", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@newdescription", MySqlDbType.VarChar, 0);
			pool_idParameter.Value = pool_id;
			mother_poolParameter.Value = mother_pool;
			chanceParameter.Value = chance;
			descriptionParameter.Value = description;
			OLD_pool_idParameter.Value = OLD_pool_id;
			OLD_mother_poolParameter.Value = OLD_mother_pool;
			OLD_chanceParameter.Value = OLD_chance;
			OLD_descriptionParameter.Value = OLD_description;
			cmd.Parameters.Add(pool_idParameter);
			cmd.Parameters.Add(mother_poolParameter);
			cmd.Parameters.Add(chanceParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(OLD_pool_idParameter);
			cmd.Parameters.Add(OLD_mother_poolParameter);
			cmd.Parameters.Add(OLD_chanceParameter);
			cmd.Parameters.Add(OLD_descriptionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_pool_id = pool_id;
			OLD_mother_pool = mother_pool;
			OLD_chance = chance;
			OLD_description = description;
		}
	}
}
