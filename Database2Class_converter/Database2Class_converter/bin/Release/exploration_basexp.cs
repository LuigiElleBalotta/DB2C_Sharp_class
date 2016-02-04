using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Exploration_basexp
	{
		int level = 0; //Comment: 
		int OLD_level = 0;

		int basexp = 0; //Comment: 
		int OLD_basexp = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Exploration_basexp(int _level, int _basexp)
		{
			level = _level;
			basexp = _basexp;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM exploration_basexp WHERE level = @level AND basexp = @basexp;";
			MySqlParameter levelParameter = new MySqlParameter("@level", MySqlDbType.VarChar, 0);
			MySqlParameter basexpParameter = new MySqlParameter("@basexp", MySqlDbType.VarChar, 0);
			levelParameter.Value = level;
			basexpParameter.Value = basexp;
			cmd.Parameters.Add(levelParameter);
			cmd.Parameters.Add(basexpParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE exploration_basexp SET level = @newlevel, basexp = @newbasexp WHERE level = @level AND basexp = @basexp;";
			MySqlParameter OLD_levelParameter = new MySqlParameter("@level", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_basexpParameter = new MySqlParameter("@basexp", MySqlDbType.VarChar, 0);
			MySqlParameter levelParameter = new MySqlParameter("@newlevel", MySqlDbType.VarChar, 0);
			MySqlParameter basexpParameter = new MySqlParameter("@newbasexp", MySqlDbType.VarChar, 0);
			levelParameter.Value = level;
			basexpParameter.Value = basexp;
			OLD_levelParameter.Value = OLD_level;
			OLD_basexpParameter.Value = OLD_basexp;
			cmd.Parameters.Add(levelParameter);
			cmd.Parameters.Add(basexpParameter);
			cmd.Parameters.Add(OLD_levelParameter);
			cmd.Parameters.Add(OLD_basexpParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_level = level;
			OLD_basexp = basexp;
		}
	}
}
