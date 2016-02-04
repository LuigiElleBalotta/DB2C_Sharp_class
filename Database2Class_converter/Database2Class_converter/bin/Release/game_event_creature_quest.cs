using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event_creature_quest
	{
		int eventEntry = 0; //Comment: Entry of the game event.
		int OLD_eventEntry = 0;

		int id = 0; //Comment: 
		int OLD_id = 0;

		int quest = 0; //Comment: 
		int OLD_quest = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event_creature_quest(int _eventEntry, int _id, int _quest)
		{
			eventEntry = _eventEntry;
			id = _id;
			quest = _quest;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event_creature_quest WHERE eventEntry = @eventEntry AND id = @id AND quest = @quest;";
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter questParameter = new MySqlParameter("@quest", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			idParameter.Value = id;
			questParameter.Value = quest;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(questParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event_creature_quest SET eventEntry = @neweventEntry, id = @newid, quest = @newquest WHERE eventEntry = @eventEntry AND id = @id AND quest = @quest;";
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_idParameter = new MySqlParameter("@id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questParameter = new MySqlParameter("@quest", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter idParameter = new MySqlParameter("@newid", MySqlDbType.VarChar, 0);
			MySqlParameter questParameter = new MySqlParameter("@newquest", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			idParameter.Value = id;
			questParameter.Value = quest;
			OLD_evententryParameter.Value = OLD_eventEntry;
			OLD_idParameter.Value = OLD_id;
			OLD_questParameter.Value = OLD_quest;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(idParameter);
			cmd.Parameters.Add(questParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.Parameters.Add(OLD_idParameter);
			cmd.Parameters.Add(OLD_questParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_eventEntry = eventEntry;
			OLD_id = id;
			OLD_quest = quest;
		}
	}
}
