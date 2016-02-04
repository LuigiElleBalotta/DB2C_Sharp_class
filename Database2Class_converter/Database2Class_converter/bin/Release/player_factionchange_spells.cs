using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Player_factionchange_spells
	{
		int alliance_id = 0; //Comment: 
		int OLD_alliance_id = 0;

		int horde_id = 0; //Comment: 
		int OLD_horde_id = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Player_factionchange_spells(int _alliance_id, int _horde_id)
		{
			alliance_id = _alliance_id;
			horde_id = _horde_id;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM player_factionchange_spells WHERE alliance_id = @alliance_id AND horde_id = @horde_id;";
			MySqlParameter alliance_idParameter = new MySqlParameter("@alliance_id", MySqlDbType.VarChar, 0);
			MySqlParameter horde_idParameter = new MySqlParameter("@horde_id", MySqlDbType.VarChar, 0);
			alliance_idParameter.Value = alliance_id;
			horde_idParameter.Value = horde_id;
			cmd.Parameters.Add(alliance_idParameter);
			cmd.Parameters.Add(horde_idParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE player_factionchange_spells SET alliance_id = @newalliance_id, horde_id = @newhorde_id WHERE alliance_id = @alliance_id AND horde_id = @horde_id;";
			MySqlParameter OLD_alliance_idParameter = new MySqlParameter("@alliance_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_horde_idParameter = new MySqlParameter("@horde_id", MySqlDbType.VarChar, 0);
			MySqlParameter alliance_idParameter = new MySqlParameter("@newalliance_id", MySqlDbType.VarChar, 0);
			MySqlParameter horde_idParameter = new MySqlParameter("@newhorde_id", MySqlDbType.VarChar, 0);
			alliance_idParameter.Value = alliance_id;
			horde_idParameter.Value = horde_id;
			OLD_alliance_idParameter.Value = OLD_alliance_id;
			OLD_horde_idParameter.Value = OLD_horde_id;
			cmd.Parameters.Add(alliance_idParameter);
			cmd.Parameters.Add(horde_idParameter);
			cmd.Parameters.Add(OLD_alliance_idParameter);
			cmd.Parameters.Add(OLD_horde_idParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_alliance_id = alliance_id;
			OLD_horde_id = horde_id;
		}
	}
}
