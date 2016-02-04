using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Game_event_model_equip
	{
		int eventEntry = 0; //Comment: Entry of the game event.
		int OLD_eventEntry = 0;

		int guid = 0; //Comment: 
		int OLD_guid = 0;

		int modelid = 0; //Comment: 
		int OLD_modelid = 0;

		int equipment_id = 0; //Comment: 
		int OLD_equipment_id = 0;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Game_event_model_equip(int _eventEntry, int _guid, int _modelid, int _equipment_id)
		{
			eventEntry = _eventEntry;
			guid = _guid;
			modelid = _modelid;
			equipment_id = _equipment_id;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM game_event_model_equip WHERE eventEntry = @eventEntry AND guid = @guid AND modelid = @modelid AND equipment_id = @equipment_id;";
			MySqlParameter evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter modelidParameter = new MySqlParameter("@modelid", MySqlDbType.VarChar, 0);
			MySqlParameter equipment_idParameter = new MySqlParameter("@equipment_id", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			guidParameter.Value = guid;
			modelidParameter.Value = modelid;
			equipment_idParameter.Value = equipment_id;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(modelidParameter);
			cmd.Parameters.Add(equipment_idParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE game_event_model_equip SET eventEntry = @neweventEntry, guid = @newguid, modelid = @newmodelid, equipment_id = @newequipment_id WHERE eventEntry = @eventEntry AND guid = @guid AND modelid = @modelid AND equipment_id = @equipment_id;";
			MySqlParameter OLD_evententryParameter = new MySqlParameter("@eventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_modelidParameter = new MySqlParameter("@modelid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_equipment_idParameter = new MySqlParameter("@equipment_id", MySqlDbType.VarChar, 0);
			MySqlParameter evententryParameter = new MySqlParameter("@neweventEntry", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@newguid", MySqlDbType.VarChar, 0);
			MySqlParameter modelidParameter = new MySqlParameter("@newmodelid", MySqlDbType.VarChar, 0);
			MySqlParameter equipment_idParameter = new MySqlParameter("@newequipment_id", MySqlDbType.VarChar, 0);
			evententryParameter.Value = eventEntry;
			guidParameter.Value = guid;
			modelidParameter.Value = modelid;
			equipment_idParameter.Value = equipment_id;
			OLD_evententryParameter.Value = OLD_eventEntry;
			OLD_guidParameter.Value = OLD_guid;
			OLD_modelidParameter.Value = OLD_modelid;
			OLD_equipment_idParameter.Value = OLD_equipment_id;
			cmd.Parameters.Add(evententryParameter);
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(modelidParameter);
			cmd.Parameters.Add(equipment_idParameter);
			cmd.Parameters.Add(OLD_evententryParameter);
			cmd.Parameters.Add(OLD_guidParameter);
			cmd.Parameters.Add(OLD_modelidParameter);
			cmd.Parameters.Add(OLD_equipment_idParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_eventEntry = eventEntry;
			OLD_guid = guid;
			OLD_modelid = modelid;
			OLD_equipment_id = equipment_id;
		}
	}
}
