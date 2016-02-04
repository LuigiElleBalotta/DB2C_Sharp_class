using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Player_factionchange_items
	{
		int race_A = 0; //Comment: 
		int OLD_race_A = 0;

		int alliance_id = 0; //Comment: 
		int OLD_alliance_id = 0;

		string commentA = null; //Comment: 
		string OLD_commentA = null;

		int race_H = 0; //Comment: 
		int OLD_race_H = 0;

		int horde_id = 0; //Comment: 
		int OLD_horde_id = 0;

		string commentH = null; //Comment: 
		string OLD_commentH = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Player_factionchange_items(int _race_A, int _alliance_id, string _commentA, int _race_H, int _horde_id, string _commentH)
		{
			race_A = _race_A;
			alliance_id = _alliance_id;
			commentA = _commentA;
			race_H = _race_H;
			horde_id = _horde_id;
			commentH = _commentH;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM player_factionchange_items WHERE race_A = @race_A AND alliance_id = @alliance_id AND commentA = @commentA AND race_H = @race_H AND horde_id = @horde_id AND commentH = @commentH;";
			MySqlParameter race_aParameter = new MySqlParameter("@race_A", MySqlDbType.VarChar, 0);
			MySqlParameter alliance_idParameter = new MySqlParameter("@alliance_id", MySqlDbType.VarChar, 0);
			MySqlParameter commentaParameter = new MySqlParameter("@commentA", MySqlDbType.VarChar, 0);
			MySqlParameter race_hParameter = new MySqlParameter("@race_H", MySqlDbType.VarChar, 0);
			MySqlParameter horde_idParameter = new MySqlParameter("@horde_id", MySqlDbType.VarChar, 0);
			MySqlParameter commenthParameter = new MySqlParameter("@commentH", MySqlDbType.VarChar, 0);
			race_aParameter.Value = race_A;
			alliance_idParameter.Value = alliance_id;
			commentaParameter.Value = commentA;
			race_hParameter.Value = race_H;
			horde_idParameter.Value = horde_id;
			commenthParameter.Value = commentH;
			cmd.Parameters.Add(race_aParameter);
			cmd.Parameters.Add(alliance_idParameter);
			cmd.Parameters.Add(commentaParameter);
			cmd.Parameters.Add(race_hParameter);
			cmd.Parameters.Add(horde_idParameter);
			cmd.Parameters.Add(commenthParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE player_factionchange_items SET race_A = @newrace_A, alliance_id = @newalliance_id, commentA = @newcommentA, race_H = @newrace_H, horde_id = @newhorde_id, commentH = @newcommentH WHERE race_A = @race_A AND alliance_id = @alliance_id AND commentA = @commentA AND race_H = @race_H AND horde_id = @horde_id AND commentH = @commentH;";
			MySqlParameter OLD_race_aParameter = new MySqlParameter("@race_A", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_alliance_idParameter = new MySqlParameter("@alliance_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commentaParameter = new MySqlParameter("@commentA", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_race_hParameter = new MySqlParameter("@race_H", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_horde_idParameter = new MySqlParameter("@horde_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_commenthParameter = new MySqlParameter("@commentH", MySqlDbType.VarChar, 0);
			MySqlParameter race_aParameter = new MySqlParameter("@newrace_A", MySqlDbType.VarChar, 0);
			MySqlParameter alliance_idParameter = new MySqlParameter("@newalliance_id", MySqlDbType.VarChar, 0);
			MySqlParameter commentaParameter = new MySqlParameter("@newcommentA", MySqlDbType.VarChar, 0);
			MySqlParameter race_hParameter = new MySqlParameter("@newrace_H", MySqlDbType.VarChar, 0);
			MySqlParameter horde_idParameter = new MySqlParameter("@newhorde_id", MySqlDbType.VarChar, 0);
			MySqlParameter commenthParameter = new MySqlParameter("@newcommentH", MySqlDbType.VarChar, 0);
			race_aParameter.Value = race_A;
			alliance_idParameter.Value = alliance_id;
			commentaParameter.Value = commentA;
			race_hParameter.Value = race_H;
			horde_idParameter.Value = horde_id;
			commenthParameter.Value = commentH;
			OLD_race_aParameter.Value = OLD_race_A;
			OLD_alliance_idParameter.Value = OLD_alliance_id;
			OLD_commentaParameter.Value = OLD_commentA;
			OLD_race_hParameter.Value = OLD_race_H;
			OLD_horde_idParameter.Value = OLD_horde_id;
			OLD_commenthParameter.Value = OLD_commentH;
			cmd.Parameters.Add(race_aParameter);
			cmd.Parameters.Add(alliance_idParameter);
			cmd.Parameters.Add(commentaParameter);
			cmd.Parameters.Add(race_hParameter);
			cmd.Parameters.Add(horde_idParameter);
			cmd.Parameters.Add(commenthParameter);
			cmd.Parameters.Add(OLD_race_aParameter);
			cmd.Parameters.Add(OLD_alliance_idParameter);
			cmd.Parameters.Add(OLD_commentaParameter);
			cmd.Parameters.Add(OLD_race_hParameter);
			cmd.Parameters.Add(OLD_horde_idParameter);
			cmd.Parameters.Add(OLD_commenthParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_race_A = race_A;
			OLD_alliance_id = alliance_id;
			OLD_commentA = commentA;
			OLD_race_H = race_H;
			OLD_horde_id = horde_id;
			OLD_commentH = commentH;
		}
	}
}
