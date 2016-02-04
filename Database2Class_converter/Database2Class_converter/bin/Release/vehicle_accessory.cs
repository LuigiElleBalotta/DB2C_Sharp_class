using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data.MySqlClient;

namespace WoWAppVisual.Database
{
	class Vehicle_accessory
	{
		int guid = 0; //Comment: 
		int OLD_guid = 0;

		int accessory_entry = 0; //Comment: 
		int OLD_accessory_entry = 0;

		int seat_id = 0; //Comment: 
		int OLD_seat_id = 0;

		int minion = 0; //Comment: 
		int OLD_minion = 0;

		string description = null; //Comment: 
		string OLD_description = null;

		int summontype = 6; //Comment: see enum TempSummonType
		int OLD_summontype = 6;

		int summontimer = 30000; //Comment: timer, only relevant for certain summontypes
		int OLD_summontimer = 30000;

		MySqlConnection conn = new MySqlConnection("server=<HOST>;user=<USER>;database=<DATABASE>;password=<PASSWORD>;");

		public Vehicle_accessory(int _guid, int _accessory_entry, int _seat_id, int _minion, string _description, int _summontype, int _summontimer)
		{
			guid = _guid;
			accessory_entry = _accessory_entry;
			seat_id = _seat_id;
			minion = _minion;
			description = _description;
			summontype = _summontype;
			summontimer = _summontimer;
			updateOldValues();
		}

		public void delete()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "DELETE FROM vehicle_accessory WHERE guid = @guid AND accessory_entry = @accessory_entry AND seat_id = @seat_id AND minion = @minion AND description = @description AND summontype = @summontype AND summontimer = @summontimer;";
			MySqlParameter guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter accessory_entryParameter = new MySqlParameter("@accessory_entry", MySqlDbType.VarChar, 0);
			MySqlParameter seat_idParameter = new MySqlParameter("@seat_id", MySqlDbType.VarChar, 0);
			MySqlParameter minionParameter = new MySqlParameter("@minion", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			MySqlParameter summontypeParameter = new MySqlParameter("@summontype", MySqlDbType.VarChar, 0);
			MySqlParameter summontimerParameter = new MySqlParameter("@summontimer", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			accessory_entryParameter.Value = accessory_entry;
			seat_idParameter.Value = seat_id;
			minionParameter.Value = minion;
			descriptionParameter.Value = description;
			summontypeParameter.Value = summontype;
			summontimerParameter.Value = summontimer;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(accessory_entryParameter);
			cmd.Parameters.Add(seat_idParameter);
			cmd.Parameters.Add(minionParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(summontypeParameter);
			cmd.Parameters.Add(summontimerParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public void update()
		{
			conn.Open();
			MySqlCommand cmd = new MySqlCommand("", conn);
			cmd.CommandText = "UPDATE vehicle_accessory SET guid = @newguid, accessory_entry = @newaccessory_entry, seat_id = @newseat_id, minion = @newminion, description = @newdescription, summontype = @newsummontype, summontimer = @newsummontimer WHERE guid = @guid AND accessory_entry = @accessory_entry AND seat_id = @seat_id AND minion = @minion AND description = @description AND summontype = @summontype AND summontimer = @summontimer;";
			MySqlParameter OLD_guidParameter = new MySqlParameter("@guid", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_accessory_entryParameter = new MySqlParameter("@accessory_entry", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_seat_idParameter = new MySqlParameter("@seat_id", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_minionParameter = new MySqlParameter("@minion", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_descriptionParameter = new MySqlParameter("@description", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_summontypeParameter = new MySqlParameter("@summontype", MySqlDbType.VarChar, 0);
			MySqlParameter OLD_summontimerParameter = new MySqlParameter("@summontimer", MySqlDbType.VarChar, 0);
			MySqlParameter guidParameter = new MySqlParameter("@newguid", MySqlDbType.VarChar, 0);
			MySqlParameter accessory_entryParameter = new MySqlParameter("@newaccessory_entry", MySqlDbType.VarChar, 0);
			MySqlParameter seat_idParameter = new MySqlParameter("@newseat_id", MySqlDbType.VarChar, 0);
			MySqlParameter minionParameter = new MySqlParameter("@newminion", MySqlDbType.VarChar, 0);
			MySqlParameter descriptionParameter = new MySqlParameter("@newdescription", MySqlDbType.VarChar, 0);
			MySqlParameter summontypeParameter = new MySqlParameter("@newsummontype", MySqlDbType.VarChar, 0);
			MySqlParameter summontimerParameter = new MySqlParameter("@newsummontimer", MySqlDbType.VarChar, 0);
			guidParameter.Value = guid;
			accessory_entryParameter.Value = accessory_entry;
			seat_idParameter.Value = seat_id;
			minionParameter.Value = minion;
			descriptionParameter.Value = description;
			summontypeParameter.Value = summontype;
			summontimerParameter.Value = summontimer;
			OLD_guidParameter.Value = OLD_guid;
			OLD_accessory_entryParameter.Value = OLD_accessory_entry;
			OLD_seat_idParameter.Value = OLD_seat_id;
			OLD_minionParameter.Value = OLD_minion;
			OLD_descriptionParameter.Value = OLD_description;
			OLD_summontypeParameter.Value = OLD_summontype;
			OLD_summontimerParameter.Value = OLD_summontimer;
			cmd.Parameters.Add(guidParameter);
			cmd.Parameters.Add(accessory_entryParameter);
			cmd.Parameters.Add(seat_idParameter);
			cmd.Parameters.Add(minionParameter);
			cmd.Parameters.Add(descriptionParameter);
			cmd.Parameters.Add(summontypeParameter);
			cmd.Parameters.Add(summontimerParameter);
			cmd.Parameters.Add(OLD_guidParameter);
			cmd.Parameters.Add(OLD_accessory_entryParameter);
			cmd.Parameters.Add(OLD_seat_idParameter);
			cmd.Parameters.Add(OLD_minionParameter);
			cmd.Parameters.Add(OLD_descriptionParameter);
			cmd.Parameters.Add(OLD_summontypeParameter);
			cmd.Parameters.Add(OLD_summontimerParameter);
			cmd.ExecuteNonQuery();
			conn.Close();
			updateOldValues();
		}

		private void updateOldValues()
		{
			OLD_guid = guid;
			OLD_accessory_entry = accessory_entry;
			OLD_seat_id = seat_id;
			OLD_minion = minion;
			OLD_description = description;
			OLD_summontype = summontype;
			OLD_summontimer = summontimer;
		}
	}
}
