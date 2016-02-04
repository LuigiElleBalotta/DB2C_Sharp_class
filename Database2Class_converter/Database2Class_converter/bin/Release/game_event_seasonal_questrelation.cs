using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event_seasonal_questrelation
	{
		int questId = 0; //Comment: Quest Identifier
		int OLD_questId = 0;

		int eventEntry = 0; //Comment: Entry of the game event
		int OLD_eventEntry = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event_seasonal_questrelation(int _questId, int _eventEntry)
		{
			questId = _questId;
			eventEntry = _eventEntry;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event_seasonal_questrelation WHERE questId = @questId AND eventEntry = @eventEntry;";
			MySqlParameter questidParameter = new MySqlParameter("@questId", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			questidParameter.Value = questId;
			evententryParameter.Value = eventEntry;
			cmd.Parameters.Add(questidParameter);
			cmd.Parameters.Add(evententryParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event_seasonal_questrelation SET questId = @newquestId, eventEntry = @neweventEntry WHERE questId = @questId AND eventEntry = @eventEntry;";
			MySqlParameter OLD_questidParameter = new MySqlParameter("@questId", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter questidParameter = new MySqlParameter("@newquestId", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			questidParameter.Value = questId;
			evententryParameter.Value = eventEntry;
			OLD_questidParameter.Value = OLD_questId;
			OLD_evententryParameter.Value = OLD_eventEntry;
			cmd.Parameters.Add(questidParameter);
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(OLD_questidParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_questId = questId;
			OLD_eventEntry = eventEntry;
		}
	}
}
