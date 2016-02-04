using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Player_xp_for_level
	{
		int Level = 0; //Comment: 
		int OLD_Level = 0;

		float Experience = 0.0f; //Comment: 
		float OLD_Experience = 0.0f;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Player_xp_for_level(int _Level, float _Experience)
		{
			Level = _Level;
			Experience = _Experience;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM player_xp_for_level WHERE Level = @Level AND Experience = @Experience;";
			MySqlParameter levelParameter = new MySqlParameter("@Level", MySqlDbType.VarChar, 0);
			MySqlParameter experienceParameter = new MySqlParameter("@Experience", MySqlDbType.VarChar, 0);
			levelParameter.Value = Level;
			experienceParameter.Value = Experience;
			cmd.Parameters.Add(levelParameter);
			cmd.Parameters.Add(experienceParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE player_xp_for_level SET Level = @newLevel, Experience = @newExperience WHERE Level = @Level AND Experience = @Experience;";
			MySqlParameter OLD_levelParameter = new MySqlParameter("@Level", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_experienceParameter = new MySqlParameter("@Experience", MySqlDbType.VarChar, 0);
			MySqlParameter levelParameter = new MySqlParameter("@newLevel", MySqlDbType.VarChar, 0);
			MySqlParameter experienceParameter = new MySqlParameter("@newExperience", MySqlDbType.VarChar, 0);
			levelParameter.Value = Level;
			experienceParameter.Value = Experience;
			OLD_levelParameter.Value = OLD_Level;
			OLD_experienceParameter.Value = OLD_Experience;
			cmd.Parameters.Add(levelParameter);
			cmd.Parameters.Add(experienceParameter);
			cmd.Parameters.Add(OLD_levelParameter);
			cmd.Parameters.Add(OLD_experienceParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_Level = Level;
			OLD_Experience = Experience;
		}
	}
}
