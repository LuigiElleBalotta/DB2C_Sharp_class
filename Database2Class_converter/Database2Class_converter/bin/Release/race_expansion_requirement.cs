using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Race_expansion_requirement
	{
		int raceID = 0; //Comment: 
		int OLD_raceID = 0;

		int expansion = 0; //Comment: 
		int OLD_expansion = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Race_expansion_requirement(int _raceID, int _expansion)
		{
			raceID = _raceID;
			expansion = _expansion;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM race_expansion_requirement WHERE raceID = @raceID AND expansion = @expansion;";
			MySqlParameter raceidParameter = new MySqlParameter("@raceID", MySqlDbType.VarChar, 0);
			MySqlParameter expansionParameter = new MySqlParameter("@expansion", MySqlDbType.VarChar, 0);
			raceidParameter.Value = raceID;
			expansionParameter.Value = expansion;
			cmd.Parameters.Add(raceidParameter);
			cmd.Parameters.Add(expansionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE race_expansion_requirement SET raceID = @newraceID, expansion = @newexpansion WHERE raceID = @raceID AND expansion = @expansion;";
			MySqlParameter OLD_raceidParameter = new MySqlParameter("@raceID", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_expansionParameter = new MySqlParameter("@expansion", MySqlDbType.VarChar, 0);
			MySqlParameter raceidParameter = new MySqlParameter("@newraceID", MySqlDbType.VarChar, 0);
			MySqlParameter expansionParameter = new MySqlParameter("@newexpansion", MySqlDbType.VarChar, 0);
			raceidParameter.Value = raceID;
			expansionParameter.Value = expansion;
			OLD_raceidParameter.Value = OLD_raceID;
			OLD_expansionParameter.Value = OLD_expansion;
			cmd.Parameters.Add(raceidParameter);
			cmd.Parameters.Add(expansionParameter);
			cmd.Parameters.Add(OLD_raceidParameter);
			cmd.Parameters.Add(OLD_expansionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_raceID = raceID;
			OLD_expansion = expansion;
		}
	}
}
