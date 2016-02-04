using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event_prerequisite
	{
		int eventEntry = 0; //Comment: Entry of the game event
		int OLD_eventEntry = 0;

		int prerequisite_event = 0; //Comment: 
		int OLD_prerequisite_event = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event_prerequisite(int _eventEntry, int _prerequisite_event)
		{
			eventEntry = _eventEntry;
			prerequisite_event = _prerequisite_event;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event_prerequisite WHERE eventEntry = @eventEntry AND prerequisite_event = @prerequisite_event;";
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter prerequisite_eventParameter = new MySqlParameter("@prerequisite_event", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			prerequisite_eventParameter.Value = prerequisite_event;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(prerequisite_eventParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event_prerequisite SET eventEntry = @neweventEntry, prerequisite_event = @newprerequisite_event WHERE eventEntry = @eventEntry AND prerequisite_event = @prerequisite_event;";
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_prerequisite_eventParameter = new MySqlParameter("@prerequisite_event", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter prerequisite_eventParameter = new MySqlParameter("@newprerequisite_event", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			prerequisite_eventParameter.Value = prerequisite_event;
			OLD_evententryParameter.Value = OLD_eventEntry;
			OLD_prerequisite_eventParameter.Value = OLD_prerequisite_event;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(prerequisite_eventParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.Parameters.Add(OLD_prerequisite_eventParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_eventEntry = eventEntry;
			OLD_prerequisite_event = prerequisite_event;
		}
	}
}
