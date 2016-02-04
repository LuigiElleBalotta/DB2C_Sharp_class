using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event_pool
	{
		int eventEntry = 0; //Comment: Entry of the game event. Put negative entry to remove during event.
		int OLD_eventEntry = 0;

		int pool_entry = 0; //Comment: Id of the pool
		int OLD_pool_entry = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event_pool(int _eventEntry, int _pool_entry)
		{
			eventEntry = _eventEntry;
			pool_entry = _pool_entry;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event_pool WHERE eventEntry = @eventEntry AND pool_entry = @pool_entry;";
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter pool_entryParameter = new MySqlParameter("@pool_entry", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			pool_entryParameter.Value = pool_entry;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(pool_entryParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event_pool SET eventEntry = @neweventEntry, pool_entry = @newpool_entry WHERE eventEntry = @eventEntry AND pool_entry = @pool_entry;";
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_pool_entryParameter = new MySqlParameter("@pool_entry", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter pool_entryParameter = new MySqlParameter("@newpool_entry", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			pool_entryParameter.Value = pool_entry;
			OLD_evententryParameter.Value = OLD_eventEntry;
			OLD_pool_entryParameter.Value = OLD_pool_entry;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(pool_entryParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.Parameters.Add(OLD_pool_entryParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_eventEntry = eventEntry;
			OLD_pool_entry = pool_entry;
		}
	}
}
