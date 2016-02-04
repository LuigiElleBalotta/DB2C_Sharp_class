using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event_creature
	{
		int eventEntry = 0; //Comment: Entry of the game event. Put negative entry to remove during event.
		int OLD_eventEntry = 0;

		int guid = 0; //Comment: 
		int OLD_guid = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event_creature(int _eventEntry, int _guid)
		{
			eventEntry = _eventEntry;
			guid = _guid;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event_creature WHERE eventEntry = @eventEntry AND guid = @guid;";
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			guidParameter.Value = guid;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(guidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event_creature SET eventEntry = @neweventEntry, guid = @newguid WHERE eventEntry = @eventEntry AND guid = @guid;";
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@newguid", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			guidParameter.Value = guid;
			OLD_evententryParameter.Value = OLD_eventEntry;
			OLD_guidParameter.Value = OLD_guid;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.Parameters.Add(OLD_guidParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_eventEntry = eventEntry;
			OLD_guid = guid;
		}
	}
}