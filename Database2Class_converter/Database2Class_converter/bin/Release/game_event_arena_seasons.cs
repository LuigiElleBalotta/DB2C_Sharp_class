using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event_arena_seasons
	{
		int eventEntry = 0; //Comment: Entry of the game event
		int OLD_eventEntry = 0;

		int season = 0; //Comment: Arena season number
		int OLD_season = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event_arena_seasons(int _eventEntry, int _season)
		{
			eventEntry = _eventEntry;
			season = _season;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event_arena_seasons WHERE eventEntry = @eventEntry AND season = @season;";
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter seasonParameter = new MySqlParameter("@season", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			seasonParameter.Value = season;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(seasonParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event_arena_seasons SET eventEntry = @neweventEntry, season = @newseason WHERE eventEntry = @eventEntry AND season = @season;";
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_seasonParameter = new MySqlParameter("@season", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter seasonParameter = new MySqlParameter("@newseason", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			seasonParameter.Value = season;
			OLD_evententryParameter.Value = OLD_eventEntry;
			OLD_seasonParameter.Value = OLD_season;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(seasonParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.Parameters.Add(OLD_seasonParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_eventEntry = eventEntry;
			OLD_season = season;
		}
	}
}
