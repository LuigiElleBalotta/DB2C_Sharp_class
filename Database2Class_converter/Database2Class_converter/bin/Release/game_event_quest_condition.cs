using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event_quest_condition
	{
		int eventEntry = 0; //Comment: Entry of the game event.
		int OLD_eventEntry = 0;

		int quest = 0; //Comment: 
		int OLD_quest = 0;

		int condition_id = 0; //Comment: 
		int OLD_condition_id = 0;

		float num = 0f; //Comment: 
		float OLD_num = 0f;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event_quest_condition(int _eventEntry, int _quest, int _condition_id, float _num)
		{
			eventEntry = _eventEntry;
			quest = _quest;
			condition_id = _condition_id;
			num = _num;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event_quest_condition WHERE eventEntry = @eventEntry AND quest = @quest AND condition_id = @condition_id AND num = @num;";
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter questParameter = new MySqlParameter("@quest", MySqlDbType.VarChar, 0);
			MySqlParameter condition_idParameter = new MySqlParameter("@condition_id", MySqlDbType.VarChar, 0);
			MySqlParameter numParameter = new MySqlParameter("@num", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			questParameter.Value = quest;
			condition_idParameter.Value = condition_id;
			numParameter.Value = num;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(questParameter);
			cmd.Parameters.Add(condition_idParameter);
			cmd.Parameters.Add(numParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event_quest_condition SET eventEntry = @neweventEntry, quest = @newquest, condition_id = @newcondition_id, num = @newnum WHERE eventEntry = @eventEntry AND quest = @quest AND condition_id = @condition_id AND num = @num;";
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_questParameter = new MySqlParameter("@quest", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_condition_idParameter = new MySqlParameter("@condition_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_numParameter = new MySqlParameter("@num", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter questParameter = new MySqlParameter("@newquest", MySqlDbType.VarChar, 0);
			MySqlParameter condition_idParameter = new MySqlParameter("@newcondition_id", MySqlDbType.VarChar, 0);
			MySqlParameter numParameter = new MySqlParameter("@newnum", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			questParameter.Value = quest;
			condition_idParameter.Value = condition_id;
			numParameter.Value = num;
			OLD_evententryParameter.Value = OLD_eventEntry;
			OLD_questParameter.Value = OLD_quest;
			OLD_condition_idParameter.Value = OLD_condition_id;
			OLD_numParameter.Value = OLD_num;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(questParameter);
			cmd.Parameters.Add(condition_idParameter);
			cmd.Parameters.Add(numParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.Parameters.Add(OLD_questParameter);
			cmd.Parameters.Add(OLD_condition_idParameter);
			cmd.Parameters.Add(OLD_numParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_eventEntry = eventEntry;
			OLD_quest = quest;
			OLD_condition_id = condition_id;
			OLD_num = num;
		}
	}
}
