using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event_condition
	{
		int eventEntry = 0; //Comment: Entry of the game event
		int OLD_eventEntry = 0;

		int condition_id = 0; //Comment: 
		int OLD_condition_id = 0;

		float req_num = 0f; //Comment: 
		float OLD_req_num = 0f;

		int max_world_state_field = 0; //Comment: 
		int OLD_max_world_state_field = 0;

		int done_world_state_field = 0; //Comment: 
		int OLD_done_world_state_field = 0;

		string description = null; //Comment: 
		string OLD_description = null;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event_condition(int _eventEntry, int _condition_id, float _req_num, int _max_world_state_field, int _done_world_state_field, string _description)
		{
			eventEntry = _eventEntry;
			condition_id = _condition_id;
			req_num = _req_num;
			max_world_state_field = _max_world_state_field;
			done_world_state_field = _done_world_state_field;
			description = _description;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event_condition WHERE eventEntry = @eventEntry AND condition_id = @condition_id AND req_num = @req_num AND max_world_state_field = @max_world_state_field AND done_world_state_field = @done_world_state_field AND description = @description;";
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter condition_idParameter = new MySqlParameter("@condition_id", MySqlDbType.VarChar, 0);
			MySqlParameter req_numParameter = new MySqlParameter("@req_num", MySqlDbType.VarChar, 0);
			MySqlParameter max_world_state_fieldParameter = new MySqlParameter("@max_world_state_field", MySqlDbType.VarChar, 0);
			MySqlParameter done_world_state_fieldParameter = new MySqlParameter("@done_world_state_field", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			condition_idParameter.Value = condition_id;
			req_numParameter.Value = req_num;
			max_world_state_fieldParameter.Value = max_world_state_field;
			done_world_state_fieldParameter.Value = done_world_state_field;
			descriptionParameter.Value = description;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(condition_idParameter);
			cmd.Parameters.Add(req_numParameter);
			cmd.Parameters.Add(max_world_state_fieldParameter);
			cmd.Parameters.Add(done_world_state_fieldParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event_condition SET eventEntry = @neweventEntry, condition_id = @newcondition_id, req_num = @newreq_num, max_world_state_field = @newmax_world_state_field, done_world_state_field = @newdone_world_state_field, description = @newdescription WHERE eventEntry = @eventEntry AND condition_id = @condition_id AND req_num = @req_num AND max_world_state_field = @max_world_state_field AND done_world_state_field = @done_world_state_field AND description = @description;";
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_condition_idParameter = new MySqlParameter("@condition_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_req_numParameter = new MySqlParameter("@req_num", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_max_world_state_fieldParameter = new MySqlParameter("@max_world_state_field", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_done_world_state_fieldParameter = new MySqlParameter("@done_world_state_field", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter condition_idParameter = new MySqlParameter("@newcondition_id", MySqlDbType.VarChar, 0);
			MySqlParameter req_numParameter = new MySqlParameter("@newreq_num", MySqlDbType.VarChar, 0);
			MySqlParameter max_world_state_fieldParameter = new MySqlParameter("@newmax_world_state_field", MySqlDbType.VarChar, 0);
			MySqlParameter done_world_state_fieldParameter = new MySqlParameter("@newdone_world_state_field", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@newdescription", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			condition_idParameter.Value = condition_id;
			req_numParameter.Value = req_num;
			max_world_state_fieldParameter.Value = max_world_state_field;
			done_world_state_fieldParameter.Value = done_world_state_field;
			descriptionParameter.Value = description;
			OLD_evententryParameter.Value = OLD_eventEntry;
			OLD_condition_idParameter.Value = OLD_condition_id;
			OLD_req_numParameter.Value = OLD_req_num;
			OLD_max_world_state_fieldParameter.Value = OLD_max_world_state_field;
			OLD_done_world_state_fieldParameter.Value = OLD_done_world_state_field;
			OLD_descriptionParameter.Value = OLD_description;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(condition_idParameter);
			cmd.Parameters.Add(req_numParameter);
			cmd.Parameters.Add(max_world_state_fieldParameter);
			cmd.Parameters.Add(done_world_state_fieldParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.Parameters.Add(OLD_condition_idParameter);
			cmd.Parameters.Add(OLD_req_numParameter);
			cmd.Parameters.Add(OLD_max_world_state_fieldParameter);
			cmd.Parameters.Add(OLD_done_world_state_fieldParameter);
			cmd.Parameters.Add(OLD_descriptionParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_eventEntry = eventEntry;
			OLD_condition_id = condition_id;
			OLD_req_num = req_num;
			OLD_max_world_state_field = max_world_state_field;
			OLD_done_world_state_field = done_world_state_field;
			OLD_description = description;
		}
	}
}
