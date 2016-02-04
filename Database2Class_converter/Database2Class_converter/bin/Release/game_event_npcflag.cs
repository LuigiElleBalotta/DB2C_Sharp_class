using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event_npcflag
	{
		int eventEntry = 0; //Comment: Entry of the game event
		int OLD_eventEntry = 0;

		int guid = 0; //Comment: 
		int OLD_guid = 0;

		int npcflag = 0; //Comment: 
		int OLD_npcflag = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event_npcflag(int _eventEntry, int _guid, int _npcflag)
		{
			eventEntry = _eventEntry;
			guid = _guid;
			npcflag = _npcflag;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event_npcflag WHERE eventEntry = @eventEntry AND guid = @guid AND npcflag = @npcflag;";
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter npcflagParameter = new MySqlParameter("@npcflag", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			guidParameter.Value = guid;
			npcflagParameter.Value = npcflag;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(npcflagParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event_npcflag SET eventEntry = @neweventEntry, guid = @newguid, npcflag = @newnpcflag WHERE eventEntry = @eventEntry AND guid = @guid AND npcflag = @npcflag;";
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_npcflagParameter = new MySqlParameter("@npcflag", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@newguid", MySqlDbType.VarChar, 0);
			MySqlParameter npcflagParameter = new MySqlParameter("@newnpcflag", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			guidParameter.Value = guid;
			npcflagParameter.Value = npcflag;
			OLD_evententryParameter.Value = OLD_eventEntry;
			OLD_guidParameter.Value = OLD_guid;
			OLD_npcflagParameter.Value = OLD_npcflag;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(npcflagParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.Parameters.Add(OLD_guidParameter);
			cmd.Parameters.Add(OLD_npcflagParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_eventEntry = eventEntry;
			OLD_guid = guid;
			OLD_npcflag = npcflag;
		}
	}
}
