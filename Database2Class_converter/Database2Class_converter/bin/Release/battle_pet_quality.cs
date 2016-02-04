using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Battle_pet_quality
	{
		int speciesId = 0; //Comment: 
		int OLD_speciesId = 0;

		int quality = 0; //Comment: 
		int OLD_quality = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Battle_pet_quality(int _speciesId, int _quality)
		{
			speciesId = _speciesId;
			quality = _quality;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM battle_pet_quality WHERE speciesId = @speciesId AND quality = @quality;";
			MySqlParameter speciesidParameter = new MySqlParameter("@speciesId", MySqlDbType.VarChar, 0);
			MySqlParameter qualityParameter = new MySqlParameter("@quality", MySqlDbType.VarChar, 0);
			speciesidParameter.Value = speciesId;
			qualityParameter.Value = quality;
			cmd.Parameters.Add(speciesidParameter);
			cmd.Parameters.Add(qualityParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE battle_pet_quality SET speciesId = @newspeciesId, quality = @newquality WHERE speciesId = @speciesId AND quality = @quality;";
			MySqlParameter OLD_speciesidParameter = new MySqlParameter("@speciesId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_qualityParameter = new MySqlParameter("@quality", MySqlDbType.VarChar, 0);
			MySqlParameter speciesidParameter = new MySqlParameter("@newspeciesId", MySqlDbType.VarChar, 0);
			MySqlParameter qualityParameter = new MySqlParameter("@newquality", MySqlDbType.VarChar, 0);
			speciesidParameter.Value = speciesId;
			qualityParameter.Value = quality;
			OLD_speciesidParameter.Value = OLD_speciesId;
			OLD_qualityParameter.Value = OLD_quality;
			cmd.Parameters.Add(speciesidParameter);
			cmd.Parameters.Add(qualityParameter);
			cmd.Parameters.Add(OLD_speciesidParameter);
			cmd.Parameters.Add(OLD_qualityParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_speciesId = speciesId;
			OLD_quality = quality;
		}
	}
}
