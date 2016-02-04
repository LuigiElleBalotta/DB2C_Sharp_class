using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Battle_pet_breeds
	{
		int speciesId = 0; //Comment: 
		int OLD_speciesId = 0;

		int breedId = 0; //Comment: 
		int OLD_breedId = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Battle_pet_breeds(int _speciesId, int _breedId)
		{
			speciesId = _speciesId;
			breedId = _breedId;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM battle_pet_breeds WHERE speciesId = @speciesId AND breedId = @breedId;";
			MySqlParameter speciesidParameter = new MySqlParameter("@speciesId", MySqlDbType.VarChar, 0);
			MySqlParameter breedidParameter = new MySqlParameter("@breedId", MySqlDbType.VarChar, 0);
			speciesidParameter.Value = speciesId;
			breedidParameter.Value = breedId;
			cmd.Parameters.Add(speciesidParameter);
			cmd.Parameters.Add(breedidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE battle_pet_breeds SET speciesId = @newspeciesId, breedId = @newbreedId WHERE speciesId = @speciesId AND breedId = @breedId;";
			MySqlParameter OLD_speciesidParameter = new MySqlParameter("@speciesId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_breedidParameter = new MySqlParameter("@breedId", MySqlDbType.VarChar, 0);
			MySqlParameter speciesidParameter = new MySqlParameter("@newspeciesId", MySqlDbType.VarChar, 0);
			MySqlParameter breedidParameter = new MySqlParameter("@newbreedId", MySqlDbType.VarChar, 0);
			speciesidParameter.Value = speciesId;
			breedidParameter.Value = breedId;
			OLD_speciesidParameter.Value = OLD_speciesId;
			OLD_breedidParameter.Value = OLD_breedId;
			cmd.Parameters.Add(speciesidParameter);
			cmd.Parameters.Add(breedidParameter);
			cmd.Parameters.Add(OLD_speciesidParameter);
			cmd.Parameters.Add(OLD_breedidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_speciesId = speciesId;
			OLD_breedId = breedId;
		}
	}
}
