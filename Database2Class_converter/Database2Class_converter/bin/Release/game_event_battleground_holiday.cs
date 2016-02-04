using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event_battleground_holiday
	{
		int eventEntry = 0; //Comment: Entry of the game event
		int OLD_eventEntry = 0;

		int bgflag = 0; //Comment: 
		int OLD_bgflag = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event_battleground_holiday(int _eventEntry, int _bgflag)
		{
			eventEntry = _eventEntry;
			bgflag = _bgflag;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event_battleground_holiday WHERE eventEntry = @eventEntry AND bgflag = @bgflag;";
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter bgflagParameter = new MySqlParameter("@bgflag", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			bgflagParameter.Value = bgflag;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(bgflagParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event_battleground_holiday SET eventEntry = @neweventEntry, bgflag = @newbgflag WHERE eventEntry = @eventEntry AND bgflag = @bgflag;";
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_bgflagParameter = new MySqlParameter("@bgflag", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter bgflagParameter = new MySqlParameter("@newbgflag", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			bgflagParameter.Value = bgflag;
			OLD_evententryParameter.Value = OLD_eventEntry;
			OLD_bgflagParameter.Value = OLD_bgflag;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(bgflagParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.Parameters.Add(OLD_bgflagParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_eventEntry = eventEntry;
			OLD_bgflag = bgflag;
		}
	}
}
